using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using sql_nhom.Model;

namespace sql_nhom.ViewModel
{
    public class UserViewModel : BaseViewModel
    {
        private ObservableCollection<NhanVien> _List;
        public ObservableCollection<NhanVien> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private NhanVien _SelectedItem;
        public NhanVien SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    MaNV = SelectedItem.MaNV;
                    TenNV = SelectedItem.TenNV;
                    
                    SDT_NV = SelectedItem.SDT_NV;
                    MoTa = SelectedItem.MoTa;
                    
                }
            }
        }

        private string _MaNV;
        public string MaNV { get => _MaNV; set { _MaNV = value; OnPropertyChanged(); } }


        private string _TenNV;
        public string TenNV { get => _TenNV; set { _TenNV = value; OnPropertyChanged(); } }


        private string _SDT_NV;
        public string SDT_NV { get => _SDT_NV; set { _SDT_NV = value; OnPropertyChanged(); } }


        private string _MoTa;
        public string MoTa { get => _MoTa; set { _MoTa = value; OnPropertyChanged(); } }


        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public UserViewModel()
        {
            List = new ObservableCollection<NhanVien>(DataProvider.Ins.DB.NhanViens);

            AddCommand = new RelayCommand<object>((p) =>
            {
                return true;

            }, (p) =>
            {
                var Nhanvien = new NhanVien() { MaNV = MaNV, TenNV = TenNV, SDT_NV = SDT_NV, MoTa = MoTa };

                DataProvider.Ins.DB.NhanViens.Add(Nhanvien);
                DataProvider.Ins.DB.SaveChanges();

                List.Add(Nhanvien);
            });
            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;

                var displayList = DataProvider.Ins.DB.NhanViens.Where(x => x.MaNV == SelectedItem.MaNV);
                if (displayList != null && displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                var Nhanvien = SelectedItem;

                DataProvider.Ins.DB.NhanViens.Remove(Nhanvien);
                DataProvider.Ins.DB.SaveChanges();

                List.Remove(Nhanvien);
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;

                var displayList = DataProvider.Ins.DB.NhanViens.Where(x => x.MaNV == SelectedItem.MaNV);
                if (displayList != null && displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {


                var nv = DataProvider.Ins.DB.NhanViens.Where(x => x.MaNV == SelectedItem.MaNV).SingleOrDefault();
                nv.TenNV = TenNV;
                nv.MaNV = MaNV;
                nv.SDT_NV = SDT_NV;
                nv.MoTa = MoTa;
                
                DataProvider.Ins.DB.SaveChanges();

                SelectedItem.MaNV = MaNV;
            });
        }
    }
}
