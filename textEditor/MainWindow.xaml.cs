using System.Windows.Input;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System;
using System.Drawing;

namespace textEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {

        private TabItem activeTab;

        public MainWindow()
        {
            InitializeComponent();
            txtEdit.FocusVisualStyle = null;
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(Keyboard.IsKeyDown(Key.LeftShift) && Keyboard.IsKeyDown(Key.LeftCtrl))
                DragMove();
        }
        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnMax_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
                WindowState = WindowState.Normal;
            else
                WindowState = WindowState.Maximized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txtEdit_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl))
            {
                // TextBox control
                System.Windows.Controls.TextBox textBox = sender as System.Windows.Controls.TextBox;

                // Increase font size with Ctrl + MouseWheel up
                if (e.Delta > 0)
                {
                    if (textBox.FontSize < 100) // max font size
                    {
                        textBox.FontSize += 1;
                    }
                }
                else // Increase font size with Ctrl + MouseWheel Down
                {
                    if (textBox.FontSize > 5) // min font size
                    {
                        textBox.FontSize -= 1;
                    }
                }

                // so it doesn't scroll the TextBox's content
                e.Handled = true;
            }
        }

        private void txtEdit_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            // Tab key
            if (e.Key == Key.Tab)
            {
                System.Windows.Controls.TextBox textBox = sender as System.Windows.Controls.TextBox;

                // Get the current cursor position
                int caretIndex = textBox.CaretIndex;

                textBox.Text = textBox.Text.Insert(caretIndex, "    ");

                // Move the cursor position after the inserted tab character
                textBox.CaretIndex = caretIndex + 4;

                // wont move the focus to the next control
                e.Handled = true;
            }
        }

        private void btnFolder_Click(object sender, RoutedEventArgs e)
        {
            if(explorPanel.Visibility == Visibility.Visible)
            {
                explorPanel.Visibility = Visibility.Collapsed;
                explorCol.Width = new GridLength(0);
                Grid.SetColumn(helperBTNs, 1);
            }
            else
            {
                explorPanel.Visibility = Visibility.Visible;
                explorCol.Width = new GridLength(200);
                Grid.SetColumn(helperBTNs, 0);
            }
        }

        private void FolderTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            var selectedNode = (TreeViewItem)e.NewValue;
            string selectedFolderPath = (string)selectedNode.Tag;
            PopulateTreeView(selectedFolderPath);
        }

        private void PopulateTreeView(string folderPath)
        {
            folderTreeView.Items.Clear();
            PopulateNode(folderPath, folderTreeView);
        }

        private void PopulateNode(string folderPath, ItemsControl parentNode)
        {
            try
            {
                // Add directories
                string[] directories = Directory.GetDirectories(folderPath);
                foreach (string directory in directories)
                {
                    var node = new TreeViewItem
                    {
                        Header = Path.GetFileName(directory),
                        Tag = directory,
                        Foreground = System.Windows.Media.Brushes.White
                    };
                    node.MouseDoubleClick += Node_MouseDoubleClick; // Add MouseDoubleClick event handler
                    parentNode.Items.Add(node);
                    PopulateNode(directory, node); // Recursively add subdirectories
                }

                // Add files
                string[] files = Directory.GetFiles(folderPath);
                foreach (string file in files)
                {
                    var node = new TreeViewItem
                    {
                        Header = Path.GetFileName(file),
                        Tag = file,
                        Foreground = System.Windows.Media.Brushes.White
                    };
                    node.MouseDoubleClick += Node_MouseDoubleClick; // Add MouseDoubleClick event handler
                    parentNode.Items.Add(node);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Node_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedNode = sender as TreeViewItem;
            string selectedPath = selectedNode.Tag.ToString();
            if (File.Exists(selectedPath))
            {
                string fileExtension = Path.GetExtension(selectedPath).ToLower();
                if (fileExtension == ".c" || fileExtension == ".h" || fileExtension == ".cpp" || fileExtension == ".hpp")
                {
                    string fileContent = File.ReadAllText(selectedPath);
                    AddTab(Path.GetFileName(selectedPath), fileContent);
                }
                else
                {
                    string fileContent = File.ReadAllText(selectedPath);
                    AddTab(Path.GetFileName(selectedPath), fileContent);
                }
            }
        }

        private void AddTab(string fileName, string fileContent)
        {
            // Check if tab with same fileName already exists
            foreach (TabItem tabItm in tabControl.Items)
            {
                if (tabItm.Header.ToString() == fileName)
                {
                    tabItm.IsSelected = true; // Switch to the existing tab
                    return;
                }
            }

            // If tab doesn't exist, create a new one
            var tabItem = new TabItem
            {
                Header = fileName
            };
            var textBox = new System.Windows.Controls.TextBox
            {
                Text = fileContent,
                AcceptsReturn = true,
                TextWrapping = TextWrapping.Wrap
            };
            tabItem.Content = textBox;
            tabControl.Items.Add(tabItem);
            tabItem.IsSelected = true; // Select the newly added tab
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tabControl.SelectedItem is TabItem selectedTab)
            {
                if (selectedTab.Content is System.Windows.Controls.TextBox textBox)
                {
                    txtEdit.Text = textBox.Text; // Set the content of the selected tab's TextBox to the main TextBox
                }
            }
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string selectedFolderPath = dialog.SelectedPath;
                PopulateTreeView(selectedFolderPath);
            }
        }

        private void TabControl_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                if (tabControl.SelectedItem is TabItem selectedItem)
                {
                    tabControl.Items.Remove(selectedItem);
                }
            }
        }

        private void SaveFile()
        {
            if (activeTab != null && activeTab.Content is System.Windows.Controls.TextBox textBox)
            {
                // Get the file path from the tab header
                string filePath = (string)activeTab.Header;

                try
                {
                    // Check if the file already exists
                    if (File.Exists(filePath))
                    {
                        // Confirm if the user wants to overwrite the existing file
                        MessageBoxResult result = System.Windows.MessageBox.Show("Do you want to overwrite the existing file?", "Confirmation", MessageBoxButton.YesNoCancel);
                        if (result == MessageBoxResult.Yes)
                        {
                            // Overwrite the file
                            File.WriteAllText(filePath, textBox.Text);
                            System.Windows.MessageBox.Show("File saved successfully.");
                        }
                        else if (result == MessageBoxResult.No)
                        {
                            // Don't save, just return
                            return;
                        }
                        else
                        {
                            // Cancel saving
                            return;
                        }
                    }
                    else
                    {
                        // File doesn't exist, just save
                        File.WriteAllText(filePath, textBox.Text);
                        System.Windows.MessageBox.Show("File saved successfully.");
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show("Error saving file: " + ex.Message);
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtEdit.Focus();
        }

        private void txtEdit_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.S && (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)))
            {
                SaveFile();
                e.Handled = true;
            }
        }
    }
}
