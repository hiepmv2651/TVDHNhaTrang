using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sql_nhom.Model;
using System.Windows.Input;

namespace sql_nhom.ViewModel
{
    public class PhieuMuonViewModel : BaseViewModel
    {
        private ObservableCollection<PhieuMuon> _List;
        public ObservableCollection<PhieuMuon> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private ObservableCollection<NhanVien> _List1;
        public ObservableCollection<NhanVien> List1 { get => _List1; set { _List1 = value; OnPropertyChanged(); } }

        private ObservableCollection<TheThuVien> _List2;
        public ObservableCollection<TheThuVien> List2 { get => _List2; set { _List2 = value; OnPropertyChanged(); } }

        private PhieuMuon _SelectedItem;
        public PhieuMuon SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    SelectedNV = SelectedItem.NhanVien;
                    SelectedTTV = SelectedItem.TheThuVien;
                    MaPM = SelectedItem.MaPM;
                    NgayMuon = SelectedItem.NgayMuon;
                    SoNgayMuon = SelectedItem.SoNgayMuon;
                }
            }
        }
        private NhanVien _SelectedNV;
        public NhanVien SelectedNV
        { 
            get => _SelectedNV; 
            set 
            {
                _SelectedNV = value;
                OnPropertyChanged(); 
            } 
        }

        private TheThuVien _SelectedTTV;
        public TheThuVien SelectedTTV
        {
            get => _SelectedTTV;
            set
            {
                _SelectedTTV = value;
                OnPropertyChanged();
            }
        }

        private string _MaPM;
        public string MaPM { get => _MaPM; set { _MaPM = value; OnPropertyChanged(); } }


        private DateTime? _NgayMuon;
        public DateTime? NgayMuon { get => _NgayMuon; set { _NgayMuon = value; OnPropertyChanged(); } }


        private int? _SoNgayMuon;
        public int? SoNgayMuon { get => _SoNgayMuon; set { _SoNgayMuon = value; OnPropertyChanged(); } }

        

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public PhieuMuonViewModel()
        {
            List = new ObservableCollection<PhieuMuon>(DataProvider.Ins.DB.PhieuMuons);
            List1 = new ObservableCollection<NhanVien>(DataProvider.Ins.DB.NhanViens);
            List2 = new ObservableCollection<TheThuVien>(DataProvider.Ins.DB.TheThuViens);

            AddCommand = new RelayCommand<object>((p) =>
            {
                return true;

            }, (p) =>
            {
                var phieumuon = new PhieuMuon() { MaPM = MaPM, MaNV = SelectedNV.MaNV, MaThe = SelectedTTV.MaThe, NgayMuon = NgayMuon, SoNgayMuon = SoNgayMuon };

                DataProvider.Ins.DB.PhieuMuons.Add(phieumuon);
                DataProvider.Ins.DB.SaveChanges();

                List.Add(phieumuon);

            });

            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null || SelectedNV == null || SelectedTTV == null)
                    return false;

                var displayList = DataProvider.Ins.DB.PhieuMuons.Where(x => x.MaPM == SelectedItem.MaPM);
                if (displayList != null && displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                var phieumuon = SelectedItem;

                DataProvider.Ins.DB.PhieuMuons.Remove(phieumuon);
                DataProvider.Ins.DB.SaveChanges();

                List.Remove(phieumuon);
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null || SelectedNV == null || SelectedTTV == null)
                    return false;

                var displayList = DataProvider.Ins.DB.PhieuMuons.Where(x => x.MaPM == SelectedItem.MaPM);
                if (displayList != null && displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {

                var phieumuon = DataProvider.Ins.DB.PhieuMuons.Where(x => x.MaPM == SelectedItem.MaPM).SingleOrDefault();
                phieumuon.MaNV = SelectedNV.MaNV;
                phieumuon.MaPM = MaPM;
                phieumuon.NgayMuon = NgayMuon;
                phieumuon.SoNgayMuon = SoNgayMuon;
                phieumuon.MaThe = SelectedTTV.MaThe;
                DataProvider.Ins.DB.SaveChanges();

                SelectedItem.MaPM = MaPM;
            });
        }
    }
}
