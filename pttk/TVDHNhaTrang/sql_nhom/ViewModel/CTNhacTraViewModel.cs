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
    public class CTNhacTraViewModel : BaseViewModel
    {
        private ObservableCollection<ChiTietNhacTra> _List;
        public ObservableCollection<ChiTietNhacTra> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private ObservableCollection<PhieuNhacTra> _List1;
        public ObservableCollection<PhieuNhacTra> List1 { get => _List1; set { _List1 = value; OnPropertyChanged(); } }

        private ObservableCollection<Sach> _List2;
        public ObservableCollection<Sach> List2 { get => _List2; set { _List2 = value; OnPropertyChanged(); } }

        private ChiTietNhacTra _SelectedItem;
        public ChiTietNhacTra SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    SelectedPNT = SelectedItem.PhieuNhacTra;
                    SelectedS = SelectedItem.Sach;
                    
                    DonGiaPhat = SelectedItem.DonGiaPhat;
                    
                }
            }
        }

        private PhieuNhacTra _SelectedPNT;
        public PhieuNhacTra SelectedPNT
        {
            get => _SelectedPNT;
            set
            {
                _SelectedPNT = value;
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

        private decimal? _DonGiaPhat;
        public decimal? DonGiaPhat { get => _DonGiaPhat; set { _DonGiaPhat = value; OnPropertyChanged(); } }


        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public CTNhacTraViewModel()
        {
            List = new ObservableCollection<ChiTietNhacTra>(DataProvider.Ins.DB.ChiTietNhacTras);
            List1 = new ObservableCollection<PhieuNhacTra>(DataProvider.Ins.DB.PhieuNhacTras);
            List2 = new ObservableCollection<Sach>(DataProvider.Ins.DB.Saches);

            AddCommand = new RelayCommand<object>((p) =>
            {
                return true;

            }, (p) =>
            {
                var ctnhactra = new ChiTietNhacTra() { SoPhieu = SelectedPNT.SoPhieu, MaSach = SelectedS.MaSach, DonGiaPhat = DonGiaPhat };

                DataProvider.Ins.DB.ChiTietNhacTras.Add(ctnhactra);
                DataProvider.Ins.DB.SaveChanges();

                List.Add(ctnhactra);
            });

            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null || SelectedPNT == null || SelectedS == null)
                    return false;

                var displayList = DataProvider.Ins.DB.ChiTietNhacTras.Where(x => x.MaSach == SelectedS.MaSach);
                if (displayList != null && displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                var ctnhactra = SelectedItem;

                DataProvider.Ins.DB.ChiTietNhacTras.Remove(ctnhactra);
                DataProvider.Ins.DB.SaveChanges();

                List.Remove(ctnhactra);
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null || SelectedPNT == null || SelectedS == null)
                    return false;

                var displayList = DataProvider.Ins.DB.ChiTietNhacTras.Where(x => x.MaSach == SelectedS.MaSach);
                if (displayList != null && displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                var ctnhactra = DataProvider.Ins.DB.ChiTietNhacTras.Where(x => x.MaSach == SelectedS.MaSach).SingleOrDefault();
                ctnhactra.MaSach = SelectedS.MaSach;
                ctnhactra.SoPhieu = SelectedPNT.SoPhieu;
                ctnhactra.DonGiaPhat = DonGiaPhat;

                DataProvider.Ins.DB.SaveChanges();

                SelectedItem.DonGiaPhat = DonGiaPhat;
            });
        }
    }
}
