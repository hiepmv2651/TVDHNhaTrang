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
    public class CTPhieuMuonViewModel : BaseViewModel
    {
        private ObservableCollection<ChiTietPhieuMuon> _List;
        public ObservableCollection<ChiTietPhieuMuon> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private ObservableCollection<PhieuMuon> _List1;
        public ObservableCollection<PhieuMuon> List1 { get => _List1; set { _List1 = value; OnPropertyChanged(); } }

        private ObservableCollection<Sach> _List2;
        public ObservableCollection<Sach> List2 { get => _List2; set { _List2 = value; OnPropertyChanged(); } }

        private ChiTietPhieuMuon _SelectedItem;
        public ChiTietPhieuMuon SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    SelectedPM = SelectedItem.PhieuMuon;
                    SelectedS = SelectedItem.Sach;
                    
                    SoLuong = SelectedItem.SoLuong;
                }
            }
        }

        private PhieuMuon _SelectedPM;
        public PhieuMuon SelectedPM
        {
            get => _SelectedPM;
            set
            {
                _SelectedPM = value;
                OnPropertyChanged();
            }
        }

        private Sach _SelectedS;
        public Sach SelectedS
        {
            get => _SelectedS;
            set
            {
                _SelectedS = value;
                OnPropertyChanged();
            }
        }

        private decimal? _SoLuong;
        public decimal? SoLuong { get => _SoLuong; set { _SoLuong = value; OnPropertyChanged(); } }


        
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public CTPhieuMuonViewModel()
        {
            List = new ObservableCollection<ChiTietPhieuMuon>(DataProvider.Ins.DB.ChiTietPhieuMuons);
            List1 = new ObservableCollection<PhieuMuon>(DataProvider.Ins.DB.PhieuMuons);
            List2 = new ObservableCollection<Sach>(DataProvider.Ins.DB.Saches);

            AddCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;

                var displayList = DataProvider.Ins.DB.ChiTietPhieuMuons.Where(x => x.MaPM == SelectedPM.MaPM);
                if (displayList != null && displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                var ctphieumuon = new ChiTietPhieuMuon() { MaPM = SelectedPM.MaPM, MaSach = SelectedS.MaSach, SoLuong = SoLuong };

                DataProvider.Ins.DB.ChiTietPhieuMuons.Add(ctphieumuon);
                DataProvider.Ins.DB.SaveChanges();

                List.Add(ctphieumuon);
            });
            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;

                var displayList = DataProvider.Ins.DB.ChiTietPhieuMuons.Where(x => x.MaPM == SelectedPM.MaPM);
                if (displayList != null && displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                var ctphieumuon = SelectedItem;

                DataProvider.Ins.DB.ChiTietPhieuMuons.Remove(ctphieumuon);
                DataProvider.Ins.DB.SaveChanges();

                List.Remove(ctphieumuon);
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;

                var displayList = DataProvider.Ins.DB.ChiTietPhieuMuons.Where(x => x.MaPM == SelectedPM.MaPM);
                if (displayList != null && displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {


                var ctphieumuon = DataProvider.Ins.DB.ChiTietPhieuMuons.Where(x => x.MaPM == SelectedPM.MaPM).SingleOrDefault();
                ctphieumuon.SoLuong = SoLuong;
                ctphieumuon.MaPM = SelectedPM.MaPM;
                ctphieumuon.MaSach = SelectedS.MaSach;
                

                DataProvider.Ins.DB.SaveChanges();

                SelectedItem.SoLuong = SoLuong;
            });
        }
    }
}
