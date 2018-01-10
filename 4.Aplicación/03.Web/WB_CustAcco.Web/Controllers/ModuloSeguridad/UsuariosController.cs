using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WB_CustAcco.Web.Models.ModuloSeguridad;

namespace WB_CustAcco.Web.Controllers.ModuloSeguridad
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [AllowAnonymous]
        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult LogIn(UsuarioModel modelo)
        {
            if (ModelState.IsValid) {
                try
                {

                }
                catch (Exception ex)
                {
                    //error
                }

            }
            return View();
        }
    }
}