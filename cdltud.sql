create database db_olympic

use db_olympic

create table tblSinhVien (
MaSV varchar(50) primary key not null,
TenSV nvarchar(100) not null,
GioiTinh nvarchar(3),
Sdt varchar(11),
NgaySinh date,
Email varchar(50),
Lop varchar(20)
)


create table tblGiangVien (
MaGV varchar(50) primary key not null,
TenGV nvarchar(100) not null,
GioiTinh nvarchar(3),
Sdt varchar(11),
NgaySinh date,
Email varchar(50),
Username varchar(50),
Password varchar(100)
)


create table tblNoidungthi (
MaNDThi varchar(50) primary key not null,
TenNDThi nvarchar(100) not null,
Mota nvarchar(100),
Ngaybatdau date,
Ngayketthuc date,
Diadiem nvarchar(100)
)

create table tblDoithi (
MaDoi varchar(50) primary key not null,
TenDoi nvarchar(100),
Ketqua nvarchar(100),
Nam int,
MaGV varchar(50),
MaNDThi varchar(50)
)

select * from tblDoithi

alter table tblDoithi add constraint FK_GV_DT foreign key (MaGV) references tblGiangVien(MaGV)
alter table tblDoithi add constraint FK_DT_NDT foreign key (MaNDThi) references tblNoidungthi(MaNDThi)

create table tblChitietDoi (
MaSV varchar(50) not null,
MaDoi varchar(50) not null
)


alter table tblChitietDoi add constraint FK_Doi_Chitiet foreign key (MaDoi) references tblDoiThi(MaDoi)
alter table tblChitietDoi add constraint FK_Doi_SV foreign key (MaSV) references tblSinhVien(MaSV)
alter table tblChitietDoi add constraint Ma PRIMARY KEY (MaSV, MaDoi)



insert into tblGiangVien values
 ('GV01', N'Trịnh Thị Xuân',N'Nữ','03662472020', '1888-08-08','trinhthixuan@gmail.com','admin','adminXuan'),
 ('GV02', N'Lê Hữu Dũng',N'Nam','0324215356', '1880-11-1','lehuudung@gmail.com','admin','adminDung'),
 ('GV03', N'Thái Thanh Tùng',N'Nam','0412578965', '1881-12-12','thaithanhtung@gmail.com','admin','adminTung'),
 ('GV04', N'Mai Thúy Hà',N'Nữ','0354125789', '1883-10-10','maithuyha@gmail.com','admin','adminHa');



insert into tblSinhVien values
 ('SV01', N'Chử Ngọc Ánh',N'Nữ','0366247203', '1999-05-05','chungocanh@gmail.com','17A4'),
 ('SV02', N'Vũ Đức Anh',N'Nam','0324123575', '1999-11-1','vuducanh@gmail.com','16A3'),
 ('SV03', N'Trần Ngọc Bảo',N'Nam','0324125645', '1998-12-12','tranngocbao@gmail.com','16A4'),
 ('SV04', N'Phạm Thị Hương',N'Nữ','0314256214', '1999-10-10','phamthihuong@gmail.com','17A2'),
 ('SV05', N'Nguyễn Thị Tuyết',N'Nữ','0311478952', '1999-11-03','nguyenthituyet@gmail.com','17A5'),
 ('SV06', N'Nguyễn Thanh Thảo',N'Nữ','0322145123', '1999-05-10','nguyenthanhthao@gmail.com','17A1'),
 ('SV07', N'Nguyễn Thị Lụa',N'Nữ','0388456214', '1999-03-11','nguyenthilua@gmail.com','17A6'),
 ('SV08', N'Trần Thùy Trang',N'Nữ','0355214785', '1999-08-08','tranthuytrang@gmail.com','17A3'),
 ('SV09', N'Phan Thanh Dũng',N'Nam','0311478952', '2000-02-02','phanthanhdung@gmail.com','18A1'),
 ('SV10', N'Phạm Văn Lộc',N'Nam','0388541962', '1998-04-04','phamvanloc@gmail.com','16A5'),
 ('SV11', N'Nguyễn Bá Anh',N'Nam','0365124853', '1998-09-03','nguyenbaanh@gmail.com','16A1');


insert into tblNoidungthi values 
 ('ND01',N'Olympic an toàn thông tin', N'Thi an toàn thông tin','2022-02-22','2022-02-22', N'Trường Đại học Mở Hà Nội'),
 ('ND02',N'Olympic tiếng anh không chuyên', N'Thi tiếng anh không chuyên','2022-02-23','2022-02-23', N'Trường Đại học Bách Khoa'),
 ('ND03',N'Olympic mã nguồn mở', N'Thi mã nguồn mở','2022-02-24','2022-02-24', N'Trường Đại học Xây Dựng'),
 ('ND04',N'Olympic mạng và hệ thống thông tin', N'Thi mạng và hệ thống thông tin','2022-02-25','2022-02-25', N'Trường Đại học Mở Hà Nội');




insert into tblDoithi values
('DT01', N'Đội 1', NULL, 2022, 'GV01','ND01'),
('DT02', N'Đội 2', NULL, 2022, 'GV02','ND02'),
('DT03', N'Đội 3', NULL, 2022, 'GV03','ND03'),
('DT04', N'Đội 4', NULL, 2022, 'GV04','ND04');


create table tblGiangVien (
MaGV varchar(50) primary key not null,
TenGV nvarchar(100) not null,
GioiTinh tinyint,
Sdt varchar(11),
NgaySinh date,
Email varchar(50),
Username varchar(50),
Password varchar(100)
)

-----------GIẢNG VIÊN----------------------
------1. hiện dữ liệu tất cả giảng viên-----
create proc hienGiangVien
as
select MaGV, TenGV, GioiTinh, Sdt, CONVERT(VARCHAR(10), NgaySinh, 103) AS NgaySinh,Email, Username, Password
from tblGiangVien
go

exec hienGiangVien;


-----2. hiện dữ liệu 1 giảng viên----

create proc hien1GiangVien
@magv varchar(50)
as
begin
select TenGV,GioiTinh, Sdt, CONVERT(VARCHAR(10), NgaySinh, 103) AS NgaySinh,Email,Username,Password
from tblGiangVien
where MaGV = @magv
end

exec hien1GiangVien 'GV02';



-----thêm giảng viên----
Create proc them_gv
@MaGV varchar(50),
@TenGV nvarchar(100),
@GioiTinh nvarchar(3),
@SDT varchar(11),
@NgaySinh date,
@Email varchar(50),
@username varchar(50),
@password varchar(100)
as
begin
insert into tblGiangVien
values (@MaGV, @TenGV, @GioiTinh,@SDT,@NgaySinh,@Email, @username, @password)
end
go

exec them_gv 'GV05', N'Nguyễn Đức Tuấn', N'Nam', '012321321','1882/05/28', 'nguyenductuan@gmail.com', 'admin', 'adminTuan';
exec them_gv 'GV06', N'hi', N'nam', '012321321','1882/05/28', 'nguyenductuan@gmail.com', 'admin', 'adminTuan';


select * from tblGiangVien

-----sửa giảng viên------
create proc sua_gv
@MaGV varchar(50), 
@TenGV nvarchar(100), 
@NgaySinh date, 
@GioiTinh nvarchar(3), 
@sdt nvarchar(10), 
@Email nvarchar(100), 
@username varchar(50),
@password varchar(100)
as
begin
update tblGiangVien
set TenGV = @TenGV, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, Sdt = @sdt, 
Email = @Email, Username = @username, Password = @password
where MaGV = @MaGV
end
GO

exec sua_gv 'GV05', N'tuấn kute','1889/05/30', N'Nam', 
'0344789521','tuankute@gmail.com','tuankute','tuankute' ; 
select * from tblGiangVien


------xóa giảng viên-----
create proc xoa_gv @MaGV varchar(50) 
as
begin
	delete from tblGiangVien where MaGV = @MaGV
end
GO
exec xoa_gv 'GV06'


----tìm kiếm giảng viên----
create proc timkiem_gv
@Key nvarchar(255)
as
  begin
	  select * from tblGiangVien
	  where
	  TenGV like N'%'+(trim(@Key))+'%' or 
	  MaGV like N'%'+(trim(@Key))+'%' or 
	  Email like N'%'+(trim(@Key))+'%' or 
	  Sdt like N'%'+(trim(@Key))+'%' 
  end

exec timkiem_gv 'lehuudung@gmail.com'

select * from tblGiangVien


alter table tblSinhVien add constraint MaSV unique

-----------SINH VIÊN----------------------
------1. hiện dữ liệu tất cả sinh viên-----
create proc hienSinhVien
as
select MaSV, TenSV, GioiTinh, Sdt, CONVERT(VARCHAR(10), NgaySinh, 103) AS NgaySinh, Email, Lop
from tblSinhVien
go

exec hienSinhVien;
select * from tblSinhVien


-----2. hiện dữ liệu 1 sinh viên----

create proc hien1SinhVien
@masv varchar(50)
as
begin
select TenSV,GioiTinh, Sdt, CONVERT(VARCHAR(10), NgaySinh, 103) AS NgaySinh,Email,Lop
from tblSinhVien
where MaSV = @masv
end

exec hien1SinhVien 'SV02';


-----thêm giảng viên----
Create proc them_sv
@MaSV varchar(50),
@TenSV nvarchar(100),
@GioiTinh nvarchar(3),
@SDT varchar(11),
@NgaySinh date,
@Email varchar(50),
@lop varchar(20)
as
begin
insert into tblSinhVien
values (@MaSV, @TenSV, @GioiTinh,@SDT,@NgaySinh,@Email, @lop)
end
go

exec them_sv 'SV99', N'Tuấn', N'Nam', '012321321','1882/05/28', 'tuan@gmail.com', '17A7';


select * from tblSinhVien

-----sửa sinh viên------
create proc sua_sv
@MaSV varchar(50), 
@TenSV nvarchar(100), 
@NgaySinh date, 
@GioiTinh nvarchar(3), 
@sdt nvarchar(10), 
@Email nvarchar(100), 
@lop varchar(20)
as
begin
update tblSinhVien
set TenSV = @TenSV, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, Sdt = @sdt, 
Email = @Email, Lop = @lop
where MaSV = @MaSV
end
GO

exec sua_sv 'SV05', N'Nguyễn thị tuýt','1889/05/30', N'Nữ', 
'0344789521','tuyet@gmail.com','17A5' ; 
select * from tblSinhVien


------xóa sinh viên-----
create proc xoa_sv @MaSV varchar(50) 
as
begin
	delete from tblSinhVien where MaSV = @MaSV
end
GO



----tìm kiếm sinh viên----
create proc timkiem_sv
@Key nvarchar(255)
as
  begin
	  select * from tblSinhVien
	  where
	  TenSV like N'%'+(trim(@Key))+'%' or 
	  MaSV like N'%'+(trim(@Key))+'%' or 
	  Email like N'%'+(trim(@Key))+'%' or 
	  Sdt like N'%'+(trim(@Key))+'%' or
	  Lop like N'%'+(trim(@Key))+'%'
  end

exec timkiem_sv '17A7'



ALTER TABLE tblSinhVien
ADD CONSTRAINT Masv_unique 
UNIQUE (MaSV);

ALTER TABLE tblGiangVien
ADD CONSTRAINT Magv_unique 
UNIQUE (MaGV);

ALTER TABLE tblNoidungthi
ADD CONSTRAINT MaNDT_unique 
UNIQUE (MaNDThi);

--------nội dung thi------------
 ('ND01',N'Olympic an toàn thông tin', N'Thi an toàn thông tin','2022-02-22','2022-02-22', N'Trường Đại học Mở Hà Nội'),


Create proc them_ndthi
@MaNDThi varchar(50),
@TenNDThi nvarchar(100),
@Mota nvarchar(100),
@Ngaybatdau date,
@Ngayketthuc date,
@Diadiem nvarchar(100)
as
begin
insert into tblNoidungthi
values (@MaNDThi, @TenNDThi, @Mota,@Ngaybatdau,@Ngayketthuc,@Diadiem)
end
go


exec them_ndthi 'ND11', N'Abc', N'Thi abc','2022-03-05','2022-03-05', N'Trường Đại học Hà Nội'


create proc sua_ndthi
@MaNDThi varchar(50),
@TenNDThi nvarchar(100),
@Mota nvarchar(100),
@Ngaybatdau date,
@Ngayketthuc date,
@Diadiem nvarchar(100)
as
begin
update tblNoidungthi
set TenNDThi = @TenNDThi, Mota = @Mota, Ngaybatdau = @Ngaybatdau, Ngayketthuc = @Ngayketthuc, Diadiem = @Diadiem
where MaNDThi = @MaNDThi
end
GO

exec sua_ndthi 'ND11', N'Abcd', N'Thi abcd','2022-03-05','2022-03-05', N'Trường Đại học Hà Nội'

create proc xoa_ndthi 
@MaNDThi varchar(50) 
as
begin
	delete from tblNoidungthi where MaNDThi = @MaNDThi
end
GO


create proc timkiem_ndthi
@Key nvarchar(255)
as
  begin
	  select * from tblNoidungthi
	  where
	  TenNDThi like N'%'+(trim(@Key))+'%' or 
	  MaNDThi like N'%'+(trim(@Key))+'%' or 
	  Diadiem like N'%'+(trim(@Key))+'%' 
  end

  exec timkiem_ndthi N'Hà Nội'


--------đội thi------------


create view v_hiendoithi 
as
select tblDoithi.MaDoi, tblDoithi.TenDoi, tblDoithi.Ketqua, tblDoithi.Nam, tblDoithi.MaGV, TenGV, tblDoithi.MaNDThi, TenNDThi
from tblDoithi 
inner join tblGiangVien on tblGiangVien.MaGV = tblDoithi.MaGV
inner join tblNoidungthi on tblNoidungthi.MaNDThi = tblDoithi.MaNDThi
group by tblDoithi.MaDoi, tblDoithi.TenDoi, tblDoithi.Ketqua, tblDoithi.Nam, tblDoithi.MaGV, TenGV, tblDoithi.MaNDThi, TenNDThi

select * from v_hiendoithi
drop view v_hiendoithi


create view v_hiensvduthi
as
select tblDoithi.MaDoi, tblDoithi.TenDoi, tblDoithi.Ketqua, tblDoithi.Nam, tblDoithi.MaGV, tblDoithi.MaNDThi

select * from tblGiangVien
select * from tblNoidungthi
select * from tblDoithi

drop proc hiendoithi

exec hiendoithi 

Create proc them_doithi
@MaDoi varchar(50),
@TenDoi nvarchar(100),
@Ketqua nvarchar(100),
@Nam int,
@MaGV varchar(50),
@MaNDThi varchar(50)
as
begin
insert into tblDoithi
values (@MaDoi, @TenDoi, @Ketqua,@Nam,@MaGV,@MaNDThi)
end
go

select * from tblDoithi


exec them_doithi 'DT05', N'Đội 5', N'Giải nhất', 2022, 'GV01','ND04'

create proc sua_doithi
@MaDoi varchar(50),
@TenDoi nvarchar(100),
@Ketqua nvarchar(100),
@Nam int,
@MaGV varchar(50),
@MaNDThi varchar(50)
as
begin
update tblDoithi
set TenDoi = @TenDoi, Ketqua = @Ketqua, Nam = @Nam, MaGV = @MaGV, MaNDThi = @MaNDThi
where MaDoi = @MaDoi
end
GO

exec sua_doithi 'DT01', N'Đội 1', N'Giải nhì', 2022, 'GV01','ND04'


create proc xoa_doithi
@MaDoi varchar(50) 
as
begin
	delete from tblDoithi where MaDoi = @MaDoi
end
GO



create proc timkiem_doithi
@Key nvarchar(255)
as
  begin
	  select * from tblDoithi
	  where
	  TenDoi like N'%'+(trim(@Key))+'%' or 
	  MaDoi like N'%'+(trim(@Key))+'%' or 
	  Ketqua like N'%'+(trim(@Key))+'%' 
  end

  insert into tblChitietDoi values ('SV01', 'DT01'),('SV02', 'DT01'), ('SV03', 'DT01'),('SV04', 'DT01');
  insert into tblChitietDoi values ('SV01', 'DT02'),('SV02', 'DT02'), ('SV03', 'DT02'),('SV04', 'DT02');
  insert into tblChitietDoi values ('SV05', 'DT03'),('SV06', 'DT03');
  insert into tblChitietDoi values ('SV07', 'DT04'),('SV08', 'DT04'), ('SV09', 'DT04');
  insert into tblChitietDoi values ('SV10', 'DT05'),('SV11', 'DT05');
  insert into tblChitietDoi values ('SV08', 'DT06'),('SV11', 'DT06');







  select * from tblDoithi 
  select * from tblSinhVien
  select * from tblChitietDoi 

  create view sv_duthi
  as
	  select tblChitietDoi.MaDoi, tblSinhVien.MaSV, tblSinhVien.TenSV, tblDoithi.TenDoi, tblDoithi.Ketqua
	  from tblChitietDoi
	  inner join tblSinhVien on tblSinhVien.MaSV = tblChitietDoi.MaSV
	  inner join tblDoithi on tblDoithi.MaDoi = tblChitietDoi.MaDoi
	  

	  group by tblSinhVien.MaSV,tblSinhVien.TenSV, tblChitietDoi.MaDoi, tblDoithi.TenDoi, tblDoithi.Ketqua

   select * from sv_duthi where MaDoi = 'DT01'


Create proc them_svdt
@MaSV varchar(50),
@MaDoi varchar(50)
as
begin
insert into tblChitietDoi
values (@MaSV, @MaDoi)
end
go

drop proc them_svdt



 select * from tblChitietDoi 
 select * from tblDoithi

exec them_svdt 'SV02', 'D9';

Create proc xoa_svduthi
@MaSV varchar(50),
@MaDoi varchar(50)
AS
	BEGIN
	DELETE FROM tblChitietDoi
	WHERE MaSV = @MaSV and MaDoi = @MaDoi
	END

	drop proc xoa_svduthi

	exec xoa_svduthi 'SV08', 'DT06';