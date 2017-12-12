using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WsDatCustAcco_Common.Global;
using WsDatCustAcco_Dao.ModuloGeneral;

namespace WsDatCustAcco_Common.ModuloGeneral
{
    public class ProveedorDat : AccesoBD
    {
        #region [Constructores]

        public ProveedorDat()
        {
            ProcedimientoMantenimiento = "Pa_gen_Mantenimiento_Proveedor";
        }

        #endregion [Constructores]

        #region [Funciones de la clase]

        private ProveedorDao ObtenerDesdeDataRow(DataRow fila)
        {
            ProveedorDao solicitudDao = new ProveedorDao()
            {
                CodigoProveedor = Utilitario.ObtenerValorSeguroByteNull(fila, ProveedorDao.CODIGO_PROVEEDOR),
                NombreProveedor = Utilitario.ObtenerValorSeguroString(fila, ProveedorDao.NOMBRE_PROVEEDOR),
                AliasProveedor = Utilitario.ObtenerValorSeguroString(fila, ProveedorDao.ALIAS_PROVEEDOR),
                EstadoProveedor = Utilitario.ObtenerValorSeguroString(fila, ProveedorDao.ESTADO_PROVEEDOR),
                DescripcionEstadoProveedor = Utilitario.ObtenerValorSeguroString(fila, ProveedorDao.DESCRIPCION_ESTADO_PROVEEDOR)
            };

            solicitudDao = (ProveedorDao)Utilitario.ObtenerDatosAuditoria(fila, solicitudDao);

            return solicitudDao;
        }

        #endregion [Funciones de la clase]

        #region [Acciones]



        #endregion [Acciones]
    }
}
