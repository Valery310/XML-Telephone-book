using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XML_Telephone_book
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ATS> viewModelATS //Коллекция времени работы плеера
        {
            get;
            set;
        }

        public class ATS
        {
            public bool isFreePBX = false;
            public string addressATS { get; set; }
            public string login { get; set; }
            public string password { get; set; }
            public string comboBoxTypeATS { get; set; }
        }
        public MainWindow()
        {
            InitializeComponent();

            viewModelATS = new ObservableCollection<ATS>();
            viewModelATS.CollectionChanged += ViewModelATS_CollectionChanged;
            viewModelATS.Add(new ATS{ isFreePBX = true, addressATS = "ATS", login = "login", password = "password", comboBoxTypeATS = "FreePBX" }) ;
            List<string> vs = new List<string>();
            vs.Add("FreePBX");
            vs.Add("Yeastar");
            dgcmbTypeATS.ItemsSource = vs;
            dgATS.ItemsSource = viewModelATS;
        }

        private void ViewModelATS_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
           // throw new NotImplementedException();
        }
    }
}
