using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WsDatCustAcco_Dao.Global
{
    [DataContract]
    public class BaseBusquedaDao
    {
        [DataMember]
        public Byte CodigoCompania { get; set; }

        [DataMember]
        public String CodigoSesion { get; set; }

        [DataMember]
        public String Ordenamiento { get; set; }

        [DataMember]
        public String Agrupamiento { get; set; }

        [DataMember]
        public String Filtros { get; set; }

        [DataMember]
        public Int32 TamanoPagina { get; set; }

        [DataMember]
        public Int32 PaginaActual { get; set; }
    }
}
