CREATE TABLE Cobro ( 
	idCobro int NOT NULL,
	idPresupuesto int NOT NULL,
	monto float NOT NULL,
	nroFactura int NOT NULL,
	ventaCancelada bit,
	fechaCobro datetime NOT NULL
)
;

CREATE TABLE PresupuestoCobros ( 
	idCobros int NOT NULL,
	idPresupuesto int NOT NULL
)
;

CREATE TABLE Ventas ( 
	idVentas  int NOT NULL,
	idCobros  int NOT NULL,
	fechaVenta date
)
;

CREATE TABLE VentasVoucher ( 
	idCobro int NOT NULL,
	idVoucher char(10) NOT NULL
)
;

CREATE TABLE Voucher ( 
	idVoucher char(10) NOT NULL,
	fechaVencimiento datetime NOT NULL,
	fechaCreacion datetime NOT NULL,
	monto float NOT NULL,
	usado bit DEFAULT 0 NOT NULL
)
;


ALTER TABLE Cobro
	ADD CONSTRAINT UQ_Cobro_idCobro UNIQUE (idCobro)
;

ALTER TABLE PresupuestoCobros
	ADD CONSTRAINT UQ_PresupuestoCobros_idPresupuesto UNIQUE (idPresupuesto)
;

ALTER TABLE PresupuestoCobros
	ADD CONSTRAINT UQ_PresupuestoCobros_idCobros UNIQUE (idCobros)
;

ALTER TABLE Ventas
	ADD CONSTRAINT UQ_Cobro_idCobro UNIQUE (idCobros)
;

ALTER TABLE VentasVoucher
	ADD CONSTRAINT UQ_CobrosVoucher_idVoucher UNIQUE (idVoucher)
;

ALTER TABLE VentasVoucher
	ADD CONSTRAINT UQ_CobrosVoucher_idCobro UNIQUE (idCobro)
;

ALTER TABLE Voucher
	ADD CONSTRAINT UQ_Voucher_idVoucher UNIQUE (idVoucher)
;

ALTER TABLE Cobro ADD CONSTRAINT PK_Cobros 
	PRIMARY KEY CLUSTERED (idCobro)
;

ALTER TABLE PresupuestoCobros ADD CONSTRAINT PK_PresupuestoCobros 
	PRIMARY KEY CLUSTERED (idCobros, idPresupuesto)
;

ALTER TABLE Ventas ADD CONSTRAINT PK_Ventas 
	PRIMARY KEY CLUSTERED (idVentas, idCobros)
;

ALTER TABLE VentasVoucher ADD CONSTRAINT PK_CobrosVoucher 
	PRIMARY KEY CLUSTERED (idCobro, idVoucher)
;

ALTER TABLE Voucher ADD CONSTRAINT PK_Voucher 
	PRIMARY KEY CLUSTERED (idVoucher)
;
