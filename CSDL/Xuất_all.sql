USE [master]
GO
/****** Object:  Database [QLSV]    Script Date: 22/12/2021 6:56:06 CH ******/
CREATE DATABASE [QLSV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLSV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLSV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLSV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLSV_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLSV] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLSV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLSV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLSV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLSV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLSV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLSV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLSV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLSV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLSV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLSV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLSV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLSV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLSV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLSV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLSV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLSV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLSV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLSV] SET RECOVERY FULL 
GO
ALTER DATABASE [QLSV] SET  MULTI_USER 
GO
ALTER DATABASE [QLSV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLSV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLSV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLSV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLSV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLSV] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLSV', N'ON'
GO
ALTER DATABASE [QLSV] SET QUERY_STORE = OFF
GO
USE [QLSV]
GO
/****** Object:  Table [dbo].[chuongtrinh]    Script Date: 22/12/2021 6:56:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chuongtrinh](
	[ma_ct] [int] IDENTITY(1,1) NOT NULL,
	[ten_ct] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_ct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[giangvien]    Script Date: 22/12/2021 6:56:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[giangvien](
	[ma_gv] [int] IDENTITY(1,1) NOT NULL,
	[ten_gv] [nvarchar](100) NULL,
	[gioitinh] [nvarchar](50) NULL,
	[phone] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_gv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ketqua]    Script Date: 22/12/2021 6:56:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ketqua](
	[ma_kq] [int] IDENTITY(1,1) NOT NULL,
	[ma_sv] [nvarchar](50) NULL,
	[ma_mh] [int] NULL,
	[ma_lop] [int] NULL,
	[lan_thi] [int] NULL,
	[diem] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_kq] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khoa]    Script Date: 22/12/2021 6:56:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khoa](
	[ma_khoa] [int] IDENTITY(1,1) NOT NULL,
	[ten_khoa] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_khoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khoahoc]    Script Date: 22/12/2021 6:56:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khoahoc](
	[ma_khoa_hoc] [int] IDENTITY(1,1) NOT NULL,
	[ten_khoa_hoc] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_khoa_hoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khung_chuong_trinh]    Script Date: 22/12/2021 6:56:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khung_chuong_trinh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ma_ct] [int] NULL,
	[ma_khoa] [int] NULL,
	[ma_mh] [int] NULL,
	[nam_hoc] [int] NULL,
	[hoc_ky] [int] NULL,
	[so_tiet_ly_thuyet] [int] NULL,
	[so_tiet_thuc_hanh] [int] NULL,
	[so_tin_chi] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[logins]    Script Date: 22/12/2021 6:56:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[logins](
	[tenDN] [nvarchar](50) NOT NULL,
	[matkhau] [nvarchar](50) NULL,
	[hoten] [nvarchar](50) NULL,
	[quyen] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[tenDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lop]    Script Date: 22/12/2021 6:56:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lop](
	[ma_lop] [int] IDENTITY(1,1) NOT NULL,
	[STT]  AS ((0)+[ma_lop]),
	[ten_lop] [nvarchar](50) NULL,
	[ma_khoa] [int] NULL,
	[ma_khoa_hoc] [int] NULL,
	[ma_ct] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_lop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[monhoc]    Script Date: 22/12/2021 6:56:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[monhoc](
	[ma_mh] [int] IDENTITY(1,1) NOT NULL,
	[ten_mh] [nvarchar](50) NULL,
	[ma_khoa] [int] NULL,
	[ma_ct] [int] NULL,
	[chu_thich] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_mh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sinhvien]    Script Date: 22/12/2021 6:56:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sinhvien](
	[ma_sv] [nvarchar](50) NOT NULL,
	[ho_ten] [nvarchar](50) NULL,
	[gioi_tinh] [nvarchar](50) NULL,
	[ngay_thang_nam_sinh] [date] NULL,
	[dia_chi] [nvarchar](200) NULL,
	[ma_lop] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_sv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[chuongtrinh] ON 
GO
INSERT [dbo].[chuongtrinh] ([ma_ct], [ten_ct]) VALUES (1, N'Quản trị mạng')
GO
INSERT [dbo].[chuongtrinh] ([ma_ct], [ten_ct]) VALUES (2, N'Đồ họa')
GO
INSERT [dbo].[chuongtrinh] ([ma_ct], [ten_ct]) VALUES (3, N'Ứng Dụng Phần Mềm')
GO
INSERT [dbo].[chuongtrinh] ([ma_ct], [ten_ct]) VALUES (4, N'Điện điện tử')
GO
INSERT [dbo].[chuongtrinh] ([ma_ct], [ten_ct]) VALUES (5, N'CN ÔTÔ')
GO
INSERT [dbo].[chuongtrinh] ([ma_ct], [ten_ct]) VALUES (6, N'test')
GO
SET IDENTITY_INSERT [dbo].[chuongtrinh] OFF
GO
SET IDENTITY_INSERT [dbo].[ketqua] ON 
GO
INSERT [dbo].[ketqua] ([ma_kq], [ma_sv], [ma_mh], [ma_lop], [lan_thi], [diem]) VALUES (1, N'SV1', 1, 1, 1, 6)
GO
INSERT [dbo].[ketqua] ([ma_kq], [ma_sv], [ma_mh], [ma_lop], [lan_thi], [diem]) VALUES (2, N'SV2', 1, 2, 1, 6)
GO
INSERT [dbo].[ketqua] ([ma_kq], [ma_sv], [ma_mh], [ma_lop], [lan_thi], [diem]) VALUES (3, N'SV3', 1, 3, 1, 6)
GO
INSERT [dbo].[ketqua] ([ma_kq], [ma_sv], [ma_mh], [ma_lop], [lan_thi], [diem]) VALUES (4, N'SV4', 1, 4, 1, 6)
GO
INSERT [dbo].[ketqua] ([ma_kq], [ma_sv], [ma_mh], [ma_lop], [lan_thi], [diem]) VALUES (5, N'SV5', 1, 5, 1, 6)
GO
INSERT [dbo].[ketqua] ([ma_kq], [ma_sv], [ma_mh], [ma_lop], [lan_thi], [diem]) VALUES (6, N'SV1', 11, 1, 1, 5)
GO
SET IDENTITY_INSERT [dbo].[ketqua] OFF
GO
SET IDENTITY_INSERT [dbo].[khoa] ON 
GO
INSERT [dbo].[khoa] ([ma_khoa], [ten_khoa]) VALUES (1, N'CNTT')
GO
INSERT [dbo].[khoa] ([ma_khoa], [ten_khoa]) VALUES (2, N'ĐIỆN_LẠNH')
GO
INSERT [dbo].[khoa] ([ma_khoa], [ten_khoa]) VALUES (3, N'ÔTÔ')
GO
INSERT [dbo].[khoa] ([ma_khoa], [ten_khoa]) VALUES (4, N'KINH TẾ')
GO
INSERT [dbo].[khoa] ([ma_khoa], [ten_khoa]) VALUES (5, N'NGÔN NGỮ')
GO
INSERT [dbo].[khoa] ([ma_khoa], [ten_khoa]) VALUES (6, N'test1')
GO
SET IDENTITY_INSERT [dbo].[khoa] OFF
GO
SET IDENTITY_INSERT [dbo].[khoahoc] ON 
GO
INSERT [dbo].[khoahoc] ([ma_khoa_hoc], [ten_khoa_hoc]) VALUES (1, N'2015-2020')
GO
INSERT [dbo].[khoahoc] ([ma_khoa_hoc], [ten_khoa_hoc]) VALUES (2, N'2020-2025')
GO
INSERT [dbo].[khoahoc] ([ma_khoa_hoc], [ten_khoa_hoc]) VALUES (3, N'2025-2030')
GO
INSERT [dbo].[khoahoc] ([ma_khoa_hoc], [ten_khoa_hoc]) VALUES (4, N'2035-2040')
GO
INSERT [dbo].[khoahoc] ([ma_khoa_hoc], [ten_khoa_hoc]) VALUES (5, N'2040-2045')
GO
INSERT [dbo].[khoahoc] ([ma_khoa_hoc], [ten_khoa_hoc]) VALUES (6, N'2045-2050')
GO
SET IDENTITY_INSERT [dbo].[khoahoc] OFF
GO
SET IDENTITY_INSERT [dbo].[khung_chuong_trinh] ON 
GO
INSERT [dbo].[khung_chuong_trinh] ([ID], [ma_ct], [ma_khoa], [ma_mh], [nam_hoc], [hoc_ky], [so_tiet_ly_thuyet], [so_tiet_thuc_hanh], [so_tin_chi]) VALUES (1, 1, 1, 1, 2015, 1, 45, 0, 1)
GO
INSERT [dbo].[khung_chuong_trinh] ([ID], [ma_ct], [ma_khoa], [ma_mh], [nam_hoc], [hoc_ky], [so_tiet_ly_thuyet], [so_tiet_thuc_hanh], [so_tin_chi]) VALUES (2, 2, 2, 2, 2015, 1, 15, 0, 1)
GO
INSERT [dbo].[khung_chuong_trinh] ([ID], [ma_ct], [ma_khoa], [ma_mh], [nam_hoc], [hoc_ky], [so_tiet_ly_thuyet], [so_tiet_thuc_hanh], [so_tin_chi]) VALUES (3, 3, 3, 3, 2015, 1, 30, 0, 1)
GO
INSERT [dbo].[khung_chuong_trinh] ([ID], [ma_ct], [ma_khoa], [ma_mh], [nam_hoc], [hoc_ky], [so_tiet_ly_thuyet], [so_tiet_thuc_hanh], [so_tin_chi]) VALUES (4, 4, 4, 4, 2015, 1, 30, 0, 1)
GO
INSERT [dbo].[khung_chuong_trinh] ([ID], [ma_ct], [ma_khoa], [ma_mh], [nam_hoc], [hoc_ky], [so_tiet_ly_thuyet], [so_tiet_thuc_hanh], [so_tin_chi]) VALUES (5, 5, 5, 5, 2015, 1, 60, 0, 1)
GO
INSERT [dbo].[khung_chuong_trinh] ([ID], [ma_ct], [ma_khoa], [ma_mh], [nam_hoc], [hoc_ky], [so_tiet_ly_thuyet], [so_tiet_thuc_hanh], [so_tin_chi]) VALUES (6, 3, 1, 11, 2020, 1, 0, 75, 1)
GO
SET IDENTITY_INSERT [dbo].[khung_chuong_trinh] OFF
GO
INSERT [dbo].[logins] ([tenDN], [matkhau], [hoten], [quyen]) VALUES (N'abcd', N'1234', N'test', N'sinhvien')
GO
INSERT [dbo].[logins] ([tenDN], [matkhau], [hoten], [quyen]) VALUES (N'admin', N'admin', N'admin', N'admin')
GO
INSERT [dbo].[logins] ([tenDN], [matkhau], [hoten], [quyen]) VALUES (N'SV1', N'123', N'Ten Sinh vien 1', N'sinhvien')
GO
SET IDENTITY_INSERT [dbo].[lop] ON 
GO
INSERT [dbo].[lop] ([ma_lop], [ten_lop], [ma_khoa], [ma_khoa_hoc], [ma_ct]) VALUES (1, N'CĐ43CNTT', 1, 1, 1)
GO
INSERT [dbo].[lop] ([ma_lop], [ten_lop], [ma_khoa], [ma_khoa_hoc], [ma_ct]) VALUES (2, N'CĐ43ĐL', 2, 2, 2)
GO
INSERT [dbo].[lop] ([ma_lop], [ten_lop], [ma_khoa], [ma_khoa_hoc], [ma_ct]) VALUES (3, N'CĐ43ÔTÔ', 3, 3, 3)
GO
INSERT [dbo].[lop] ([ma_lop], [ten_lop], [ma_khoa], [ma_khoa_hoc], [ma_ct]) VALUES (4, N'CĐ43KT', 4, 4, 4)
GO
INSERT [dbo].[lop] ([ma_lop], [ten_lop], [ma_khoa], [ma_khoa_hoc], [ma_ct]) VALUES (5, N'CĐ43', 5, 5, 5)
GO
INSERT [dbo].[lop] ([ma_lop], [ten_lop], [ma_khoa], [ma_khoa_hoc], [ma_ct]) VALUES (6, N'test', 1, 1, 4)
GO
SET IDENTITY_INSERT [dbo].[lop] OFF
GO
SET IDENTITY_INSERT [dbo].[monhoc] ON 
GO
INSERT [dbo].[monhoc] ([ma_mh], [ten_mh], [ma_khoa], [ma_ct], [chu_thich]) VALUES (1, N'Chính trị', 1, 1, N'Môn chung')
GO
INSERT [dbo].[monhoc] ([ma_mh], [ten_mh], [ma_khoa], [ma_ct], [chu_thich]) VALUES (2, N'Pháp luật', 1, 1, N'Môn chung')
GO
INSERT [dbo].[monhoc] ([ma_mh], [ten_mh], [ma_khoa], [ma_ct], [chu_thich]) VALUES (3, N'Giáo dục thể chất', 1, 1, N'Môn chung')
GO
INSERT [dbo].[monhoc] ([ma_mh], [ten_mh], [ma_khoa], [ma_ct], [chu_thich]) VALUES (4, N'Tiếng anh', 1, 1, N'Môn chung')
GO
INSERT [dbo].[monhoc] ([ma_mh], [ten_mh], [ma_khoa], [ma_ct], [chu_thich]) VALUES (5, N'Tin đại cương', 1, 1, N'Môn chung')
GO
INSERT [dbo].[monhoc] ([ma_mh], [ten_mh], [ma_khoa], [ma_ct], [chu_thich]) VALUES (6, N'Chính trị', 1, 3, N'Môn chung')
GO
INSERT [dbo].[monhoc] ([ma_mh], [ten_mh], [ma_khoa], [ma_ct], [chu_thich]) VALUES (7, N'Pháp luật', 1, 3, N'Môn chung')
GO
INSERT [dbo].[monhoc] ([ma_mh], [ten_mh], [ma_khoa], [ma_ct], [chu_thich]) VALUES (8, N'Giáo dục thể chất', 1, 3, N'Môn chung')
GO
INSERT [dbo].[monhoc] ([ma_mh], [ten_mh], [ma_khoa], [ma_ct], [chu_thich]) VALUES (9, N'Tiếng anh', 1, 3, N'Môn chung')
GO
INSERT [dbo].[monhoc] ([ma_mh], [ten_mh], [ma_khoa], [ma_ct], [chu_thich]) VALUES (10, N'Tin đại cương', 1, 3, N'Môn chung')
GO
INSERT [dbo].[monhoc] ([ma_mh], [ten_mh], [ma_khoa], [ma_ct], [chu_thich]) VALUES (11, N'test1', 1, 3, N'Môn riêng')
GO
SET IDENTITY_INSERT [dbo].[monhoc] OFF
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV*1', N'TEN*SV1', N'Nữ', CAST(N'1990-03-10' AS Date), N'Hà nội', 1)
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV*2', N'TEN*SV2', N'Nữ', CAST(N'1990-02-18' AS Date), N'Hải Duong', 2)
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV*3', N'TEN*SV1', N'Nữ', CAST(N'1990-11-20' AS Date), N'Hải phòng', 3)
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV*4', N'TEN*SV5', N'Nữ', CAST(N'1990-02-20' AS Date), N'Hải phòng', 4)
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV*5', N'TEN*SV5', N'NAM', CAST(N'1990-12-25' AS Date), N'Đông Anh', 5)
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV_1', N'TEN_SV1', N'Nam', CAST(N'1990-04-10' AS Date), N'Hà nội', 1)
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV_2', N'TEN_SV2', N'Nam', CAST(N'1990-11-05' AS Date), N'Hải Dương', 2)
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV_3', N'TEN_SV1', N'Nam', CAST(N'1990-09-25' AS Date), N'Hải phòng', 3)
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV_4', N'TEN_SV4', N'Nam', CAST(N'1990-02-15' AS Date), N'Hải phòng', 4)
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV_5', N'TEN_SV5', N'Nam', CAST(N'1990-05-25' AS Date), N'Đông Anh', 5)
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV=1', N'TEN=SV1', N'Nam', CAST(N'1990-05-01' AS Date), N'Hà nội', 1)
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV=2', N'TEN=SV2', N'Nam', CAST(N'1990-01-22' AS Date), N'Hải Dương', 2)
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV=3', N'TEN=SV1', N'Nam', CAST(N'1990-03-01' AS Date), N'Hải phòng', 3)
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV=4', N'TEN=SV4', N'Nam', CAST(N'1990-01-16' AS Date), N'Hải phòng', 4)
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV=5', N'TEN=SV5', N'NAM', CAST(N'1990-10-26' AS Date), N'Đông Anh', 5)
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV1', N'TENSV1', N'Nam', CAST(N'1990-03-22' AS Date), N'Hà nội', 1)
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV-1', N'TEN-SV1', N'Nữ', CAST(N'1990-06-14' AS Date), N'Hà nội', 1)
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV2', N'TENSV2', N'Nam', CAST(N'1990-06-08' AS Date), N'Hải Dương', 2)
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV-2', N'TEN-SV2', N'Nữ', CAST(N'1990-01-25' AS Date), N'Hải Dương', 2)
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV3', N'TEN_SV1', N'Nam', CAST(N'1990-08-24' AS Date), N'Hải phòng', 3)
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV-3', N'TEN-SV1', N'Nữ', CAST(N'1990-10-10' AS Date), N'Hải phòng', 3)
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV4', N'TEN_SV4', N'Nam', CAST(N'1990-01-03' AS Date), N'Hải phòng', 4)
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV-4', N'TEN-SV5', N'Nữ', CAST(N'1990-09-25' AS Date), N'Hải phòng', 4)
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV5', N'TEN_SV5', N'Nam', CAST(N'1990-09-24' AS Date), N'Đông Anh', 5)
GO
INSERT [dbo].[sinhvien] ([ma_sv], [ho_ten], [gioi_tinh], [ngay_thang_nam_sinh], [dia_chi], [ma_lop]) VALUES (N'SV-5', N'TEN-SV5', N'NAM', CAST(N'1990-11-21' AS Date), N'Đông Anh', 5)
GO
ALTER TABLE [dbo].[lop]  WITH CHECK ADD  CONSTRAINT [FK__lop__ma_ct__7B7B4DDC] FOREIGN KEY([ma_ct])
REFERENCES [dbo].[chuongtrinh] ([ma_ct])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[lop] CHECK CONSTRAINT [FK__lop__ma_ct__7B7B4DDC]
GO
ALTER TABLE [dbo].[lop]  WITH CHECK ADD  CONSTRAINT [FK__lop__ma_khoa__7A8729A3] FOREIGN KEY([ma_khoa])
REFERENCES [dbo].[khoa] ([ma_khoa])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[lop] CHECK CONSTRAINT [FK__lop__ma_khoa__7A8729A3]
GO
ALTER TABLE [dbo].[lop]  WITH CHECK ADD  CONSTRAINT [FK__lop__ma_khoa_hoc__7993056A] FOREIGN KEY([ma_khoa_hoc])
REFERENCES [dbo].[khoahoc] ([ma_khoa_hoc])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[lop] CHECK CONSTRAINT [FK__lop__ma_khoa_hoc__7993056A]
GO
ALTER TABLE [dbo].[monhoc]  WITH CHECK ADD  CONSTRAINT [FK__monhoc__ma_ct__76B698BF] FOREIGN KEY([ma_ct])
REFERENCES [dbo].[chuongtrinh] ([ma_ct])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[monhoc] CHECK CONSTRAINT [FK__monhoc__ma_ct__76B698BF]
GO
ALTER TABLE [dbo].[monhoc]  WITH CHECK ADD  CONSTRAINT [FK__monhoc__ma_khoa__75C27486] FOREIGN KEY([ma_khoa])
REFERENCES [dbo].[khoa] ([ma_khoa])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[monhoc] CHECK CONSTRAINT [FK__monhoc__ma_khoa__75C27486]
GO
ALTER TABLE [dbo].[sinhvien]  WITH CHECK ADD  CONSTRAINT [FK__sinhvien__ma_lop__7E57BA87] FOREIGN KEY([ma_lop])
REFERENCES [dbo].[lop] ([ma_lop])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[sinhvien] CHECK CONSTRAINT [FK__sinhvien__ma_lop__7E57BA87]
GO
USE [master]
GO
ALTER DATABASE [QLSV] SET  READ_WRITE 
GO
