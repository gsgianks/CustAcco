using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WsDatCustAcco_Common.Global;
using WsDatCustAcco_Dao.ModuloSeguridad;

namespace WsDatCustAcco_Common.ModuloSeguridad
{
    public class UsuarioDat : AccesoBD
    {
        #region [Constructores]

        public UsuarioDat()
        {
            ProcedimientoMantenimiento = "Pa_seg_Mantenimiento_Usuario";
        }

        #endregion [Constructores]

        #region [Funciones de la clase]

        private UsuarioDao ObtenerDesdeDataRow(DataRow fila)
        {
            UsuarioDao solicitudDao = new UsuarioDao()
            {
                ConsecutivoUsuario = Utilitario.ObtenerValorSeguroByteNull(fila, UsuarioDao.CONSECUTIVO_USUARIO),
                NombreUsuario = Utilitario.ObtenerValorSeguroString(fila, UsuarioDao.NOMBRE_USUARIO),
                PrimerApellidoUsuario = Utilitario.ObtenerValorSeguroString(fila, UsuarioDao.PRIMER_APELLIDO_USUARIO),
                SegundoApellidoUsuario = Utilitario.ObtenerValorSeguroString(fila, UsuarioDao.SEGUNDO_APELLIDO_USUARIO),
                CorreoElectronicoUsuario = Utilitario.ObtenerValorSeguroString(fila, UsuarioDao.CORREO_ELECTRONICO_USUARIO),
                CodigoUsuario = Utilitario.ObtenerValorSeguroString(fila, UsuarioDao.CODIGO_USUARIO),
                CodigoContrasenaUsuario = Utilitario.ObtenerValorSeguroString(fila, UsuarioDao.CODIGO_CONTRASENA_USUARIO),
                EstadoUsuario = Utilitario.ObtenerValorSeguroString(fila, UsuarioDao.CODIGO_ESTADO_USUARIO),
                DescripcionEstadoUsuario = Utilitario.ObtenerValorSeguroString(fila, UsuarioDao.DESCRIPCION_ESTADO_USUARIO),
            };

            solicitudDao = (UsuarioDao)Utilitario.ObtenerDatosAuditoria(fila, solicitudDao);

            return solicitudDao;
    }

    #endregion [Funciones de la clase]

    #region [Acciones]



    #endregion [Acciones]
}
}
