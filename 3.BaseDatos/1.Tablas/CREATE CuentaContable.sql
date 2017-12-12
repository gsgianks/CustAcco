CREATE DATABASE BDCustAcco;

USE BDCustAcco;

CREATE TABLE conCuentContable(
	conCuentaContable INT PRIMARY KEY IDENTITY,
	nomNombreCuentaContable VARCHAR(60) NOT NULL,
	cocCuentaContable VARCHAR(60) NOT NULL,
	cocCuentaContableMadre VARCHAR(60) NULL,
	codNaturalezaCuentaContable TINYINT NOT NULL,
	indAfectaCuentaContable BIT NOT NULL,
	usrIngreso VARCHAR(35) NOT NULL,
	fecIngreso DATETIME NOT NULL,
	cocSesionIngreso VARCHAR(120) NOT NULL,
	cocIpIngreso VARCHAR(35) NOT NULL,
	usrModifico VARCHAR(35) NULL,
	fecModifico DATETIME NULL,
	cocSesionModifico VARCHAR(120) NULL,
	cocIpModifico VARCHAR(35) NULL,
	usrAnulo VARCHAR(35) NULL,
	fecAnulo DATETIME NULL,
	cocSesionAnulo VARCHAR(120) NULL,
	cocIpAnulo VARCHAR(35) NULL
)