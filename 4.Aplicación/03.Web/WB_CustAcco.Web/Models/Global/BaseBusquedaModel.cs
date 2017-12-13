using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WB_CustAcco.Web.Models.Global
{
    public class BaseBusquedaModel
    {
        public Byte CodigoCompania { get; set; }

        public String CodigoSesion { get; set; }

        public String Ordenamiento { get; set; }

        public String Agrupamiento { get; set; }

        public String Filtros { get; set; }

        public int TamanoPagina { get; set; }

        public int PaginaActual { get; set; }

        public Boolean Indicador { get; set; }

        public BaseBusquedaModel()
        {
            TamanoPagina = int.MaxValue;
            PaginaActual = 1;
        }
    }
}