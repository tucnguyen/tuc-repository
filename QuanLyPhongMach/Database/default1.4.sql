USE [QuanLyPhongMach]
GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 06/06/2016 00:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Thuoc](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ma] [varchar](10) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](200) NULL,
	[CreateBy] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[UpdateBy] [nvarchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[DeleteFlag] [bit] NOT NULL,
 CONSTRAINT [PK_Thuoc] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Thuoc] ON
INSERT [dbo].[Thuoc] ([Id], [Ma], [Ten], [MoTa], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [DeleteFlag]) VALUES (1, N'TH1', N'Thuốc A', N'', N'admin', CAST(0x0000A6140172920B AS DateTime), N'admin', CAST(0x0000A6140174C2AE AS DateTime), 0)
INSERT [dbo].[Thuoc] ([Id], [Ma], [Ten], [MoTa], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [DeleteFlag]) VALUES (2, N'TH2', N'Thuốc B', N'', N'admin', CAST(0x0000A6140173E6D9 AS DateTime), N'admin', CAST(0x0000A6140174C2E7 AS DateTime), 0)
INSERT [dbo].[Thuoc] ([Id], [Ma], [Ten], [MoTa], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [DeleteFlag]) VALUES (3, N'TH3', N'Thuốc C', N'', N'admin', CAST(0x0000A6140173F3FE AS DateTime), N'admin', CAST(0x0000A6140174C2E7 AS DateTime), 0)
INSERT [dbo].[Thuoc] ([Id], [Ma], [Ten], [MoTa], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [DeleteFlag]) VALUES (4, N'TH4', N'Thuốc D', N'', N'admin', CAST(0x0000A614017401B8 AS DateTime), N'admin', CAST(0x0000A614017401B8 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Thuoc] OFF
/****** Object:  Table [dbo].[SanPham]    Script Date: 06/06/2016 00:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SanPham](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ma] [varchar](10) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](200) NULL,
	[CreateBy] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[UpdateBy] [nvarchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[DeleteFlag] [bit] NOT NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PetGroup]    Script Date: 06/06/2016 00:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PetGroup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ma] [varchar](6) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](200) NULL,
 CONSTRAINT [PK_PetGroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[PetGroup] ON
INSERT [dbo].[PetGroup] ([Id], [Ma], [Ten], [MoTa]) VALUES (1, N'DO', N'Chó', NULL)
INSERT [dbo].[PetGroup] ([Id], [Ma], [Ten], [MoTa]) VALUES (2, N'CA', N'Mèo', NULL)
SET IDENTITY_INSERT [dbo].[PetGroup] OFF
/****** Object:  Table [dbo].[KhachHangGroup]    Script Date: 06/06/2016 00:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHangGroup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ma] [varchar](6) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](200) NULL,
 CONSTRAINT [PK_KhachHangGroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHangGroup] ON
INSERT [dbo].[KhachHangGroup] ([Id], [Ma], [Ten], [MoTa]) VALUES (1, N'KT', N'Khách thường', NULL)
SET IDENTITY_INSERT [dbo].[KhachHangGroup] OFF
/****** Object:  Table [dbo].[UserGroup]    Script Date: 06/06/2016 00:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserGroup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](20) NOT NULL,
	[MoTa] [nvarchar](200) NULL,
 CONSTRAINT [PK_UserGroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[UserGroup] ON
INSERT [dbo].[UserGroup] ([Id], [Ten], [MoTa]) VALUES (1, N'Admin', NULL)
SET IDENTITY_INSERT [dbo].[UserGroup] OFF
/****** Object:  Table [dbo].[User]    Script Date: 06/06/2016 00:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdGroup] [int] NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[GioiTinh] [nvarchar](3) NOT NULL,
	[DOB] [date] NULL,
	[CMND] [nvarchar](10) NULL,
	[NgayCap] [date] NULL,
	[NoiCap] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [nvarchar](20) NULL,
	[Email] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](200) NULL,
	[CreateBy] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[UpdateBy] [nvarchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[DeleteFlag] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[User] ON
INSERT [dbo].[User] ([Id], [IdGroup], [Ten], [UserName], [Password], [GioiTinh], [DOB], [CMND], [NgayCap], [NoiCap], [DiaChi], [DienThoai], [Email], [GhiChu], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [DeleteFlag]) VALUES (1, 1, N'admin', N'admin', N'21232F297A57A5A743894AE4A801FC345454433454539', N'Nam', CAST(0xDB3A0B00 AS Date), NULL, CAST(0xDB3A0B00 AS Date), NULL, NULL, NULL, NULL, NULL, N'admin', CAST(0x0000A58000000000 AS DateTime), N'admin', CAST(0x0000A58000000000 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[User] OFF
/****** Object:  Table [dbo].[KhachHang]    Script Date: 06/06/2016 00:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdGroup] [int] NOT NULL,
	[Ma] [varchar](10) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](3) NOT NULL,
	[DOB] [date] NULL,
	[CMND] [nchar](10) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [nvarchar](20) NULL,
	[Email] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](200) NULL,
	[CreateBy] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[UpdateBy] [nvarchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[DeleteFlag] [bit] NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON
INSERT [dbo].[KhachHang] ([Id], [IdGroup], [Ma], [Ten], [GioiTinh], [DOB], [CMND], [DiaChi], [DienThoai], [Email], [GhiChu], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [DeleteFlag]) VALUES (0, 1, N'KT001', N'Nguyễn Gia Túc', N'Nam', CAST(0x63140B00 AS Date), N'024247809 ', N'Bình Thạnh', N'0907496225', N'', N'', N'admin', CAST(0x0000A6120188A364 AS DateTime), N'admin', CAST(0x0000A6120188A364 AS DateTime), 0)
INSERT [dbo].[KhachHang] ([Id], [IdGroup], [Ma], [Ten], [GioiTinh], [DOB], [CMND], [DiaChi], [DienThoai], [Email], [GhiChu], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [DeleteFlag]) VALUES (1, 1, N'KT002', N'Lưu Thị Xuân Mai', N'Nữ', CAST(0x6E3B0B00 AS Date), N'          ', N'', N'', N'', N'', N'admin', CAST(0x0000A61300185D9B AS DateTime), N'admin', CAST(0x0000A61300185D9B AS DateTime), 0)
INSERT [dbo].[KhachHang] ([Id], [IdGroup], [Ma], [Ten], [GioiTinh], [DOB], [CMND], [DiaChi], [DienThoai], [Email], [GhiChu], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [DeleteFlag]) VALUES (2, 1, N'KT003', N'test', N'Nam', CAST(0x6E3B0B00 AS Date), N'          ', N'', N'', N'', N'', N'admin', CAST(0x0000A613001D9C61 AS DateTime), N'admin', CAST(0x0000A613001D9C61 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
/****** Object:  Table [dbo].[HoaDon]    Script Date: 06/06/2016 00:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdKhachHang] [int] NULL,
	[Ma] [char](6) NOT NULL,
	[GhiChu] [nvarchar](200) NULL,
	[TongTien] [bigint] NOT NULL,
	[CreateBy] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[UpdateBy] [nvarchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[DeleteFlag] [bit] NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pet]    Script Date: 06/06/2016 00:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdGroup] [int] NOT NULL,
	[IdKhachHang] [int] NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](3) NOT NULL,
	[Giong] [nvarchar](20) NULL,
	[DOB] [date] NULL,
	[TrongLuong] [float] NULL,
	[GhiChu] [nvarchar](200) NULL,
	[CreateBy] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[UpdateBy] [nvarchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[DeleteFlag] [bit] NOT NULL,
 CONSTRAINT [PK_Pet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Pet] ON
INSERT [dbo].[Pet] ([Id], [IdGroup], [IdKhachHang], [Ten], [GioiTinh], [Giong], [DOB], [TrongLuong], [GhiChu], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [DeleteFlag]) VALUES (1, 1, 0, N'Conan', N'Cái', N'Chó Nhật', CAST(0xEA280B00 AS Date), 10, N'', N'admin', CAST(0x0000A61400E5E7CA AS DateTime), N'admin', CAST(0x0000A61C018A16EF AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Pet] OFF
/****** Object:  Table [dbo].[HoaDon_SanPham]    Script Date: 06/06/2016 00:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon_SanPham](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdHoaDon] [int] NOT NULL,
	[IdSanPham] [int] NOT NULL,
	[Gia] [bigint] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[TongTien] [bigint] NOT NULL,
 CONSTRAINT [PK_HoaDon_SanPham] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuDieuTri]    Script Date: 06/06/2016 00:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuDieuTri](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPet] [int] NOT NULL,
	[Ma] [char](6) NOT NULL,
	[TrongLuong] [float] NULL,
	[NhietDo] [varchar](4) NULL,
	[TrieuChung] [nvarchar](100) NULL,
	[IsKhamBenh] [bit] NOT NULL,
	[IsChich_UongThuoc] [bit] NOT NULL,
	[IsTruyenDichTinhMach] [bit] NOT NULL,
	[Khac] [nvarchar](50) NULL,
	[LoiDanDo] [nvarchar](50) NULL,
	[TongTien] [bigint] NOT NULL,
	[CreateBy] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[UpdateBy] [nvarchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[DeleteFlag] [bit] NOT NULL,
 CONSTRAINT [PK_PhieuDieuTri] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[PhieuDieuTri] ON
INSERT [dbo].[PhieuDieuTri] ([Id], [IdPet], [Ma], [TrongLuong], [NhietDo], [TrieuChung], [IsKhamBenh], [IsChich_UongThuoc], [IsTruyenDichTinhMach], [Khac], [LoiDanDo], [TongTien], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [DeleteFlag]) VALUES (1, 1, N'P1    ', 8, N'BT', N'Test TC', 1, 1, 0, N'', N'Test LDD', 100000, N'admin', CAST(0x0000A61C012F98B8 AS DateTime), N'admin', CAST(0x0000A61C012F98B8 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[PhieuDieuTri] OFF
/****** Object:  Table [dbo].[PhieuDieuTri_Thuoc]    Script Date: 06/06/2016 00:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuDieuTri_Thuoc](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPhieuDieuTri] [int] NOT NULL,
	[IdThuoc] [int] NOT NULL,
	[LieuLuong] [float] NOT NULL,
	[DuongCap] [char](2) NOT NULL,
 CONSTRAINT [PK_PhieuDieuTri_Thuoc] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[PhieuDieuTri_Thuoc] ON
INSERT [dbo].[PhieuDieuTri_Thuoc] ([Id], [IdPhieuDieuTri], [IdThuoc], [LieuLuong], [DuongCap]) VALUES (1, 1, 1, 1, N'IM')
SET IDENTITY_INSERT [dbo].[PhieuDieuTri_Thuoc] OFF
/****** Object:  Default [DF_HoaDon_TongTien]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[HoaDon] ADD  CONSTRAINT [DF_HoaDon_TongTien]  DEFAULT ((0)) FOR [TongTien]
GO
/****** Object:  Default [DF_HoaDon_DeleteFlag]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[HoaDon] ADD  CONSTRAINT [DF_HoaDon_DeleteFlag]  DEFAULT ((0)) FOR [DeleteFlag]
GO
/****** Object:  Default [DF_KhachHang_GioiTinh]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[KhachHang] ADD  CONSTRAINT [DF_KhachHang_GioiTinh]  DEFAULT (N'Nam') FOR [GioiTinh]
GO
/****** Object:  Default [DF_KhachHang_DeleteFlag]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[KhachHang] ADD  CONSTRAINT [DF_KhachHang_DeleteFlag]  DEFAULT ((0)) FOR [DeleteFlag]
GO
/****** Object:  Default [DF_Pet_GioiTinh]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[Pet] ADD  CONSTRAINT [DF_Pet_GioiTinh]  DEFAULT (N'Đực') FOR [GioiTinh]
GO
/****** Object:  Default [DF_Pet_TrongLuong]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[Pet] ADD  CONSTRAINT [DF_Pet_TrongLuong]  DEFAULT ((5)) FOR [TrongLuong]
GO
/****** Object:  Default [DF_Pet_DeleteFlag]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[Pet] ADD  CONSTRAINT [DF_Pet_DeleteFlag]  DEFAULT ((0)) FOR [DeleteFlag]
GO
/****** Object:  Default [DF_PhieuDieuTri_NhietDo]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[PhieuDieuTri] ADD  CONSTRAINT [DF_PhieuDieuTri_NhietDo]  DEFAULT ('BT') FOR [NhietDo]
GO
/****** Object:  Default [DF_PhieuDieuTri_IsKhamBenh]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[PhieuDieuTri] ADD  CONSTRAINT [DF_PhieuDieuTri_IsKhamBenh]  DEFAULT ((1)) FOR [IsKhamBenh]
GO
/****** Object:  Default [DF_PhieuDieuTri_IsChichThuoc]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[PhieuDieuTri] ADD  CONSTRAINT [DF_PhieuDieuTri_IsChichThuoc]  DEFAULT ((1)) FOR [IsChich_UongThuoc]
GO
/****** Object:  Default [DF_PhieuDieuTri_IsTruyenDichTinhMach]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[PhieuDieuTri] ADD  CONSTRAINT [DF_PhieuDieuTri_IsTruyenDichTinhMach]  DEFAULT ((0)) FOR [IsTruyenDichTinhMach]
GO
/****** Object:  Default [DF_PhieuDieuTri_TongTien]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[PhieuDieuTri] ADD  CONSTRAINT [DF_PhieuDieuTri_TongTien]  DEFAULT ((0)) FOR [TongTien]
GO
/****** Object:  Default [DF_PhieuDieuTri_DeleteFlag]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[PhieuDieuTri] ADD  CONSTRAINT [DF_PhieuDieuTri_DeleteFlag]  DEFAULT ((0)) FOR [DeleteFlag]
GO
/****** Object:  Default [DF_PhieuDieuTri_Thuoc_SoLuong]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[PhieuDieuTri_Thuoc] ADD  CONSTRAINT [DF_PhieuDieuTri_Thuoc_SoLuong]  DEFAULT ((1)) FOR [LieuLuong]
GO
/****** Object:  Default [DF_PhieuDieuTri_Thuoc_DuongCap]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[PhieuDieuTri_Thuoc] ADD  CONSTRAINT [DF_PhieuDieuTri_Thuoc_DuongCap]  DEFAULT ('IM') FOR [DuongCap]
GO
/****** Object:  Default [DF_SanPham_DeleteFlag]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[SanPham] ADD  CONSTRAINT [DF_SanPham_DeleteFlag]  DEFAULT ((0)) FOR [DeleteFlag]
GO
/****** Object:  Default [DF_Thuoc_DeleteFlag]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[Thuoc] ADD  CONSTRAINT [DF_Thuoc_DeleteFlag]  DEFAULT ((0)) FOR [DeleteFlag]
GO
/****** Object:  Default [DF_User_GioiTinh]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_GioiTinh]  DEFAULT (N'Nam') FOR [GioiTinh]
GO
/****** Object:  Default [DF_User_DeleteFlag]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_DeleteFlag]  DEFAULT ((0)) FOR [DeleteFlag]
GO
/****** Object:  ForeignKey [FK_HoaDon_KhachHang]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([IdKhachHang])
REFERENCES [dbo].[KhachHang] ([Id])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
/****** Object:  ForeignKey [FK_HoaDon_SanPham_HoaDon]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[HoaDon_SanPham]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_SanPham_HoaDon] FOREIGN KEY([IdHoaDon])
REFERENCES [dbo].[HoaDon] ([Id])
GO
ALTER TABLE [dbo].[HoaDon_SanPham] CHECK CONSTRAINT [FK_HoaDon_SanPham_HoaDon]
GO
/****** Object:  ForeignKey [FK_HoaDon_SanPham_SanPham]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[HoaDon_SanPham]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_SanPham_SanPham] FOREIGN KEY([IdSanPham])
REFERENCES [dbo].[SanPham] ([Id])
GO
ALTER TABLE [dbo].[HoaDon_SanPham] CHECK CONSTRAINT [FK_HoaDon_SanPham_SanPham]
GO
/****** Object:  ForeignKey [FK_KhachHang_KhachHangGroup]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_KhachHangGroup] FOREIGN KEY([IdGroup])
REFERENCES [dbo].[KhachHangGroup] ([Id])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_KhachHangGroup]
GO
/****** Object:  ForeignKey [FK_Pet_KhachHang]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[Pet]  WITH CHECK ADD  CONSTRAINT [FK_Pet_KhachHang] FOREIGN KEY([IdKhachHang])
REFERENCES [dbo].[KhachHang] ([Id])
GO
ALTER TABLE [dbo].[Pet] CHECK CONSTRAINT [FK_Pet_KhachHang]
GO
/****** Object:  ForeignKey [FK_Pet_PetGroup]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[Pet]  WITH CHECK ADD  CONSTRAINT [FK_Pet_PetGroup] FOREIGN KEY([IdGroup])
REFERENCES [dbo].[PetGroup] ([Id])
GO
ALTER TABLE [dbo].[Pet] CHECK CONSTRAINT [FK_Pet_PetGroup]
GO
/****** Object:  ForeignKey [FK_PhieuDieuTri_Pet]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[PhieuDieuTri]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDieuTri_Pet] FOREIGN KEY([IdPet])
REFERENCES [dbo].[Pet] ([Id])
GO
ALTER TABLE [dbo].[PhieuDieuTri] CHECK CONSTRAINT [FK_PhieuDieuTri_Pet]
GO
/****** Object:  ForeignKey [FK_PhieuDieuTri_Thuoc_PhieuDieuTri]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[PhieuDieuTri_Thuoc]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDieuTri_Thuoc_PhieuDieuTri] FOREIGN KEY([IdPhieuDieuTri])
REFERENCES [dbo].[PhieuDieuTri] ([Id])
GO
ALTER TABLE [dbo].[PhieuDieuTri_Thuoc] CHECK CONSTRAINT [FK_PhieuDieuTri_Thuoc_PhieuDieuTri]
GO
/****** Object:  ForeignKey [FK_PhieuDieuTri_Thuoc_Thuoc]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[PhieuDieuTri_Thuoc]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDieuTri_Thuoc_Thuoc] FOREIGN KEY([IdThuoc])
REFERENCES [dbo].[Thuoc] ([Id])
GO
ALTER TABLE [dbo].[PhieuDieuTri_Thuoc] CHECK CONSTRAINT [FK_PhieuDieuTri_Thuoc_Thuoc]
GO
/****** Object:  ForeignKey [FK_User_UserGroup]    Script Date: 06/06/2016 00:02:47 ******/
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_UserGroup] FOREIGN KEY([IdGroup])
REFERENCES [dbo].[UserGroup] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_UserGroup]
GO
