CREATE TABLE [dbo].[Akun] (
    [id_user]        INT          IDENTITY (1, 1) NOT NULL,
    [username]       VARCHAR (20) NOT NULL,
    [password]       VARCHAR (20) NOT NULL,
    [nama_user]      VARCHAR (30) NOT NULL,
    [tgl_lahir_user] DATE         NOT NULL,
    [jk_user]        VARCHAR (1)  NOT NULL,
    [tipe_user]      VARCHAR (1)  NOT NULL,
    PRIMARY KEY CLUSTERED ([id_user] ASC),
    UNIQUE NONCLUSTERED ([username] ASC)
);

CREATE TABLE [dbo].[Kategori] (
    [id_kategori]   INT          IDENTITY (1, 1) NOT NULL,
    [nama_kategori] VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([id_kategori] ASC)
);

CREATE TABLE [dbo].[Member] (
    [id_member]     INT          IDENTITY (1, 1) NOT NULL,
    [nama_member]   VARCHAR (50) NOT NULL,
    [no_hp_member]  VARCHAR (13) NOT NULL,
    [birthdate]     DATETIME     NULL,
    [tgl_daftar]    DATE         NOT NULL,
    [jk_member]     VARCHAR (1)  NOT NULL,
    [alamat_member] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([id_member] ASC)
);

CREATE TABLE [dbo].[h_transaksi] (
    [id_trans]     INT          NOT NULL IDENTITY(1,1),
    [id_member]    INT          NULL,
    [total_trans]  NUMERIC (15) NOT NULL,
    [tgl_trans]    DATE         NOT NULL,
    [metode_trans] VARCHAR (10) NOT NULL,
    [diskon]       NUMERIC (15) NOT NULL,
    PRIMARY KEY CLUSTERED ([id_trans] ASC),
    FOREIGN KEY ([id_member]) REFERENCES [dbo].[Member] ([id_member])
);

CREATE TABLE [dbo].[Barang] (
    [id_barang]    INT           IDENTITY (1, 1) NOT NULL,
    [id_kategori]  INT           NOT NULL,
    [nama_barang]  VARCHAR (100) NOT NULL,
    [harga_barang] NUMERIC (15)  NOT NULL,
    [stok_barang]  NUMERIC (3)   NOT NULL,
    [gambar]       VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([id_barang] ASC),
    FOREIGN KEY ([id_kategori]) REFERENCES [dbo].[Kategori] ([id_kategori])
);

CREATE TABLE [dbo].[d_transaksi] (
    [id_barang]     INT          NOT NULL,
    [id_trans]      INT          NOT NULL,
    [jumlah_barang] VARCHAR (10) NOT NULL,
    FOREIGN KEY ([id_trans]) REFERENCES [dbo].[h_transaksi] ([id_trans]),
    FOREIGN KEY ([id_barang]) REFERENCES [dbo].[Barang] ([id_barang])
);

CREATE TABLE [dbo].[Menginputkan] (
    [id_input]  INT           IDENTITY (1, 1) NOT NULL,
    [id_user]   INT           NOT NULL,
    [id_barang] INT           NOT NULL,
    [tgl_input] DATE          NOT NULL,
    [qty_input] NUMERIC (3)   NOT NULL,
    [ket_input] VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([id_input] ASC),
    FOREIGN KEY ([id_user]) REFERENCES [dbo].[Akun] ([id_user]),
    FOREIGN KEY ([id_barang]) REFERENCES [dbo].[Barang] ([id_barang])
);





