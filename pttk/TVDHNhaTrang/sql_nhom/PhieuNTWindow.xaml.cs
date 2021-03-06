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
using System.Windows.Shapes;
using sql_nhom.Model;

namespace sql_nhom
{
    /// <summary>
    /// Interaction logic for Output1Window.xaml
    /// </summary>
    public partial class Output1Window : Window
    {
        public Output1Window()
        {
            InitializeComponent();
            List = new ObservableCollection<PhieuNhacTra>(DataProvider.Ins.DB.PhieuNhacTras);
            list.ItemsSource = List;

            searchall.ItemsSource = List;
        }

        public ObservableCollection<PhieuNhacTra> List { get; }
    }
}
