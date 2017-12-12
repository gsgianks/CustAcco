USE BDCustAcco
GO

CREATE TABLE genProveedor(
	conProveedor SMALLINT IDENTITY,
	nomProveedor VARCHAR(120) NOT NULL,
	nomAliasProveedor VARCHAR(120) NULL,
	desTelefono VARCHAR(12) NULL,
	estProveedor CHAR(3) NOT NULL,
	usrIngreso VARCHAR(35) NOT NULL,
	fecIngreso DATETIME NOT NULL,
	cocSesionIngreso VARCHAR(120) NOT NULL,
	cocIpIngreso VARCHAR(35) NOT NULL,
	usrModifico VARCHAR(35) NULL,
	fecModifico DATETIME NULL,
	cocSesionModifico VARCHAR(120) NULL, 
	cocIpModifico VARCHAR(35) NULL,
	usrActivo VARCHAR(35) NULL,
	fecActivo DATETIME NULL,
	cocSesionActivo VARCHAR(120) NULL,
	cocIpActivo VARCHAR(35) NULL,
	usrAnulo VARCHAR(35) NULL,
	fecAnulo DATETIME NULL,
	cocSesionAnulo VARCHAR(120) NULL,
	cocIpAnulo VARCHAR(35) NULL,
	PRIMARY KEY(conProveedor)
)