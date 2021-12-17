using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Win32;
using OpenQA.Selenium.Chrome;
using sql_nhom.Model;

namespace sql_nhom.ViewModel
{
    public class DocGiaViewModel : BaseViewModel 
    {
        private ObservableCollection<DocGia> _List;
        public ObservableCollection<DocGia> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private ObservableCollection<LoaiDoiTuong> _List1;
        public ObservableCollection<LoaiDoiTuong> List1 { get => _List1; set { _List1 = value; OnPropertyChanged(); } }

        private DocGia _SelectedItem;
        public DocGia SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    MaDG = SelectedItem.MaDG;
                    SelectedDT = SelectedItem.LoaiDoiTuong;
                    HoTenDG = SelectedItem.HoTenDG;
                    NgaySinh = SelectedItem.NgaySinh;
                    GioiTinh = SelectedItem.GioiTinh;
                    DiaChi = SelectedItem.DiaChi;
                    SoDT = SelectedItem.SoDT;

                }
            }
        }

        private LoaiDoiTuong _SelectedDT;
        public LoaiDoiTuong SelectedDT
        {
            get => _SelectedDT;
            set
            {
                _SelectedDT = value;
                OnPropertyChanged();
            }
        }

        

        private string _MaDG;
        public string MaDG { get => _MaDG; set { _MaDG = value; OnPropertyChanged(); } }

        private string _HoTenDG;
        public string HoTenDG { get => _HoTenDG; set { _HoTenDG = value; OnPropertyChanged(); } }

        private string _GioiTinh;
        public string GioiTinh { get => _GioiTinh; set { _GioiTinh = value; OnPropertyChanged(); } }

        private string _DiaChi;
        public string DiaChi { get => _DiaChi; set { _DiaChi = value; OnPropertyChanged(); } }

        private string _SoDT;
        public string SoDT { get => _SoDT; set { _SoDT = value; OnPropertyChanged(); } }

        private DateTime? _NgaySinh;
        public DateTime? NgaySinh { get => _NgaySinh; set { _NgaySinh = value; OnPropertyChanged(); } }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand XuatCommand { get; set; }
        public DocGiaViewModel()
        {
            List = new ObservableCollection<DocGia>(DataProvider.Ins.DB.DocGias);
            List1 = new ObservableCollection<LoaiDoiTuong>(DataProvider.Ins.DB.LoaiDoiTuongs);
            

            AddCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null || SelectedDT == null)
                    return false;

                var displayList = DataProvider.Ins.DB.DocGias.Where(x => x.MaDG == SelectedItem.MaDG);
                if (displayList != null && displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                var dg = new DocGia() { MaDT = SelectedDT.MaDT, MaDG = MaDG, HoTenDG = HoTenDG, NgaySinh = NgaySinh, GioiTinh = GioiTinh, DiaChi = DiaChi, SoDT = SoDT };

                DataProvider.Ins.DB.DocGias.Add(dg);
                DataProvider.Ins.DB.SaveChanges();

                List.Add(dg);
            });
            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null || SelectedDT == null)
                    return false;

                var displayList = DataProvider.Ins.DB.DocGias.Where(x => x.MaDG == SelectedItem.MaDG);
                if (displayList != null && displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                 var dg = SelectedItem;

                 DataProvider.Ins.DB.DocGias.Remove(dg);
                 DataProvider.Ins.DB.SaveChanges();

                 List.Remove(dg);
               
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null || SelectedDT == null)
                    return false;

                var displayList = DataProvider.Ins.DB.DocGias.Where(x => x.MaDG == SelectedItem.MaDG);
                if (displayList != null && displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
               

                var dg = DataProvider.Ins.DB.DocGias.Where(x => x.MaDG == SelectedItem.MaDG).SingleOrDefault();
                dg.MaDG = MaDG;
                dg.MaDT = SelectedDT.MaDT;
                dg.HoTenDG = HoTenDG;
                dg.NgaySinh = NgaySinh;
                dg.GioiTinh = GioiTinh;
                dg.DiaChi = DiaChi;
                dg.SoDT = SoDT;

                DataProvider.Ins.DB.SaveChanges();
                
                SelectedItem.MaDG = MaDG;
            });

            SearchCommand = new RelayCommand<object>((p) =>
            {
                return true;

            }, (p) =>
            {
                

            });

        }
    
    }
}
