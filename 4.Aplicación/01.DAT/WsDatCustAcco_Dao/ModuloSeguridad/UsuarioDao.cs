using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WsDatCustAcco_Dao.Global;

namespace WsDatCustAcco_Dao.ModuloSeguridad
{
    [DataContract]
    public class UsuarioDao : BaseDao
    {
        #region [Constantes de la clase]

        public const String CONSECUTIVO_USUARIO = "conUsuario";
        public const String CODIGO_USUARIO = "cocUsuario";
        public const String CODIGO_CONTRASENA_USUARIO = "cocContrasena";
        public const String NOMBRE_USUARIO = "nomUsuario";
        public const String PRIMER_APELLIDO_USUARIO = "desPrimerApellido";
        public const String SEGUNDO_APELLIDO_USUARIO = "desSegundoApellido";
        public const String CORREO_ELECTRONICO_USUARIO = "desCorreoElectronico";
        public const String CODIGO_ESTADO_USUARIO = "cocEstado";
        public const String DESCRIPCION_ESTADO_USUARIO = "desEstado";

        #endregion [Constantes de la clase]

        #region [Propiedades de la clase]

        [DataMember]
        public Byte? ConsecutivoUsuario { get; set; }

        [DataMember]
        public String NombreUsuario { get; set; }

        [DataMember]
        public String PrimerApellidoUsuario { get; set; }

        [DataMember]
        public String SegundoApellidoUsuario { get; set; }

        [DataMember]
        public String CorreoElectronicoUsuario { get; set; }

        [DataMember]
        public String CodigoUsuario { get; set; }

        [DataMember]
        public String CodigoContrasenaUsuario { get; set; }

        [DataMember]
        public String EstadoUsuario { get; set; }

        [DataMember]
        public String DescripcionEstadoUsuario { get; set; }

        #endregion [Propiedades de la clase]

        #region [Constructores]

        public UsuarioDao()
        {
            ResultadoEjecucion = new Global.ResultadoEjecucion();
        }

        #endregion [Constructores]
    }

    [DataContract]
    public class UsuarioBusquedaDao : BaseBusquedaDao
    {
        #region [Propiedades de la clase]

        [DataMember]
        public Byte? ConsecutivoUsuario { get; set; }

        [DataMember]
        public String NombreUsuario { get; set; }

        [DataMember]
        public String PrimerApellidoUsuario { get; set; }

        [DataMember]
        public String SegundoApellidoUsuario { get; set; }

        [DataMember]
        public String CorreoElectronicoUsuario { get; set; }

        [DataMember]
        public String CodigoUsuario { get; set; }

        [DataMember]
        public String CodigoContrasenaUsuario { get; set; }

        [DataMember]
        public String EstadoUsuario { get; set; }

        [DataMember]
        public String DescripcionEstadoUsuario { get; set; }

        #endregion [Propiedades de la clase]

        #region [Constructores]

        public UsuarioBusquedaDao()
        {
            TamanoPagina = Int32.MaxValue;
            PaginaActual = 1;
        }

        #endregion [Constructores]

    }
}
