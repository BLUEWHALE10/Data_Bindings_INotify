﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace OpenFileDialog_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "C# Source File | *.cs";
            fileDialog.Title = "Please pick as CS Source file ...";
            bool? success = fileDialog.ShowDialog();

            if(success == true)
            {
                string[] path = fileDialog.FileNames;
                string[] fileName = fileDialog.SafeFileNames;
                //tbInfo.Text = path;
            }
            else
            {

                //didin't pick anythings

            }

        }
    }
}