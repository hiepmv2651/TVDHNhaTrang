create database QliThuVien
go
use QliThuVien
go

create table LoaiDoiTuong (
	MaDT varchar(10) ,
	TenDT nvarchar(50),
	MoTa nvarchar(50),
	primary key (MaDT)
	)
	
create table DocGia
(
     MaDG varchar(10),
	 MaDT varchar(10) FOREIGN KEY REFERENCES LoaiDoiTuong(MaDT),
     HoTenDG nvarchar(50),
     NgaySinh date,
     GioiTinh nvarchar(20),
     DiaChi  nvarchar(50),
	 SoDT varchar(20),
	 primary key (MaDG)
	 )
create table TheThuVien(
	MaThe varchar(10),
	MaDG varchar(10) FOREIGN KEY REFERENCES DocGia(MaDG),
	NgayTao date,
	primary key (MaThe)
	)
	
	 create table NhanVien(
	 MaNV  varchar(10) ,
	 TenNV nvarchar(20),
	 SDT_NV nvarchar(20),
	 MoTa nvarchar(50),
	 primary key(MaNV)
	 )
	 

	  create table TacGia
	 (
	 MaTG varchar(10),
	 TenTG nvarchar(20),
	 DiachiTG nvarchar(50),
	 CoQuanCongTac nvarchar(50),
	 SDT_TG varchar(20),
	 primary key(MaTG)
	 )
	 
	 create table TheLoai(
	 MaTL varchar(10),
	 TenTL nvarchar(50),
	 primary key(MaTL)
	 )
	 
	 create table NhaXuatBan (
	MaNXB varchar (10)  ,
	TenNXB nvarchar(50),
	DiaChi nvarchar(50),
	SDT_NXB varchar(20),
	PRIMARY KEY (MaNXB)
	)
	

	 create table Sach (
	 MaSach varchar(10),
	 MaNXB varchar(10) FOREIGN KEY REFERENCES NhaXuatBan(MaNXB),
	 MaTL varchar(10) FOREIGN KEY REFERENCES TheLoai(MaTL) ,
     MaTG varchar(10) FOREIGN KEY REFERENCES TacGia(MaTG),
     TenSach nvarchar(50),
     TinhTrang nvarchar(20),
     NamXB int ,
	 primary key(MaSach)
	 )
	 
	 create table PhieuMuon
	 (
	 MaPM varchar(10),
     MaNV varchar(10) FOREIGN KEY REFERENCES NhanVien(MaNV),
     MaThe varchar(10) FOREIGN KEY REFERENCES TheThuVien(MaThe) ,
     NgayMuon date,
     SoNgayMuon int,
	 primary key (MaPM)
	 )
	 
	 create table PhieuNhacTra
	 (
	 SoPhieu int,
     MaThe varchar(10) FOREIGN KEY REFERENCES TheThuVien(MaThe),
     NgayLap date,
	 primary key(SoPhieu)
	 )
	 
	
	create table ChiTietPhieuMuon(
	MaPM varchar(10) FOREIGN KEY REFERENCES PhieuMuon(MaPM) ,
	MaSach varchar(10) FOREIGN KEY REFERENCES Sach(MaSach) ,
	SoLuong int,
	primary key (MaPM,MaSach)
	)
	
	
	create table ChiTietNhacTra (
	MaSach varchar(10) FOREIGN KEY REFERENCES Sach(MaSach),
	SoPhieu int FOREIGN KEY REFERENCES PhieuNhacTra(SoPhieu) ,
	DonGiaPhat money,
	primary key (MaSach,SoPhieu)
	)

	
	
insert into LoaiDoiTuong 
Values ('DT1',N'Sinh Viên',N' là sinh viên đại học Khánh Hòa'),
('DT2',N'Sinh Viên',N' là sinh viên đại học Nha Trang'),
('DT3',N'Học Sinh',N' là học sinh  Lê Thánh Tôn'),
('DT4',N'Giáo Viên',N' là Giáo Viên đại học Nha Trang')
	 Insert into DocGia
Values
('DG1','DT1',N'Nguyễn Trung','03/20/1999','nam',N'12 Lê Đại Hành ,Nha Trang ','098726262'),
('DG2','DT2',N'Trần Hoàng Thi ','07/12/1999',N'nữ',N'48 Sinh Trung ,Nha Trang','098726263'),
('DG3','DT3',N'Nguyễn Như','12/12/1999' ,N'nữ',N'22 Lê Đại Hành ,Khánh Hòa','098726222'),
('DG4','DT4',N'Lê Quốc Hào','06/15/1999','nam',N'Hoàng Trung','098720304' )

insert into NhanVien
values ( 'nv01',N'Trần Võ Huy','0988512376',N'Quản Lý Thư Viện'),
( 'nv02',N'Lê Lâm Thanh','0988512222',N'Kế Toán Sổ Sách'),
( 'nv03',N'Lê Xuân Nhàn','0923512376',N'Kiểm Kê Sách'),
( 'nv04',N'Trần Lan Anh','0988512399',N'Nhân Viên Nhập Sách')

insert into TacGia
values ('TG1',N'Ngô Quỳnh Hoa',N'120 Quang Trung,Nha Trang',N'22/8 Ngô Gia Tự ,Nha Trang','0583992147'),
('TG2',N'Lê Lam Vi',N'12 Lê Thánh Tôn,Nha Trang',N'10 Ngô Quyền ,Nha Trang','0583992222'),
('TG3',N'Trần Quỳnh',N'22 Vĩnh Phước,Nha Trang',N'10/9 Nguyễn Trãi ,Nha Trang','0584812147'),
('TG4',N'Đoàn Hải Sơn',N'335 Vĩnh Nguyên,Nha Trang',N'10 Trường Sơn ,Nha Trang','0583992090')

insert into NhaXuatBan
values ('XB001',N'Xuân Hương',N'22 Lê Quang Tuấn ,Nha Trang','0912002987'),
('XB005',N'Hoàng Diệu',N'10 Nguyễn Trãi ,Nha Trang','0891002987'),
('XB002',N'Tố Hữu',N'Tây Hòa ,Phú Yên','0912008752'),
('XB004',N'Trần Xuân Cảnh',N'Cửu Long ,Cần Thơ','0912119987')

insert into TheThuVien
values ('tv01','DG1','01/22/2020'),
('tv02','DG2','01/20/2020'),
('tv03','DG3','01/18/2020'),
('tv04','DG4','01/06/2020')
insert into TheLoai
values ('TL01',N'Sách Khoa Học Công Nghệ'),
('TL02',N'Sách Giáo Trình'),
('TL03',N'Sách Kinh Tế'),
('TL04',N'Chính trị – pháp luật')

insert into Sach 
values 
('cs01','XB001','TL01','TG1',N'Lập trình nhúng',N'sách mới','2020'),
('cs02','XB005','TL03','TG2',N' Giáo Trình Tiếng Anh',N'sách mới','2021'),
('cs03','XB002','TL02','TG3',N'Kinh Doanh Đổi Mới',N'sách mới','2000'),
('cs04','XB004','TL04','TG4',N'Pháp Luật Xã Hội',N'sách cũ','2022')



insert into PhieuNhacTra
values
('20','tv01','10/02/2021'),
('10','tv02','10/11/2020'),
('08','tv03','08/21/2021'),
('01','tv04','02/10/2021')


insert into PhieuMuon
values
('PM001','nv01','tv01','10/01/2020','30'),
('PM002','nv02','tv02','10/03/2020','10'),
('PM003','nv03','tv03','10/04/2020','20'),
('PM004','nv04','tv04','10/06/2020','10')



insert into ChiTietNhacTra
values ('cs01','20','200000'),
('cs02','10','300000'),
('cs03','08','250000'),
('cs04','01','400000')

insert into ChiTietPhieuMuon
VALUES ('PM001','cs01','30'),
('PM002','cs02','10'),
('PM003','cs03','20'),
('PM004','cs04','10')

create procedure DocGia_insert(
            @MaDG varchar(10)
           ,@MaDT varchar(10)
           ,@HoTenDG nvarchar(50)
           ,@NgaySinh date
           ,@GioiTinh nvarchar(20)
           ,@DiaChi nvarchar(50)
		   ,@SoDT nvarchar(20))
		   as
		   begin 
		   INSERT INTO [dbo].[DocGia]
           ([MaDG]
           ,[MaDT]
           ,[HoTenDG]
           ,[NgaySinh]
           ,[GioiTinh]
           ,[DiaChi]
		   ,[SoDT])
		   values 
		    (@MaDG
           ,@MaDT
           ,@HoTenDG
           ,@NgaySinh
           ,@GioiTinh
           ,@DiaChi
		   ,@SoDT)
		   select ErrMsg = N'thêm thành công'
		   end


create procedure[dbo].[ DocGia_update]
(
            @MaDG varchar(10)
           ,@MaDT varchar(10)
           ,@HoTenDG nvarchar(50)
           ,@NgaySinh date
           ,@GioiTinh nvarchar(20)
           ,@DiaChi nvarchar(50)
		   ,@SoDT nvarchar(20))
		   as
		   begin 
		   UPDATE [dbo].[DocGia]
		   set 
            [MaDT]=@MaDT
           ,[HoTenDG]=@HoTenDG
           ,[NgaySinh]=@NgaySinh
           ,[GioiTinh]=@GioiTinh
           ,[SoDT]=@SoDT
           ,[DiaChi]=@DiaChi
		   where [MaDG]=@MaDG
		   select ErrMsg = N' s?a thành công'
		   end 

 create procedure[dbo].[ DocGia_delete]
		  (
		  @MaDG varchar(10)
		  )
		  as
		  begin
		  DELETE FROM [dbo].[DocGia]
		   where [MaDG]=@MaDG
		    select ErrMsg = N' xóa  thành công'
		   end 