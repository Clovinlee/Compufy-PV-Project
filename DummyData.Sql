SET IDENTITY_INSERT [dbo].[Akun] ON
INSERT INTO [dbo].[Akun] ([id_user], [username], [password], [nama_user], [tgl_lahir_user], [jk_user], [tipe_user]) VALUES (1, N'admin', N'admin', N'herman', N'1985-04-01', N'L', N'1')
INSERT INTO [dbo].[Akun] ([id_user], [username], [password], [nama_user], [tgl_lahir_user], [jk_user], [tipe_user]) VALUES (2, N'kasir1', N'kasir1', N'tukiyem', N'1995-05-05', N'P', N'2')
INSERT INTO [dbo].[Akun] ([id_user], [username], [password], [nama_user], [tgl_lahir_user], [jk_user], [tipe_user]) VALUES (3, N'kasir2', N'kasir2', N'sandriana', N'1994-08-17', N'P', N'2')
INSERT INTO [dbo].[Akun] ([id_user], [username], [password], [nama_user], [tgl_lahir_user], [jk_user], [tipe_user]) VALUES (4, N'kasir3', N'kasir3', N'susilo', N'1990-09-14', N'L', N'2')
INSERT INTO [dbo].[Akun] ([id_user], [username], [password], [nama_user], [tgl_lahir_user], [jk_user], [tipe_user]) VALUES (5, N'Clovinlee6', N'123456', N'Chrisanto Sinatra', N'1995-02-13', N'L', N'3')
INSERT INTO [dbo].[Akun] ([id_user], [username], [password], [nama_user], [tgl_lahir_user], [jk_user], [tipe_user]) VALUES (6, N'Chelsie123', N'123456', N'Chelsie Monica', N'1997-02-14', N'P', N'3')
INSERT INTO [dbo].[Akun] ([id_user], [username], [password], [nama_user], [tgl_lahir_user], [jk_user], [tipe_user]) VALUES (7, N'StevanenH', N'123456', N'Steven Hindarmawan', N'2000-09-11', N'L', N'3')
INSERT INTO [dbo].[Akun] ([id_user], [username], [password], [nama_user], [tgl_lahir_user], [jk_user], [tipe_user]) VALUES (8, N'Erika222', N'123456', N'Erika Sientari', N'1996-02-12', N'P', N'3')
INSERT INTO [dbo].[Akun] ([id_user], [username], [password], [nama_user], [tgl_lahir_user], [jk_user], [tipe_user]) VALUES (10, N'admin2', N'admin2', N'Rika', N'1987-05-02', N'P', N'1')
INSERT INTO [dbo].[Akun] ([id_user], [username], [password], [nama_user], [tgl_lahir_user], [jk_user], [tipe_user]) VALUES (11, N'admin3', N'admin3', N'Dadang', N'1985-03-05', N'L', N'1')
SET IDENTITY_INSERT [dbo].[Akun] OFF

SET IDENTITY_INSERT [dbo].[Kategori] ON
INSERT INTO [dbo].[Kategori] ([id_kategori], [nama_kategori]) VALUES (1, N'Desktop')
INSERT INTO [dbo].[Kategori] ([id_kategori], [nama_kategori]) VALUES (2, N'Smartphone')
INSERT INTO [dbo].[Kategori] ([id_kategori], [nama_kategori]) VALUES (3, N'Laptop')
INSERT INTO [dbo].[Kategori] ([id_kategori], [nama_kategori]) VALUES (4, N'Accesories')
SET IDENTITY_INSERT [dbo].[Kategori] OFF

SET IDENTITY_INSERT [dbo].[Member] ON
INSERT INTO [dbo].[Member] ([id_member], [nama_member], [no_hp_member], [birthdate], [tgl_daftar], [jk_member], [alamat_member]) VALUES (1, N'Kevin Arianto', N'0878940983782', CONVERT(date,'12/10/1990',103), N'2021-03-01', N'L', N'Setro tengah 21A')
INSERT INTO [dbo].[Member] ([id_member], [nama_member], [no_hp_member], [birthdate], [tgl_daftar], [jk_member], [alamat_member]) VALUES (2, N'Chrisanto Sinatra', N'0887653678902', CONVERT(date,'11/04/2001',103), N'2021-02-24', N'L', N'Babatan Pantai 22B')
INSERT INTO [dbo].[Member] ([id_member], [nama_member], [no_hp_member], [birthdate], [tgl_daftar], [jk_member], [alamat_member]) VALUES (3, N'Steven Hindarmawan', N'0852909890231', CONVERT(date,'03/12/2004',103), N'2021-01-30', N'L', N'Embong Malang 120B')
INSERT INTO [dbo].[Member] ([id_member], [nama_member], [no_hp_member], [birthdate], [tgl_daftar], [jk_member], [alamat_member]) VALUES (4, N'Erika Sientari', N'0819203858232', CONVERT(date,'05/09/2005',103), N'2021-04-11', N'P', N'Kenjeran tengah 22O')
INSERT INTO [dbo].[Member] ([id_member], [nama_member], [no_hp_member], [birthdate], [tgl_daftar], [jk_member], [alamat_member]) VALUES (5, N'Patrice Febyani', N'0846273198232', CONVERT(date,'17/01/1994',103), N'2021-01-16', N'P', N'Lebak jaya 21B')
INSERT INTO [dbo].[Member] ([id_member], [nama_member], [no_hp_member], [birthdate], [tgl_daftar], [jk_member], [alamat_member]) VALUES (6, N'Susanto Megaranto', N'0829312093819', CONVERT(date,'08/09/1992',103), N'2020-07-18', N'L', N'Jenderal sudirman 18B')
INSERT INTO [dbo].[Member] ([id_member], [nama_member], [no_hp_member], [birthdate], [tgl_daftar], [jk_member], [alamat_member]) VALUES (7, N'Herman Susilo', N'0873123584339',CONVERT(date,'22/11/1991',103), N'2020-09-19', N'L', N'Petemon kali 22C')
INSERT INTO [dbo].[Member] ([id_member], [nama_member], [no_hp_member], [birthdate], [tgl_daftar], [jk_member], [alamat_member]) VALUES (8, N'Chelsie Monica', N'0834738274883', CONVERT(datetime,'08/11/1989',103), N'2020-11-11', N'P', N'Rangkah 55C')
INSERT INTO [dbo].[Member] ([id_member], [nama_member], [no_hp_member], [birthdate], [tgl_daftar], [jk_member], [alamat_member]) VALUES (9, N'Coki Pardede', N'0847827313722', CONVERT(date,'11/07/1970',103), N'2021-02-03', N'L', N'Kuburan 89')
INSERT INTO [dbo].[Member] ([id_member], [nama_member], [no_hp_member], [birthdate], [tgl_daftar], [jk_member], [alamat_member]) VALUES (10, N'Momo', N'0823721837812', CONVERT(date,'09/09/1982',103), N'2020-10-04', N'P', N'Kampung jepun 81CA')
SET IDENTITY_INSERT [dbo].[Member] OFF

SET IDENTITY_INSERT [dbo].[h_transaksi] ON
INSERT INTO [dbo].[h_transaksi] ([id_trans], [id_member], [total_trans], [tgl_trans], [metode_trans], [diskon]) VALUES (1, NULL, CAST(6000000 AS Decimal(15, 0)), N'2021-04-15', N'Cash', 0)
INSERT INTO [dbo].[h_transaksi] ([id_trans], [id_member], [total_trans], [tgl_trans], [metode_trans], [diskon]) VALUES (2, NULL, CAST(190000 AS Decimal(15, 0)), N'2021-04-13', N'Credit', CAST(10000 AS Decimal(15, 0)))
INSERT INTO [dbo].[h_transaksi] ([id_trans], [id_member], [total_trans], [tgl_trans], [metode_trans], [diskon]) VALUES (3, 1, CAST(1245000 AS Decimal(15, 0)), N'2021-04-14', N'Credit', CAST(50000 AS Decimal(15, 0)))
INSERT INTO [dbo].[h_transaksi] ([id_trans], [id_member], [total_trans], [tgl_trans], [metode_trans], [diskon]) VALUES (4, NULL, CAST(6100000 AS Decimal(15, 0)), N'2021-04-15', N'Cash', CAST(230000 AS Decimal(15, 0)))
INSERT INTO [dbo].[h_transaksi] ([id_trans], [id_member], [total_trans], [tgl_trans], [metode_trans], [diskon]) VALUES (5, 5, CAST(2935000 AS Decimal(15, 0)), N'2021-04-14', N'Cash', CAST(120000 AS Decimal(15, 0)))
INSERT INTO [dbo].[h_transaksi] ([id_trans], [id_member], [total_trans], [tgl_trans], [metode_trans], [diskon]) VALUES (6, NULL, CAST(13800000 AS Decimal(15, 0)), N'2021-04-16', N'Credit', CAST(900000 AS Decimal(15, 0)))
SET IDENTITY_INSERT [dbo].[h_transaksi] OFF

SET IDENTITY_INSERT [dbo].[Barang] ON
INSERT INTO [dbo].[Barang] ([id_barang], [id_kategori], [nama_barang], [harga_barang], [stok_barang]) VALUES (1, 1, N'Monitor LED Viewsonic 22 inch', CAST(1200000 AS Decimal(15, 0)), CAST(4 AS Decimal(3, 0)))
INSERT INTO [dbo].[Barang] ([id_barang], [id_kategori], [nama_barang], [harga_barang], [stok_barang]) VALUES (2, 1, N'SSD Midasforce 1TB Caddy 9.5', CAST(1500000 AS Decimal(15, 0)), CAST(3 AS Decimal(3, 0)))
INSERT INTO [dbo].[Barang] ([id_barang], [id_kategori], [nama_barang], [harga_barang], [stok_barang]) VALUES (3, 1, N'ASUS GeForce GT 710 2GB', CAST(450000 AS Decimal(15, 0)), CAST(6 AS Decimal(3, 0)))
INSERT INTO [dbo].[Barang] ([id_barang], [id_kategori], [nama_barang], [harga_barang], [stok_barang]) VALUES (4, 1, N'Ram 8GB Kingston DDR4', CAST(750000 AS Decimal(15, 0)), CAST(7 AS Decimal(3, 0)))
INSERT INTO [dbo].[Barang] ([id_barang], [id_kategori], [nama_barang], [harga_barang], [stok_barang]) VALUES (5, 1, N'Processor AMD Ryzen 7 3800XT 3.9 Ghz AM4', CAST(6100000 AS Decimal(15, 0)), CAST(1 AS Decimal(3, 0)))
INSERT INTO [dbo].[Barang] ([id_barang], [id_kategori], [nama_barang], [harga_barang], [stok_barang]) VALUES (6, 2, N'Xiaomi Redmi 9T', CAST(2100000 AS Decimal(15, 0)), CAST(8 AS Decimal(3, 0)))
INSERT INTO [dbo].[Barang] ([id_barang], [id_kategori], [nama_barang], [harga_barang], [stok_barang]) VALUES (7, 2, N'Xiaomi POCO X3 NFC', CAST(3000000 AS Decimal(15, 0)), CAST(0 AS Decimal(3, 0)))
INSERT INTO [dbo].[Barang] ([id_barang], [id_kategori], [nama_barang], [harga_barang], [stok_barang]) VALUES (8, 2, N'vivo Y20s [G]', CAST(2300000 AS Decimal(15, 0)), CAST(4 AS Decimal(3, 0)))
INSERT INTO [dbo].[Barang] ([id_barang], [id_kategori], [nama_barang], [harga_barang], [stok_barang]) VALUES (9, 2, N'Samsung Galaxy M51', CAST(5000000 AS Decimal(15, 0)), CAST(6 AS Decimal(3, 0)))
INSERT INTO [dbo].[Barang] ([id_barang], [id_kategori], [nama_barang], [harga_barang], [stok_barang]) VALUES (10, 2, N'OPPO Reno5', CAST(4000000 AS Decimal(15, 0)), CAST(3 AS Decimal(3, 0)))
INSERT INTO [dbo].[Barang] ([id_barang], [id_kategori], [nama_barang], [harga_barang], [stok_barang]) VALUES (11, 3, N'HP Envy 13', CAST(12600000 AS Decimal(15, 0)), CAST(1 AS Decimal(3, 0)))
INSERT INTO [dbo].[Barang] ([id_barang], [id_kategori], [nama_barang], [harga_barang], [stok_barang]) VALUES (12, 3, N'Lenovo ThinkBook 14s Yoga', CAST(13800000 AS Decimal(15, 0)), CAST(1 AS Decimal(3, 0)))
INSERT INTO [dbo].[Barang] ([id_barang], [id_kategori], [nama_barang], [harga_barang], [stok_barang]) VALUES (13, 3, N'ASUS Chromebook Flip C434', CAST(10900000 AS Decimal(15, 0)), CAST(1 AS Decimal(3, 0)))
INSERT INTO [dbo].[Barang] ([id_barang], [id_kategori], [nama_barang], [harga_barang], [stok_barang]) VALUES (14, 3, N'Acer Swift 3', CAST(12500000 AS Decimal(15, 0)), CAST(2 AS Decimal(3, 0)))
INSERT INTO [dbo].[Barang] ([id_barang], [id_kategori], [nama_barang], [harga_barang], [stok_barang]) VALUES (15, 3, N'ASUS ZenBook 13', CAST(13300000 AS Decimal(15, 0)), CAST(1 AS Decimal(3, 0)))
INSERT INTO [dbo].[Barang] ([id_barang], [id_kategori], [nama_barang], [harga_barang], [stok_barang]) VALUES (16, 4, N'Keyboard Logitech G213 Prodigy', CAST(525000 AS Decimal(15, 0)), CAST(3 AS Decimal(3, 0)))
INSERT INTO [dbo].[Barang] ([id_barang], [id_kategori], [nama_barang], [harga_barang], [stok_barang]) VALUES (17, 4, N'Keyboard Fantech SOLDIER K612', CAST(235000 AS Decimal(15, 0)), CAST(7 AS Decimal(3, 0)))
INSERT INTO [dbo].[Barang] ([id_barang], [id_kategori], [nama_barang], [harga_barang], [stok_barang]) VALUES (18, 4, N'Keyboard Rexus Battlefire KX1', CAST(250000 AS Decimal(15, 0)), CAST(3 AS Decimal(3, 0)))
INSERT INTO [dbo].[Barang] ([id_barang], [id_kategori], [nama_barang], [harga_barang], [stok_barang]) VALUES (19, 4, N'Mouse Rexus Xierra S5 Aviator', CAST(95000 AS Decimal(15, 0)), CAST(11 AS Decimal(3, 0)))
INSERT INTO [dbo].[Barang] ([id_barang], [id_kategori], [nama_barang], [harga_barang], [stok_barang]) VALUES (20, 4, N'Mouse 	CORSAIR IRONCLAW RGB', CAST(720000 AS Decimal(15, 0)), CAST(2 AS Decimal(3, 0)))
INSERT INTO [dbo].[Barang] ([id_barang], [id_kategori], [nama_barang], [harga_barang], [stok_barang]) VALUES (21, 4, N'Headset Logitech Prodigy G231 ', CAST(531000 AS Decimal(15, 0)), CAST(1 AS Decimal(3, 0)))
INSERT INTO [dbo].[Barang] ([id_barang], [id_kategori], [nama_barang], [harga_barang], [stok_barang]) VALUES (22, 4, N'Headset Corsair HS70', CAST(1000000 AS Decimal(15, 0)), CAST(1 AS Decimal(3, 0)))
SET IDENTITY_INSERT [dbo].[Barang] OFF

INSERT INTO [dbo].[d_transaksi] ([id_barang], [id_trans], [jumlah_barang]) VALUES (2, 1, N'2')
INSERT INTO [dbo].[d_transaksi] ([id_barang], [id_trans], [jumlah_barang]) VALUES (7, 1, N'1')
INSERT INTO [dbo].[d_transaksi] ([id_barang], [id_trans], [jumlah_barang]) VALUES (19, 2, N'2')
INSERT INTO [dbo].[d_transaksi] ([id_barang], [id_trans], [jumlah_barang]) VALUES (16, 3, N'1')
INSERT INTO [dbo].[d_transaksi] ([id_barang], [id_trans], [jumlah_barang]) VALUES (20, 3, N'1')
INSERT INTO [dbo].[d_transaksi] ([id_barang], [id_trans], [jumlah_barang]) VALUES (5, 4, N'1')
INSERT INTO [dbo].[d_transaksi] ([id_barang], [id_trans], [jumlah_barang]) VALUES (17, 5, N'1')
INSERT INTO [dbo].[d_transaksi] ([id_barang], [id_trans], [jumlah_barang]) VALUES (4, 5, N'2')
INSERT INTO [dbo].[d_transaksi] ([id_barang], [id_trans], [jumlah_barang]) VALUES (1, 5, N'1')
INSERT INTO [dbo].[d_transaksi] ([id_barang], [id_trans], [jumlah_barang]) VALUES (12, 6, N'1')

SET IDENTITY_INSERT [dbo].[Menginputkan] ON
INSERT INTO [dbo].[Menginputkan] ([id_input], [id_user], [id_barang], [tgl_input], [qty_input], [ket_input]) VALUES (1, 1, 3, N'2021-04-14', CAST(6 AS Decimal(3, 0)), N'Aman')
INSERT INTO [dbo].[Menginputkan] ([id_input], [id_user], [id_barang], [tgl_input], [qty_input], [ket_input]) VALUES (2, 11, 4, N'2021-04-15', CAST(5 AS Decimal(3, 0)), N'Aman')
INSERT INTO [dbo].[Menginputkan] ([id_input], [id_user], [id_barang], [tgl_input], [qty_input], [ket_input]) VALUES (3, 10, 14, N'2021-04-15', CAST(8 AS Decimal(3, 0)), N'Aman')
INSERT INTO [dbo].[Menginputkan] ([id_input], [id_user], [id_barang], [tgl_input], [qty_input], [ket_input]) VALUES (4, 1, 3, N'2021-04-16', CAST(7 AS Decimal(3, 0)), N'Aman')
INSERT INTO [dbo].[Menginputkan] ([id_input], [id_user], [id_barang], [tgl_input], [qty_input], [ket_input]) VALUES (5, 1, 15, N'2021-04-16', CAST(4 AS Decimal(3, 0)), N'Aman')
INSERT INTO [dbo].[Menginputkan] ([id_input], [id_user], [id_barang], [tgl_input], [qty_input], [ket_input]) VALUES (6, 11, 14, N'2021-04-16', CAST(11 AS Decimal(3, 0)), N'Aman')
INSERT INTO [dbo].[Menginputkan] ([id_input], [id_user], [id_barang], [tgl_input], [qty_input], [ket_input]) VALUES (7, 10, 20, N'2021-04-17', CAST(2 AS Decimal(3, 0)), N'Aman')
INSERT INTO [dbo].[Menginputkan] ([id_input], [id_user], [id_barang], [tgl_input], [qty_input], [ket_input]) VALUES (9, 11, 8, N'2021-04-20', CAST(4 AS Decimal(3, 0)), N'Aman')
INSERT INTO [dbo].[Menginputkan] ([id_input], [id_user], [id_barang], [tgl_input], [qty_input], [ket_input]) VALUES (10, 10, 5, N'2021-04-16', CAST(9 AS Decimal(3, 0)), N'Aman')
SET IDENTITY_INSERT [dbo].[Menginputkan] OFF



