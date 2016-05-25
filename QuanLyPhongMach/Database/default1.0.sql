USE [QuanLyPhongMach]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/20/2016 10:26:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[Id] [int] NOT NULL,
	[Ma] [varchar](10) NOT NULL,
	[IdGroup] [int] NOT NULL,
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHangGroup]    Script Date: 5/20/2016 10:26:14 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pet]    Script Date: 5/20/2016 10:26:14 PM ******/
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
	[DOB] [date] NULL,
	[GhiChu] [nvarchar](200) NULL,
	[CreateBy] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[UpdateBy] [nvarchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[DeleteFlag] [bit] NOT NULL,
 CONSTRAINT [PK_Pet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PetGroup]    Script Date: 5/20/2016 10:26:14 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuDieuTri]    Script Date: 5/20/2016 10:26:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuDieuTri](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ma] [char](6) NOT NULL,
	[IdPet] [int] NOT NULL,
	[IdUser] [int] NOT NULL,
	[TrongLuong] [float] NOT NULL,
	[NhietDo] [float] NOT NULL,
	[IsKhamBenh] [bit] NOT NULL,
	[IsChich_UongThuoc] [bit] NOT NULL,
	[IsTruyenDichTinhMach] [bit] NOT NULL,
	[Khac] [nvarchar](200) NULL,
	[LoiDanDo] [nvarchar](200) NULL,
	[TongTien] [bigint] NOT NULL,
	[CreateBy] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[UpdateBy] [nvarchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[DeleteFlag] [bit] NOT NULL,
 CONSTRAINT [PK_PhieuDieuTri] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuDieuTri_Thuoc]    Script Date: 5/20/2016 10:26:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDieuTri_Thuoc](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPhieuDieuTri] [int] NOT NULL,
	[IdThuoc] [int] NOT NULL,
	[LieuLuong] [float] NOT NULL,
 CONSTRAINT [PK_PhieuDieuTri_Thuoc] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 5/20/2016 10:26:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Thuoc](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ma] [varchar](10) NOT NULL,
	[IdGroup] [int] NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](200) NULL,
	[DonViTinh] [nvarchar](10) NOT NULL,
	[CreateBy] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[UpdateBy] [nvarchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[DeleteFlag] [bit] NOT NULL,
 CONSTRAINT [PK_Thuoc] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThuocGroup]    Script Date: 5/20/2016 10:26:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThuocGroup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ma] [varchar](2) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ThuocGroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 5/20/2016 10:26:14 PM ******/
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
	[DTDD] [nvarchar](20) NULL,
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserGroup]    Script Date: 5/20/2016 10:26:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserGroup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](20) NOT NULL,
	[Mota] [nvarchar](200) NULL,
 CONSTRAINT [PK_UserGroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[ThuocGroup] ON 

INSERT [dbo].[ThuocGroup] ([Id], [Ma], [Ten]) VALUES (1, N'IM', N'Chích bắp')
INSERT [dbo].[ThuocGroup] ([Id], [Ma], [Ten]) VALUES (2, N'IV', N'Chích vein')
INSERT [dbo].[ThuocGroup] ([Id], [Ma], [Ten]) VALUES (3, N'PO', N'Uống')
SET IDENTITY_INSERT [dbo].[ThuocGroup] OFF
ALTER TABLE [dbo].[KhachHang] ADD  CONSTRAINT [DF_KhachHang_GioiTinh]  DEFAULT (N'Nam') FOR [GioiTinh]
GO
ALTER TABLE [dbo].[KhachHang] ADD  CONSTRAINT [DF_KhachHang_DeleteFlag]  DEFAULT ((0)) FOR [DeleteFlag]
GO
ALTER TABLE [dbo].[Pet] ADD  CONSTRAINT [DF_Pet_GioiTinh]  DEFAULT (N'Duc') FOR [GioiTinh]
GO
ALTER TABLE [dbo].[Pet] ADD  CONSTRAINT [DF_Pet_DeleteFlag]  DEFAULT ((0)) FOR [DeleteFlag]
GO
ALTER TABLE [dbo].[PhieuDieuTri] ADD  CONSTRAINT [DF_PhieuDieuTri_IsKhamBenh]  DEFAULT ((1)) FOR [IsKhamBenh]
GO
ALTER TABLE [dbo].[PhieuDieuTri] ADD  CONSTRAINT [DF_PhieuDieuTri_IsChichThuoc]  DEFAULT ((1)) FOR [IsChich_UongThuoc]
GO
ALTER TABLE [dbo].[PhieuDieuTri] ADD  CONSTRAINT [DF_PhieuDieuTri_IsTruyenDichTinhMach]  DEFAULT ((0)) FOR [IsTruyenDichTinhMach]
GO
ALTER TABLE [dbo].[PhieuDieuTri] ADD  CONSTRAINT [DF_PhieuDieuTri_TongTien]  DEFAULT ((0)) FOR [TongTien]
GO
ALTER TABLE [dbo].[PhieuDieuTri] ADD  CONSTRAINT [DF_PhieuDieuTri_DeleteFlag]  DEFAULT ((0)) FOR [DeleteFlag]
GO
ALTER TABLE [dbo].[PhieuDieuTri_Thuoc] ADD  CONSTRAINT [DF_PhieuDieuTri_Thuoc_SoLuong]  DEFAULT ((1)) FOR [LieuLuong]
GO
ALTER TABLE [dbo].[Thuoc] ADD  CONSTRAINT [DF_Thuoc_DonViTinh]  DEFAULT (N'cc') FOR [DonViTinh]
GO
ALTER TABLE [dbo].[Thuoc] ADD  CONSTRAINT [DF_Thuoc_DeleteFlag]  DEFAULT ((0)) FOR [DeleteFlag]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_GioiTinh]  DEFAULT (N'Nam') FOR [GioiTinh]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_DeleteFlag]  DEFAULT ((0)) FOR [DeleteFlag]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_KhachHangGroup] FOREIGN KEY([IdGroup])
REFERENCES [dbo].[KhachHangGroup] ([Id])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_KhachHangGroup]
GO
ALTER TABLE [dbo].[Pet]  WITH CHECK ADD  CONSTRAINT [FK_Pet_KhachHang] FOREIGN KEY([IdKhachHang])
REFERENCES [dbo].[KhachHang] ([Id])
GO
ALTER TABLE [dbo].[Pet] CHECK CONSTRAINT [FK_Pet_KhachHang]
GO
ALTER TABLE [dbo].[Pet]  WITH CHECK ADD  CONSTRAINT [FK_Pet_PetGroup] FOREIGN KEY([IdGroup])
REFERENCES [dbo].[PetGroup] ([Id])
GO
ALTER TABLE [dbo].[Pet] CHECK CONSTRAINT [FK_Pet_PetGroup]
GO
ALTER TABLE [dbo].[PhieuDieuTri]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDieuTri_Pet] FOREIGN KEY([IdPet])
REFERENCES [dbo].[Pet] ([Id])
GO
ALTER TABLE [dbo].[PhieuDieuTri] CHECK CONSTRAINT [FK_PhieuDieuTri_Pet]
GO
ALTER TABLE [dbo].[PhieuDieuTri]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDieuTri_User] FOREIGN KEY([IdUser])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[PhieuDieuTri] CHECK CONSTRAINT [FK_PhieuDieuTri_User]
GO
ALTER TABLE [dbo].[PhieuDieuTri_Thuoc]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDieuTri_Thuoc_PhieuDieuTri] FOREIGN KEY([IdPhieuDieuTri])
REFERENCES [dbo].[PhieuDieuTri] ([Id])
GO
ALTER TABLE [dbo].[PhieuDieuTri_Thuoc] CHECK CONSTRAINT [FK_PhieuDieuTri_Thuoc_PhieuDieuTri]
GO
ALTER TABLE [dbo].[PhieuDieuTri_Thuoc]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDieuTri_Thuoc_Thuoc] FOREIGN KEY([IdThuoc])
REFERENCES [dbo].[Thuoc] ([Id])
GO
ALTER TABLE [dbo].[PhieuDieuTri_Thuoc] CHECK CONSTRAINT [FK_PhieuDieuTri_Thuoc_Thuoc]
GO
ALTER TABLE [dbo].[Thuoc]  WITH CHECK ADD  CONSTRAINT [FK_Thuoc_ThuocGroup] FOREIGN KEY([IdGroup])
REFERENCES [dbo].[ThuocGroup] ([Id])
GO
ALTER TABLE [dbo].[Thuoc] CHECK CONSTRAINT [FK_Thuoc_ThuocGroup]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_UserGroup] FOREIGN KEY([IdGroup])
REFERENCES [dbo].[UserGroup] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_UserGroup]
GO
