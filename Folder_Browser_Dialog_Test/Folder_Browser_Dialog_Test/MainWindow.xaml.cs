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

namespace Folder_Browser_Dialog_Test
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
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.InitialDirectory = "D:\\WPF\\Folder_Browser_Dialog_Test";
            folderBrowserDialog.ShowDialog();
            DialogResult result = default;
            if (result == System.Windows.Forms.DialogResult.OK){

                string folder = folderBrowserDialog.SelectedPath;
            }
        }
    }
}