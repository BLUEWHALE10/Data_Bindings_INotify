using System.Collections;
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

namespace ListView_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lvEntries.Items.Add("A");
            lvEntries.Items.Add("B");
            lvEntries.Items.Add("C");
            lvEntries.Items.Add("D");
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Add(txtEntry.Text);
            txtEntry.Clear();
        }

        private void btnClr_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();
        }

        private void btnDele_Click(object sender, RoutedEventArgs e)
        {
            //int index = lvEntries.SelectedIndex;
            //lvEntries.Items.RemoveAt(index);

            //object items = lvEntries.SelectedItems;

            var items = lvEntries.SelectedItems;
            var result = MessageBox.Show($"Do you want to delete {items.Count}?", "Delete Entry", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                var listitems = new ArrayList(items);
                foreach (var item in listitems)
                    lvEntries.Items.Remove(item);

            }
        }
    }
}