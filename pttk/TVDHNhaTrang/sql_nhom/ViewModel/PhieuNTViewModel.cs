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
    public class PhieuNTViewModel : BaseViewModel
    {
        private ObservableCollection<PhieuNhacTra> _List;
        public ObservableCollection<PhieuNhacTra> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private ObservableCollection<TheThuVien> _List1;
        public ObservableCollection<TheThuVien> List1 { get => _List1; set { _List1 = value; OnPropertyChanged(); } }

        

        private PhieuNhacTra _SelectedItem;
        public PhieuNhacTra SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    SelectedTTV = SelectedItem.TheThuVien;
                    
                    SoPhieu = SelectedItem.SoPhieu;
                    NgayLap = SelectedItem.NgayLap;

                }
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

        private int _SoPhieu;
        public  int SoPhieu { get => _SoPhieu; set { _SoPhieu = value; OnPropertyChanged(); } }


        private DateTime? _NgayLap;
        public DateTime? NgayLap { get => _NgayLap; set { _NgayLap = value; OnPropertyChanged(); } }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public PhieuNTViewModel()
        {
            List = new ObservableCollection<PhieuNhacTra>(DataProvider.Ins.DB.PhieuNhacTras);
            List1 = new ObservableCollection<TheThuVien>(DataProvider.Ins.DB.TheThuViens);
            

            AddCommand = new RelayCommand<object>((p) =>
            {
                return true;

            }, (p) =>
            {
                var phieunt = new PhieuNhacTra() { SoPhieu = SoPhieu, NgayLap = NgayLap, MaThe = SelectedTTV.MaThe };

                DataProvider.Ins.DB.PhieuNhacTras.Add(phieunt);
                DataProvider.Ins.DB.SaveChanges();

                List.Add(phieunt);

            });

            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null || SelectedTTV == null)
                    return false;

                var displayList = DataProvider.Ins.DB.PhieuNhacTras.Where(x => x.SoPhieu == SelectedItem.SoPhieu);
                if (displayList != null && displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                var phieunt = SelectedItem;

                DataProvider.Ins.DB.PhieuNhacTras.Remove(phieunt);
                DataProvider.Ins.DB.SaveChanges();

                List.Remove(phieunt);
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null || SelectedTTV == null)
                    return false;

                var displayList = DataProvider.Ins.DB.PhieuNhacTras.Where(x => x.SoPhieu == SelectedItem.SoPhieu);
                if (displayList != null && displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {


                var phieunt = DataProvider.Ins.DB.PhieuNhacTras.Where(x => x.SoPhieu == SelectedItem.SoPhieu).SingleOrDefault();
                phieunt.SoPhieu = SoPhieu;
                phieunt.NgayLap = NgayLap;
                phieunt.MaThe = SelectedTTV.MaThe;
               
                DataProvider.Ins.DB.SaveChanges();

                SelectedItem.SoPhieu = SoPhieu;
            });
        }
    }
}
