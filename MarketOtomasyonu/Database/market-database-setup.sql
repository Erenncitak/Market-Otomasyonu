-- =============================================
-- Market Database Setup Script
-- Created: 14.01.2026
-- Description: Complete database schema and sample data
-- =============================================

USE [master]
GO

-- Create Database
CREATE DATABASE [market]
GO

USE [market]
GO

-- =============================================
-- TABLES
-- =============================================

-- Login Table
CREATE TABLE [dbo].[loginTable](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciAdi] [varchar](50) NOT NULL,
	[sifre] [varchar](50) NOT NULL,
	[yetki] [varchar](20) NOT NULL,
	[bolge] [varchar](50) NULL,
	[emailAdres] [varchar](100) NOT NULL,
	[guvenlikSorusu] [varchar](200) NULL,
	[guvenlikCevabi] [varchar](70) NULL,
 CONSTRAINT [PK_loginTable] PRIMARY KEY CLUSTERED ([id] ASC),
 CONSTRAINT [unieque_user] UNIQUE NONCLUSTERED ([kullaniciAdi] ASC)
)
GO

-- Product Table
CREATE TABLE [dbo].[urun](
	[id] [varchar](10) NOT NULL,
	[qrkod] [varchar](50) NULL,
	[barkodKod] [varchar](50) NULL,
	[olusturulma_Tarih] [datetime] NULL,
	[guncellenme_Tarih] [datetime] NULL,
	[urunIsim] [varchar](50) NULL,
	[kilo] [float] NULL,
	[fiyat] [int] NULL,
	[ciro] [int] NULL,
 CONSTRAINT [PK_urun] PRIMARY KEY CLUSTERED ([id] ASC),
 CONSTRAINT [unieque_barkod] UNIQUE NONCLUSTERED ([barkodKod] ASC)
)
GO

-- =============================================
-- SAMPLE DATA
-- =============================================

-- Insert Users
SET IDENTITY_INSERT [dbo].[loginTable] ON 
GO

INSERT [dbo].[loginTable] ([id], [kullaniciAdi], [sifre], [yetki], [bolge], [emailAdres], [guvenlikSorusu], [guvenlikCevabi]) VALUES 
(1, N'eren', N'111', N'admin', N'Adalar', N'marketotomasyonumail@gmail.com', N'En sevdiğiniz hayvan nedir', N'köpek'),
(2, N'bilal', N'222', N'kasiyer', N'Arnavutköy', N'marketotomasyonu2@hotmail.com', N'En sevdiğiniz araba?', N'audi'),
(3, N'yakup', N'333', N'kasiyer', N'Ataşehir', N'yakup@gmail.com', N'Birinci sınıf öğretmeninizin ismi?', N'Beyhan'),
(4, N'aysun', N'444', N'kasiyer', N'Avcılar', N'aysun@gmail.com', N'En sevdiğiniz hayvanınızın ismi?', N'Minnoş'),
(5, N'yusuf', N'555', N'kasiyer', N'Bağcılar', N'yusuf@gmail.com', N'Annenizin kızlık soyadı nedir?', N'Aktaş'),
(6, N'mehmet', N'666', N'kasiyer', N'Bakırköy', N'mehmet@gmail.com', N'Hangi şehirde doğdunuz?', N'İstanbul'),
(7, N'mustafa', N'777', N'kasiyer', N'Beyoğlu', N'mustafa@gmail.com', N'Babanızın ortanca ismi nedir?', N'Ahmet'),
(8, N'sercan', N'888', N'kasiyer', N'Çatalca', N'sercan@gmail.com', N'Çocukluk lakabınız nedir?', N'Seco'),
(9, N'ismet', N'999', N'kasiyer', N'Çekmeköy', N'ismet@gmail.com', N'İlk telefonunuzun modeli nedir?', N'Huawei'),
(10, N'murat', N'121', N'kasiyer', N'Sancaktepe', N'murat@gmail.com', N'Çocukluk lakabınız nedir?', N'Muro')
GO

SET IDENTITY_INSERT [dbo].[loginTable] OFF
GO

-- Insert Products
INSERT [dbo].[urun] ([id], [qrkod], [barkodKod], [olusturulma_Tarih], [guncellenme_Tarih], [urunIsim], [kilo], [fiyat], [ciro]) VALUES 
(N'101112', NULL, N'2552441210', CAST(N'2021-04-03T00:00:00.000' AS DateTime), CAST(N'2021-05-03T00:00:00.000' AS DateTime), N'Elma', 87, 2, 12500),
(N'101113', NULL, N'2552441211', CAST(N'2021-04-03T00:00:00.000' AS DateTime), CAST(N'2021-05-03T00:00:00.000' AS DateTime), N'Muz', 172, 8, 2750),
(N'101114', NULL, N'2552441212', CAST(N'2021-04-03T00:00:00.000' AS DateTime), CAST(N'2021-05-03T00:00:00.000' AS DateTime), N'Brokoli', 130, 10, 5244),
(N'101115', N'', N'2552441213', CAST(N'2021-04-03T00:00:00.000' AS DateTime), CAST(N'2021-05-22T00:00:00.000' AS DateTime), N'Üzüm', 234, 5, 1253),
(N'101116', NULL, N'2552441214', CAST(N'2021-04-03T00:00:00.000' AS DateTime), CAST(N'2021-05-03T00:00:00.000' AS DateTime), N'Lahana', 82, 15, 6578),
(N'101117', NULL, N'2552441215', CAST(N'2021-04-03T00:00:00.000' AS DateTime), CAST(N'2021-05-03T00:00:00.000' AS DateTime), N'Portakal', 276, 6, 3421),
(N'101118', NULL, N'2552441216', CAST(N'2021-04-03T00:00:00.000' AS DateTime), CAST(N'2021-05-03T00:00:00.000' AS DateTime), N'Mandalina', 189, 7, 4532),
(N'101119', NULL, N'2552441217', CAST(N'2021-04-03T00:00:00.000' AS DateTime), CAST(N'2021-05-03T00:00:00.000' AS DateTime), N'Çilek', 95, 12, 8721),
(N'101120', NULL, N'2552441218', CAST(N'2021-04-03T00:00:00.000' AS DateTime), CAST(N'2021-05-03T00:00:00.000' AS DateTime), N'Kavun', 345, 4, 2134)
GO

-- =============================================
-- STORED PROCEDURES
-- =============================================

-- Login Procedure
CREATE PROCEDURE [dbo].[login_sp]
(
	@kullaniciAdi varchar(50),
	@sifre varchar(30)
)
AS
BEGIN
	SELECT COUNT(*) FROM loginTable WHERE kullaniciAdi = @kullaniciAdi AND sifre = @sifre
END
GO

-- Get Security Question
CREATE PROCEDURE [dbo].[guvenlikSorusuGetir_sp]
AS
BEGIN
	SELECT * FROM loginTable
END
GO

-- Update Password
CREATE PROCEDURE [dbo].[sifreGuncelle_sp]
(
	@kullaniciAdi varchar(50),
	@sifre varchar(30)
)
AS
BEGIN
	UPDATE loginTable SET sifre = @sifre WHERE kullaniciAdi = @kullaniciAdi
END
GO

-- Add User
CREATE PROCEDURE [dbo].[sp_kullaniciEkle]
(
	@kullaniciAdi varchar(50),
	@sifre varchar(50),
	@yetki varchar(20),
	@bolge varchar(50),
	@emailAdres varchar(100),
	@guvenlikSorusu varchar(200),
	@guvenlikCevabi varchar(70)
)
AS
BEGIN
	INSERT INTO loginTable (kullaniciAdi, sifre, yetki, bolge, emailAdres, guvenlikSorusu, guvenlikCevabi) 
	VALUES (@kullaniciAdi, @sifre, @yetki, @bolge, @emailAdres, @guvenlikSorusu, @guvenlikCevabi)
END
GO

-- Update User
CREATE PROCEDURE [dbo].[sp_kullaniciGuncelle]
(
	@id varchar(50),
	@kullaniciAdi varchar(50),
	@sifre varchar(50),
	@yetki varchar(20),
	@bolge varchar(50),
	@emailAdres varchar(100),
	@guvenlikSorusu varchar(200),
	@guvenlikCevabi varchar(70)
)
AS
BEGIN
	UPDATE loginTable 
	SET kullaniciAdi = @kullaniciAdi,
		sifre = @sifre,
		yetki = @yetki,
		bolge = @bolge,
		emailAdres = @emailAdres,
		guvenlikSorusu = @guvenlikSorusu,
		guvenlikCevabi = @guvenlikCevabi
	WHERE id = @id
END
GO

-- Add Product
CREATE PROCEDURE [dbo].[sp_urunEkle]
(
	@id varchar(10),
	@qrkod varchar(50),
	@barkodKod varchar(50),
	@olusturulma_Tarih datetime,
	@guncellenme_Tarih datetime,
	@urunIsim varchar(50),
	@kilo int,
	@fiyat int,
	@ciro int
)
AS
BEGIN
	INSERT INTO urun VALUES (@id, @qrkod, @barkodKod, @olusturulma_Tarih, @guncellenme_Tarih, @urunIsim, @kilo, @fiyat, @ciro)
END
GO

-- Update Product
CREATE PROCEDURE [dbo].[sp_urunGuncelle]
(
	@id varchar(10),
	@qrkod varchar(50),
	@barkodKod varchar(50),
	@olusturulma_Tarih datetime,
	@guncellenme_Tarih datetime,
	@urunIsim varchar(50),
	@kilo int,
	@fiyat int,
	@ciro int
)
AS
BEGIN
	UPDATE urun 
	SET qrkod = @qrkod,
		barkodKod = @barkodKod,
		olusturulma_Tarih = @olusturulma_Tarih,
		guncellenme_Tarih = @guncellenme_Tarih,
		urunIsim = @urunIsim,
		kilo = @kilo,
		fiyat = @fiyat,
		ciro = @ciro
	WHERE id = @id
END
GO

-- =============================================
-- COMPLETED
-- =============================================
PRINT 'Database setup completed successfully!'
GO
