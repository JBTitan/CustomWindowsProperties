﻿// Copyright (c) 2013, 2020 Dijji, and released under Ms-PL.  This, with other relevant licenses, can be found in the root of this distribution.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows;
using System.Xml.Serialization;

namespace CustomWindowsProperties
{
    internal class State
    {
        private Options options = null;
        //private List<TreeItem> allProperties = new List<TreeItem>();
        //private List<string> groupProperties = new List<string>();
        //private SavedState savedState = new SavedState();

        public List<PropertyConfig> SystemProperties { get; } = new List<PropertyConfig>();
        public List<PropertyConfig> CustomProperties { get; } = new List<PropertyConfig>();
        public List<PropertyConfig> EditorProperties { get; } = new List<PropertyConfig>();


        public Dictionary<string, PropertyConfig> InstalledProperties { get; } = new Dictionary<string, PropertyConfig>();

        public Dictionary<string, PropertyConfig> EditedProperties { get; } = new Dictionary<string, PropertyConfig>();


        public string DataFolder
        {
            get { return Options.DataFolder; }
            set { Options.DataFolder = value; SaveOptions(); }
        }


        private Options Options
        {
            get
            {
                if (options == null)
                    options = new Options();
                return options;
            }
        }

        private string OptionsFileName
        {
            get
            {
                return ApplicationDataFolder + Path.DirectorySeparatorChar + "Options.xml";
            }
        }

        private string ApplicationDataFolder
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "CustomWindowsProperties");
            }
        }

        public void LoadOptions()
        {
            if (File.Exists(OptionsFileName))
            {
                try
                {
                    XmlSerializer x = new XmlSerializer(typeof(Options));
                    using (TextReader reader = new StreamReader(OptionsFileName))
                    {
                        options = (Options)x.Deserialize(reader);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error reading saved options");
                }
            }
        }

        public void SaveOptions()
        {
            try
            {
                if (!Directory.Exists(ApplicationDataFolder))
                    Directory.CreateDirectory(ApplicationDataFolder);

                XmlSerializer x = new XmlSerializer(typeof(Options));
                using (TextWriter writer = new StreamWriter(OptionsFileName))
                {
                    x.Serialize(writer, Options);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error saving chosen options");
            }
        }

        public PropertyConfig LoadPropertyConfig(string fullFileName)
        {
            if (File.Exists(fullFileName))
            {
                try
                {
                    XmlSerializer x = new XmlSerializer(typeof(PropertyConfig));
                    using (TextReader reader = new StreamReader(fullFileName))
                    {
                        return (PropertyConfig)x.Deserialize(reader);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error reading saved property configuration");
                }
            }

            return null;
        }

        public void SavePropertyConfig(PropertyConfig config)
        {
            try
            {
                string fileName = DataFolder + Path.DirectorySeparatorChar + config.CanonicalName + ".xml";

                XmlSerializer x = new XmlSerializer(typeof(PropertyConfig));
                using (TextWriter writer = new StreamWriter(fileName))
                {
                    x.Serialize(writer, config);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"Error saving property configuration {config.CanonicalName}");
            }
        }

        public void Populate()
        {
            LoadOptions();
            PopulatePropertyList(SystemProperties, PropertySystemNativeMethods.PropDescEnumFilter.PDEF_SYSTEM);
            PopulatePropertyList(CustomProperties, PropertySystemNativeMethods.PropDescEnumFilter.PDEF_NONSYSTEM);
            LoadEditorProperties();
        }

        private void PopulatePropertyList(List<PropertyConfig> propertyList,
                PropertySystemNativeMethods.PropDescEnumFilter filter)
        {
            propertyList.Clear();
            IPropertyDescriptionList propertyDescriptionList = null;
            IPropertyDescription propertyDescription = null;
            Guid guid = new Guid(ShellIIDGuid.IPropertyDescriptionList);

            try
            {
                var hr = PropertySystemNativeMethods.PSEnumeratePropertyDescriptions(
                            filter, ref guid, out propertyDescriptionList);
                if (hr >= 0)
                {
                    propertyDescriptionList.GetCount(out uint count);
                    guid = new Guid(ShellIIDGuid.IPropertyDescription);

                    for (uint i = 0; i < count; i++)
                    {
                        propertyDescriptionList.GetAt(i, ref guid, out propertyDescription);

                        if (propertyDescription != null)
                        {
                            var shellProperty = new ShellPropertyDescription(propertyDescription);
                            var pc = new PropertyConfig(shellProperty);
                            shellProperty.Dispose(); // Releases propertyDescription
                            propertyDescription = null;
                            propertyList.Add(pc);
                            InstalledProperties.Add(pc.CanonicalName, pc);
                        }
                    }
                }
            }
            finally
            {
                if (propertyDescriptionList != null)
                {
                    Marshal.ReleaseComObject(propertyDescriptionList);
                }
                if (propertyDescription != null)
                {
                    Marshal.ReleaseComObject(propertyDescription);
                }
            }
        }

        private void LoadEditorProperties()
        {
            var di = new DirectoryInfo(DataFolder);
            foreach (var fi in di.GetFiles().Where(f => f.Extension == ".xml"))
            {
                var pc = LoadPropertyConfig(fi.FullName);
                EditorProperties.Add(pc);
            }
        }
    }
}