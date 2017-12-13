using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WsAppCustAcco_Common.ModuloGeneral;
using WsDatCustAcco_Dao.Global;
using WsDatCustAcco_Dao.ModuloGeneral;

namespace WsAppCustAcco
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "GeneralAppService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione GeneralAppService.svc o GeneralAppService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class GeneralAppService : IGeneralAppService
    {
        #region [Proveedores]

        public ProveedorDao IngresarProveedor(ProveedorDao solicitudDao)
        {
            return ProveedorApp.Ingresar(solicitudDao);
        }

        public ProveedorDao EditarProveedor(ProveedorDao solicitudDao)
        {
            return ProveedorApp.Editar(solicitudDao);
        }

        public ResultadoEjecucion EliminarProveedor(ProveedorDao solicitudDao)
        {
            return ProveedorApp.Eliminar(solicitudDao);
        }

        public ResultadoEjecucion ActivarProveedor(ProveedorDao solicitudDao)
        {
            return ProveedorApp.Activar(solicitudDao);
        }

        public ProveedorDao ObtenerProveedor(Byte? codigoProveedor, ref Int16 codigoError, ref String mensajeError)
        {
            return ProveedorApp.Obtener(codigoProveedor, ref codigoError, ref mensajeError);
        }

        #endregion [Proveedores]
    }
}
