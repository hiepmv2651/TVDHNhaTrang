using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using sql_nhom.Model;

namespace sql_nhom.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<TonKho> _TonKhoList;
        public ObservableCollection<TonKho> TonKhoList { get => _TonKhoList; set { _TonKhoList = value; OnPropertyChanged(); } }

        public bool Isloaded = false;
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand SuplierCommand { get; set; }//chi tiết phiếu mượn
        public ICommand UnitCommand { get; set; }//sách
        
        public ICommand UserCommand { get; set; }//nhân viên
        public ICommand InputCommand { get; set; }//phiếu mượn
        public ICommand OutputCommand { get; set; }//chi tiết nhắc trả
        public ICommand DocgiaCommand { get; set; }//độc giả
        public ICommand NhapCommand { get; set; }//thẻ thư viện
        public ICommand XuatCommand { get; set; }//phiếu nhắc trả
        // mọi thứ xử lý sẽ nằm trong này
        public MainViewModel()
        {
            LoadedWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) => {
                Isloaded = true;
                if (p == null)
                    return;
                p.Hide();
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();

                if (loginWindow.DataContext == null)
                    return;
                var loginVM = loginWindow.DataContext as LoginViewModel;

                if (loginVM.IsLogin)
                {
                    p.Show();
                    LoadTonKhoData();
                }
                else
                {
                    p.Close();
                }
            }
              );

            UnitCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                UnitWindow wd = new UnitWindow(); wd.ShowDialog();
            }//sách
              );

            SuplierCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                SuplierWindow wd = new SuplierWindow(); wd.ShowDialog();
            }//chi tiết phiếu mượn
             );

            UserCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                UserWindow wd = new UserWindow(); wd.ShowDialog();
            }//nhân viên
             );

            InputCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                InputWindow wd = new InputWindow(); wd.ShowDialog();
            }//phiếu mượn
            );

            OutputCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                OutputWindow wd = new OutputWindow(); wd.ShowDialog();
            }//chi tiết nhắc trả
            );

            DocgiaCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                BaoHanhWindow wd = new BaoHanhWindow(); wd.ShowDialog();
            }//độc giả
            );

            NhapCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                Input1Window wd = new Input1Window(); wd.ShowDialog();
            }//thẻ thư viện
            );

            XuatCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                Output1Window wd = new Output1Window(); wd.ShowDialog();
            }//phiếu nhắc trả
            );
        }
        void LoadTonKhoData()
        {
            
        }
    }
}
