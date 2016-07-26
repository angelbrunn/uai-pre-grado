CREATE TABLE CuentaCorriente ( 
	idCuentaCorriente int NOT NULL,
	nroCuentaCorriente int NOT NULL,
	totalDeuda float DEFAULT 0 NOT NULL,
	fechaCancelacionDeuda datetime NOT NULL
)
;

CREATE TABLE CuentaCorrientePago ( 
	idPago int NOT NULL,
	idCuentaCorriente int NOT NULL
)
;

CREATE TABLE Divisa ( 
	idDivisa int NOT NULL,
	descripcion char(10),
	valorActual float NOT NULL
)
;

CREATE TABLE Pago ( 
	idPago int NOT NULL,
	confirmacionPagoRealizado bit DEFAULT 0 NOT NULL,
	fechaPago datetime,
	idPresupuesto int NOT NULL
)
;

CREATE TABLE presupuestoDivisa ( 
	idPresupuesto int NOT NULL,
	idDivisa int NOT NULL
)
;


ALTER TABLE CuentaCorriente
	ADD CONSTRAINT UQ_CuentaCorriente_idCuentaCorriente UNIQUE (idCuentaCorriente)
;

ALTER TABLE CuentaCorrientePago
	ADD CONSTRAINT UQ_CuentaCorrientePago_idCuentaCorriente UNIQUE (idCuentaCorriente)
;

ALTER TABLE CuentaCorrientePago
	ADD CONSTRAINT UQ_CuentaCorrientePago_idPago UNIQUE (idPago)
;

ALTER TABLE Divisa
	ADD CONSTRAINT UQ_Divisa_idDivisa UNIQUE (idDivisa)
;

ALTER TABLE presupuestoDivisa
	ADD CONSTRAINT UQ_presupuestoDivisa_idDivisa UNIQUE (idDivisa)
;

ALTER TABLE presupuestoDivisa
	ADD CONSTRAINT UQ_presupuestoDivisa_idPresupuesto UNIQUE (idPresupuesto)
;

ALTER TABLE CuentaCorriente ADD CONSTRAINT PK_CuentaCorriente 
	PRIMARY KEY CLUSTERED (idCuentaCorriente)
;

ALTER TABLE CuentaCorrientePago ADD CONSTRAINT PK_CuentaCorrientePago 
	PRIMARY KEY CLUSTERED (idPago, idCuentaCorriente)
;

ALTER TABLE Divisa ADD CONSTRAINT PK_Divisa 
	PRIMARY KEY CLUSTERED (idDivisa)
;

ALTER TABLE Pago ADD CONSTRAINT PK_Pago 
	PRIMARY KEY CLUSTERED (idPago)
;

ALTER TABLE presupuestoDivisa ADD CONSTRAINT PK_presupuestoDivisa 
	PRIMARY KEY CLUSTERED (idPresupuesto, idDivisa)
;
