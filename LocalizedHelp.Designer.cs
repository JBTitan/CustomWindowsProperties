﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomWindowsProperties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class LocalizedHelp {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LocalizedHelp() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CustomWindowsProperties.LocalizedHelp", typeof(LocalizedHelp).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;Specifies how aggregate properties are displayed when multiple values are selected. Default is &quot;Default&quot;.&lt;/p&gt;
        ///&lt;table&gt;&lt;tr&gt;&lt;td&gt;
        ///Default	&lt;/td&gt;&lt;td&gt;Displays a Multiple Values placeholder in the UI. This is the default if the type is incompatible with the specified aggregationType.
        ///&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;
        ///First&lt;/td&gt;&lt;td&gt;	Displays the property value of the first item in the selection or collection.
        ///&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;
        ///Sum&lt;/td&gt;&lt;td&gt;	Displays the sum of the numerical values. Useful for properties such as System.Med [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AggregationType {
            get {
                return ResourceManager.GetString("AggregationType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the alignment to use. The default is &quot;Left&quot;..
        /// </summary>
        internal static string Alignment {
            get {
                return ResourceManager.GetString("Alignment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies which pair of strings should be used to format a Boolean value. The default is &quot;YesNo&quot;, i.e. &quot;Yes&quot; for true and &quot;No&quot; for false..
        /// </summary>
        internal static string BooleanFormat {
            get {
                return ResourceManager.GetString("BooleanFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When set to &quot;true&quot;, allows an innate property to be deleted. Innate properties, which are calculated from other properties, are read-only by definition. The available and default values for this attribute depends on the IsInnate value. If IsInnate is &quot;true &quot;, then CanBePurged defaults to &quot;false&quot;, but may be set to &quot;true&quot;. If IsInnate is &quot;false&quot;, then CanBePurged must be &quot;true&quot;..
        /// </summary>
        internal static string CanBePurged {
            get {
                return ResourceManager.GetString("CanBePurged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The case-sensitive name of a property as it is known to the system, regardless of its localized name.
        ///
        ///Canonical names consist of any number of tokens, separated by dots, for example:
        ///
        ///Name1.NameB.Name7.Basil
        ///
        ///Each token in the name must begin with a capital letter, and otherwise consist of upper case and lower case letters, or numbers..
        /// </summary>
        internal static string CanonicalName {
            get {
                return ResourceManager.GetString("CanonicalName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;To optimize sorting and grouping, the Windows search engine can create secondary indexes for properties that have isColumn=&quot;true&quot; and is only useful in such cases.  If the property tends to be sorted frequently by users, this attribute should be specified. The default value is &quot;OnDemand&quot;.&lt;/p&gt;
        ///&lt;p&gt;The following values are valid. &lt;/p&gt;
        ///&lt;table&gt;&lt;tr&gt;&lt;td&gt;
        ///NotIndexed:&lt;/td&gt;&lt;td&gt; Never build a value index. 
        ///&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;
        ///OnDisk: &lt;/td&gt;&lt;td&gt;Build a value index by default for this property.
        ///&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ColumnIndexType {
            get {
                return ResourceManager.GetString("ColumnIndexType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;Specifies a hint to the Search Query Builder tool so that it can determine the default operator. The default is &quot;Equal&quot;. The possible values are as follows:&lt;/p&gt;
        ///&lt;table&gt;&lt;tr&gt;&lt;td&gt;
        ///Equal	 &lt;/td&gt;&lt;td&gt; Indicates equivalent.
        ///&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;
        ///NotEqual	&lt;/td&gt;&lt;td&gt;Indicates not equivalent.
        ///&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;
        ///LessThan&lt;/td&gt;&lt;td&gt;	Indicates less than.
        ///&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;
        ///GreaterThan	&lt;/td&gt;&lt;td&gt;Default for properties of ConditionType=&quot;Size&quot;. Indicates greater than.
        ///&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;
        ///Contains&lt;/td&gt;&lt;td&gt;	Default for p [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ConditionOperation {
            get {
                return ResourceManager.GetString("ConditionOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;Specifies a hint to the Search Query Builder UI so that it can determine the list of possible condition operators inside a predicate. The following are recognized values. The default is &quot;String&quot;.&lt;/p&gt;
        ///&lt;table&gt;&lt;tr&gt;
        ///&lt;td&gt;String&lt;/td&gt;&lt;td&gt;The following operators will be used: &quot;is&quot;, &quot;is not&quot;, &quot;&lt;&quot;, &quot;&gt;&quot;, &quot;&lt;=&quot;, &quot;=&quot;&quot;&gt;=&quot;, &quot;starts with&quot;, &quot;ends with&quot;, &quot;contains&quot;, &quot;doesn&apos;t contain&quot;, &quot;is like&quot;.
        ///&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;
        ///&lt;td&gt; Number&lt;/td&gt;&lt;td&gt;Default for numeric properties. The following operators will be used: &quot;equals&quot;, &quot;doesn&apos;t e [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ConditionType {
            get {
                return ResourceManager.GetString("ConditionType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt; Specifies how a date-time value should be formatted. The default is &quot;General&quot;. The following values are valid:&lt;/p&gt;
        ///&lt;table&gt;&lt;tr&gt;&lt;td&gt;
        ///General	&lt;/td&gt;&lt;td&gt;Default. Formats the date-time value using the shell date-time format. [Use the formatTimeAs and formatDateAs attributes to specify how the time and date are formatted.] Currently, this tool will always format the time as ShortTime e.g. &quot;7:48 PM&quot; and the date as ShortDate e.g. &quot;5/13/59&quot;. Requires the property type to be DateTime.
        ///&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;
        ///Month [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DateTimeFormat {
            get {
                return ResourceManager.GetString("DateTimeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The default is &apos;20&apos;.
        /// </summary>
        internal static string DefaultColumnWidth {
            get {
                return ResourceManager.GetString("DefaultColumnWidth", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the sort direction. The default is &quot;Ascending&quot;..
        /// </summary>
        internal static string DefaultSortDirection {
            get {
                return ResourceManager.GetString("DefaultSortDirection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The display name of the property as it is displayed in the UI (for example, the details column label or preview panel)..
        /// </summary>
        internal static string DisplayName {
            get {
                return ResourceManager.GetString("DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;Default is &amp;quot;String&amp;quot;. Specifies the type of the display string. The following are valid types. &lt;/p&gt;
        ///&lt;table&gt;
        ///&lt;thead&gt;
        ///&lt;tr class=&quot;header&quot;&gt;
        ///&lt;th&gt;Value&lt;/th&gt;
        ///&lt;th&gt;Meaning&lt;/th&gt;
        ///&lt;/tr&gt;
        ///&lt;/thead&gt;
        ///&lt;tbody&gt;
        ///&lt;tr class=&quot;odd&quot;&gt;
        ///&lt;td&gt;String&lt;/td&gt;
        ///&lt;td&gt;Default. Value is displayed as a string. Use &amp;quot;StringFormat&amp;quot; to format. &lt;/td&gt;
        ///&lt;/tr&gt;
        ///&lt;tr class=&quot;even&quot;&gt;
        ///&lt;td&gt;Number&lt;/td&gt;
        ///&lt;td&gt;Default for numeric properties. Value is displayed as a number. Use &amp;quot;NumberFormat&amp;quot; to format. &lt;/td&gt;
        ///&lt;/tr&gt;&lt;tr class= [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DisplayType {
            get {
                return ResourceManager.GetString("DisplayType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;Specifies what control to use when editing the property. The default is &quot;Default&quot;. The following are valid values.&lt;/p&gt;
        ///&lt;table&gt;&lt;tr&gt;&lt;td&gt;
        ///Default	&lt;/td&gt;&lt;td&gt; Uses the default control, based upon the Type. String with MultipleValues uses the &quot;MultiValueText&quot; control. DateTime uses the &quot;Calendar&quot; control. Any other type results in using the &quot;Text&quot; control.
        ///&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;
        ///Calendar	&lt;/td&gt;&lt;td&gt;Uses the calendar control.
        ///&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;
        ///CheckboxDropList	&lt;/td&gt;&lt;td&gt;Uses the list control with checkboxes.
        ///&lt;/ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string EditControl {
            get {
                return ResourceManager.GetString("EditControl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Help string text that is displayed as an instruction to the user for the control or ToolTip (for instance, &quot;Enter author name.&quot;)..
        /// </summary>
        internal static string EditInvitation {
            get {
                return ResourceManager.GetString("EditInvitation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;Specifies how this property is displayed when a view is grouped by this property. The default is &quot;Discrete&quot;.&lt;/p&gt;
        ///&lt;table&gt;&lt;tr&gt;&lt;td&gt;
        ///Discrete	&lt;/td&gt;&lt;td&gt;Default. Displays individual values.
        ///&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;
        ///Alphanumeric &lt;/td&gt;&lt;td&gt;Displays static alphanumeric ranges for values.
        ///&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;
        ///Size&lt;/td&gt;&lt;td&gt;	Displays static size ranges for values.
        ///&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;
        ///Date	&lt;/td&gt;&lt;td&gt;Displays month/year groups. Default for properties of type=&quot;DateTime&quot;.
        ///&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;
        ///TimeRelative&lt;/td&gt;&lt;td&gt; Displays [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GroupingRange {
            get {
                return ResourceManager.GetString("GroupingRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Indicates whether the label is hidden. The default is &quot;false&quot;..
        /// </summary>
        internal static string HideLabel {
            get {
                return ResourceManager.GetString("HideLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Indicates whether the property value should be stored in the inverted index. This lets end users perform full-text queries over the values of this property.
        ///The default is &quot;false&quot;..
        /// </summary>
        internal static string InInvertedIndex {
            get {
                return ResourceManager.GetString("InInvertedIndex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Indicates whether the property should also be stored in the Windows search database as a column, so that independent software vendors (ISVs) can create predicate-based queries (for example, &quot;Select * Where &quot;System.Title&quot;=&apos;qqq&apos;&quot;). 
        ///Set to &quot;true&quot; to enable end users (or developers) to create predicate based queries on the property. 
        ///The default is &quot;false&quot;..
        /// </summary>
        internal static string IsColumn {
            get {
                return ResourceManager.GetString("IsColumn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The default is &quot;true&quot;. If the property is multi-valued, this attribute is always &quot;true&quot;..
        /// </summary>
        internal static string IsColumnSparse {
            get {
                return ResourceManager.GetString("IsColumnSparse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies whether the property is a group heading. Default is &quot;false&quot;. A group heading is strictly used to group properties within a list, has no value, and is never stored in a file. Some UI in the system use property lists to indicate the sequence of the properties to display. These property lists may include references to group headings (eg, System.PropGroup.Camera), which tell the UI to start a new group section (eg, &quot;Camera Settings&quot;). A property description with IsGroup=&quot;true&quot; should specify a , other [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string IsGroup {
            get {
                return ResourceManager.GetString("IsGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Default is &quot;false&quot;. Specifies whether the property is considered innate. An innate property is one which is either calculated from the content of a file, or from other resources or systems. For example, System.Size is an innate property provided by the file system; changing the value of the property in and of itself does nothing. Other examples are System.Image.Dimensions and System.Document.PageCount, which are calculated by programs based upon the content of the file, not based upon a user-changeable sett [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string IsInnate {
            get {
                return ResourceManager.GetString("IsInnate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Whether this is a tree property. The default is &quot;false&quot;..
        /// </summary>
        internal static string IsTreeProperty {
            get {
                return ResourceManager.GetString("IsTreeProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies whether this property is intended to be viewable to the user. Default value is &quot;false&quot;. For example, the Column Chooser UI only shows the properties that have IisViewable=&quot;true&quot;. The exception is UI that is driven by a property list, which will always show the property. If you have a property that is only meant to shuttle data between two objects, and never intended to be viewed by the user, this attribute should be false..
        /// </summary>
        internal static string IsViewable {
            get {
                return ResourceManager.GetString("IsViewable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The maximum size, in bytes, allowed for a certain property that is stored in the Windows search database.
        ///The default is: 512 bytes 
        ///Note that this maximum size is measured in bytes, not characters. The maximum number of characters depends on their encoding..
        /// </summary>
        internal static string MaxSize {
            get {
                return ResourceManager.GetString("MaxSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A list of mnemonic values that can be used to refer to the property in search queries.
        ///The list is delimited with the &apos;|&apos; character..
        /// </summary>
        internal static string Mnemonics {
            get {
                return ResourceManager.GetString("Mnemonics", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies whether this property can have multiple values. Default is &quot;false&quot;..
        /// </summary>
        internal static string MultipleValues {
            get {
                return ResourceManager.GetString("MultipleValues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;Specifies the display format. The default is &quot;General&quot;. The following are valid values.&lt;/p&gt;
        ///	&lt;table&gt;&lt;tr&gt;&lt;td&gt;
        ///General	&lt;/td&gt;&lt;td&gt; Displays the value as an unformatted number.
        ///&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;
        ///Percentage&lt;/td&gt;&lt;td&gt;	Formats the value as a percentage. Requires the property to be UInt32.
        ///&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;
        ///ByteSize&lt;/td&gt;&lt;td&gt;	Formats the value as a byte, &quot;KB&quot;, &quot;MB&quot;, or &quot;GB&quot; as appropriate. Requires the property to be UInt64.
        ///&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;
        ///KBSize	&lt;/td&gt;&lt;td&gt;Formats the value as a &quot;KB&quot;, no matter what th [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string NumberFormat {
            get {
                return ResourceManager.GetString("NumberFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string RelativeDescriptionType {
            get {
                return ResourceManager.GetString("RelativeDescriptionType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The default is &quot;false&quot;..
        /// </summary>
        internal static string SearchRawValue {
            get {
                return ResourceManager.GetString("SearchRawValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;Specifies the strings offered as sort options. The following values provide the corresponding UI strings.&lt;/p&gt;
        ///&lt;table&gt;&lt;tr&gt;&lt;td&gt;
        ///General: &lt;/td&gt;&lt;td&gt;&quot;Sort going up&quot; / &quot;Sort going down&quot;
        ///&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;
        ///AToZ:&lt;/td&gt;&lt;td&gt; &quot;A on top&quot; / &quot;Z on top&quot;
        ///&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;
        ///LowestHighest:&lt;/td&gt;&lt;td&gt; &quot;Lowest on top&quot; / &quot;Highest on top&quot;
        ///&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;
        ///OldestNewest: &lt;/td&gt;&lt;td&gt;&quot;Oldest on top&quot; / &quot;Newest on top&quot;
        ///&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;
        ///SmallestLargest: &lt;/td&gt;&lt;td&gt;&quot;Smallest on top&quot; / &quot;Largest on top&quot;
        ///&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;.
        /// </summary>
        internal static string SortDescription {
            get {
                return ResourceManager.GetString("SortDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies how the property&apos;s value should be formatted as a string. The default is &quot;General&quot;..
        /// </summary>
        internal static string StringFormat {
            get {
                return ResourceManager.GetString("StringFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;Indicates the type of the property. The default is &quot;Any&quot;.  The following are valid types &lt;/p&gt;
        ///&lt;p&gt;Some of the options only make sense for programmatic access to the property, like Buffer, Stream, Blob, Clipboard or Object, and cannot be used directly in an editor.&lt;/p&gt;
        ///&lt;table&gt;&lt;tr&gt;&lt;td&gt;
        ///Any&lt;/td&gt;&lt;td&gt;	The  property system does not know anything about the type of the value, and you are strongly encouraged not to use this default.
        ///&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;
        ///Null	&lt;/td&gt;&lt;td&gt;There is and never can be any value for this [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Type {
            get {
                return ResourceManager.GetString("Type", resourceCulture);
            }
        }
    }
}
