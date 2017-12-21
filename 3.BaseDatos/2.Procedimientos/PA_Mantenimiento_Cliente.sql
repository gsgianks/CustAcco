USE BDCustAcco;

DROP PROCEDURE IF EXISTS PA_Mantenimiento_Cliente;

CREATE PROCEDURE PA_Mantenimiento_Cliente
@p_tipoOperacion TINYINT
AS
	IF(@p_tipoOperacion = 1)
		BEGIN
			SELECT conCliente, nomCliente, desCorreoElectronico,
				   desTelefono, cocEstado, usrIngreso, fecIngreso, ipIngreso, cocSesionIngreso, usrModifico, fecModifico, ipModifico,	cocSesionModifico 
			FROM genCliente;
		END
	END IF;

