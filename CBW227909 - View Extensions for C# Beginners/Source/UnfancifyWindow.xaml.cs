﻿using System.Windows;
using System.Windows.Forms;

namespace Unfancify
{
    /// <summary>
    /// Interaction logic for UnfancifyWindow.xaml
    /// </summary>
    public partial class UnfancifyWindow : Window
    {

        /// <summary>
        /// The form constructor
        /// </summary>
        public UnfancifyWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method that gets called when the user clicks on the Batch-Unfancify button
        /// </summary>
        public void selectSource_Click(object sender, RoutedEventArgs e)
        {
            // A dialog that lets the user select a directory
            var openDialog = new FolderBrowserDialog
            {
                // Include the option to create a new folder on-the-fly
                ShowNewFolderButton = true
            };

            // Only do something if the user leaves the FolderBrowserDialog by clicking OK
            // Otherwise the user just returns to our window
            if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Get a refrence to our tool's view model
                UnfancifyViewModel vm = (UnfancifyViewModel)unfancifyPanel.DataContext;
                // Call the batch-unfancify method in our view model, providing the folder chosen by the user
                vm.OnBatchUnfancifyClicked(openDialog.SelectedPath);
            }
        }
    }
}