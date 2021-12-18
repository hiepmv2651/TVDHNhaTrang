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
    public class SachViewModel : BaseViewModel
    {
        private ObservableCollection<Sach> _List;
        public ObservableCollection<Sach> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private ObservableCollection<NhaXuatBan> _List1;
        public ObservableCollection<NhaXuatBan> List1 { get => _List1; set { _List1 = value; OnPropertyChanged(); } }

        private ObservableCollection<TheLoai> _List2;
        public ObservableCollection<TheLoai> List2 { get => _List2; set { _List2 = value; OnPropertyChanged(); } }

        private ObservableCollection<TacGia> _List3;
        public ObservableCollection<TacGia> List3 { get => _List3; set { _List3 = value; OnPropertyChanged(); } }

        private Sach _SelectedItem;
        public Sach SelectedItem 
        { 
            get => _SelectedItem; 
            set 
            { 
                _SelectedItem = value;
                OnPropertyChanged(); 
                if (SelectedItem != null) 
                {
                    MaSach = SelectedItem.MaSach;
                    SelectedNXB = SelectedItem.NhaXuatBan;
                    SelectedTL = SelectedItem.TheLoai;
                    SelectedTG = SelectedItem.TacGia;
                    TenSach = SelectedItem.TenSach;
                    TinhTrang = SelectedItem.TinhTrang;
                    NamXB = SelectedItem.NamXB;
                }
            } 
        }

        private NhaXuatBan _SelectedNXB;
        public NhaXuatBan SelectedNXB
        {
            get => _SelectedNXB;
            set
            {
                _SelectedNXB = value;
                OnPropertyChanged();
            }
        }

        private TheLoai _SelectedTL;
        public TheLoai SelectedTL
        {
            get => _SelectedTL;
            set
            {
                _SelectedTL = value;
                OnPropertyChanged();
            }
        }

        private TacGia _SelectedTG;
        public TacGia SelectedTG
        {
            get => _SelectedTG;
            set
            {
                _SelectedTG = value;
                OnPropertyChanged();
            }
        }

        private string _MaSach;
        public string MaSach { get => _MaSach; set { _MaSach = value; OnPropertyChanged(); } }

        private string _TenSach;
        public string TenSach { get => _TenSach; set { _TenSach = value; OnPropertyChanged(); } }

        private string _TinhTrang;
        public string TinhTrang { get => _TinhTrang; set { _TinhTrang = value; OnPropertyChanged(); } }

        

        private int? _NamXB;
        public int? NamXB { get => _NamXB; set { _NamXB = value; OnPropertyChanged(); } }

        

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public SachViewModel()
        {
            List = new ObservableCollection<Sach>(DataProvider.Ins.DB.Saches);
            List1 = new ObservableCollection<NhaXuatBan>(DataProvider.Ins.DB.NhaXuatBans);
            List2 = new ObservableCollection<TheLoai>(DataProvider.Ins.DB.TheLoais);
            List3 = new ObservableCollection<TacGia>(DataProvider.Ins.DB.TacGias);

            AddCommand = new RelayCommand<object>((p) =>
            {
                return true;

            }, (p) =>
            {
                var sach = new Sach() { MaSach = MaSach, MaNXB = SelectedNXB.MaNXB, MaTL = SelectedTL.MaTL, MaTG = SelectedTG.MaTG, TenSach = TenSach, TinhTrang = TinhTrang, NamXB = NamXB };

                DataProvider.Ins.DB.Saches.Add(sach);
                DataProvider.Ins.DB.SaveChanges();

                List.Add(sach);
            })
            {

            };
            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null || SelectedNXB == null || SelectedTL == null || SelectedTG == null)
                    return false;

                var displayList = DataProvider.Ins.DB.Saches.Where(x => x.MaSach == SelectedItem.MaSach);
                if (displayList != null && displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                var sach = SelectedItem;

                DataProvider.Ins.DB.Saches.Remove(sach);
                DataProvider.Ins.DB.SaveChanges();

                List.Remove(sach);
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null || SelectedNXB == null || SelectedTL == null || SelectedTG == null)
                    return false;

                var displayList = DataProvider.Ins.DB.Saches.Where(x => x.MaSach == SelectedItem.MaSach);
                if (displayList != null && displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {


                var sach = DataProvider.Ins.DB.Saches.Where(x => x.MaSach == SelectedItem.MaSach).SingleOrDefault();
                sach.MaSach = MaSach;
                sach.MaNXB = SelectedNXB.MaNXB;
                sach.MaTL = SelectedTL.MaTL;
                sach.MaTG = SelectedTG.MaTG;
                sach.TenSach = TenSach;
                sach.TinhTrang = TinhTrang;
                sach.NamXB = NamXB;
                
                DataProvider.Ins.DB.SaveChanges();

                SelectedItem.MaSach = MaSach;
            });
        }

        
    }
}
