USE [Doan5]
GO
/****** Object:  Table [dbo].[Binhluan]    Script Date: 2/3/2021 10:52:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Binhluan](
	[Mabinhluan] [char](5) NOT NULL,
	[Makhachhang] [char](5) NULL,
	[Masanpham] [char](5) NULL,
	[Noidungbinhluan] [nvarchar](100) NULL,
	[Danhgia] [char](10) NULL,
	[Thoigian] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Mabinhluan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chitietdondathang]    Script Date: 2/3/2021 10:52:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chitietdondathang](
	[Machitietdondathang] [char](5) NOT NULL,
	[Madondathang] [char](5) NULL,
	[Masanpham] [char](5) NULL,
	[Tensanpham] [nvarchar](50) NULL,
	[Soluong] [int] NULL,
	[Dongia] [int] NULL,
	[Giamgia] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Machitietdondathang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chitiethoadon]    Script Date: 2/3/2021 10:52:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chitiethoadon](
	[Machitiethoadon] [char](5) NOT NULL,
	[Mahoadon] [char](5) NULL,
	[Masanpham] [char](5) NULL,
	[Soluong] [int] NULL,
	[Dongia] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Machitiethoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dangnhapadmin]    Script Date: 2/3/2021 10:52:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dangnhapadmin](
	[Maadmin] [char](5) NOT NULL,
	[Taikhoanadmin] [nvarchar](50) NULL,
	[Matkhauadmin] [nvarchar](50) NULL,
	[Tenadmin] [nvarchar](50) NULL,
	[Sodienthoaiadmin] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Maadmin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Danhmucsanpham]    Script Date: 2/3/2021 10:52:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Danhmucsanpham](
	[Madanhmuc] [char](5) NOT NULL,
	[Tendanhmuc] [nvarchar](30) NULL,
	[Mota] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Madanhmuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dondathang]    Script Date: 2/3/2021 10:52:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dondathang](
	[Madondathang] [char](5) NOT NULL,
	[Makhachhang] [char](5) NULL,
	[Manhanvien] [char](5) NULL,
	[Ngaydat] [date] NULL,
	[Tenkhachhang] [nvarchar](50) NULL,
	[Trangthai] [nvarchar](10) NULL,
	[Diachinhanhang] [nvarchar](50) NULL,
	[Sodienthoai] [int] NULL,
	[Ghichu] [nvarchar](50) NULL,
	[Thanhtien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Madondathang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hangsanxuat]    Script Date: 2/3/2021 10:52:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hangsanxuat](
	[Mahang] [char](5) NOT NULL,
	[Tenhang] [nvarchar](50) NULL,
	[Mota] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Mahang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hoadon]    Script Date: 2/3/2021 10:52:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoadon](
	[Mahoadon] [char](5) NOT NULL,
	[Manhanvien] [char](5) NULL,
	[Manhacungcap] [char](5) NULL,
	[Ngaynhap] [date] NULL,
	[Thanhtien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Mahoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khachhang]    Script Date: 2/3/2021 10:52:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khachhang](
	[Makhachhang] [char](5) NOT NULL,
	[Hoten] [nvarchar](50) NULL,
	[Diachi] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Sdt] [int] NULL,
	[Taikhoan] [nvarchar](50) NULL,
	[Matkhau] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Makhachhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khuyenmai]    Script Date: 2/3/2021 10:52:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khuyenmai](
	[Makhuyenmai] [char](5) NOT NULL,
	[Tenkhuyenmai] [nvarchar](50) NULL,
	[Magiamgia] [char](20) NULL,
	[Soluong] [int] NULL,
	[Tinhnangma] [nvarchar](20) NULL,
	[Giakhuyenmai] [int] NULL,
	[Thoigianbatdau] [nvarchar](20) NULL,
	[Thoigianketthuc] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Makhuyenmai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loaisanpham]    Script Date: 2/3/2021 10:52:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loaisanpham](
	[Maloai] [char](5) NOT NULL,
	[Madanhmuc] [char](5) NULL,
	[Tenloai] [nvarchar](50) NULL,
	[Mota] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Maloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhacungcap]    Script Date: 2/3/2021 10:52:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhacungcap](
	[Manhacungcap] [char](5) NOT NULL,
	[Tennhacungcap] [nvarchar](50) NULL,
	[Diachi] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Manhacungcap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 2/3/2021 10:52:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhanvien](
	[Manhanvien] [char](5) NOT NULL,
	[Tennhanvien] [nvarchar](50) NULL,
	[Ngaysinh] [varchar](50) NULL,
	[Quequan] [nvarchar](60) NULL,
	[Sochungminhthu] [int] NULL,
	[Sodienthoai] [int] NULL,
	[Chucvu] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[Manhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sanpham]    Script Date: 2/3/2021 10:52:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sanpham](
	[Masanpham] [char](5) NOT NULL,
	[Maloai] [char](5) NULL,
	[Mahang] [char](5) NULL,
	[Tensanpham] [nvarchar](50) NULL,
	[Dongia] [int] NULL,
	[Ngaycapnhat] [date] NULL,
	[Soluong] [int] NULL,
	[Hansudung] [nvarchar](50) NULL,
	[Mota] [nvarchar](4000) NULL,
	[Hinhanh] [nvarchar](4000) NULL,
	[Trongluong] [nvarchar](30) NULL,
	[Xuatxu] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Masanpham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Slider]    Script Date: 2/3/2021 10:52:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Slider](
	[Maslider] [char](5) NOT NULL,
	[Tenslider] [nvarchar](50) NULL,
	[Hinhanh] [nvarchar](1000) NULL,
	[Mota] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Maslider] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tintuc]    Script Date: 2/3/2021 10:52:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tintuc](
	[Matintuc] [char](5) NOT NULL,
	[Tieude] [nvarchar](50) NULL,
	[Mota] [nvarchar](100) NULL,
	[Noidung] [nvarchar](3000) NULL,
	[Anh] [nvarchar](1000) NULL,
	[Ngaydang] [date] NULL,
	[Nguoidang] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Matintuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Binhluan] ([Mabinhluan], [Makhachhang], [Masanpham], [Noidungbinhluan], [Danhgia], [Thoigian]) VALUES (N'Ma001', N'Ma001', N'Ma001', N'Tạm được', N'3         ', CAST(N'2020-12-12' AS Date))
GO
INSERT [dbo].[Danhmucsanpham] ([Madanhmuc], [Tendanhmuc], [Mota]) VALUES (N'Ma001', N'Tóc', N'Hair')
INSERT [dbo].[Danhmucsanpham] ([Madanhmuc], [Tendanhmuc], [Mota]) VALUES (N'Ma002', N'Râu', N'Beard')
GO
INSERT [dbo].[Dondathang] ([Madondathang], [Makhachhang], [Manhanvien], [Ngaydat], [Tenkhachhang], [Trangthai], [Diachinhanhang], [Sodienthoai], [Ghichu], [Thanhtien]) VALUES (N'Ma001', N'Ma001', N'Ma001', CAST(N'2020-11-11' AS Date), N'Nguyễn Văn Phục', N'1', N'Ngọc Lịch - Trưng Trắc - Văn Lâm - Hưng Yên', 966553703, N'Gửi hàng nhanh nhé', 21000000)
GO
INSERT [dbo].[Hangsanxuat] ([Mahang], [Tenhang], [Mota]) VALUES (N'Ma001', N'Loreal', N'Loreal của Pháp')
INSERT [dbo].[Hangsanxuat] ([Mahang], [Tenhang], [Mota]) VALUES (N'Ma002', N'Minoxidil', N'Minoxidil USA')
INSERT [dbo].[Hangsanxuat] ([Mahang], [Tenhang], [Mota]) VALUES (N'Ma003', N'sáp', N'sáp')
INSERT [dbo].[Hangsanxuat] ([Mahang], [Tenhang], [Mota]) VALUES (N'Ma004', N'Kindrad2', N'Kindrad USA')
INSERT [dbo].[Hangsanxuat] ([Mahang], [Tenhang], [Mota]) VALUES (N'Ma005', N'Jamaca', N'USA')
GO
INSERT [dbo].[Hoadon] ([Mahoadon], [Manhanvien], [Manhacungcap], [Ngaynhap], [Thanhtien]) VALUES (N'Ma001', N'Ma001', N'Ma001', CAST(N'2020-11-10' AS Date), 52000000)
INSERT [dbo].[Hoadon] ([Mahoadon], [Manhanvien], [Manhacungcap], [Ngaynhap], [Thanhtien]) VALUES (N'Ma002', N'Ma001', N'Ma001', CAST(N'2020-11-12' AS Date), 1234)
GO
INSERT [dbo].[Khachhang] ([Makhachhang], [Hoten], [Diachi], [Email], [Sdt], [Taikhoan], [Matkhau]) VALUES (N'Ma001', N'Nguyễn Văn Phục', N'Hưng Yên', N'Phucvanlamhy@gmail.com', 966553703, N'phuc1999', N'123456')
GO
INSERT [dbo].[Khuyenmai] ([Makhuyenmai], [Tenkhuyenmai], [Magiamgia], [Soluong], [Tinhnangma], [Giakhuyenmai], [Thoigianbatdau], [Thoigianketthuc]) VALUES (N'Ma001', N'Khuyến mại 20-11', N'123456789           ', 8, N'1', 150000, N'2020-11-11', N'2020-30-11')
INSERT [dbo].[Khuyenmai] ([Makhuyenmai], [Tenkhuyenmai], [Magiamgia], [Soluong], [Tinhnangma], [Giakhuyenmai], [Thoigianbatdau], [Thoigianketthuc]) VALUES (N'Ma002', N'Khuyến mại sinh nhật BeardClub 1 năm', N'987654321           ', 5, N'2', 20, N'2020-11-11', N'2020-30-11')
GO
INSERT [dbo].[Loaisanpham] ([Maloai], [Madanhmuc], [Tenloai], [Mota]) VALUES (N'Ma001', N'Ma001', N'Sáp vuốt tóc', N'Sáp')
INSERT [dbo].[Loaisanpham] ([Maloai], [Madanhmuc], [Tenloai], [Mota]) VALUES (N'Ma002', N'Ma002', N'Dầu dưỡng râu', N'Dầu')
GO
INSERT [dbo].[Nhacungcap] ([Manhacungcap], [Tennhacungcap], [Diachi], [Email]) VALUES (N'Ma001', N'ShopABC', N'143 Thái Hà -Hà Nội', N'ShopABC@gmail.com')
GO
INSERT [dbo].[Nhanvien] ([Manhanvien], [Tennhanvien], [Ngaysinh], [Quequan], [Sochungminhthu], [Sodienthoai], [Chucvu]) VALUES (N'Ma001', N'Tạ Đình Phong', N'08-06-1996', N'Hà Giang', 146857487, 966558181, N'Quản lý')
GO
INSERT [dbo].[Sanpham] ([Masanpham], [Maloai], [Mahang], [Tensanpham], [Dongia], [Ngaycapnhat], [Soluong], [Hansudung], [Mota], [Hinhanh], [Trongluong], [Xuatxu]) VALUES (N'Ma001', N'Ma001', N'Ma001', N'Sáp vuốt tóc Loreal-i22', 120000, CAST(N'2020-10-16' AS Date), 23, N'2022-10-21', N'Hàng chính hãng - chất lượng cao', N'loreal2.jpg', N'4kg', N'Pháp')
INSERT [dbo].[Sanpham] ([Masanpham], [Maloai], [Mahang], [Tensanpham], [Dongia], [Ngaycapnhat], [Soluong], [Hansudung], [Mota], [Hinhanh], [Trongluong], [Xuatxu]) VALUES (N'Ma002', N'Ma001', N'Ma001', N'Sáp vuốt tóc Loreal-U33', 280000, CAST(N'2020-10-21' AS Date), 8, N'2022-10-21', N'Sản phẩm tốt trong tầm giá', N'loreal2.jpg', N'5kg', N'Pháp')
INSERT [dbo].[Sanpham] ([Masanpham], [Maloai], [Mahang], [Tensanpham], [Dongia], [Ngaycapnhat], [Soluong], [Hansudung], [Mota], [Hinhanh], [Trongluong], [Xuatxu]) VALUES (N'Ma003', N'Ma001', N'Ma001', N'Sáp vuốt tóc Loreal-U33', 280000, CAST(N'2020-10-21' AS Date), 8, N'2022-10-21', N'Sản phẩm tốt trong tầm giá', N'loreal2.jpg', N'5kg', N'Pháp')
INSERT [dbo].[Sanpham] ([Masanpham], [Maloai], [Mahang], [Tensanpham], [Dongia], [Ngaycapnhat], [Soluong], [Hansudung], [Mota], [Hinhanh], [Trongluong], [Xuatxu]) VALUES (N'Ma004', N'Ma002', N'Ma005', N'Dầu dưỡng râu For men', 120000, CAST(N'2020-11-12' AS Date), 21, N'2022-11-12', N'Hàng chính hãng - chất lượng cao', N'product10.jpg', N'4kg', N'Mỹ')
INSERT [dbo].[Sanpham] ([Masanpham], [Maloai], [Mahang], [Tensanpham], [Dongia], [Ngaycapnhat], [Soluong], [Hansudung], [Mota], [Hinhanh], [Trongluong], [Xuatxu]) VALUES (N'Ma005', N'Ma002', N'Ma005', N'Dầu dưỡng râu Jamaica', 520000, CAST(N'2020-11-12' AS Date), 7, N'2022-11-12', N'Hàng chính hãng - chất lượng cao', N'product-1.jpg', N'4kg', N'Cuba')
INSERT [dbo].[Sanpham] ([Masanpham], [Maloai], [Mahang], [Tensanpham], [Dongia], [Ngaycapnhat], [Soluong], [Hansudung], [Mota], [Hinhanh], [Trongluong], [Xuatxu]) VALUES (N'Ma006', N'Ma002', N'Ma005', N'Dầu dưỡng râu Jamaica 2', 320000, CAST(N'2020-11-12' AS Date), 12, N'2022-11-12', N'Hàng chính hãng - chất lượng cao', N'product-2.jpg', N'5kg', N'Mỹ')
INSERT [dbo].[Sanpham] ([Masanpham], [Maloai], [Mahang], [Tensanpham], [Dongia], [Ngaycapnhat], [Soluong], [Hansudung], [Mota], [Hinhanh], [Trongluong], [Xuatxu]) VALUES (N'Ma007', N'Ma002', N'Ma005', N'Dầu dưỡng râu Xidil', 850000, CAST(N'2020-11-12' AS Date), 5, N'2022-11-12', N'Hàng chính hãng - chất lượng cao', N'product-3.jpg', N'6kg', N'Anh')
INSERT [dbo].[Sanpham] ([Masanpham], [Maloai], [Mahang], [Tensanpham], [Dongia], [Ngaycapnhat], [Soluong], [Hansudung], [Mota], [Hinhanh], [Trongluong], [Xuatxu]) VALUES (N'Ma008', N'Ma002', N'Ma005', N'Dầu dưỡng râu Coconut', 280000, CAST(N'2020-11-12' AS Date), 30, N'2022-11-12', N'Hàng chính hãng - chất lượng cao', N'product-4.jpg', N'4kg', N'Đức')
INSERT [dbo].[Sanpham] ([Masanpham], [Maloai], [Mahang], [Tensanpham], [Dongia], [Ngaycapnhat], [Soluong], [Hansudung], [Mota], [Hinhanh], [Trongluong], [Xuatxu]) VALUES (N'Ma009', N'Ma002', N'Ma005', N'Dầu dưỡng râu MenPlay', 640000, CAST(N'2020-11-12' AS Date), 11, N'2022-11-12', N'Hàng chính hãng - chất lượng cao', N'product-5.jpg', N'3kg', N'Mỹ')
INSERT [dbo].[Sanpham] ([Masanpham], [Maloai], [Mahang], [Tensanpham], [Dongia], [Ngaycapnhat], [Soluong], [Hansudung], [Mota], [Hinhanh], [Trongluong], [Xuatxu]) VALUES (N'Ma010', N'Ma002', N'Ma005', N'Dầu dưỡng râu MenOK', 280000, CAST(N'2020-11-12' AS Date), 6, N'2022-11-12', N'Hàng chính hãng - chất lượng cao', N'product-6.jpg', N'4kg', N'Mỹ')
INSERT [dbo].[Sanpham] ([Masanpham], [Maloai], [Mahang], [Tensanpham], [Dongia], [Ngaycapnhat], [Soluong], [Hansudung], [Mota], [Hinhanh], [Trongluong], [Xuatxu]) VALUES (N'Ma011', N'Ma002', N'Ma005', N'Dầu dưỡng râu MenVip', 640000, CAST(N'2020-11-12' AS Date), 6, N'2022-11-12', N'Hàng chính hãng - chất lượng cao', N'product-8.jpg', N'4kg', N'Mỹ')
GO
INSERT [dbo].[Slider] ([Maslider], [Tenslider], [Hinhanh], [Mota]) VALUES (N'Ma001', N'BeardOil', NULL, N'Beard')
GO
INSERT [dbo].[Tintuc] ([Matintuc], [Tieude], [Mota], [Noidung], [Anh], [Ngaydang], [Nguoidang]) VALUES (N'Ma001', N'Điện thoại new', N'New', N'New', NULL, CAST(N'2020-11-11' AS Date), N'Tạ Đình Phong')
GO
ALTER TABLE [dbo].[Binhluan]  WITH CHECK ADD FOREIGN KEY([Makhachhang])
REFERENCES [dbo].[Khachhang] ([Makhachhang])
GO
ALTER TABLE [dbo].[Binhluan]  WITH CHECK ADD FOREIGN KEY([Masanpham])
REFERENCES [dbo].[Sanpham] ([Masanpham])
GO
ALTER TABLE [dbo].[Chitietdondathang]  WITH CHECK ADD FOREIGN KEY([Madondathang])
REFERENCES [dbo].[Dondathang] ([Madondathang])
GO
ALTER TABLE [dbo].[Chitietdondathang]  WITH CHECK ADD FOREIGN KEY([Masanpham])
REFERENCES [dbo].[Sanpham] ([Masanpham])
GO
ALTER TABLE [dbo].[Chitiethoadon]  WITH CHECK ADD FOREIGN KEY([Mahoadon])
REFERENCES [dbo].[Hoadon] ([Mahoadon])
GO
ALTER TABLE [dbo].[Chitiethoadon]  WITH CHECK ADD FOREIGN KEY([Masanpham])
REFERENCES [dbo].[Sanpham] ([Masanpham])
GO
ALTER TABLE [dbo].[Dondathang]  WITH CHECK ADD FOREIGN KEY([Makhachhang])
REFERENCES [dbo].[Khachhang] ([Makhachhang])
GO
ALTER TABLE [dbo].[Dondathang]  WITH CHECK ADD FOREIGN KEY([Manhanvien])
REFERENCES [dbo].[Nhanvien] ([Manhanvien])
GO
ALTER TABLE [dbo].[Hoadon]  WITH CHECK ADD FOREIGN KEY([Manhacungcap])
REFERENCES [dbo].[Nhacungcap] ([Manhacungcap])
GO
ALTER TABLE [dbo].[Hoadon]  WITH CHECK ADD FOREIGN KEY([Manhanvien])
REFERENCES [dbo].[Nhanvien] ([Manhanvien])
GO
ALTER TABLE [dbo].[Loaisanpham]  WITH CHECK ADD FOREIGN KEY([Madanhmuc])
REFERENCES [dbo].[Danhmucsanpham] ([Madanhmuc])
GO
ALTER TABLE [dbo].[Sanpham]  WITH CHECK ADD FOREIGN KEY([Mahang])
REFERENCES [dbo].[Hangsanxuat] ([Mahang])
GO
ALTER TABLE [dbo].[Sanpham]  WITH CHECK ADD FOREIGN KEY([Maloai])
REFERENCES [dbo].[Loaisanpham] ([Maloai])
GO
