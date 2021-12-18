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
    public class ThetvViewModel : BaseViewModel
    {
        private ObservableCollection<TheThuVien> _List;
        public ObservableCollection<TheThuVien> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private ObservableCollection<DocGia> _List1;
        public ObservableCollection<DocGia> List1 { get => _List1; set { _List1 = value; OnPropertyChanged(); } }

        
        private TheThuVien _SelectedItem;
        public TheThuVien SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    SelectedDG = SelectedItem.DocGia;
                    
                    MaThe = SelectedItem.MaThe;
                    NgayTao = SelectedItem.NgayTao;
                    
                }
            }
        }
        private DocGia _SelectedDG;
        public DocGia SelectedDG
        {
            get => _SelectedDG;
            set
            {
                _SelectedDG = value;
                OnPropertyChanged();
            }
        }

        

        private string _MaThe;
        public string MaThe { get => _MaThe; set { _MaThe = value; OnPropertyChanged(); } }


        private DateTime? _NgayTao;
        public DateTime? NgayTao { get => _NgayTao; set { _NgayTao = value; OnPropertyChanged(); } }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public ThetvViewModel()
        {
            List = new ObservableCollection<TheThuVien>(DataProvider.Ins.DB.TheThuViens);
            List1 = new ObservableCollection<DocGia>(DataProvider.Ins.DB.DocGias);
            

            AddCommand = new RelayCommand<object>((p) =>
            {
                return true;

            }, (p) =>
            {
                var thetv = new TheThuVien() { MaThe = MaThe, NgayTao = NgayTao, MaDG = SelectedDG.MaDG };

                DataProvider.Ins.DB.TheThuViens.Add(thetv);
                DataProvider.Ins.DB.SaveChanges();

                List.Add(thetv);

            });

            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null || SelectedDG == null)
                    return false;

                var displayList = DataProvider.Ins.DB.TheThuViens.Where(x => x.MaThe == SelectedItem.MaThe);
                if (displayList != null && displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                var thetv = SelectedItem;

                DataProvider.Ins.DB.TheThuViens.Remove(thetv);
                DataProvider.Ins.DB.SaveChanges();

                List.Remove(thetv);
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null || SelectedDG == null)
                    return false;

                var displayList = DataProvider.Ins.DB.TheThuViens.Where(x => x.MaThe == SelectedItem.MaThe);
                if (displayList != null && displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {


                var thetv = DataProvider.Ins.DB.TheThuViens.Where(x => x.MaThe == SelectedItem.MaThe).SingleOrDefault();
                thetv.MaThe = MaThe;
                thetv.NgayTao = NgayTao;
                thetv.MaDG = SelectedDG.MaDG;
                
                DataProvider.Ins.DB.SaveChanges();

                SelectedItem.MaThe = MaThe;
            });
        }
    }
}
