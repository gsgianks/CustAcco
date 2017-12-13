using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WB_CustAcco.Web.Utilities;

namespace WB_CustAcco.Web.Models.Global
{
    public class BaseModel
    {
        [Display(Name = EtiquetasUtility.ETIQ_SIS_GLOB_ACCIONES)]
        public Byte? Accion { get; set; }

        [Display(Name = EtiquetasUtility.ETIQ_SEC_AUDI_COMPANIA)]
        public Byte? CodigoCompania { get; set; }

        [Display(Name = EtiquetasUtility.ETIQ_SEC_AUDI_SESION)]
        public String CodigoSesion
        {
            get
            {
                return HttpContext.Current.Session.SessionID;
            }
        }

        public String SesionIngreso { get; set; }

        [Display(Name = EtiquetasUtility.ETIQ_SEC_AUDI_USUARIO_INGRESO)]
        public String UsuarioIngreso { get; set; }

        [Display(Name = EtiquetasUtility.ETIQ_SEC_AUDI_FECHA_INGRESO)]
        public DateTime? FechaIngreso { get; set; }

        [Display(Name = EtiquetasUtility.ETIQ_SEC_AUDI_IP_INGRESO)]
        public String IPIngreso { get; set; }


        public String SesionModifico { get; set; }

        [Display(Name = EtiquetasUtility.ETIQ_SEC_AUDI_USUARIO_MODIFICO)]
        public String UsuarioModifico { get; set; }

        [Display(Name = EtiquetasUtility.ETIQ_SEC_AUDI_FECHA_MODIFICO)]
        public DateTime? FechaModifico { get; set; }

        [Display(Name = EtiquetasUtility.ETIQ_SEC_AUDI_IP_MODIFICO)]
        public String IPModifico { get; set; }


        public String SesionActivo { get; set; }

        [Display(Name = EtiquetasUtility.ETIQ_SEC_AUDI_USUARIO_ACTIVO)]
        public String UsuarioActivo { get; set; }

        [Display(Name = EtiquetasUtility.ETIQ_SEC_AUDI_FECHA_ACTIVO)]
        public DateTime? FechaActivo { get; set; }

        [Display(Name = EtiquetasUtility.ETIQ_SEC_AUDI_IP_ACTIVO)]
        public String IPActivo { get; set; }


        public String SesionAnulo { get; set; }

        [Display(Name = EtiquetasUtility.ETIQ_SEC_AUDI_USUARIO_ANULO)]
        public String UsuarioAnulo { get; set; }

        [Display(Name = EtiquetasUtility.ETIQ_SEC_AUDI_FECHA_ANULO)]
        public DateTime? FechaAnulo { get; set; }

        [Display(Name = EtiquetasUtility.ETIQ_SEC_AUDI_IP_ANULO)]
        public String IPAnulo { get; set; }


        public int CodigoError { get; set; }

        public String MensajeErrorTecnico { get; set; }

        public String MensajeErrorUsuario { get; set; }


        public Boolean Indicador { get; set; }
    }
}