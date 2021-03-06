USE [dew]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 11/12/2014 13:13:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin](
	[username] [nvarchar](128) NOT NULL,
	[password] [nvarchar](128) NULL,
	[hoten] [nvarchar](128) NULL,
	[ngaysinh] [datetime] NULL,
 CONSTRAINT [PK_admin] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[admin] ([username], [password], [hoten], [ngaysinh]) VALUES (N'admin', N'123456', N'huỳnh bá đạt', CAST(0x0000840100000000 AS DateTime))
/****** Object:  Table [dbo].[loaisanpham]    Script Date: 11/12/2014 13:13:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaisanpham](
	[maloai] [nvarchar](128) NOT NULL,
	[tenloai] [nvarchar](max) NULL,
 CONSTRAINT [PK__loaisanphamModel__00551192] PRIMARY KEY CLUSTERED 
(
	[maloai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[loaisanpham] ([maloai], [tenloai]) VALUES (N'BT        ', N'Bông tai')
INSERT [dbo].[loaisanpham] ([maloai], [tenloai]) VALUES (N'DC1D      ', N'Dây chuyền đơn')
INSERT [dbo].[loaisanpham] ([maloai], [tenloai]) VALUES (N'DC2D      ', N'Dây chuyền đôi')
INSERT [dbo].[loaisanpham] ([maloai], [tenloai]) VALUES (N'LC        ', N'Lắc chân')
INSERT [dbo].[loaisanpham] ([maloai], [tenloai]) VALUES (N'LT        ', N'Lắc tay')
INSERT [dbo].[loaisanpham] ([maloai], [tenloai]) VALUES (N'MD        ', N'Mặt dây')
INSERT [dbo].[loaisanpham] ([maloai], [tenloai]) VALUES (N'N1D       ', N'Nhẫn đơn')
INSERT [dbo].[loaisanpham] ([maloai], [tenloai]) VALUES (N'N2D       ', N'Nhẫn đôi')
INSERT [dbo].[loaisanpham] ([maloai], [tenloai]) VALUES (N'VC        ', N'Vòng cổ')
INSERT [dbo].[loaisanpham] ([maloai], [tenloai]) VALUES (N'VT        ', N'Vòng tay')
/****** Object:  Table [dbo].[phieuxuat]    Script Date: 11/12/2014 13:13:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieuxuat](
	[maphieuxuat] [nchar](10) NOT NULL,
	[tennguoilap] [nvarchar](50) NULL,
	[ngaylap] [datetime] NULL,
	[trangthai] [nvarchar](50) NULL,
 CONSTRAINT [PK_phieuxuat] PRIMARY KEY CLUSTERED 
(
	[maphieuxuat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[phieuxuat] ([maphieuxuat], [tennguoilap], [ngaylap], [trangthai]) VALUES (N'PX1       ', N'dat', CAST(0x0000A3E000000000 AS DateTime), N'Đã xuất hàng')
INSERT [dbo].[phieuxuat] ([maphieuxuat], [tennguoilap], [ngaylap], [trangthai]) VALUES (N'PX2       ', N'Huỳnh Bá Đạt', CAST(0x0000A3E000000000 AS DateTime), N'Mới lập')
/****** Object:  Table [dbo].[phieunhap]    Script Date: 11/12/2014 13:13:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieunhap](
	[maphieunhap] [nchar](10) NOT NULL,
	[tennguoilap] [nvarchar](50) NULL,
	[ngaylap] [datetime] NULL,
	[trangthai] [nvarchar](50) NULL,
 CONSTRAINT [PK_phieunhap] PRIMARY KEY CLUSTERED 
(
	[maphieunhap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[phieunhap] ([maphieunhap], [tennguoilap], [ngaylap], [trangthai]) VALUES (N'PN1       ', N'Huỳnh Bá Đạt', CAST(0x0000A3E100000000 AS DateTime), N'Mới lập')
INSERT [dbo].[phieunhap] ([maphieunhap], [tennguoilap], [ngaylap], [trangthai]) VALUES (N'PN2       ', N'Huỳnh Bá Đạt', CAST(0x0000A3E000000000 AS DateTime), N'Mới lập')
INSERT [dbo].[phieunhap] ([maphieunhap], [tennguoilap], [ngaylap], [trangthai]) VALUES (N'PN3       ', N'Huỳnh Bá Đạt', CAST(0x0000A3E000000000 AS DateTime), N'Mới lập')
INSERT [dbo].[phieunhap] ([maphieunhap], [tennguoilap], [ngaylap], [trangthai]) VALUES (N'PN4       ', N'Huỳnh Bá Đạt', CAST(0x0000A3DB00000000 AS DateTime), N'Đã nhập hàng')
/****** Object:  Table [dbo].[phanquyen]    Script Date: 11/12/2014 13:13:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phanquyen](
	[maphanquyen] [int] NOT NULL,
	[quyen] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_dbo.phanquyen] PRIMARY KEY CLUSTERED 
(
	[maphanquyen] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[phanquyen] ([maphanquyen], [quyen]) VALUES (1, N'Khách hàng')
INSERT [dbo].[phanquyen] ([maphanquyen], [quyen]) VALUES (2, N'Nhân viên')
/****** Object:  Table [dbo].[nguoidung]    Script Date: 11/12/2014 13:13:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nguoidung](
	[username] [nvarchar](128) NOT NULL,
	[hoten] [nvarchar](max) NULL,
	[password] [nvarchar](max) NULL,
	[ngaysinh] [datetime] NULL,
	[gioitinh] [int] NULL,
	[sdt] [nvarchar](max) NULL,
	[diachi] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
	[maphanquyen] [int] NOT NULL,
	[useran] [bit] NOT NULL,
 CONSTRAINT [PK__nguoidungModels__7E6CC920] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[nguoidung] ([username], [hoten], [password], [ngaysinh], [gioitinh], [sdt], [diachi], [email], [maphanquyen], [useran]) VALUES (N'badat', N'huỳnh bá đạt', N'123456', CAST(0x0000838F00000000 AS DateTime), 1, N'01699460529', N'hoang van thu', N'badat1007@gmail.com', 1, 0)
INSERT [dbo].[nguoidung] ([username], [hoten], [password], [ngaysinh], [gioitinh], [sdt], [diachi], [email], [maphanquyen], [useran]) VALUES (N'badat07', N'huỳnh bá đạt', N'123456', CAST(0x0000840100000000 AS DateTime), 1, N'01699460529', N'11 đồng đen', N'badat1007@gmail.com', 1, 0)
INSERT [dbo].[nguoidung] ([username], [hoten], [password], [ngaysinh], [gioitinh], [sdt], [diachi], [email], [maphanquyen], [useran]) VALUES (N'camtu', N'nguyen thi cam tu', N'123456', CAST(0x0000848D00000000 AS DateTime), 0, N'01699460529', N'273 An Dương Vương', N'badat1007@gmail.com', 1, 0)
INSERT [dbo].[nguoidung] ([username], [hoten], [password], [ngaysinh], [gioitinh], [sdt], [diachi], [email], [maphanquyen], [useran]) VALUES (N'hieppham', N'pham hoang hiep', N'123456', CAST(0x0000848D00000000 AS DateTime), 0, N'01672396507', N'273 An Dương Vương', N'phhoanghiep035@gmail.com', 1, 0)
INSERT [dbo].[nguoidung] ([username], [hoten], [password], [ngaysinh], [gioitinh], [sdt], [diachi], [email], [maphanquyen], [useran]) VALUES (N'hoanghiep', N'pham hoang hiep', N'123456', CAST(0x0000823800000000 AS DateTime), 1, N'01672396507', N'273, An Dương Vương', N'badat1007@gmail.com', 2, 0)
INSERT [dbo].[nguoidung] ([username], [hoten], [password], [ngaysinh], [gioitinh], [sdt], [diachi], [email], [maphanquyen], [useran]) VALUES (N'hoanglichsu', N'pham nhut hoang', N'123456', CAST(0x0000848D00000000 AS DateTime), 1, N'01672396508', N'273 An Dương Vương', N'badat1007@gmail.com', 2, 0)
INSERT [dbo].[nguoidung] ([username], [hoten], [password], [ngaysinh], [gioitinh], [sdt], [diachi], [email], [maphanquyen], [useran]) VALUES (N'nguoidung', N'pham nguoi dung', N'123456', CAST(0x0000848D00000000 AS DateTime), 1, N'01699460529', N'nguyen van thu', N'badat1007@gmail.com', 1, 0)
INSERT [dbo].[nguoidung] ([username], [hoten], [password], [ngaysinh], [gioitinh], [sdt], [diachi], [email], [maphanquyen], [useran]) VALUES (N'nguoidung2', N'pham van nguoi dung', N'123456', CAST(0x0000861D00000000 AS DateTime), 1, N'01699460529', N'hoang hoa tham', N'badat1007@gmail.com', 2, 0)
INSERT [dbo].[nguoidung] ([username], [hoten], [password], [ngaysinh], [gioitinh], [sdt], [diachi], [email], [maphanquyen], [useran]) VALUES (N'nguoidung3', N'pham van nguoi dung 3', N'123456', CAST(0x0000822200000000 AS DateTime), 1, N'01699460529', N'mac thi buoi', N'badat1007@gmail.com', 1, 0)
INSERT [dbo].[nguoidung] ([username], [hoten], [password], [ngaysinh], [gioitinh], [sdt], [diachi], [email], [maphanquyen], [useran]) VALUES (N'nguoidung4', N'pham van nguoi dung', N'123456', CAST(0x0000447B00000000 AS DateTime), 1, N'01699460529', N'273 An Dương Vương', N'phhoanghiep035@gmail.com', 1, 0)
INSERT [dbo].[nguoidung] ([username], [hoten], [password], [ngaysinh], [gioitinh], [sdt], [diachi], [email], [maphanquyen], [useran]) VALUES (N'nguoidung5', N'pham van nguoi dung', N'123456', CAST(0x0000447B00000000 AS DateTime), 1, N'01699460529', N'273 An Dương Vương', N'phhoanghiep035@gmail.com', 1, 1)
INSERT [dbo].[nguoidung] ([username], [hoten], [password], [ngaysinh], [gioitinh], [sdt], [diachi], [email], [maphanquyen], [useran]) VALUES (N'tuyetnguyen', N'nguyen thi tuyet', N'123456', CAST(0x0000835F00000000 AS DateTime), 0, N'01672396508', N'273 An Dương Vương', N'badat1007@gmail.com', 1, 1)
/****** Object:  Table [dbo].[sanpham]    Script Date: 11/12/2014 13:13:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sanpham](
	[masanpham] [nvarchar](128) NOT NULL,
	[tensanpham] [nvarchar](max) NULL,
	[chatlieu] [nvarchar](max) NULL,
	[giasanpham] [int] NULL,
	[sanphammoi] [int] NULL,
	[hinhanh] [nvarchar](max) NULL,
	[maloai] [nvarchar](128) NULL,
 CONSTRAINT [PK__sanphamModels__7C8480AE] PRIMARY KEY CLUSTERED 
(
	[masanpham] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'BT001', N'Bông tai vàng vĩnh cửu', N'vàng, pha lê', 4300000, 1, N'image/bongtai/1.jpg', N'BT')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'BT002     ', N'Bông tai hoa kim cương', N'bạch kim, kim cương', 5000000, 1, N'image/bongtai/2.jpg', N'BT')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'BT003     ', N'Bông tai hoa pha lê', N'bach kim, pha lê', 2350000, 1, N'image/bongtai/3.jpg', N'BT')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'BT004     ', N'Bông tai kim cương', N'bạch kim, kim cương', 5600000, 1, N'image/bongtai/4.jpg', N'BT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'BT005     ', N'Bông tai hoa kim cương trong suốt', N'bạch kim, kim cương', 4560000, 1, N'image/bongtai/5.jpg', N'BT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'BT006     ', N'Bông tai ngôi sao vàng', N'bạch kim, kim cương', 3560000, 1, N'image/bongtai/6.jpg', N'BT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'BT007     ', N'Bông tai sao xoắn', N'bạch kim, kim cương', 3400000, 1, N'image/bongtai/7.jpg', N'BT')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'BT008     ', N'Bông tai kim cương vàng', N'vàng, kim cương', 6000000, 1, N'image/bongtai/8.jpg', N'BT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'BT009     ', N'Bông tai xoắn hoa vàng', N'vàng, kim cương', 5600000, 1, N'image/bongtai/9.jpg', N'BT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'BT010     ', N'Bông tai tim vàng', N'vàng, kim cương', 4300000, 1, N'image/bongtai/10.jpg', N'BT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'BT011     ', N'Bông tai kim cương xoay', N'bạch kim, kim cương', 4500000, 1, N'image/bongtai/11.jpg', N'BT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'BT012     ', N'Bông tai xoắn kim cương', N'bạch kim, kim cương', 3500000, 1, N'image/bongtai/12.jpg', N'BT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'BT020', N'Bông tai bạch kim', N'bạch kim', 2500000, 0, N'Image/bongtai/5.png', N'BT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'BT021', N'bông tai hoa xoan vàng', N'vàng', 1500000, 0, N'Image/bongtai/3.png', N'BT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'BT100', N'bongtai vang', N'vàng', 500000, 0, N'image/bongtai/5.png', N'BT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC1D001   ', N'Dây chuyền hoa hồng', N'vàng, pha lê', 980000, 1, N'image/daychuyen/1.jpg', N'DC1D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC1D002   ', N'Dây chuyền ngọc trai', N'ngọc trai', 4000000, 1, N'image/daychuyen/2.jpg', N'DC1D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC1D011   ', N'Dây chuyền vương miệng ngọc trai', N'bạch kim, ngọc trai', 860000, 1, N'image/daychuyen/11.jpg', N'DC1D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC1D013   ', N' Dây chuyền pha lê', N'pha lê', 200000, 1, N'image/daychuyen/13.jpg', N'DC1D')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC1D014   ', N'Dây chuyền vườn hoa pha lê', N'pha lê', 1000000, 1, N'image/daychuyen/14.jpg', N'DC1D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC1D017   ', N'Dây chuyền mưa trái tim', N'bạc, pha lê', 2790000, 1, N'image/daychuyen/17.jpg', N'DC1D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC1D024   ', N'Dây chuyền ngọc trai hai lớp', N'ngọc trai', 18000000, 1, N'image/daychuyen/24.jpg', N'DC1D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC1D025   ', N'Dây chuyền vòng khuyên', N'bạc', 1000000, 1, N'image/daychuyen/25.jpg', N'DC1D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC1D026   ', N'Dây chuyền hoa trong tim', N'vàng', 5950000, 1, N'image/daychuyen/26.jpg', N'DC1D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC1D049   ', N'Dây chuyền Love', N'bạc, pha lê', 650000, 1, N'image/daychuyen/49.jpg', N'DC1D')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC1D050   ', N'Dây chuyền chuột Mickey', N'bạc, pha lê', 770000, 1, N'image/daychuyen/50.jpg', N'DC1D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC1D051   ', N'Dây chuyền trái tim lung linh', N'bạc, pha lê', 1000000, 1, N'image/daychuyen/51.jpg', N'DC1D')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC1D052   ', N'Dây chuyền chuồn chuồn nước', N'vàng, pha lê', 4100000, 1, N'image/daychuyen/52.jpg', N'DC1D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC1D053   ', N'Dây chuyền pha lê xanh', N'vàng, pha lê', 800000, 1, N'image/daychuyen/53.jpg', N'DC1D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC1D054   ', N'Dây chuyền nhịp đập trái tim', N'vàng', 900000, 1, N'image/daychuyen/54.jpg', N'DC1D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC2D003   ', N'Dây chuyền đôi khóa tình yêu', N'bạc', 1500000, 1, N'image/daychuyen/3.jpg', N'DC2D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC2D004   ', N'Dây chuyền đôi Puka', N'bạc', 860000, 1, N'image/daychuyen/4.jpg', N'DC2D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC2D005   ', N'Dây chuyền đôi ngọt ngào', N'bạc', 750000, 1, N'image/daychuyen/5.jpg', N'DC2D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC2D006   ', N'Dây chuyền đôi tình yêu', N'bạc', 790000, 1, N'image/daychuyen/6.jpg', N'DC2D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC2D007   ', N'Dây chuyền đôi ngôi sao may mắn', N'bạc', 1000000, 1, N'image/daychuyen/7.jpg', N'DC2D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC2D019   ', N'Dây chuyền đôi I Love You', N'bạc', 2500000, 1, N'image/daychuyen/19.jpg', N'DC2D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC2D032   ', N'Dây chuyền đôi Miss You', N'bạc', 1570000, 1, N'image/daychuyen/32.jpg', N'DC2D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC2D034   ', N'Dây chuyền đôi lông ngỗng 	', N'bạc', 1300000, 1, N'image/daychuyen/34.jpg', N'DC2D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC2D035   ', N'Dây chuyền đôi vòng tròn tình yêu', N'bạc', 2900000, 1, N'image/daychuyen/35.jpg', N'DC2D')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC2D036   ', N'Dây chuyền thư tình trong trái tim', N'bạc', 1100000, 1, N'image/daychuyen/36.jpg', N'DC2D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC2D037   ', N'Dây chuyền đôi Love', N'bạc', 1200000, 1, N'image/daychuyen/37.jpg', N'DC2D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC2D040   ', N'Dây chuyền đôi tim trong tim', N'bạc', 1000000, 1, N'image/daychuyen/40.jpg', N'DC2D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC2D041   ', N'Dây chuyên đôi thánh giá', N'bạc', 3500000, 1, N'image/daychuyen/41.jpg', N'DC2D')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC2D042   ', N' 	Dây chuyền đôi kết nối', N'bạc', 640000, 1, N'image/daychuyen/42.jpg', N'DC2D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'DC2D043   ', N'Dây chuyền đôi Love You', N'bạc', 990000, 1, N'image/daychuyen/43.jpg', N'DC2D      ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LC010     ', N'Lắc chân lấp lánh', N'bạc', 320000, 1, N'image/lac/10.jpg', N'LC        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LC013     ', N'Lắc chân quả cầu', N'bạc', 450000, 1, N'image/lac/13.jpg', N'LC        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LC017     ', N'Lắc chân yêu thương', N'bạc', 130000, 1, N'image/lac/17.jpg', N'LC        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LC018     ', N'Lắc chân kết nối trái tim', N'bạc', 350000, 1, N'image/lac/18.jpg', N'LC        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LC019     ', N'Lắc chân nắm giữ con tim', N'bạc', 4300000, 1, N'image/lac/19.jpg', N'LC        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LC021     ', N'Lắc chân hoa xuân', N'bạc', 99000, 1, N'image/lac/21.jpg', N'LC        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LC024     ', N'Lắc chân cỏ ba lá may mắn', N'bạc, pha lê', 150000, 1, N'image/lac/24.jpg', N'LC        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LC025     ', N'Lắc chân chiếc lá', N'bạc', 94000, 1, N'image/lac/25.jpg', N'LC        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LC026     ', N'Lắc chân cún con', N'bạc', 100000, 1, N'image/lac/26.jpg', N'LC        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LC027     ', N'Lắc chân trái tim', N'bạc', 130000, 1, N'image/lac/27.jpg', N'LC')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LC040     ', N'Lắc chân ngôi sao', N'bạc', 120000, 1, N'image/lac/40.jpg', N'LC        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LC042     ', N'Lắc chân chìa khóa con tim', N'bạc', 85000, 1, N'image/lac/42.jpg', N'LC        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LC043     ', N'Lắc chân chiếc ô', N'bạc, pha lê', 270000, 1, N'image/lac/43.jpg', N'LC        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LC044     ', N'Lắc chân cỏ ba lá', N'bạc', 110000, 1, N'image/lac/44.jpg', N'LC        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LC048     ', N'Lắc chân ngọc ngà', N'bạc, ngọc trai', 3990000, 1, N'image/lac/48.jpg', N'LC        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LT002     ', N'Lắc tay tú cầu', N'bạc', 860000, 1, N'image/lac/2.jpg', N'LT')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LT003     ', N'Lắc tay pha lê nhiều màu', N'pha lê', 150000, 1, N'image/lac/3.jpg', N'LT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LT004     ', N'Lắc tay ngọt ngào', N'bạc, pha lê', 730000, 1, N'image/lac/4.jpg', N'LT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LT005     ', N'Lắc tay miu miu', N'bạc', 220000, 1, N'image/lac/5.jpg', N'LT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LT006     ', N'Lắc tay bình an', N'vàng, pha lê', 4860000, 1, N'image/lac/6.jpg', N'LT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LT007     ', N'Lắc tay bướm xinh', N'bạc', 4300000, 1, N'image/lac/7.jpg', N'LT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LT009     ', N'Lắc tay Mèo Hello Kitty', N'bạc', 800000, 1, N'image/lac/9.jpg', N'LT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LT012     ', N'Lắc tay giáng sinh', N'bạc', 700000, 1, N'image/lac/12.jpg', N'LT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LT022     ', N'Lắc tay hoa anh đào', N'bạc, pha lê', 300000, 1, N'image/lac/22.jpg', N'LT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LT030     ', N'Lắc tay hoa anh đào', N'ngoc trai', 5120000, 1, N'image/lac/30.jpg', N'LT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LT034     ', N' 	Lắc tay ngọc trai đen', N'bạc', 3220000, 1, N'image/lac/34.jpg', N'LT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LT035     ', N' 	Lắc tay dịu dàng sắc lam', N'bạc', 450000, 1, N'image/lac/35.jpg', N'LT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LT036     ', N'Lắc tay dịu dàng sắc tím', N'bạc', 450000, 1, N'image/lac/36.jpg', N'LT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LT038     ', N'Lắc tay vòng khuyên', N'vàng', 3100000, 1, N'image/lac/38.jpg', N'LT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LT039     ', N'Lắc tay hình thú', N'bạc', 250000, 1, N'image/lac/39.jpg', N'LT')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'LT047', N'Lắc tay ngọc trai dịu dàng', N'ngọc trai, bạch kim', 540000, 1, N'image/lac/47.jpg', N'LT')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'MD001     ', N' 	Mặt dây kim cương xoắn', N'bạch kim, kim cương', 3000000, 1, N'image/matday/1.jpg', N'MD        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'MD002     ', N'Mặt dây hoa kim cương', N'bạch kim, kim cương', 2500000, 1, N'image/matday/2.jpg', N'MD        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'MD003     ', N' 	Mặt dây kim cương huyền bí', N'bạch kim, kim cương', 2300000, 1, N'image/matday/3.jpg', N'MD        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'MD004     ', N'Mặt dây kim cương xoay tròn', N'bạch kim, kim cương', 1300000, 1, N'image/matday/4.jpg', N'MD        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'MD005     ', N'Mặt dây tim pha lê', N'bạch kim, kim cương', 2350000, 1, N'image/matday/5.jpg', N'MD        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'MD006     ', N'Mặt dây ngôi sao kim cương', N'bạch kim, kim cương', 3500000, 1, N'image/matday/6.jpg', N'MD        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'MD007     ', N'Mặt dây hoa mai vàng', N'vàng, kim cương', 5050000, 1, N'image/matday/7.jpg', N'MD        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'MD008     ', N'Mặt dây hoa xoắn kim cương', N'bạch kim, kim cương', 2100000, 1, N'image/matday/8.jpg', N'MD        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'MD009     ', N'Mặt dây hoa nổi kim cương', N'bạch kim, kim cương', 3450000, 1, N'image/matday/9.jpg', N'MD        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'MD010     ', N'Mặt dây tim trong tim', N'vàng, kim cương', 4500000, 1, N'image/matday/10.jpg', N'MD        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'MD011     ', N'Mặt dây pha lê sắc xanh', N'bạch kim, pha lê', 1000000, 1, N'image/matday/11.jpg', N'MD        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'MD012     ', N'Mặt dây pha lê sắc tím', N'bạch kim, pha lê', 2300000, 1, N'image/matday/12.jpg', N'MD        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N1D006    ', N'Nhẫn kim cương', N'bạch kim, kim cương', 20300000, 1, N'image/nhan/6.jpg', N'N1D       ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N1D007    ', N'Nhẫn kim cương mặt trái tim', N'bạch kim, kim cương', 19300000, 1, N'image/nhan/7.jpg', N'N1D       ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N1D009    ', N'Nhẫn thiên thạch', N'vàng, pha lê', 2650000, 1, N'image/nhan/9.jpg', N'N1D')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N1D010    ', N'Nhẫn Love', N'bạc', 260000, 1, N'image/nhan/10.jpg', N'N1D       ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N1D015    ', N'Nhẫn pha lê xanh lục', N'bạc, pha lê', 135000, 1, N'image/nhan/15.jpg', N'N1D       ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N1D021    ', N'Nhẫn vòng xoay', N'bạc, pha lê', 790000, 1, N'image/nhan/21.jpg', N'N1D')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N1D022    ', N'Nhẫn kim cương hoa tuyết', N'bạch kim, kim cương', 12000000, 1, N'image/nhan/22.jpg', N'N1D')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N1D026    ', N'Nhẫn kim cương dày', N'bạch kim, kim cương', 11500000, 1, N'image/nhan/26.jpg', N'N1D       ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N1D035    ', N'Nhẫn kim cương mặt vuông', N'bạc, kim cương, pha lê', 7750000, 1, N'image/nhan/35.jpg', N'N1D       ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N1D048    ', N'Nhẫn pha lê tình yêu', N'bạc, pha lê', 530000, 1, N'image/nhan/48.jpg', N'N1D       ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N1D049    ', N'Nhẫn pha lê xanh', N'bạc, pha lê', 390000, 1, N'image/nhan/49.jpg', N'N1D       ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N1D050    ', N'Nhẫn hoa pha lê', N'bạc, pha lê', 400000, 1, N'image/nhan/50.jpg', N'N1D       ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N1D052    ', N'Nhẫn ngọc trai trắng', N'bạc, ngọc trai', 3389000, 1, N'image/nhan/52.jpg', N'N1D       ')
GO
print 'Processed 100 total records'
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N1D053    ', N'Nhẫn hoa ngọc trai', N'bạch kim, ngọc trai, pha lê', 7020000, 1, N'image/nhan/53.jpg', N'N1D       ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N1D057    ', N'Nhẫn vương miệng', N'vàng, pha lê', 3220000, 1, N'image/nhan/57.jpg', N'N1D       ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N2D001    ', N'Nhẫn đôi ngọt ngào', N'bạc', 750000, 1, N'image/nhan/1.jpg', N'N2D       ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N2D002    ', N'Nhẫn đôi tình yêu', N'bạc', 790000, 1, N'image/nhan/2.jpg', N'N2D       ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N2D003    ', N' Nhẫn đôi ước hẹn', N'bạc', 1000000, 1, N'image/nhan/3.jpg', N'N2D')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N2D004    ', N'Nhẫn đôi tình duyên', N'bạc', 650000, 1, N'image/nhan/4.jpg', N'N2D       ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N2D005    ', N'Nhẫn đôi vĩnh cửu', N'bạc', 2300000, 1, N'image/nhan/5.jpg', N'N2D       ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N2D008    ', N'Nhẫn đôi đính kim cương', N'bạc, kim cương', 23890000, 1, N'image/nhan/8.jpg', N'N2D       ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N2D011    ', N'Nhẫn đôi hai nửa tình yêu', N'bạc', 1320000, 1, N'image/nhan/11.jpg', N'N2D       ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N2D012    ', N'Nhẫn đôi I love U', N'bạc', 500000, 1, N'image/nhan/12.jpg', N'N2D       ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N2D013    ', N'Nhẫn đôi cành hồng cho em', N'bạc', 260000, 1, N'image/nhan/13.jpg', N'N2D       ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N2D014    ', N'Nhẫn đôi yêu thương', N'bạc', 730000, 1, N'image/nhan/14.jpg', N'N2D       ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N2D034    ', N' 	Nhẫn đôi vĩnh hằng', N'vàng, pha lê', 3280000, 1, N'image/nhan/34.jpg', N'N2D')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N2D038    ', N'Nhẫn đôi gắn kết tình yêu', N'bạc, pha lê', 19300000, 1, N'image/nhan/38.jpg', N'N2D       ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N2D039    ', N'Nhẫn đôi vững bền', N'vàng', 20300000, 1, N'image/nhan/39.jpg', N'N2D       ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N2D041    ', N'Nhẫn đôi forever', N'bạc, pha lê', 999000, 1, N'image/nhan/41.jpg', N'N2D')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'N2D042    ', N'Nhẫn đôi vuông', N'bạc', 1020000, 1, N'image/nhan/42.jpg', N'N2D       ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'VC001     ', N'Vòng cổ nút áo', N'nút gỗ', 230000, 1, N'image/vong/1.jpg', N'VC')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'VC002     ', N'Vòng cổ pha lê', N'pha lê', 450000, 1, N'image/vong/2.jpg', N'VC        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'VC003     ', N'Vòng cổ nút nâu', N'nút gỗ', 900000, 1, N'image/vong/3.jpg', N'VC        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'VC004     ', N'Vòng cổ song sắc', N'nút gỗ', 250000, 1, N'image/vong/4.jpg', N'VC        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'VC005     ', N'Vòng cổ pha lê vàng', N'pha lê', 450000, 1, N'image/vong/5.jpg', N'VC        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'VC006     ', N'Vòng cổ bình an', N'đá hoa', 600000, 1, N'image/vong/6.jpg', N'VC        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'VC007     ', N'Vòng cổ mắc xích', N'nút gỗ', 450000, 1, N'image/vong/7.jpg', N'VC        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'VC008     ', N' 	Vòng vàng thuần việt', N'vàng', 4500000, 1, N'image/vong/8.jpg', N'VC')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'VC009     ', N'Vòng pha lê ánh vàng', N'pha lê', 460000, 1, N'image/vong/9.jpg', N'VC        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'VC010     ', N'Vòng cổ pha lê viên tròn', N'pha lê', 1000000, 1, N'image/vong/10.jpg', N'VC        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'VT001     ', N'Vòng tay đen huyền bí', N'bạc, pha lê', 350000, 1, N'image/vong/11.jpg', N'VT')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'VT002     ', N'Vòng đôi tỉ muội', N'bạc, pha lê', 1600000, 1, N'image/vong/12.jpg', N'VT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'VT003     ', N'Vòng tay thanh mãnh', N'bạch kim, pha lê', 1900000, 1, N'image/vong/13.jpg', N'VT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'VT004     ', N'Vòng tay kết nối trái tim', N'bạch kim, pha lê', 2000000, 1, N'image/vong/14.jpg', N'VT')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'VT005     ', N'Vòng tay pha lê', N'bạch kim, pha lê', 3200000, 1, N'image/vong/15.jpg', N'VT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'VT006     ', N' 	Vòng tay đồng tâm kết', N'vàng', 4300000, 1, N'image/vong/16.jpg', N'VT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'VT007     ', N'Vòng vân pha lê', N'bạc, pha lê', 1450000, 1, N'image/vong/17.jpg', N'VT        ')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'VT008     ', N'Vòng tay vững bền', N'vàng, pha lê', 3200000, 1, N'image/vong/18.jpg', N'VT')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'VT009     ', N'Vòng tay hoa xinh', N'vàng', 2150000, 1, N'image/vong/19.jpg', N'VT')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [chatlieu], [giasanpham], [sanphammoi], [hinhanh], [maloai]) VALUES (N'VT010     ', N'Vòng tay dịu dàng', N'bạch kim, pha lê', 2100000, 1, N'image/vong/20.jpg', N'VT')
/****** Object:  Table [dbo].[tonkho]    Script Date: 11/12/2014 13:13:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tonkho](
	[ngay] [datetime] NOT NULL,
	[masanpham] [nvarchar](128) NOT NULL,
	[soluong] [int] NULL,
 CONSTRAINT [PK_tonkho] PRIMARY KEY CLUSTERED 
(
	[ngay] ASC,
	[masanpham] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300000000 AS DateTime), N'BT001     ', 0)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A2730000012C AS DateTime), N'BT002     ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300000258 AS DateTime), N'BT003     ', 6)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300000384 AS DateTime), N'BT004     ', 2)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000004B0 AS DateTime), N'BT005     ', 1)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000005DC AS DateTime), N'BT006     ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300000708 AS DateTime), N'BT007     ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300000834 AS DateTime), N'BT008     ', 0)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300000960 AS DateTime), N'BT009     ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300000A8C AS DateTime), N'BT010     ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300000BB8 AS DateTime), N'BT011     ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300000CE4 AS DateTime), N'BT012     ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300000F3C AS DateTime), N'DC1D001   ', 8)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300001068 AS DateTime), N'DC1D002   ', 1)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300001194 AS DateTime), N'DC1D011   ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000012C0 AS DateTime), N'DC1D013   ', 9)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000013EC AS DateTime), N'DC1D014   ', 3)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300001518 AS DateTime), N'DC1D017   ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300001644 AS DateTime), N'DC1D024   ', 2)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300001770 AS DateTime), N'DC1D025   ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A2730000189C AS DateTime), N'DC1D026   ', 3)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000019C8 AS DateTime), N'DC1D049   ', 9)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300001AF4 AS DateTime), N'DC1D050   ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300001C20 AS DateTime), N'DC1D051   ', 6)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300001D4C AS DateTime), N'DC1D052   ', 1)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300001E78 AS DateTime), N'DC1D053   ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300001FA4 AS DateTime), N'DC1D054   ', 7)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000020D0 AS DateTime), N'DC2D003   ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000021FC AS DateTime), N'DC2D004   ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300002328 AS DateTime), N'DC2D005   ', 6)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300002454 AS DateTime), N'DC2D006   ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300002580 AS DateTime), N'DC2D007   ', 7)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000026AC AS DateTime), N'DC2D019   ', 12)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000027D8 AS DateTime), N'DC2D032   ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300002904 AS DateTime), N'DC2D034   ', 8)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300002A30 AS DateTime), N'DC2D035   ', 7)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300002B5C AS DateTime), N'DC2D036   ', 8)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300002C88 AS DateTime), N'DC2D037   ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300002DB4 AS DateTime), N'DC2D040   ', 7)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300002EE0 AS DateTime), N'DC2D041   ', 10)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A2730000300C AS DateTime), N'DC2D042   ', 12)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300003138 AS DateTime), N'DC2D043   ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300003264 AS DateTime), N'LC010     ', 9)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300003390 AS DateTime), N'LC013     ', 7)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000034BC AS DateTime), N'LC017     ', 8)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000035E8 AS DateTime), N'LC018     ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300003714 AS DateTime), N'LC019     ', 8)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300003840 AS DateTime), N'LC021     ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A2730000396C AS DateTime), N'LC024     ', 14)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300003A98 AS DateTime), N'LC025     ', 3)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300003BC4 AS DateTime), N'LC026     ', 7)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300003CF0 AS DateTime), N'LC027     ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300003E1C AS DateTime), N'LC040     ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300003F48 AS DateTime), N'LC042     ', 9)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300004074 AS DateTime), N'LC043     ', 3)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000041A0 AS DateTime), N'LC044     ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000042CC AS DateTime), N'LC048     ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000043F8 AS DateTime), N'LT002     ', 7)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300004524 AS DateTime), N'LT003     ', 13)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300004650 AS DateTime), N'LT004     ', 9)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A2730000477C AS DateTime), N'LT005     ', 7)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000048A8 AS DateTime), N'LT006     ', 3)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000049D4 AS DateTime), N'LT007     ', 8)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300004B00 AS DateTime), N'LT009     ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300004C2C AS DateTime), N'LT012     ', 6)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300004D58 AS DateTime), N'LT022     ', 6)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300004E84 AS DateTime), N'LT030     ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300004FB0 AS DateTime), N'LT034     ', 1)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000050DC AS DateTime), N'LT035     ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300005208 AS DateTime), N'LT036     ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300005334 AS DateTime), N'LT038     ', 3)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300005460 AS DateTime), N'LT039     ', 6)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A2730000558C AS DateTime), N'LT047', 7)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000056B8 AS DateTime), N'MD001     ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000057E4 AS DateTime), N'MD002     ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300005910 AS DateTime), N'MD003     ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300005A3C AS DateTime), N'MD004     ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300005B68 AS DateTime), N'MD005     ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300005C94 AS DateTime), N'MD006     ', 7)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300005DC0 AS DateTime), N'MD007     ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300005EEC AS DateTime), N'MD008     ', 2)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300006018 AS DateTime), N'MD009     ', 6)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300006144 AS DateTime), N'MD010     ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300006270 AS DateTime), N'MD011     ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A2730000639C AS DateTime), N'MD012     ', 3)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000064C8 AS DateTime), N'N1D006    ', 2)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000065F4 AS DateTime), N'N1D007    ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300006720 AS DateTime), N'N1D009    ', 1)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A2730000684C AS DateTime), N'N1D010    ', 7)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300006978 AS DateTime), N'N1D015    ', 9)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300006AA4 AS DateTime), N'N1D021    ', 7)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300006BD0 AS DateTime), N'N1D022    ', 1)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300006CFC AS DateTime), N'N1D026    ', 1)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300006E28 AS DateTime), N'N1D035    ', 3)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300006F54 AS DateTime), N'N1D048    ', 8)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300007080 AS DateTime), N'N1D049    ', 6)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000071AC AS DateTime), N'N1D050    ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000072D8 AS DateTime), N'N1D052    ', 1)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300007404 AS DateTime), N'N1D053    ', 2)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300007530 AS DateTime), N'N1D057    ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A2730000765C AS DateTime), N'N2D001    ', 5)
GO
print 'Processed 100 total records'
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300007788 AS DateTime), N'N2D002    ', 6)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000078B4 AS DateTime), N'N2D003    ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000079E0 AS DateTime), N'N2D004    ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300007B0C AS DateTime), N'N2D005    ', 3)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300007C38 AS DateTime), N'N2D008    ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300007D64 AS DateTime), N'N2D011    ', 6)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300007E90 AS DateTime), N'N2D012    ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300007FBC AS DateTime), N'N2D013    ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000080E8 AS DateTime), N'N2D014    ', 8)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300008214 AS DateTime), N'N2D034    ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300008340 AS DateTime), N'N2D038    ', 1)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A2730000846C AS DateTime), N'N2D039    ', 2)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300008598 AS DateTime), N'N2D041    ', 7)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000086C4 AS DateTime), N'N2D042    ', 3)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000087F0 AS DateTime), N'VC001     ', 3)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A2730000891C AS DateTime), N'VC002     ', 7)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300008A48 AS DateTime), N'VC003     ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300008B74 AS DateTime), N'VC004     ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300008CA0 AS DateTime), N'VC005     ', 3)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300008DCC AS DateTime), N'VC006     ', 10)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300008EF8 AS DateTime), N'VC007     ', 7)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300009024 AS DateTime), N'VC008     ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300009150 AS DateTime), N'VC009     ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A2730000927C AS DateTime), N'VC010     ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000093A8 AS DateTime), N'VT001     ', 9)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A273000094D4 AS DateTime), N'VT002     ', 7)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300009600 AS DateTime), N'VT003     ', 3)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A2730000972C AS DateTime), N'VT004     ', 6)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300009858 AS DateTime), N'VT005     ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300009984 AS DateTime), N'VT006     ', 1)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300009AB0 AS DateTime), N'VT007     ', 7)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300009BDC AS DateTime), N'VT008     ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300009D08 AS DateTime), N'VT009     ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A27300009E34 AS DateTime), N'VT010     ', 6)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28800E5C9C8 AS DateTime), N'BT002     ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28800E74ED8 AS DateTime), N'BT003     ', 7)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28800E81610 AS DateTime), N'BT003     ', 6)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A289014E482C AS DateTime), N'VC002     ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28A00000000 AS DateTime), N'BT003     ', 3)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28A007032A8 AS DateTime), N'BT004     ', 1)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28A0137F298 AS DateTime), N'LT030     ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28A01399620 AS DateTime), N'LC048     ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28A013E6F24 AS DateTime), N'LC048     ', 3)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28A014168DC AS DateTime), N'BT003     ', 2)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28A01416EB8 AS DateTime), N'VC007     ', 6)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28A0141B88C AS DateTime), N'DC2D034   ', 6)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28A015AC3E0 AS DateTime), N'BT001', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28A01646C88 AS DateTime), N'LC048     ', 2)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28B0001FA40 AS DateTime), N'DC2D041   ', 8)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28B0047A2AC AS DateTime), N'DC1D053   ', 7)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28B00495B4C AS DateTime), N'LT009     ', 15)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28B004A46D8 AS DateTime), N'DC1D053   ', 10)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28B004A67A8 AS DateTime), N'LT039     ', 8)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28B0178D13C AS DateTime), N'BT006     ', 9)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28B017963B8 AS DateTime), N'LC024     ', 19)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28B017AE418 AS DateTime), N'N1D010    ', 10)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28B017AE79C AS DateTime), N'N2D002    ', 9)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28B017DE280 AS DateTime), N'BT004     ', 3)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28B017F09D0 AS DateTime), N'VT007     ', 9)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28B017FC0A0 AS DateTime), N'VT002     ', 9)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28B018042B4 AS DateTime), N'BT005     ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28B018286C8 AS DateTime), N'BT004     ', 6)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28B0182DFD8 AS DateTime), N'LC026     ', 10)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28B0184C17C AS DateTime), N'BT006     ', 12)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28B0184C500 AS DateTime), N'BT007     ', 7)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28B0189CA8C AS DateTime), N'BT003     ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28C00000A8C AS DateTime), N'N2D038    ', 3)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28C00000A8C AS DateTime), N'VC001     ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28C00015630 AS DateTime), N'BT003     ', 3)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28C00015630 AS DateTime), N'LC024     ', 18)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28C00015630 AS DateTime), N'LC048     ', 0)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28C000DBDF8 AS DateTime), N'BT004     ', 8)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28C000DBDF8 AS DateTime), N'N1D015    ', 11)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28C000DBDF8 AS DateTime), N'N2D002    ', 11)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A28D00E40C78 AS DateTime), N'LC024     ', 20)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A29F016C626C AS DateTime), N'BT003     ', 6)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A29F016C626C AS DateTime), N'BT012     ', 6)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A29F016C626C AS DateTime), N'DC1D002   ', 11)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A3D700B3976B AS DateTime), N'BT001', 3)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A3D700B9E56D AS DateTime), N'BT001', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A3D700B9E5E2 AS DateTime), N'BT002     ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A3D700B9E5E5 AS DateTime), N'DC1D002   ', 9)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A3D700BA8502 AS DateTime), N'BT002     ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A3D700BA8512 AS DateTime), N'BT020', 0)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A3D700BA8512 AS DateTime), N'BT100', 0)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A3D700BA8512 AS DateTime), N'DC1D002   ', 11)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A3DE00F8F580 AS DateTime), N'BT021', 0)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A3DF016754A4 AS DateTime), N'BT002     ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A3DF016754F9 AS DateTime), N'BT004     ', 6)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A3DF0167550F AS DateTime), N'N1D006    ', 1)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A3DF0167BEE8 AS DateTime), N'N2D039    ', 1)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A3DF0169F54F AS DateTime), N'N2D039    ', 3)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A3DF016A9136 AS DateTime), N'N2D039    ', 4)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A3E00162D674 AS DateTime), N'BT004     ', 5)
INSERT [dbo].[tonkho] ([ngay], [masanpham], [soluong]) VALUES (CAST(0x0000A3E10013ADC8 AS DateTime), N'BT001', 4)
/****** Object:  Table [dbo].[hoadon]    Script Date: 11/12/2014 13:13:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoadon](
	[mahoadon] [int] IDENTITY(1,1) NOT NULL,
	[tendangnhap] [nvarchar](128) NULL,
	[sdt] [nvarchar](max) NULL,
	[ngaymuahang] [datetime] NULL,
	[diadiemgiaohang] [nvarchar](max) NULL,
	[ngaygiaohang] [datetime] NULL,
	[trangthai] [nvarchar](50) NULL,
 CONSTRAINT [PK_hoadon] PRIMARY KEY CLUSTERED 
(
	[mahoadon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[hoadon] ON
INSERT [dbo].[hoadon] ([mahoadon], [tendangnhap], [sdt], [ngaymuahang], [diadiemgiaohang], [ngaygiaohang], [trangthai]) VALUES (1, N'badat', N'01699460529', CAST(0x0000A3DA00AE81E7 AS DateTime), N'hoang hoa tham', CAST(0x0000A3E000000000 AS DateTime), N'Đã giao')
INSERT [dbo].[hoadon] ([mahoadon], [tendangnhap], [sdt], [ngaymuahang], [diadiemgiaohang], [ngaygiaohang], [trangthai]) VALUES (2, N'hoanghiep', N'01672396507', CAST(0x0000A3DA00AED4B4 AS DateTime), N'273, An Dương Vương', CAST(0x0000A3E000000000 AS DateTime), N'Đã giao')
INSERT [dbo].[hoadon] ([mahoadon], [tendangnhap], [sdt], [ngaymuahang], [diadiemgiaohang], [ngaygiaohang], [trangthai]) VALUES (3, N'camtu', N'01699460529', CAST(0x0000A3DA00B01EB8 AS DateTime), N'lạc long quân', CAST(0x0000A3E000000000 AS DateTime), N'Mới')
INSERT [dbo].[hoadon] ([mahoadon], [tendangnhap], [sdt], [ngaymuahang], [diadiemgiaohang], [ngaygiaohang], [trangthai]) VALUES (4, N'nguoidung', N'01699460529', CAST(0x0000A3DA00B073F8 AS DateTime), N'nguyen van thu', CAST(0x0000A3E000000000 AS DateTime), N'Hủy')
INSERT [dbo].[hoadon] ([mahoadon], [tendangnhap], [sdt], [ngaymuahang], [diadiemgiaohang], [ngaygiaohang], [trangthai]) VALUES (5, N'nguoidung2', N'01699460529', CAST(0x0000A3DA00B0A80E AS DateTime), N'hoang hoa tham', CAST(0x0000A3E000000000 AS DateTime), N'Đã giao')
INSERT [dbo].[hoadon] ([mahoadon], [tendangnhap], [sdt], [ngaymuahang], [diadiemgiaohang], [ngaygiaohang], [trangthai]) VALUES (6, N'hieppham', N'01672396507', CAST(0x0000A3DA00B3CDDE AS DateTime), N'Thi Nghe', CAST(0x0000A3E000000000 AS DateTime), N'Mới')
INSERT [dbo].[hoadon] ([mahoadon], [tendangnhap], [sdt], [ngaymuahang], [diadiemgiaohang], [ngaygiaohang], [trangthai]) VALUES (7, N'hieppham', N'01672396507', CAST(0x0000A3DA00B3FDBE AS DateTime), N'2734 An Dương Vương', CAST(0x0000A3E000000000 AS DateTime), N'Đã giao')
INSERT [dbo].[hoadon] ([mahoadon], [tendangnhap], [sdt], [ngaymuahang], [diadiemgiaohang], [ngaygiaohang], [trangthai]) VALUES (8, N'nguoidung3', N'01699460529', CAST(0x0000A3DA00B42E77 AS DateTime), N'mac thi buoi', CAST(0x0000A3E000000000 AS DateTime), N'Mới')
INSERT [dbo].[hoadon] ([mahoadon], [tendangnhap], [sdt], [ngaymuahang], [diadiemgiaohang], [ngaygiaohang], [trangthai]) VALUES (9, N'nguoidung3', N'01699460529', CAST(0x0000A3DA00B4835A AS DateTime), N'mac thi buoi', CAST(0x0000A3E000000000 AS DateTime), N'Hủy')
INSERT [dbo].[hoadon] ([mahoadon], [tendangnhap], [sdt], [ngaymuahang], [diadiemgiaohang], [ngaygiaohang], [trangthai]) VALUES (10, N'nguoidung4', N'01699460529', CAST(0x0000A3DA00B4A885 AS DateTime), N'nguyen cuu dam', CAST(0x0000A3E000000000 AS DateTime), N'Trả lại')
INSERT [dbo].[hoadon] ([mahoadon], [tendangnhap], [sdt], [ngaymuahang], [diadiemgiaohang], [ngaygiaohang], [trangthai]) VALUES (11, N'nguoidung4', N'01699460529', CAST(0x0000A3DA00B51E25 AS DateTime), N'273 An Dương Vương', CAST(0x0000A3E000000000 AS DateTime), N'Trả lại')
INSERT [dbo].[hoadon] ([mahoadon], [tendangnhap], [sdt], [ngaymuahang], [diadiemgiaohang], [ngaygiaohang], [trangthai]) VALUES (12, N'badat', N'01699460529', CAST(0x0000A3DA00B53D4C AS DateTime), N'hoang van thu', CAST(0x0000A3E000000000 AS DateTime), N'Hủy')
INSERT [dbo].[hoadon] ([mahoadon], [tendangnhap], [sdt], [ngaymuahang], [diadiemgiaohang], [ngaygiaohang], [trangthai]) VALUES (13, N'badat', N'01699460529', CAST(0x0000A3DC01352AA6 AS DateTime), N'hoang van thu', CAST(0x0000A3E000000000 AS DateTime), N'Hùy')
INSERT [dbo].[hoadon] ([mahoadon], [tendangnhap], [sdt], [ngaymuahang], [diadiemgiaohang], [ngaygiaohang], [trangthai]) VALUES (14, N'badat', N'01699460529', CAST(0x0000A3DC015C3280 AS DateTime), N'hoang van thu', CAST(0x0000A3E000000000 AS DateTime), N'Mới')
INSERT [dbo].[hoadon] ([mahoadon], [tendangnhap], [sdt], [ngaymuahang], [diadiemgiaohang], [ngaygiaohang], [trangthai]) VALUES (15, N'badat', N'0902154422', CAST(0x0000A3DC016E096A AS DateTime), N'hoang van thu', CAST(0x0000A3E000000000 AS DateTime), N'Hủy')
INSERT [dbo].[hoadon] ([mahoadon], [tendangnhap], [sdt], [ngaymuahang], [diadiemgiaohang], [ngaygiaohang], [trangthai]) VALUES (16, N'nguoidung', N'01699460529', CAST(0x0000A3E1002CD06C AS DateTime), N'nguyen van thu', CAST(0x0000A3E300000000 AS DateTime), N'Đã giao')
INSERT [dbo].[hoadon] ([mahoadon], [tendangnhap], [sdt], [ngaymuahang], [diadiemgiaohang], [ngaygiaohang], [trangthai]) VALUES (17, N'nguoidung', N'01699460529', CAST(0x0000A3E1002D6816 AS DateTime), N'nguyen van thu', CAST(0x0000A3E200000000 AS DateTime), N'Mới')
SET IDENTITY_INSERT [dbo].[hoadon] OFF
/****** Object:  Table [dbo].[chitietphieuxuat]    Script Date: 11/12/2014 13:13:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietphieuxuat](
	[maphieuxuat] [nchar](10) NOT NULL,
	[masanpham] [nvarchar](128) NOT NULL,
	[soluong] [int] NULL,
 CONSTRAINT [PK_chitietphieuxuat] PRIMARY KEY CLUSTERED 
(
	[maphieuxuat] ASC,
	[masanpham] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[chitietphieuxuat] ([maphieuxuat], [masanpham], [soluong]) VALUES (N'PX1       ', N'BT001', 1)
INSERT [dbo].[chitietphieuxuat] ([maphieuxuat], [masanpham], [soluong]) VALUES (N'PX2       ', N'BT007     ', 2)
/****** Object:  Table [dbo].[chitietphieunhap]    Script Date: 11/12/2014 13:13:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietphieunhap](
	[maphieunhap] [nchar](10) NOT NULL,
	[masanpham] [nvarchar](128) NOT NULL,
	[soluong] [int] NULL,
 CONSTRAINT [PK_chitietphieunhap] PRIMARY KEY CLUSTERED 
(
	[maphieunhap] ASC,
	[masanpham] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[chitietphieunhap] ([maphieunhap], [masanpham], [soluong]) VALUES (N'PN1       ', N'BT001', 1)
INSERT [dbo].[chitietphieunhap] ([maphieunhap], [masanpham], [soluong]) VALUES (N'PN1       ', N'BT002     ', 1)
INSERT [dbo].[chitietphieunhap] ([maphieunhap], [masanpham], [soluong]) VALUES (N'PN2       ', N'DC1D013   ', 4)
INSERT [dbo].[chitietphieunhap] ([maphieunhap], [masanpham], [soluong]) VALUES (N'PN2       ', N'DC1D024   ', 1)
INSERT [dbo].[chitietphieunhap] ([maphieunhap], [masanpham], [soluong]) VALUES (N'PN3       ', N'VT006     ', 2)
INSERT [dbo].[chitietphieunhap] ([maphieunhap], [masanpham], [soluong]) VALUES (N'PN4       ', N'N2D039    ', 2)
/****** Object:  Table [dbo].[chitiethoadon]    Script Date: 11/12/2014 13:13:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitiethoadon](
	[mahoadon] [int] NOT NULL,
	[masanpham] [nvarchar](128) NOT NULL,
	[soluong] [int] NULL,
	[giasanpham] [int] NULL,
 CONSTRAINT [PK_chitiethoadon] PRIMARY KEY CLUSTERED 
(
	[mahoadon] ASC,
	[masanpham] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[chitiethoadon] ([mahoadon], [masanpham], [soluong], [giasanpham]) VALUES (1, N'BT002', 1, 5000000)
INSERT [dbo].[chitiethoadon] ([mahoadon], [masanpham], [soluong], [giasanpham]) VALUES (1, N'BT004', 2, 5600000)
INSERT [dbo].[chitiethoadon] ([mahoadon], [masanpham], [soluong], [giasanpham]) VALUES (2, N'BT003', 1, 2350000)
INSERT [dbo].[chitiethoadon] ([mahoadon], [masanpham], [soluong], [giasanpham]) VALUES (2, N'DC1D002', 1, 4000000)
INSERT [dbo].[chitiethoadon] ([mahoadon], [masanpham], [soluong], [giasanpham]) VALUES (2, N'LT004', 1, 730000)
INSERT [dbo].[chitiethoadon] ([mahoadon], [masanpham], [soluong], [giasanpham]) VALUES (3, N'DC1D026', 1, 5950000)
INSERT [dbo].[chitiethoadon] ([mahoadon], [masanpham], [soluong], [giasanpham]) VALUES (4, N'N2D004', 1, 650000)
INSERT [dbo].[chitiethoadon] ([mahoadon], [masanpham], [soluong], [giasanpham]) VALUES (4, N'VT006', 1, 4300000)
INSERT [dbo].[chitiethoadon] ([mahoadon], [masanpham], [soluong], [giasanpham]) VALUES (5, N'N1D006', 1, 20300000)
INSERT [dbo].[chitiethoadon] ([mahoadon], [masanpham], [soluong], [giasanpham]) VALUES (6, N'DC1D024', 1, 18000000)
INSERT [dbo].[chitiethoadon] ([mahoadon], [masanpham], [soluong], [giasanpham]) VALUES (6, N'N2D008', 1, 23890000)
INSERT [dbo].[chitiethoadon] ([mahoadon], [masanpham], [soluong], [giasanpham]) VALUES (7, N'BT004', 1, 5600000)
INSERT [dbo].[chitiethoadon] ([mahoadon], [masanpham], [soluong], [giasanpham]) VALUES (8, N'DC2D035', 1, 2900000)
INSERT [dbo].[chitiethoadon] ([mahoadon], [masanpham], [soluong], [giasanpham]) VALUES (9, N'BT012', 1, 3500000)
INSERT [dbo].[chitiethoadon] ([mahoadon], [masanpham], [soluong], [giasanpham]) VALUES (10, N'MD001', 1, 3000000)
INSERT [dbo].[chitiethoadon] ([mahoadon], [masanpham], [soluong], [giasanpham]) VALUES (11, N'N2D039', 1, 20300000)
INSERT [dbo].[chitiethoadon] ([mahoadon], [masanpham], [soluong], [giasanpham]) VALUES (12, N'N2D008', 1, 23890000)
INSERT [dbo].[chitiethoadon] ([mahoadon], [masanpham], [soluong], [giasanpham]) VALUES (13, N'BT004', 1, 5600000)
INSERT [dbo].[chitiethoadon] ([mahoadon], [masanpham], [soluong], [giasanpham]) VALUES (14, N'DC1D049', 1, 650000)
INSERT [dbo].[chitiethoadon] ([mahoadon], [masanpham], [soluong], [giasanpham]) VALUES (15, N'DC1D026', 1, 5950000)
INSERT [dbo].[chitiethoadon] ([mahoadon], [masanpham], [soluong], [giasanpham]) VALUES (16, N'VC004', 1, 250000)
INSERT [dbo].[chitiethoadon] ([mahoadon], [masanpham], [soluong], [giasanpham]) VALUES (17, N'LT004', 1, 730000)
/****** Object:  ForeignKey [FK_chitiethoadon_hoadon]    Script Date: 11/12/2014 13:13:58 ******/
ALTER TABLE [dbo].[chitiethoadon]  WITH CHECK ADD  CONSTRAINT [FK_chitiethoadon_hoadon] FOREIGN KEY([mahoadon])
REFERENCES [dbo].[hoadon] ([mahoadon])
GO
ALTER TABLE [dbo].[chitiethoadon] CHECK CONSTRAINT [FK_chitiethoadon_hoadon]
GO
/****** Object:  ForeignKey [FK_chitiethoadon_sanpham]    Script Date: 11/12/2014 13:13:58 ******/
ALTER TABLE [dbo].[chitiethoadon]  WITH CHECK ADD  CONSTRAINT [FK_chitiethoadon_sanpham] FOREIGN KEY([masanpham])
REFERENCES [dbo].[sanpham] ([masanpham])
GO
ALTER TABLE [dbo].[chitiethoadon] CHECK CONSTRAINT [FK_chitiethoadon_sanpham]
GO
/****** Object:  ForeignKey [FK_chitietphieunhap_phieunhap]    Script Date: 11/12/2014 13:13:58 ******/
ALTER TABLE [dbo].[chitietphieunhap]  WITH CHECK ADD  CONSTRAINT [FK_chitietphieunhap_phieunhap] FOREIGN KEY([maphieunhap])
REFERENCES [dbo].[phieunhap] ([maphieunhap])
GO
ALTER TABLE [dbo].[chitietphieunhap] CHECK CONSTRAINT [FK_chitietphieunhap_phieunhap]
GO
/****** Object:  ForeignKey [FK_chitietphieunhap_sanpham]    Script Date: 11/12/2014 13:13:58 ******/
ALTER TABLE [dbo].[chitietphieunhap]  WITH CHECK ADD  CONSTRAINT [FK_chitietphieunhap_sanpham] FOREIGN KEY([masanpham])
REFERENCES [dbo].[sanpham] ([masanpham])
GO
ALTER TABLE [dbo].[chitietphieunhap] CHECK CONSTRAINT [FK_chitietphieunhap_sanpham]
GO
/****** Object:  ForeignKey [FK_chitietphieuxuat_phieuxuat]    Script Date: 11/12/2014 13:13:58 ******/
ALTER TABLE [dbo].[chitietphieuxuat]  WITH CHECK ADD  CONSTRAINT [FK_chitietphieuxuat_phieuxuat] FOREIGN KEY([maphieuxuat])
REFERENCES [dbo].[phieuxuat] ([maphieuxuat])
GO
ALTER TABLE [dbo].[chitietphieuxuat] CHECK CONSTRAINT [FK_chitietphieuxuat_phieuxuat]
GO
/****** Object:  ForeignKey [FK_chitietphieuxuat_sanpham]    Script Date: 11/12/2014 13:13:58 ******/
ALTER TABLE [dbo].[chitietphieuxuat]  WITH CHECK ADD  CONSTRAINT [FK_chitietphieuxuat_sanpham] FOREIGN KEY([masanpham])
REFERENCES [dbo].[sanpham] ([masanpham])
GO
ALTER TABLE [dbo].[chitietphieuxuat] CHECK CONSTRAINT [FK_chitietphieuxuat_sanpham]
GO
/****** Object:  ForeignKey [FK_hoadon_nguoidung]    Script Date: 11/12/2014 13:13:58 ******/
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_nguoidung] FOREIGN KEY([tendangnhap])
REFERENCES [dbo].[nguoidung] ([username])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_nguoidung]
GO
/****** Object:  ForeignKey [FK_nguoidung_phanquyen]    Script Date: 11/12/2014 13:13:58 ******/
ALTER TABLE [dbo].[nguoidung]  WITH CHECK ADD  CONSTRAINT [FK_nguoidung_phanquyen] FOREIGN KEY([maphanquyen])
REFERENCES [dbo].[phanquyen] ([maphanquyen])
GO
ALTER TABLE [dbo].[nguoidung] CHECK CONSTRAINT [FK_nguoidung_phanquyen]
GO
/****** Object:  ForeignKey [FK_sanpham_loaisanpham]    Script Date: 11/12/2014 13:13:58 ******/
ALTER TABLE [dbo].[sanpham]  WITH CHECK ADD  CONSTRAINT [FK_sanpham_loaisanpham] FOREIGN KEY([maloai])
REFERENCES [dbo].[loaisanpham] ([maloai])
GO
ALTER TABLE [dbo].[sanpham] CHECK CONSTRAINT [FK_sanpham_loaisanpham]
GO
/****** Object:  ForeignKey [FK_tonkho_sanpham]    Script Date: 11/12/2014 13:13:58 ******/
ALTER TABLE [dbo].[tonkho]  WITH CHECK ADD  CONSTRAINT [FK_tonkho_sanpham] FOREIGN KEY([masanpham])
REFERENCES [dbo].[sanpham] ([masanpham])
GO
ALTER TABLE [dbo].[tonkho] CHECK CONSTRAINT [FK_tonkho_sanpham]
GO
