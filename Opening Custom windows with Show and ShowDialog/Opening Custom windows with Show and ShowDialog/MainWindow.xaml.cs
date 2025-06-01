using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Opening_Custom_windows_with_Show_and_ShowDialog.View;


namespace Opening_Custom_windows_with_Show_and_ShowDialog
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

        private void btn_Normal_Click(object sender, RoutedEventArgs e)
        {
            NormalWindow normalWindow = new NormalWindow();
            normalWindow.Show();
        }

        private void btn_Modal_Click(object sender, RoutedEventArgs e)
        {
            ModalWindow modalWindow = new ModalWindow(this);
            Opacity = 0.4; // Optional: Dim the main window
            modalWindow.ShowDialog();
            Opacity = 1.0; // Restore the main window opacity after the modal window is closed
            if (modalWindow.Success)
            {
                txt_Input.Text = modalWindow.get_text;
            }
        }
    }
}