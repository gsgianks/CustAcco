USE BDCustAcco;

DROP TABLE IF EXISTS segRoles;

CREATE TABLE segRoles(
	conRol SMALLINT IDENTITY PRIMARY KEY,
	desRol VARCHAR(120) NOT NULL,
	usrIngreso VARCHAR(35) NOT NULL,
	fecIngreso DATETIME NOT NULL,
	usrModifico VARCHAR(35) NULL,
	fecModifico DATETIME NULL
);

DROP TABLE IF EXISTS segAccesos;

CREATE TABLE segAccesos(
	cocAcceso VARCHAR(60) PRIMARY KEY,
	cocAccesoPadre VARCHAR(60) NOT NULL,
	numOrden SMALLINT NOT NULL,
	desController VARCHAR(60) NULL,
	desAction VARCHAR(60),
	desAcceso VARCHAR(120) NOT NULL,
	usrIngreso VARCHAR(35) NOT NULL,
	fecIngreso DATETIME NOT NULL,
	usrModifico VARCHAR(35) NULL,
	fecModifico DATETIME NULL,
);

DROP TABLE IF EXISTS segModulos;

CREATE TABLE segModulos(
	conModulo SMALLINT IDENTITY PRIMARY KEY,
	cocModulo VARCHAR(3) NOT NULL,
	desModulo VARCHAR(60) NOT NULL,
	numOrden SMALLINT NOT NULL,
	usrIngreso VARCHAR(35) NOT NULL,
	fecIngreso DATETIME NOT NULL,
	usrModifico VARCHAR(35) NULL,
	fecModifico DATETIME NULL
);

DROP TABLE IF EXISTS segRoles_Acceso;

CREATE TABLE segRoles_Acceso(
	cocAcceso VARCHAR(60),
	conRol SMALLINT,
	usrIngreso VARCHAR(35) NOT NULL,
	fecIngreso DATETIME NOT NULL,
	PRIMARY KEY(cocAcceso,conRol)
);

DROP TABLE IF EXISTS segUsuarios;

CREATE TABLE segUsuarios(
	conUsuario SMALLINT IDENTITY PRIMARY KEY,
	cocUsuario VARCHAR(120) NOT NULL,
	cocContrasena VARCHAR(60) NOT NULL,
	nomUsuario VARCHAR(60) NOT NULL,
	desPrimerApellido VARCHAR(60) NOT NULL,
	desSegundoApellido VARCHAR(60) NOT NULL,
	desCorreoElectronico VARCHAR(120) NOT NULL,
	usrIngreso VARCHAR(35) NOT NULL,
	fecIngreso DATETIME NOT NULL,
	cocSesionIngreso VARCHAR(120) NOT NULL,
	cocIpIngreso VARCHAR(35) NOT NULL,
	usrModifico VARCHAR(35) NULL,
	fecModifico DATETIME NULL,
	cocSesionModifico VARCHAR(120) NULL,
	cocIpModifico VARCHAR(35) NULL,
	cocEstado VARCHAR(3) NOT NULL,
);