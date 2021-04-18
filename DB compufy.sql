CREATE TABLE [dbo].[Kategori] (
    [id_kategori]   VARCHAR (10) NOT NULL,
    [nama_kategori] VARCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([id_kategori] ASC)
);


CREATE TABLE [dbo].[Barang] (
    [id_barang]    VARCHAR (10) NOT NULL,
    [id_kategori]  VARCHAR (10) NOT NULL,
    [nama_barang]  VARCHAR (25) NULL,
    [harga_barang] NUMERIC (15) NULL,
    [stok_barang]  NUMERIC (3)  NULL,
    PRIMARY KEY CLUSTERED ([id_barang] ASC),
    FOREIGN KEY ([id_kategori]) REFERENCES [dbo].[Kategori] ([id_kategori])
);


CREATE TABLE [dbo].[Member] (
    [id_member]     VARCHAR (10) NOT NULL,
    [nama_member]   VARCHAR (20) NULL,
    [no_hp_member]  VARCHAR (13) NULL,
    [umur_member]   VARCHAR (3)  NULL,
    [tgl_daftar]    DATETIME         NULL,
    [jk_member]     VARCHAR (1)  NULL,
    [alamat_member] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([id_member] ASC)
);

CREATE TABLE [dbo].[User] (
    [id_user]        VARCHAR (10) NOT NULL,
    [username]       VARCHAR (20) NULL,
    [password]       VARCHAR (20) NULL,
    [nama_user]      VARCHAR (30) NULL,
    [tgl_lahir_user] DATETIME         NULL,
    [jk_user]        VARCHAR (1)  NULL,
    [tipe_user]      VARCHAR (1)  NULL,
    PRIMARY KEY CLUSTERED ([id_user] ASC)
);

CREATE TABLE [dbo].[Transaksi] (
    [id_trans]     VARCHAR (10) NOT NULL,
    [id_member]    VARCHAR (10) NOT NULL,
    [id_user]      VARCHAR (10) NOT NULL,
    [total_trans]  NUMERIC (15) NULL,
    [tgl_trans]    DATETIME         NULL,
    [metode_trans] VARCHAR (10) NULL,
    [diskon]       NUMERIC (15) NULL,
    PRIMARY KEY CLUSTERED ([id_trans] ASC),
    FOREIGN KEY ([id_member]) REFERENCES [dbo].[Member] ([id_member]),
    FOREIGN KEY ([id_user]) REFERENCES [dbo].[User] ([id_user])
);

CREATE TABLE [dbo].[Detail_Transaksi] (
    [id_barang]     VARCHAR (10) NOT NULL,
    [id_trans]      VARCHAR (10) NOT NULL,
    [jumlah_barang] VARCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([id_barang] ASC, [id_trans] ASC),
    FOREIGN KEY ([id_barang]) REFERENCES [dbo].[Barang] ([id_barang]),
    FOREIGN KEY ([id_trans]) REFERENCES [dbo].[Transaksi] ([id_trans])
);

CREATE TABLE [dbo].[Menginputkan] (
    [id_user]   VARCHAR (10)  NOT NULL,
    [id_barang] VARCHAR (10)  NOT NULL,
    [tgl_input] DATETIME          NULL,
    [qty_input] NUMERIC (3)   NULL,
    [ket_input] VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([id_user] ASC, [id_barang] ASC),
    FOREIGN KEY ([id_user]) REFERENCES [dbo].[User] ([id_user]),
    FOREIGN KEY ([id_barang]) REFERENCES [dbo].[Barang] ([id_barang])
);

INSERT INTO [User](id_user,username,password,nama_user,tgl_lahir_user,jk_user,tipe_user) VALUES(
    'U0001','admin','admin','Administrator',CONVERT(datetime,'18-06-12 10:34:09 PM',5),'l','1'
);

INSERT INTO [User](id_user,username,password,nama_user,tgl_lahir_user,jk_user,tipe_user) VALUES(
    'U0002','chrisanto','chris','Administrator',CONVERT(datetime,'18-06-12',5),'l','1'
);

INSERT INTO [User](id_user,username,password,nama_user,tgl_lahir_user,jk_user,tipe_user) VALUES(
    'U0003','super','super','Super Chris',CONVERT(datetime,'11-02-10',5),'l','0'
);