﻿// Copyright (c) 2020, Dijji, and released under Ms-PL.  This, with other relevant licenses, can be found in the root of this distribution.

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CustomWindowsProperties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly State state = new State();
        private readonly MainView view = new MainView();

        private string EditedPropertyName { get { return view.EditorConfig.CanonicalName; } }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = view;
            try
            {
                state.Populate();
                view.Populate(state);
            }
            catch (Exception ex)
            {
                DisplayStatus($"Error {ex.Message} occurred during initialisation");
            }
            RefreshPropertyEditor();
        }

        private void SavedTree_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (((TreeView)sender).SelectedItem is TreeItem item)
            {
                var pc = view.SetSelectedTreeItem(item, false);
                if (pc != null)
                {
                    RefreshPropertyEditor();
                }
            }
        }

        private void InstalledTree_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (((TreeView)sender).SelectedItem is TreeItem item)
            {
                var config = view.SetSelectedTreeItem(item, true);
                if (config != null)
                {
                    PropertyDisplay.DataContext = config;
                }
            }
        }

        private void Editor_GotFocus(object sender, RoutedEventArgs e)
        {
            view.EditorFocusChanged(((FrameworkElement)e.OriginalSource).Tag as string, wbHelp);
        }

        private void Editor_LostFocus(object sender, RoutedEventArgs e)
        {
            view.EditorFocusChanged(null, wbHelp);
        }

        private void ChooseDataFolder_Clicked(object sender, RoutedEventArgs e)
        {
            if (view.ChooseDataFolder())
                DisplayStatus($"Data folder is now {state.DataFolder}");
        }

        private void New_Clicked(object sender, RoutedEventArgs e)
        {
            view.NewEditorProperty();
        }

        private void Save_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                view.SaveEditorProperty(treeViewSaved);
                DisplayStatus($"Property {EditedPropertyName} saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error saving property");
            }
        }

        private void Discard_Clicked(object sender, RoutedEventArgs e)
        {
            view.DiscardEditorChanges();
        }

        private void Install_Clicked(object sender, RoutedEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Wait; // Tree search can be slow
            try
            {
                switch (view.InstallEditorProperty(treeViewSaved, treeViewInstalled))
                {
                    case 0:
                        DisplayStatus($"Property {EditedPropertyName} installed");
                        break;
                    case 1:
                        DisplayStatus($"Property {EditedPropertyName} installed with warnings of possible incompleteness");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error installing property");
            }
            finally
            {
                Mouse.OverrideCursor = null;
            }
        }

        private void Copy_Clicked(object sender, RoutedEventArgs e)
        {
            view.CopyInstalledPropertyToEditor();
            RefreshPropertyEditor();
        }

        private void EditedInstall_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            var config = (treeViewSaved.SelectedItem as TreeItem)?.Item as PropertyConfig;
            e.CanExecute = view.CanBeInstalled(config);
        }

        private void EditedInstall_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var config = (treeViewSaved.SelectedItem as TreeItem)?.Item as PropertyConfig;
            Mouse.OverrideCursor = Cursors.Wait; // Tree search can be slow
            try
            {
                switch (view.InstallProperty(config, treeViewInstalled))
                {
                    case 0:
                        DisplayStatus($"Property {config.CanonicalName} installed");
                        break;
                    case 1:
                        DisplayStatus($"Property {config.CanonicalName} installed with warnings of possible incompleteness");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error installing property");
            }
            finally
            {
                Mouse.OverrideCursor = null;
            }
        }

        private void EditedExport_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            var treeItem = treeViewSaved.SelectedItem as TreeItem;
            e.CanExecute = view.CanBeExported(treeItem);
        }

        private void EditedExport_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var treeItem = treeViewSaved.SelectedItem as TreeItem;
            try
            {
                var outputFile = view.ExportPropDesc(treeItem);
                if (outputFile != null)
                {
                    DisplayStatus($"Exported successfully to {outputFile}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error exporting propdesc");
            }
        }

        private void EditedDelete_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            var config = (treeViewSaved.SelectedItem as TreeItem)?.Item as PropertyConfig;
            e.CanExecute = view.CanBeDeleted(config);
        }

        private void EditedDelete_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var config = (treeViewSaved.SelectedItem as TreeItem)?.Item as PropertyConfig;

            try
            {
                view.DeleteProperty(config);
                DisplayStatus($"Property {config.CanonicalName} deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error deleting property");
            }
        }

        private void InstalledUninstall_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            var config = (treeViewInstalled.SelectedItem as TreeItem)?.Item as PropertyConfig;
            e.CanExecute = view.CanBeUninstalled(config);
        }

        private void InstalledUninstall_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var config = (treeViewInstalled.SelectedItem as TreeItem)?.Item as PropertyConfig;
            try
            {
                if (view.UninstallProperty(config))
                    DisplayStatus($"Property {config.CanonicalName} uninstalled");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error uninstalling property");
            }
        }

        private void RefreshPropertyEditor()
        {
            PropertyEditor.DataContext = null;
            PropertyEditor.DataContext = view.EditorConfig;
            view.RefreshEditorStatus();
        }

        private void DisplayStatus(string text)
        {
            StatusBar.Text = text;
        }
    }
}
