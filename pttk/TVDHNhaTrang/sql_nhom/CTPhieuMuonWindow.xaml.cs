﻿using System;
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
    /// Interaction logic for SuplierWindow.xaml
    /// </summary>
    public partial class SuplierWindow : Window
    {
        public SuplierWindow()
        {
            InitializeComponent();
            List = new ObservableCollection<ChiTietPhieuMuon>(DataProvider.Ins.DB.ChiTietPhieuMuons);
            list.ItemsSource = List;

            searchall.ItemsSource = List;
        }

        public ObservableCollection<ChiTietPhieuMuon> List { get; }
    }
}
