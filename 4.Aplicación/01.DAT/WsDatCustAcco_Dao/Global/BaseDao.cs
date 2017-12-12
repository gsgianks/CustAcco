using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WsDatCustAcco_Dao.Global
{
    [DataContract]
    public class BaseDao
    {
        public const String CODIGO_COMPANIA = "Com_conCompania";

        public const String CODIGO_SESION_INGRESO = "cocSesionIngreso";
        public const String USUARIO_INGRESO = "cocUsuarioIngreso";
        public const String FECHA_INGRESO = "fecIngreso";
        public const String IP_INGRESO = "cocIPIngreso";

        public const String CODIGO_SESION_MODIFICO = "cocSesionModifico";
        public const String USUARIO_MODIFICO = "cocUsuarioModifico";
        public const String FECHA_MODIFICO = "fecModifico";
        public const String IP_MODIFICO = "cocIPModifico";

        public const String CODIGO_SESION_ACTIVO = "cocSesionActivo";
        public const String USUARIO_ACTIVO = "cocUsuarioActivo";
        public const String FECHA_ACTIVO = "fecActivo";
        public const String IP_ACTIVO = "cocIPActivo";

        public const String CODIGO_SESION_ANULO = "cocSesionAnulo";
        public const String USUARIO_ANULO = "cocUsuarioAnulo";
        public const String FECHA_ANULO = "fecAnulo";
        public const String IP_ANULO = "cocIPAnulo";

        public virtual String PrefijoTabla
        {
            get
            {
                return String.Empty;
            }
        }

        public virtual string NombreTabla
        {
            get
            {
                return String.Empty;
            }
        }

        [DataMember]
        public Byte CodigoCompania { get; set; }

        [DataMember]
        //[XmlIgnore]
        public String CodigoSesion { get; set; }

        [DataMember]
        public String SesionIngreso { get; set; }

        [DataMember]
        public String UsuarioIngreso { get; set; }

        [DataMember]
        public DateTime FechaIngreso { get; set; }

        [DataMember]
        public String IPIngreso { get; set; }


        [DataMember]
        public String SesionModifico { get; set; }

        [DataMember]
        public String UsuarioModifico { get; set; }

        [DataMember]
        public DateTime FechaModifico { get; set; }

        [DataMember]
        public String IPModifico { get; set; }


        [DataMember]
        public String SesionActivo { get; set; }

        [DataMember]
        public String UsuarioActivo { get; set; }

        [DataMember]
        public DateTime FechaActivo { get; set; }

        [DataMember]
        public String IPActivo { get; set; }


        [DataMember]
        public String SesionAnulo { get; set; }

        [DataMember]
        public String UsuarioAnulo { get; set; }

        [DataMember]
        public DateTime FechaAnulo { get; set; }

        [DataMember]
        public String IPAnulo { get; set; }

        [XmlIgnore]
        [DataMember]
        public ResultadoEjecucion ResultadoEjecucion { get; set; }

        [DataMember]
        public Boolean Indicador { get; set; }
    }
}
