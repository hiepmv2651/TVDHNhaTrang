//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sql_nhom.Model
{
    using System;
    using System.Collections.Generic;
    using sql_nhom.ViewModel;

    public partial class PhieuMuon : BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuMuon()
        {
            this.ChiTietPhieuMuons = new HashSet<ChiTietPhieuMuon>();
        }

        private string _MaPM;
        public string MaPM { get => _MaPM; set { _MaPM = value; OnPropertyChanged(); } }

        private string _MaNV;
        public string MaNV { get => _MaNV; set { _MaNV = value; OnPropertyChanged(); } }

        private string _MaThe;
        public string MaThe { get => _MaThe; set { _MaThe = value; OnPropertyChanged(); } }

        private Nullable<System.DateTime> _NgayMuon;
        public Nullable<System.DateTime> NgayMuon { get => _NgayMuon; set { _NgayMuon = value; OnPropertyChanged(); } }

        private Nullable<int> _SoNgayMuon;
        public Nullable<int> SoNgayMuon { get => _SoNgayMuon; set { _SoNgayMuon = value; OnPropertyChanged(); } }

        
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; }
        

        private NhanVien _NhanVien;
        public virtual NhanVien NhanVien { get => _NhanVien; set { _NhanVien = value; OnPropertyChanged(); } }

        private TheThuVien _TheThuVien;
        public virtual TheThuVien TheThuVien { get => _TheThuVien; set { _TheThuVien = value; OnPropertyChanged(); } }
    }
}
