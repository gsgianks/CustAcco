USE BDCustAcco;

DROP TABLE IF EXISTS genCompania

CREATE TABLE genCompania(
	conCompania SMALLINT IDENTITY PRIMARY KEY,
	nomCompania VARCHAR(45) NOT NULL,
	conCliente TINYINT NOT NULL,
	cocMoneda CHAR(3) NOT NULL,
	cocEstado CHAR(3) NOT NULL,
	usrIngreso VARCHAR(35) NOT NULL,
	fecIngreso DATETIME DEFAULT GETDATE() NOT NULL,
	ipIngreso VARCHAR(12) NOT NULL,
	cocSesionIngreso VARCHAR(120) NOT NULL,
	usrModifico VARCHAR(35) NULL,
	fecModifico DATETIME NULL,
	ipModifico VARCHAR(12) NULL,
	cocSesionModifico VARCHAR(120) NULL,
)


DROP TABLE IF EXISTS genMoneda

CREATE TABLE genMoneda(
	cocMoneda CHAR(3) PRIMARY KEY,
	desMoneda VARCHAR(20),
	cocEstado CHAR(3) NOT NULL,
	usrIngreso VARCHAR(35) NOT NULL,
	fecIngreso DATETIME DEFAULT GETDATE() NOT NULL,
	ipIngreso VARCHAR(12) NOT NULL,
	cocSesionIngreso VARCHAR(120) NOT NULL,
	usrModifico VARCHAR(35) NULL,
	fecModifico DATETIME NULL,
	ipModifico VARCHAR(12) NULL,
	cocSesionModifico VARCHAR(120) NULL,
)

CREATE TABLE genCliente(
	conCliente TINYINT IDENTITY PRIMARY KEY,
	nomCliente VARCHAR(120) NOT NULL,
	desCorreoElectronico VARCHAR(120) NULL,
	desTelefono VARCHAR(14) NULL,
	cocEstado CHAR(3) NOT NULL,
	usrIngreso VARCHAR(35) NOT NULL,
	fecIngreso DATETIME DEFAULT GETDATE() NOT NULL,
	ipIngreso VARCHAR(12) NOT NULL,
	cocSesionIngreso VARCHAR(120) NOT NULL,
	usrModifico VARCHAR(35) NULL,
	fecModifico DATETIME NULL,
	ipModifico VARCHAR(12) NULL,
	cocSesionModifico VARCHAR(120) NULL,
)

CREATE TABLE genEstado(
	cocEstado CHAR(3) PRIMARY KEY,
	desEstado VARCHAR(12) NOT NULL,
	usrIngreso VARCHAR(35) NOT NULL,
	fecIngreso DATETIME DEFAULT GETDATE() NOT NULL,
	ipIngreso VARCHAR(12) NOT NULL,
	cocSesionIngreso VARCHAR(120) NOT NULL,
	usrModifico VARCHAR(35) NULL,
	fecModifico DATETIME NULL,
	ipModifico VARCHAR(12) NULL,
	cocSesionModifico VARCHAR(120) NULL,
)