CREATE DATABASE QLDSV;
USE QLDSV;

CREATE TABLE Khoa (
  MaKhoa		VARCHAR(50) PRIMARY KEY,
  TenKhoa		NVARCHAR(50),
  DiaChi		NVARCHAR(100),
  SoDienThoai	VARCHAR(20)
);

CREATE TABLE ChuyenNganh (
   MaChuyenNganh   VARCHAR(50) NOT NULL PRIMARY KEY,
   TenChuyenNganh  NVARCHAR(50) NOT NULL,
   MaKhoa          VARCHAR(50) NOT NULL,
   MoTa            NVARCHAR(MAX),
   CONSTRAINT FK_ChuyenNganh_Khoa FOREIGN KEY (MaKhoa)
		REFERENCES Khoa(MaKhoa)
);

CREATE TABLE MonHoc (
    MaMonHoc		VARCHAR(50) PRIMARY KEY,
    TenMonHoc		NVARCHAR(100) NOT NULL,
    SoTinChi		INT NOT NULL,
    MaChuyenNganh	VARCHAR(50) NOT NULL,
    CONSTRAINT FK_ChuyenNganh_MonHoc FOREIGN KEY (MaChuyenNganh)
        REFERENCES ChuyenNganh(MaChuyenNganh)
);

CREATE TABLE GiaoVien (
    MaGV		VARCHAR(50) PRIMARY KEY,
    HoTen		NVARCHAR(100) NOT NULL,
    GioiTinh	NVARCHAR(5) NOT NULL,
    NgaySinh	DATE NOT NULL,
    Email		NVARCHAR(100),
    SoDienThoai	VARCHAR(20),
    DiaChi		NVARCHAR(200),
    MaKhoa		VARCHAR(50),
	CONSTRAINT FK_Khoa_GiaoVien FOREIGN KEY (MaKhoa)
        REFERENCES Khoa(MaKhoa)
);

CREATE TABLE CountGiaoVien (
	[count] INT
);

INSERT INTO CountGiaoVien VALUES (1);

CREATE TABLE LopHoc (
    MaLop			CHAR(10) PRIMARY KEY,
    TenLop			NVARCHAR(50) NOT NULL,
    MaKhoa			VARCHAR(50) NOT NULL,
    MaChuyenNganh	VARCHAR(50) NOT NULL,
    MaGV			VARCHAR(50) NOT NULL,
    CONSTRAINT FK_Khoa_LopHoc FOREIGN KEY (MaKhoa)
		REFERENCES Khoa(MaKhoa),
    CONSTRAINT FK_ChuyenNganh_LopHoc FOREIGN KEY (MaChuyenNganh)
		REFERENCES ChuyenNganh(MaChuyenNganh),
    CONSTRAINT FK_GiaoVien_LopHoc FOREIGN KEY (MaGV)
		REFERENCES GiaoVien(MaGV)
);

CREATE TABLE SinhVien (
    MaSV		VARCHAR(50) PRIMARY KEY,
    HoTen		NVARCHAR(100) NOT NULL,
	GioiTinh	NVARCHAR(5) NOT NULL,
    NgaySinh	DATE,
	Email		VARCHAR(50),
	SoDienThoai	VARCHAR(20),
    DiaChi		NVARCHAR(200),
    MaLop		CHAR(10),
	CONSTRAINT FK_LopHoc_SinhVien FOREIGN KEY (MaLop)
		REFERENCES LopHoc(MaLop)
);

CREATE TABLE CountSinhVien (
	[count] INT
);

INSERT INTO CountSinhVien VALUES (1);

CREATE TABLE DiemDanh (
	MaLop			CHAR(10),
	MaSV			VARCHAR(50),
	NgayDiemDanh	DATE DEFAULT GETDATE(),
	CoPhep			INT DEFAULT 0,
	KhongPhep		INT DEFAULT 0,
	CONSTRAINT FK_LopHoc_DiemDanh FOREIGN KEY (MaLop)
		REFERENCES LopHoc(MaLop),
	CONSTRAINT FK_SinhVien_DiemDanh FOREIGN KEY (MaSV)
		REFERENCES SinhVien(MaSV)
);

CREATE TABLE DiemSo (
	MaMonHoc	VARCHAR(50),
	MaLop		CHAR(10),
	MaSV		VARCHAR(50),
	Diem15p		FLOAT,
	Diem45p1	FLOAT,
	Diem45p2	FLOAT,
	Diem45p3	FLOAT,
	DiemThi		FLOAT,
	CONSTRAINT FK_MonHoc_DiemSo FOREIGN KEY (MaMonHoc)
		REFERENCES MonHoc(MaMonHoc),
	CONSTRAINT FK_LopHoc_DiemSo FOREIGN KEY (MaLop)
		REFERENCES LopHoc(MaLop),
	CONSTRAINT FK_SinhVien_DiemSo FOREIGN KEY (MaSV)
		REFERENCES SinhVien(MaSV)
);
