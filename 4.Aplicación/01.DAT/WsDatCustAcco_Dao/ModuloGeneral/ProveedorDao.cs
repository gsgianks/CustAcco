using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WsDatCustAcco_Dao.Global;

namespace WsDatCustAcco_Dao.ModuloGeneral
{
    [DataContract]
    public class ProveedorDao : BaseDao
    {
        #region [Constantes de la clase]

        public const String CODIGO_PROVEEDOR = "conProveedor";
        public const String NOMBRE_PROVEEDOR = "nomProveedor";
        public const String ALIAS_PROVEEDOR = "nomAliasProveedor";
        public const String TELEFONO_PROVEEDOR = "desTelefono";
        public const String ESTADO_PROVEEDOR = "estProveedor";
        public const String DESCRIPCION_ESTADO_PROVEEDOR = "desProveedor";

        #endregion [Constantes de la clase]

        #region [Propiedades de la clase]

        [DataMember]
        public Byte? CodigoProveedor { get; set; }

        [DataMember]
        public String NombreProveedor { get; set; }

        [DataMember]
        public String AliasProveedor { get; set; }

        [DataMember]
        public String TelefonoProveedor { get; set; }

        [DataMember]
        public String EstadoProveedor { get; set; }

        [DataMember]
        public String DescripcionEstadoProveedor { get; set; }

        #endregion [Propiedades de la clase]

        #region [Constructores]

        public ProveedorDao()
        {
            ResultadoEjecucion = new Global.ResultadoEjecucion();
        }

        #endregion [Constructores]
    }

    [DataContract]
    public class ProveedorBusquedaDao : BaseBusquedaDao
    {
        #region [Propiedades de la clase]

        [DataMember]
        public Byte? CodigoProveedor { get; set; }

        [DataMember]
        public String NombreProveedor { get; set; }

        [DataMember]
        public String AliasProveedor { get; set; }

        [DataMember]
        public String TelefonoProveedor { get; set; }

        [DataMember]
        public String EstadoProveedor { get; set; }

        [DataMember]
        public String DescripcionEstadoProveedor { get; set; }

        #endregion [Propiedades de la clase]

        #region [Constructores]

        public ProveedorBusquedaDao()
        {
            TamanoPagina = Int32.MaxValue;
            PaginaActual = 1;
        }

        #endregion [Constructores]

    }
}
