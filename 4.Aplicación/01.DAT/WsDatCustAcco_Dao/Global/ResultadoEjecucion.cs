using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WsDatCustAcco_Dao.Global
{
    public class ResultadoEjecucion
    {
        public ResultadoEjecucion()
        {
            CodigoError = 0;
        }

        [DataMember]
        public int CodigoError { get; set; }

        [DataMember]
        public String MensajeErrorTecnico { get; set; }

        [DataMember]
        public String MensajeErrorUsuario { get; set; }
    }
}
