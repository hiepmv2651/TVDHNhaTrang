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
    /// Interaction logic for UnitWindow.xaml
    /// </summary>
    public partial class UnitWindow : Window
    {
        public UnitWindow()
        {
            InitializeComponent();
            //List = new ObservableCollection<Sach>(DataProvider.Ins.DB.Saches);
            //list.ItemsSource = List;

            //searchall.ItemsSource = List;
        }

       // public ObservableCollection<Sach> List { get; }
    }
}
