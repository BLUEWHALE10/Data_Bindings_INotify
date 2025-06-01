using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Opening_Custom_windows_with_Show_and_ShowDialog.View
{
    /// <summary>
    /// Interaction logic for ModalWindow.xaml
    /// </summary>
    public partial class ModalWindow : Window
    {
        public bool Success { get; set; }
        public string get_text { get; set; } = string.Empty; // Initialize to avoid nullability issue

        public ModalWindow(Window parentWindow)
        {
            Owner = parentWindow; // Set the owner of the modal window
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            Success = true;
            get_text = txt_Input.Text;
            Close();
        }

        private void btn_Cancle_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txt_Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_Input.Text))
            {
                btn_ok.IsEnabled = true; // Enable the OK button if there is text
            }
            else
            {
                btn_ok.IsEnabled = false; // Disable the OK button if the text is empty
            }
        }
    }
}
