using System.Collections.ObjectModel;
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

namespace Observe_collection_with_ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = this;
            entries = new ObservableCollection<string>();
            InitializeComponent();

        }

        private ObservableCollection<string> entries;

        public ObservableCollection<string> Entries
        {
            get { return entries; }
            set { entries = value; }
        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Entries.Add(txtEntry.Text);
        }

        private void btnDele_Click(object sender, RoutedEventArgs e)
        {
            string slectedItem = (string)lvEntries.SelectedItem;
            Entries.Remove(slectedItem);
        }

        private void btnClr_Click(object sender, RoutedEventArgs e)
        {
            Entries.Clear(); 
        }
    }
}