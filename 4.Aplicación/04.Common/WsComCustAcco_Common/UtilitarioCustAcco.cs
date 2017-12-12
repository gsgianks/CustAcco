using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WsComCustAcco_Common
{
    public class UtilitarioCustAcco
    {
        public static String ObtenerFechaCadena()
        {
            DateTime fechaActual = DateTime.Now;

            String dia = fechaActual.Day.ToString("00");
            String mes = fechaActual.Month.ToString("00");
            String ano = fechaActual.Year.ToString("0000");
            String hora = fechaActual.Hour.ToString("00");
            String minuto = fechaActual.Minute.ToString("00");
            String segundo = fechaActual.Second.ToString("00");

            String fechaCadena = ano + mes + dia + hora + minuto + segundo;

            return fechaCadena;
        }
    }
}
