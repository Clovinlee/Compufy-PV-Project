--AKUN
INSERT INTO [Akun] (id_user, username, password, nama_user, tgl_lahir_user, jk_user, tipe_user) 
VALUES('US0001', 'admin', 'admin', 'Herman', CONVERT(datetime, '1996-06-12'), 'L', '1');

INSERT INTO [Akun] (id_user, username, password, nama_user, tgl_lahir_user, jk_user, tipe_user) 
VALUES('US0002', 'kasir1', 'kasir1', 'Tukiyem', CONVERT(datetime, '1997-12-27'), 'P', '2');

INSERT INTO [Akun] (id_user, username, password, nama_user, tgl_lahir_user, jk_user, tipe_user) 
VALUES('US0003', 'kasir2','kasir2', 'Andreas', CONVERT(datetime, '1998-08-14'), 'L', '1');

--KATEGORI
INSERT INTO [Kategori] (id_kategori, nama_kategori) 
VALUES('KA0001', 'Keyboard');

INSERT INTO [Kategori] (id_kategori, nama_kategori) 
VALUES('KA0002', 'Mouse');

INSERT INTO [Kategori] (id_kategori, nama_kategori) 
VALUES('KA0003', 'Mousepad');

--BARANG
INSERT INTO [Barang] (id_barang, id_kategori, nama_barang, harga_barang, stok_barang) 
VALUES('BA0001', 'KA0001', 'Razer Blackwidow S222', 560000, 5);

INSERT INTO [Barang] (id_barang, id_kategori, nama_barang, harga_barang, stok_barang) 
VALUES('BA0002', 'KA0002', 'NYK Monster 555', 260000, 7);

INSERT INTO [Barang] (id_barang, id_kategori, nama_barang, harga_barang, stok_barang) 
VALUES('BA0003', 'KA0003', 'Mousepad XXDareu', 25000, 11);

--MEMBER
INSERT INTO [Member] (id_member, nama_member, no_hp_member, umur_member, tgl_daftar, jk_member, alamat_member) 
VALUES('ME0001', 'Kevin', '0897678987652', '25', CONVERT(datetime, '2020-08-14'), 'L', 'Kedungsari 2/15');

INSERT INTO [Member] (id_member, nama_member, no_hp_member, umur_member, tgl_daftar, jk_member, alamat_member) 
VALUES('ME0002', 'Cecil', '0827384908762', '50', CONVERT(datetime, '2020-12-17'), 'P', 'Semarang 2/13');

INSERT INTO [Member] (id_member, nama_member, no_hp_member, umur_member, tgl_daftar, jk_member, alamat_member) 
VALUES('ME0003', 'Hendra', '0827384908762', '34', CONVERT(datetime, '2019-06-21'), 'L', 'Setro Timur 2/14');

--TRANSAKSI
INSERT INTO [Transaksi] (id_trans, id_member, id_user, total_trans, tgl_trans, metode_trans, diskon) 
VALUES('TR0001', 'ME0001', 'US0002', 350000, CONVERT(datetime, '2021-04-01'), 'Cash', 11);

INSERT INTO [Transaksi] (id_trans, id_member, id_user, total_trans, tgl_trans, metode_trans, diskon) 
VALUES('TR0002', 'ME0002', 'US0003', 460000, CONVERT(datetime, '2021-04-02'), 'Credit', 13);

INSERT INTO [Transaksi] (id_trans, id_member, id_user, total_trans, tgl_trans, metode_trans, diskon) 
VALUES('TR0003', 'ME0003', 'US0002', 780000, CONVERT(datetime, '2021-04-03'), 'Cash', 14);

--DETAIL
INSERT INTO [Detail_Transaksi] (id_barang, id_trans, jumlah_barang) 
VALUES('BA0001', 'TR0001', 2);
INSERT INTO [Detail_Transaksi] (id_barang, id_trans, jumlah_barang) 
VALUES('BA0002', 'TR0001', 4);

INSERT INTO [Detail_Transaksi] (id_barang, id_trans, jumlah_barang) 
VALUES('BA0003', 'TR0002', 5);

INSERT INTO [Detail_Transaksi] (id_barang, id_trans, jumlah_barang) 
VALUES('BA0003', 'TR0003', 3);

--MENGINPUTKAN
INSERT INTO [Menginputkan] (id_user, id_barang, tgl_input, qty_input, ket_input) 
VALUES('US0001', 'BA0001', CONVERT(datetime, '2020-07-22'), 20, 'Barang Aman');

INSERT INTO [Menginputkan] (id_user, id_barang, tgl_input, qty_input, ket_input) 
VALUES('US0001', 'BA0002', CONVERT(datetime, '2020-07-23'), 10, 'Barang Aman');

INSERT INTO [Menginputkan] (id_user, id_barang, tgl_input, qty_input, ket_input) 
VALUES('US0001', 'BA0003', CONVERT(datetime, '2020-07-24'), 12, 'Barang Aman');
