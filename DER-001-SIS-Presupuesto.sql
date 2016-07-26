CREATE TABLE Cliente ( 
	codigoCliente int  NOT NULL,
	domicilio varchar(50),
	telefono varchar(20),
	mail varchar(20),
	inhibicion int
)
;

CREATE TABLE ClientePresupuesto ( 
	codigoCliente  int NOT NULL,
	idPresupuesto  int NOT NULL
)
;

CREATE TABLE Encuesta ( 
	idEncuesta  int NOT NULL,
	idVenta  int NOT NULL,
	nivelSatisfaccion int ,
	fechaEncuesta date,
	codigoCliente  int NOT NULL,
	destino varchar(50)
)
;

CREATE TABLE EncuestaVendedor ( 
	idEncuesta  int NOT NULL,
	legajo  int NOT NULL
)
;

CREATE TABLE Hospedaje ( 
	idProveedor int NOT NULL,
	idCuentaCorriente int,
	poseeCuentaCorriente bit DEFAULT 0 NOT NULL,
	razonSocial char(10) NOT NULL,
	direccion char(10),
	monto float NOT NULL,
	destino char(10) NOT NULL,
	mail char(10),
	reservaPendiente bit DEFAULT 1 NOT NULL,
	idDivisa int NOT NULL,
	pagoPendiente bit DEFAULT 1 NOT NULL,
	montoAPagar float NOT NULL,
	categoria int NOT NULL,
	descripcion char(50) NOT NULL,
	codigoHospedaje int NOT NULL
)
;

CREATE TABLE PaquetesPromocionable ( 
	idPaquetePromocionable  int NOT NULL,
	idProveedor  int NOT NULL,
	destino varchar(50),
	fechaPartida date,
	fechaRegreso date,
	cantidadPasajero int,
	monto float,
	fechaCreacionPaquete date,
	paqueteActivo int,
	descripcion varchar(50)
)
;

CREATE TABLE Pasajero ( 
	idPasajero  int NOT NULL,
	Apellido varchar(50),
	Nombre varchar(50),
	fechaNacimiento date,
	edad int
)
;

CREATE TABLE PasajeroPresupuesto ( 
	idPresupuesto  int NOT NULL,
	idPasajero  int NOT NULL
)
;

CREATE TABLE presupuesto ( 
	idPresupuesto int NOT NULL,
	codigoCliente char(10) NOT NULL,
	legajo int NOT NULL,
	destino char(10) NOT NULL,
	fechaPartida datetime,
	fechaRegreso datetime,
	idPaquetePromocionable int,
	fechaCreacion datetime NOT NULL
)
;

CREATE TABLE PresupuestoHospedaje ( 
	idPresupuesto int NOT NULL,
	idProveedor int NOT NULL
)
;

CREATE TABLE PresupuestoPaquetePromocionable ( 
	idPresupuesto  int NOT NULL,
	idPaquetePromocionable  int NOT NULL
)
;

CREATE TABLE PresupuestoServicio ( 
	idServicio  int NOT NULL,
	idPresupuesto  int NOT NULL
)
;

CREATE TABLE PresupuestoTransporte ( 
	idPresupuesto int NOT NULL,
	idProveedor int NOT NULL
)
;

CREATE TABLE Servicio ( 
	idServicio  int NOT NULL,
	descripcion varchar(50)
)
;

CREATE TABLE Transporte ( 
	idProveedor int NOT NULL,
	cuentaCorriente int NOT NULL,
	poseeCuentaCorriente bit NOT NULL,
	razonSocial char(10) NOT NULL,
	direccion char(10),
	monto float NOT NULL,
	destino char(10) NOT NULL,
	poseeReservaPorMail bit DEFAULT 0 NOT NULL,
	mail char(10),
	idDivisa int NOT NULL,
	pagoPendiente bit DEFAULT 1 NOT NULL,
	montoAPagar float,
	codigoTransporte int NOT NULL
)
;

CREATE TABLE Vendedor ( 
	legajo  int NOT NULL,
	Apellido varchar(50),
	Nombre varchar(50),
	telefono varchar(50),
	Domicilio varchar(50),
	fechaNacimiento date ,
	codigoCliente int
)
;

CREATE TABLE vendedorPresupuesto ( 
	legajo  int NOT NULL,
	idPresupuesto  int NOT NULL
)
;


ALTER TABLE Cliente
	ADD CONSTRAINT UQ_Cliente_codigoCliente UNIQUE (codigoCliente)
;

ALTER TABLE ClientePresupuesto
	ADD CONSTRAINT UQ_ClientePresupuesto_codigoCliente UNIQUE (codigoCliente)
;

ALTER TABLE ClientePresupuesto
	ADD CONSTRAINT UQ_ClientePresupuesto_idPresupuesto UNIQUE (idPresupuesto)
;

ALTER TABLE Encuesta
	ADD CONSTRAINT UQ_Encuesta_codigoCliente UNIQUE (codigoCliente)
;

ALTER TABLE Encuesta
	ADD CONSTRAINT UQ_Encuesta_idEncuesta UNIQUE (idEncuesta)
;

ALTER TABLE Encuesta
	ADD CONSTRAINT UQ_Encuesta_idVenta UNIQUE (idVenta)
;

ALTER TABLE EncuestaVendedor
	ADD CONSTRAINT UQ_EncuestaVendedor_idEncuesta UNIQUE (idEncuesta)
;

ALTER TABLE EncuestaVendedor
	ADD CONSTRAINT UQ_EncuestaVendedor_legajo UNIQUE (legajo)
;

ALTER TABLE Hospedaje
	ADD CONSTRAINT UQ_Hospedaje_idProveedor UNIQUE (idProveedor)
;

ALTER TABLE PaquetesPromocionable
	ADD CONSTRAINT UQ_PaquetesPromocionable_idPaquetePromocionable UNIQUE (idPaquetePromocionable)
;

ALTER TABLE PaquetesPromocionable
	ADD CONSTRAINT UQ_PaquetesPromocionable_idProveedor UNIQUE (idProveedor)
;

ALTER TABLE Pasajero
	ADD CONSTRAINT UQ_Pasajero_idPasajero UNIQUE (idPasajero)
;

ALTER TABLE PasajeroPresupuesto
	ADD CONSTRAINT UQ_PasajeroPresupuesto_idPasajero UNIQUE (idPasajero)
;

ALTER TABLE PasajeroPresupuesto
	ADD CONSTRAINT UQ_PasajeroPresupuesto_idPresupuesto UNIQUE (idPresupuesto)
;

ALTER TABLE presupuesto
	ADD CONSTRAINT UQ_presupuesto_idPresupuesto UNIQUE (idPresupuesto)
;

ALTER TABLE PresupuestoHospedaje
	ADD CONSTRAINT UQ_PresupuestoHospedaje_idPresupuesto UNIQUE (idPresupuesto)
;

ALTER TABLE PresupuestoHospedaje
	ADD CONSTRAINT UQ_PresupuestoHospedaje_idProveedor UNIQUE (idProveedor)
;

ALTER TABLE PresupuestoPaquetePromocionable
	ADD CONSTRAINT UQ_PresupuestoPaquetePromocionable_idPaquetePromocionable UNIQUE (idPaquetePromocionable)
;

ALTER TABLE PresupuestoPaquetePromocionable
	ADD CONSTRAINT UQ_PresupuestoPaquetePromocionable_idPresupuesto UNIQUE (idPresupuesto)
;

ALTER TABLE PresupuestoServicio
	ADD CONSTRAINT UQ_PresupuestoServicio_idServicio UNIQUE (idServicio)
;

ALTER TABLE PresupuestoServicio
	ADD CONSTRAINT UQ_PresupuestoServicio_idPresupuesto UNIQUE (idPresupuesto)
;

ALTER TABLE PresupuestoTransporte
	ADD CONSTRAINT UQ_TransportePresupuesto_idPresupuesto UNIQUE (idPresupuesto)
;

ALTER TABLE PresupuestoTransporte
	ADD CONSTRAINT UQ_TransportePresupuesto_idProveedor UNIQUE (idProveedor)
;

ALTER TABLE Servicio
	ADD CONSTRAINT UQ_Servicio_idServicio UNIQUE (idServicio)
;

ALTER TABLE Transporte
	ADD CONSTRAINT UQ_Transporte_idProveedor UNIQUE (idProveedor)
;

ALTER TABLE Vendedor
	ADD CONSTRAINT UQ_Vendedor_legajo UNIQUE (legajo)
;

ALTER TABLE vendedorPresupuesto
	ADD CONSTRAINT UQ_vendedorPresupuesto_idPresupuesto UNIQUE (idPresupuesto)
;

ALTER TABLE vendedorPresupuesto
	ADD CONSTRAINT UQ_vendedorPresupuesto_legajo UNIQUE (legajo)
;

ALTER TABLE Cliente ADD CONSTRAINT PK_Cliente 
	PRIMARY KEY CLUSTERED (codigoCliente)
;

ALTER TABLE ClientePresupuesto ADD CONSTRAINT PK_ClientePresupuesto 
	PRIMARY KEY CLUSTERED (codigoCliente, idPresupuesto)
;

ALTER TABLE Encuesta ADD CONSTRAINT PK_Encuesta 
	PRIMARY KEY CLUSTERED (idEncuesta)
;

ALTER TABLE EncuestaVendedor ADD CONSTRAINT PK_EncuestaVendedor 
	PRIMARY KEY CLUSTERED (idEncuesta, legajo)
;

ALTER TABLE Hospedaje ADD CONSTRAINT PK_Hospedaje 
	PRIMARY KEY CLUSTERED (idProveedor)
;

ALTER TABLE PaquetesPromocionable ADD CONSTRAINT PK_PaquetesPromocionable 
	PRIMARY KEY CLUSTERED (idPaquetePromocionable)
;

ALTER TABLE Pasajero ADD CONSTRAINT PK_Pasajero 
	PRIMARY KEY CLUSTERED (idPasajero)
;

ALTER TABLE PasajeroPresupuesto ADD CONSTRAINT PK_PasajeroPresupuesto 
	PRIMARY KEY CLUSTERED (idPresupuesto, idPasajero)
;

ALTER TABLE presupuesto ADD CONSTRAINT PK_presupuesto 
	PRIMARY KEY CLUSTERED (idPresupuesto)
;

ALTER TABLE PresupuestoHospedaje ADD CONSTRAINT PK_PresupuestoHospedaje 
	PRIMARY KEY CLUSTERED (idPresupuesto, idProveedor)
;

ALTER TABLE PresupuestoPaquetePromocionable ADD CONSTRAINT PK_PresupuestoPaquetePromocionable 
	PRIMARY KEY CLUSTERED (idPresupuesto, idPaquetePromocionable)
;

ALTER TABLE PresupuestoServicio ADD CONSTRAINT PK_PresupuestoServicio 
	PRIMARY KEY CLUSTERED (idServicio, idPresupuesto)
;

ALTER TABLE PresupuestoTransporte ADD CONSTRAINT PK_TransportePresupuesto 
	PRIMARY KEY CLUSTERED (idPresupuesto, idProveedor)
;

ALTER TABLE Servicio ADD CONSTRAINT PK_Servicio 
	PRIMARY KEY CLUSTERED (idServicio)
;

ALTER TABLE Transporte ADD CONSTRAINT PK_Transporte 
	PRIMARY KEY CLUSTERED (idProveedor)
;

ALTER TABLE Vendedor ADD CONSTRAINT PK_Vendedor 
	PRIMARY KEY CLUSTERED (legajo)
;

ALTER TABLE vendedorPresupuesto ADD CONSTRAINT PK_vendedorPresupuesto 
	PRIMARY KEY CLUSTERED (legajo, idPresupuesto)
;