USE [QuanLyKTXSV]
GO
/****** Object:  Table [dbo].[Loaiphong]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loaiphong](
	[MaLP] [nchar](10) NOT NULL,
	[TenLP] [nchar](10) NOT NULL,
	[Tiendien] [int] NULL,
	[Tiennuoc] [int] NULL,
 CONSTRAINT [PK_Loaiphong] PRIMARY KEY CLUSTERED 
(
	[MaLP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phieudathutien]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phieudathutien](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Sonuoc] [int] NULL,
	[Tongtiennuoc] [int] NULL,
	[Sodien] [int] NULL,
	[Tongtiendien] [int] NOT NULL,
	[Tongtien] [int] NULL,
	[Maphong] [int] NULL,
 CONSTRAINT [PK_Phieudathutien] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[Maphong] [int] NOT NULL,
	[Toanha] [nchar](10) NULL,
	[Sodien] [int] NULL,
	[Sonuoc] [int] NULL,
	[Loaiphong] [nchar](10) NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[Maphong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sinhvien]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sinhvien](
	[MSSV] [int] NOT NULL,
	[Hoten] [nchar](10) NULL,
	[Gioitinh] [nchar](10) NULL,
	[Truonghoc] [nchar](10) NULL,
	[Ngaysinh] [date] NULL,
	[SoDT] [nchar](10) NOT NULL,
	[Noisinh] [int] NULL,
	[Maphong] [int] NOT NULL,
 CONSTRAINT [PK_Sinhvien] PRIMARY KEY CLUSTERED 
(
	[MSSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Taikhoan]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Taikhoan](
	[username] [nchar](10) NOT NULL,
	[password] [nchar](10) NULL,
 CONSTRAINT [PK_Taikhoan] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thanhpho]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thanhpho](
	[MaTP] [int] NOT NULL,
	[TenTP] [nchar](10) NULL,
 CONSTRAINT [PK_Thanhpho] PRIMARY KEY CLUSTERED 
(
	[MaTP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Truong]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Truong](
	[Matruong] [nchar](10) NOT NULL,
	[Tentruong] [nchar](50) NULL,
 CONSTRAINT [PK_Truong] PRIMARY KEY CLUSTERED 
(
	[Matruong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Loaiphong] ([MaLP], [TenLP], [Tiendien], [Tiennuoc]) VALUES (N'CC        ', N'Cao Cấp   ', 4000, 16000)
INSERT [dbo].[Loaiphong] ([MaLP], [TenLP], [Tiendien], [Tiennuoc]) VALUES (N'HS        ', N'Hạng sang ', 2500, 13000)
INSERT [dbo].[Loaiphong] ([MaLP], [TenLP], [Tiendien], [Tiennuoc]) VALUES (N'ML        ', N'Máy lạnh  ', 4000, 15000)
INSERT [dbo].[Loaiphong] ([MaLP], [TenLP], [Tiendien], [Tiennuoc]) VALUES (N'TH        ', N'Thường    ', 3000, 13000)
SET IDENTITY_INSERT [dbo].[Phieudathutien] ON 

INSERT [dbo].[Phieudathutien] ([id], [Sonuoc], [Tongtiennuoc], [Sodien], [Tongtiendien], [Tongtien], [Maphong]) VALUES (2, 9, 117000, 25, 75000, 192000, 102)
INSERT [dbo].[Phieudathutien] ([id], [Sonuoc], [Tongtiennuoc], [Sodien], [Tongtiendien], [Tongtien], [Maphong]) VALUES (3, 30, 120000, 8, 120000, 240000, 103)
INSERT [dbo].[Phieudathutien] ([id], [Sonuoc], [Tongtiennuoc], [Sodien], [Tongtiendien], [Tongtien], [Maphong]) VALUES (12, 35, 320000, 20, 140000, 460000, 101)
SET IDENTITY_INSERT [dbo].[Phieudathutien] OFF
INSERT [dbo].[Phong] ([Maphong], [Toanha], [Sodien], [Sonuoc], [Loaiphong]) VALUES (101, N'B04       ', 35, 20, N'CC        ')
INSERT [dbo].[Phong] ([Maphong], [Toanha], [Sodien], [Sonuoc], [Loaiphong]) VALUES (102, N'B04       ', 25, 9, N'TH        ')
INSERT [dbo].[Phong] ([Maphong], [Toanha], [Sodien], [Sonuoc], [Loaiphong]) VALUES (103, N'B04       ', 30, 8, N'ML        ')
INSERT [dbo].[Phong] ([Maphong], [Toanha], [Sodien], [Sonuoc], [Loaiphong]) VALUES (104, N'B04       ', 40, 15, N'CC        ')
INSERT [dbo].[Sinhvien] ([MSSV], [Hoten], [Gioitinh], [Truonghoc], [Ngaysinh], [SoDT], [Noisinh], [Maphong]) VALUES (16110170, N'Phan Cường', N'Nam       ', N'SPK       ', CAST(N'1998-08-09' AS Date), N'0945347898', 93, 102)
INSERT [dbo].[Sinhvien] ([MSSV], [Hoten], [Gioitinh], [Truonghoc], [Ngaysinh], [SoDT], [Noisinh], [Maphong]) VALUES (16110174, N'Phát Đoàn ', N'Nam       ', N'SPK       ', CAST(N'1998-12-08' AS Date), N'091234576 ', 93, 103)
INSERT [dbo].[Sinhvien] ([MSSV], [Hoten], [Gioitinh], [Truonghoc], [Ngaysinh], [SoDT], [Noisinh], [Maphong]) VALUES (16110177, N'DoanPhat  ', N'Nam       ', N'SPK       ', CAST(N'1998-12-08' AS Date), N'0975547178', 93, 102)
INSERT [dbo].[Sinhvien] ([MSSV], [Hoten], [Gioitinh], [Truonghoc], [Ngaysinh], [SoDT], [Noisinh], [Maphong]) VALUES (16110178, N'Bupcandy  ', N'Nữ        ', N'BUH       ', CAST(N'1998-01-01' AS Date), N'0399757557', 93, 102)
INSERT [dbo].[Sinhvien] ([MSSV], [Hoten], [Gioitinh], [Truonghoc], [Ngaysinh], [SoDT], [Noisinh], [Maphong]) VALUES (16110193, N'Doan      ', N'          ', N'QHT       ', CAST(N'1998-09-19' AS Date), N'0975547178', 85, 103)
INSERT [dbo].[Sinhvien] ([MSSV], [Hoten], [Gioitinh], [Truonghoc], [Ngaysinh], [SoDT], [Noisinh], [Maphong]) VALUES (16110199, N'Ha_Ha     ', N'          ', N'SPK       ', CAST(N'1998-08-09' AS Date), N'0975547178', 93, 101)
INSERT [dbo].[Sinhvien] ([MSSV], [Hoten], [Gioitinh], [Truonghoc], [Ngaysinh], [SoDT], [Noisinh], [Maphong]) VALUES (16123123, N'Văn Tèo   ', N'          ', N'BUH       ', CAST(N'1998-12-03' AS Date), N'0912543678', 61, 101)
INSERT [dbo].[Sinhvien] ([MSSV], [Hoten], [Gioitinh], [Truonghoc], [Ngaysinh], [SoDT], [Noisinh], [Maphong]) VALUES (16458123, N'Lê Thị Bé ', N'          ', N'QHT       ', CAST(N'1998-12-03' AS Date), N'097645321 ', 85, 102)
INSERT [dbo].[Taikhoan] ([username], [password]) VALUES (N'admin     ', N'123       ')
INSERT [dbo].[Taikhoan] ([username], [password]) VALUES (N'beobanhbo ', N'1234      ')
INSERT [dbo].[Taikhoan] ([username], [password]) VALUES (N'buple     ', N'123       ')
INSERT [dbo].[Taikhoan] ([username], [password]) VALUES (N'phatdoan  ', N'123       ')
INSERT [dbo].[Thanhpho] ([MaTP], [TenTP]) VALUES (59, N'TP Hồ Chí ')
INSERT [dbo].[Thanhpho] ([MaTP], [TenTP]) VALUES (60, N'Đồng Nai  ')
INSERT [dbo].[Thanhpho] ([MaTP], [TenTP]) VALUES (61, N'Bình Dương')
INSERT [dbo].[Thanhpho] ([MaTP], [TenTP]) VALUES (85, N'Ninh Thuận')
INSERT [dbo].[Thanhpho] ([MaTP], [TenTP]) VALUES (86, N'Bình Thuận')
INSERT [dbo].[Thanhpho] ([MaTP], [TenTP]) VALUES (93, N'Bình Phước')
INSERT [dbo].[Truong] ([Matruong], [Tentruong]) VALUES (N'BUH       ', N'ĐH Ngân Hàng Tp HCM                               ')
INSERT [dbo].[Truong] ([Matruong], [Tentruong]) VALUES (N'GHA       ', N'ĐH Giao Thông Vận Tải                             ')
INSERT [dbo].[Truong] ([Matruong], [Tentruong]) VALUES (N'QHT       ', N'ĐH Khoa Học Tự Nhiên                              ')
INSERT [dbo].[Truong] ([Matruong], [Tentruong]) VALUES (N'SPK       ', N'ĐH SPKT TPHCM                                     ')
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK_Phong_Loaiphong] FOREIGN KEY([Loaiphong])
REFERENCES [dbo].[Loaiphong] ([MaLP])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_Loaiphong]
GO
ALTER TABLE [dbo].[Sinhvien]  WITH CHECK ADD  CONSTRAINT [FK_Sinhvien_Phong] FOREIGN KEY([Maphong])
REFERENCES [dbo].[Phong] ([Maphong])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sinhvien] CHECK CONSTRAINT [FK_Sinhvien_Phong]
GO
ALTER TABLE [dbo].[Sinhvien]  WITH CHECK ADD  CONSTRAINT [FK_Sinhvien_Thanhpho] FOREIGN KEY([Noisinh])
REFERENCES [dbo].[Thanhpho] ([MaTP])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sinhvien] CHECK CONSTRAINT [FK_Sinhvien_Thanhpho]
GO
ALTER TABLE [dbo].[Sinhvien]  WITH CHECK ADD  CONSTRAINT [FK_Sinhvien_Truong] FOREIGN KEY([Truonghoc])
REFERENCES [dbo].[Truong] ([Matruong])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sinhvien] CHECK CONSTRAINT [FK_Sinhvien_Truong]
GO
/****** Object:  StoredProcedure [dbo].[ups_CapnhatLP]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[ups_CapnhatLP]
   @MaLP nchar(10),
  @TenLP nchar(10),
  @Tiendien money,
  @Tiennuoc money
AS 
BEGIN 
UPDATE Loaiphong
SET   TenLP=@TenLP,
      Tiendien=@Tiendien,
	  Tiennuoc=@Tiennuoc
        
WHERE MaLP=@MaLP
END 
GO
/****** Object:  StoredProcedure [dbo].[ups_CapnhatPhong]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ups_CapnhatPhong]
   @Maphong int,
   @Toanha nvarchar(10),
   @Sodien int,
   @Sonuoc int,
  
   @Loaiphong nvarchar(10)
AS 
BEGIN 
UPDATE Phong
SET 
  Toanha= @Toanha,
  Sodien= @Sodien,
  Sonuoc= @Sonuoc,
   Loaiphong=@Loaiphong
WHERE Maphong = @Maphong
END 
GO
/****** Object:  StoredProcedure [dbo].[ups_CapnhatSV]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[ups_CapnhatSV]
   @MSSV int,
   @Hoten nvarchar(10),
   @Gioitinh nvarchar(10),
   @Truonghoc nvarchar(10),
   @Ngaysinh date,
   @SoDT nvarchar(10),
   @Noisinh	int,
   @Maphong int
AS 
BEGIN 
UPDATE Sinhvien
SET  Hoten = @Hoten,
     Gioitinh= @Gioitinh,
	 Truonghoc= @Truonghoc,
	 Ngaysinh=@Ngaysinh,
	 SoDT= @SoDT,
	 Noisinh=@Noisinh,
	 Maphong = @Maphong


WHERE MSSV = @MSSV
END 
GO
/****** Object:  StoredProcedure [dbo].[ups_CapnhatTK]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[ups_CapnhatTK]
    @username nchar(10),
  @password nchar(10)
AS 
BEGIN 
UPDATE Taikhoan
SET  password = @password
WHERE username=@username
END 
GO
/****** Object:  StoredProcedure [dbo].[ups_CapnhatTP]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[ups_CapnhatTP]
   @MaTP int,
   @TenTP nchar(10)
AS 
BEGIN 
UPDATE Thanhpho
SET  TenTP = @TenTP
WHERE MaTP = @MaTP
END 
GO
/****** Object:  StoredProcedure [dbo].[ups_CapnhatTruong]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[ups_CapnhatTruong]
  @Matruong nchar(10),
  @Tentruong nchar(50)
AS 
BEGIN 
UPDATE Truong
SET  Tentruong = @Tentruong
WHERE Matruong = @Matruong
END 
GO
/****** Object:  StoredProcedure [dbo].[ups_XoaLP]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[ups_XoaLP]
 @MaLP nchar(10)
AS 
BEGIN 
DELETE FROM Loaiphong
WHERE MaLP=@MaLP
END 
GO
/****** Object:  StoredProcedure [dbo].[ups_XoaPhieuthutien]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[ups_XoaPhieuthutien]
 @Maphong int
AS 
BEGIN 
DELETE FROM Phieudathutien
WHERE Maphong=@Maphong
END 
GO
/****** Object:  StoredProcedure [dbo].[ups_XoaPhong]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[ups_XoaPhong]
@Maphong int
AS 
BEGIN 
DELETE FROM Phong
WHERE Maphong = @Maphong
END 
GO
/****** Object:  StoredProcedure [dbo].[ups_XoaSV]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[ups_XoaSV]
@MSSV int
AS 
BEGIN 
DELETE FROM Sinhvien
WHERE MSSV = @MSSV
END 
GO
/****** Object:  StoredProcedure [dbo].[ups_XoaTK]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[ups_XoaTK]
  @username nchar(10)
AS 
BEGIN 
DELETE FROM Taikhoan
WHERE username=@username
END 
GO
/****** Object:  StoredProcedure [dbo].[ups_XoaTP]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[ups_XoaTP]
@MaTP int
AS 
BEGIN 
DELETE FROM Thanhpho
WHERE MaTP = @MaTP
END 
GO
/****** Object:  StoredProcedure [dbo].[ups_XoaTruong]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[ups_XoaTruong]
 @Matruong nchar(10)
AS 
BEGIN 
DELETE FROM Truong
WHERE Matruong=@Matruong
END 
GO
/****** Object:  StoredProcedure [dbo].[usp_Danhsachphong]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[usp_Danhsachphong]
AS 
BEGIN 
SELECT* FROM Loaiphong
END 
GO
/****** Object:  StoredProcedure [dbo].[usp_DanhsachSV]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_DanhsachSV]
  
AS 
BEGIN 
SELECT MSSV,Hoten,Ngaysinh,Tentruong,TenTP,Maphong,Gioitinh,SoDT FROM Sinhvien,Truong,Thanhpho
WHERE Sinhvien.Truonghoc=Truong.Matruong AND Sinhvien.Noisinh=Thanhpho.MaTP
END 
GO
/****** Object:  StoredProcedure [dbo].[usp_DemSLSVtrongPhong]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_DemSLSVtrongPhong]
  @Maphong int
AS 
BEGIN 
    SELECT Count(*) from Sinhvien
    WHERE Sinhvien.Maphong=@Maphong
END 
GO
/****** Object:  StoredProcedure [dbo].[usp_DS_Taikhoan]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[usp_DS_Taikhoan]
  
AS 
BEGIN 
SELECT* FROM Taikhoan
END 
GO
/****** Object:  StoredProcedure [dbo].[usp_DSPhong]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_DSPhong]
 
AS 
BEGIN 
    Select Maphong,Toanha,Sodien,Sonuoc,TenLP,MaLP from Phong,Loaiphong
    Where Phong.Loaiphong= Loaiphong.MaLP
END 
GO
/****** Object:  StoredProcedure [dbo].[usp_KTDN_TK]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[usp_KTDN_TK]
   @username nchar(10),
   @password nchar(10)
AS 
BEGIN 
   SELECT*FROM Taikhoan
   WHERE username=@username AND password=@password
END 
GO
/****** Object:  StoredProcedure [dbo].[usp_LocDSSVtheoMSSV]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_LocDSSVtheoMSSV]
   @MSSV int
AS 
BEGIN 
SELECT MSSV,Hoten,Ngaysinh,Tentruong,TenTP,Maphong,SoDT FROM Sinhvien,Truong,Thanhpho
WHERE Sinhvien.Truonghoc=Truong.Matruong AND Sinhvien.Noisinh=Thanhpho.MaTP AND Sinhvien.MSSV=@MSSV
END 
GO
/****** Object:  StoredProcedure [dbo].[usp_LocSVtheoPhong]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_LocSVtheoPhong]
   @Maphong int
AS 
BEGIN 
SELECT MSSV,Hoten,Ngaysinh,Tentruong,TenTP,Maphong,SoDT FROM Sinhvien,Truong,Thanhpho
WHERE Sinhvien.Truonghoc=Truong.Matruong AND Sinhvien.Noisinh=Thanhpho.MaTP AND Sinhvien.Maphong=@Maphong
END 
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemLP]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[usp_ThemLP]
  @MaLP nchar(10),
  @TenLP nchar(10),
  @Tiendien money,
  @Tiennuoc money

AS
BEGIN
     INSERT INTO Loaiphong(MaLP,TenLP,Tiendien,Tiennuoc)
     VALUES(@MaLP,@TenLP,@Tiendien,@Tiennuoc)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Themphieudathu]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[usp_Themphieudathu]
  @Sonuoc int,
  @Tongtiennuoc int,
  @Sodien int,
  @Tongtiendien int,
  @Tongtien int,
  @Maphong int

AS
BEGIN
     INSERT INTO Phieudathutien(Sonuoc,Tongtiennuoc,Sodien,Tongtiendien,Tongtien,Maphong)
     VALUES(@Sonuoc,@Tongtiennuoc,@Sodien,@Tongtiendien,@Tongtien,@Maphong);
END
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemSV]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[usp_ThemSV]
   @MSSV int,
   @Hoten nvarchar(10),
   @Gioitinh nvarchar(10),
   @Truonghoc nvarchar(10),
   @Ngaysinh date,
   @SoDT nvarchar(10),
   @Noisinh	int,
   @Maphong int

AS
BEGIN
     INSERT INTO Sinhvien(MSSV,Hoten,Gioitinh,Truonghoc,Ngaysinh,SoDT,Noisinh,Maphong)
     VALUES(@MSSV,@Hoten,@Gioitinh,@Truonghoc,@Ngaysinh,@SoDT,@Noisinh,@Maphong)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemTK]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[usp_ThemTK]
  @username nchar(10),
  @password nchar(10)

AS
BEGIN
     INSERT INTO Taikhoan(username,password)
     VALUES(@username,@password)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemTP]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[usp_ThemTP]
  @MaTP int,
  @TenTP nchar(10)

AS
BEGIN
     INSERT INTO Thanhpho(MaTP,TenTP)
     VALUES(@MaTP,@TenTP)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemTruong]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[usp_ThemTruong]
  @Matruong nchar(10),
  @Tentruong nchar(50)

AS
BEGIN
     INSERT INTO Truong(Matruong,Tentruong)
     VALUES(@Matruong,@Tentruong)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_TheuPhong]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_TheuPhong]
   @Maphong int,
   @Toanha nvarchar(10),
   @Sodien int,
   @Sonuoc int,
   
   @Loaiphong nvarchar(10)
   

AS
BEGIN
     INSERT INTO Phong(Maphong,Toanha,Sodien,Sonuoc,Loaiphong)
     VALUES(@Maphong,@Toanha,@Sodien,@Sonuoc,@Loaiphong)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Thongkediennuoc]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[usp_Thongkediennuoc]
AS
BEGIN
     SELECT SUM(Sonuoc) AS Tongsonuoc1T,SUM(Tongtiennuoc) AS Tongtiennuoc1T,SUM(Sodien) AS Tongsodien1T,SUM(Tongtiendien) AS Tongtiendien1T,SUM(Tongtien) AS Tongtien1T FROM Phieudathutien
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Tiendiennuoc]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Tiendiennuoc]
   @Maphong int
AS 
BEGIN 
Select Tiendien*Sodien AS Thanhtiendien, Tiennuoc*Sonuoc AS Thanhtiennuoc,Maphong,(Tiendien*Sodien+Tiennuoc*Sonuoc) AS Tong,Sodien,Sonuoc from Loaiphong,Phong
Where Loaiphong.MaLP=Phong.Loaiphong  AND Phong.Maphong=@Maphong

END 
GO
/****** Object:  Trigger [dbo].[T_R_KTinphieuD_N]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create trigger [dbo].[T_R_KTinphieuD_N] ON [dbo].[Phieudathutien]
INSTEAD OF INSERT
AS
  BEGIN 
	IF EXISTS (SELECT * FROM inserted WHERE inserted.Maphong IN
	(
	SELECT Maphong FROM Phieudathutien))
   BEGIN 
   PRINT N' Phieu dien nuoc da duoc in'
   ROLLBACK TRAN
   END
   ELSE
    BEGIN
    DECLARE  @Sonuoc int
	DECLARE  @Tongtiennuoc int
	DECLARE  @Sodien int
	DECLARE  @Tongtiendien int
	DECLARE  @Tongtien int
	DECLARE  @Maphong int
    
    SELECT @Sonuoc = Sonuoc, @Tongtiennuoc=Tongtiennuoc,
	       @Sodien=Sodien,@Tongtiendien=Tongtiendien,
		   @Tongtien=Tongtien,@Maphong=Maphong FROM inserted
    INSERT INTO Phieudathutien(Sonuoc,Tongtiennuoc,Sodien,Tongtiendien,Tongtien,Maphong)
     VALUES(@Sonuoc,@Tongtiennuoc,@Sodien,@Tongtiendien,@Tongtien,@Maphong)
  END
 END
GO
ALTER TABLE [dbo].[Phieudathutien] ENABLE TRIGGER [T_R_KTinphieuD_N]
GO
/****** Object:  Trigger [dbo].[tr_SLSVtrongPhong]    Script Date: 5/19/2019 9:23:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[tr_SLSVtrongPhong] On [dbo].[Sinhvien] For Insert
As
 If (Select Count(a.Maphong)
     From Sinhvien a Inner Join INSERTED b On a.Maphong = b.Maphong) > 4
 Begin
   Print 'Phòng không còn chỗ'
   RollBack Tran
 End
GO
ALTER TABLE [dbo].[Sinhvien] ENABLE TRIGGER [tr_SLSVtrongPhong]
GO
