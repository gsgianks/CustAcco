using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WB_CustAcco.Web.Models.ModuloSeguridad
{
    public class UsuarioModel
    {
        public Byte? ConsecutivoUsuario { get; set; } 

        public String NombreUsuario { get; set; }

        public String PrimerApellidoUsuario { get; set; }

        public String SegundoApellidoUsuario { get; set; }

        public String CorreoElectronicoUsuario { get; set; }
        [Display(Name = "Usuario")]
        [Required(ErrorMessage = "El usuario es requerido")]
        public String CodigoUsuario { get; set; }
        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "La contraseña es requerido")]
        public String CodigoContrasenaUsuario { get; set; }

        public String EstadoUsuario { get; set; }

        public String DescripcionEstadoUsuario { get; set; }
    }
}