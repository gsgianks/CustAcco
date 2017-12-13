using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WsDatCustAcco_Dao.Global;
using WsDatCustAcco_Dao.ModuloGeneral;

namespace WsAppCustAcco
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IGeneralAppService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IGeneralAppService
    {
        #region [Proveedores]

        [OperationContract]
        ProveedorDao IngresarProveedor(ProveedorDao solicitudDao);

        [OperationContract]
        ProveedorDao EditarProveedor(ProveedorDao solicitudDao);

        [OperationContract]
        ResultadoEjecucion EliminarProveedor(ProveedorDao solicitudDao);

        [OperationContract]
        ResultadoEjecucion ActivarProveedor(ProveedorDao solicitudDao);

        [OperationContract]
        ProveedorDao ObtenerProveedor(Byte? codigoProveedor, ref Int16 codigoError, ref String mensajeError);

        #endregion [Proveedores]
    }
}
