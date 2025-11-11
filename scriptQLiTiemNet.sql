USE [QLi Tiem Net]
GO
/****** Object:  Table [dbo].[GoiChoi]    Script Date: 4/11/2025 7:21:23 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GoiChoi](
	[MaGoi] [nvarchar](50) NULL,
	[TenGoi] [nvarchar](50) NULL,
	[GiaTien] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonAn]    Script Date: 4/11/2025 7:21:24 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonAn](
	[MaMonAn] [nvarchar](50) NULL,
	[TenMonAn] [nvarchar](50) NULL,
	[GiaTien] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoUong]    Script Date: 7/11/2025 2:02:41 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoUong](
	[MaDoUong] [nvarchar](50) NULL,
	[TenDoUong] [nvarchar](50) NULL,
	[GiaTien] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[GoiChoi] ([MaGoi], [TenGoi], [GiaTien]) VALUES (N'G1', N'10.000 VND - 1 giờ chơi', N'10000')
INSERT [dbo].[GoiChoi] ([MaGoi], [TenGoi], [GiaTien]) VALUES (N'G2', N'20.000 VND - 2 giờ chơi', N'20000')
INSERT [dbo].[GoiChoi] ([MaGoi], [TenGoi], [GiaTien]) VALUES (N'G3', N'50.000 VND - 5 giờ chơi', N'30000')
INSERT [dbo].[GoiChoi] ([MaGoi], [TenGoi], [GiaTien]) VALUES (N'G4', N'100.000 VND - 10 giờ chơi', N'100000')
INSERT [dbo].[GoiChoi] ([MaGoi], [TenGoi], [GiaTien]) VALUES (N'G5', N'200.000 VND - 20 giờ chơi', N'200000')
INSERT [dbo].[GoiChoi] ([MaGoi], [TenGoi], [GiaTien]) VALUES (N'G6', N'500.000 VND - 50 giờ chơi', N'500000')
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [GiaTien]) VALUES (N'ID1', N'Mì xào bò', N'35000')
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [GiaTien]) VALUES (N'ID2', N'Cơm chiên hải sản', N'35000')
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [GiaTien]) VALUES (N'ID3', N'Cơm chiên trứng', N'25000')
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [GiaTien]) VALUES (N'ID4', N'Mì xào giòn hải sản', N'40000')
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [GiaTien]) VALUES (N'ID5', N'Cơm gà chiên ', N'45000')
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [GiaTien]) VALUES (N'ID6', N'Canh rong biển', N'10000')
GO
INSERT [dbo].[DoUong] ([MaDoUong], [TenDoUong], [GiaTien]) VALUES (N'A1', N'Trà sữa trân châu đen', N'35000')
INSERT [dbo].[DoUong] ([MaDoUong], [TenDoUong], [GiaTien]) VALUES (N'A2', N'Trà xanh 0 độ', N'15000')
INSERT [dbo].[DoUong] ([MaDoUong], [TenDoUong], [GiaTien]) VALUES (N'A3', N'Nước suối', N'10000')
INSERT [dbo].[DoUong] ([MaDoUong], [TenDoUong], [GiaTien]) VALUES (N'A4', N'Pepsi', N'15000')
INSERT [dbo].[DoUong] ([MaDoUong], [TenDoUong], [GiaTien]) VALUES (N'A5', N'Matcha Latte', N'35000')
GO


