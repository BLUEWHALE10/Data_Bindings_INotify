using System.ComponentModel;
using System.Runtime.CompilerServices;
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

namespace Data_Bindings_INotify
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        public MainWindow()
        {
            DataContext = this;
            Boundtext = string.Empty;
            InitializeComponent();
        }

        //propfull + double tab
        private string Boundtext;

        public event PropertyChangedEventHandler? PropertyChanged;
        public string boundtext
        {
            get { return Boundtext; }
            set { Boundtext = value;             
                OnpropertyChanged();
            }
        }

        private void OnpropertyChanged([CallerMemberName] string PropertyName = null)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));

        }

        private void btn_set_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}