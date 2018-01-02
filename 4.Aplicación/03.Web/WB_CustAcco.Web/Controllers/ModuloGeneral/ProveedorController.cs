using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WB_CustAcco.Web.Models.ModuloGeneral;
using WB_CustAcco.Web.Utilities;
using static WsComCustAcco_Common.Enumeradores;

namespace WB_CustAcco.Web.Controllers.ModuloGeneral
{
    public class ProveedorController : Controller
    {

        #region [GET]

        public ActionResult Editar(Byte? codigoProveedor, Int32 codigoError = 0, String tipoMensajeError = null, String mensajeErrorUsuario = null, String mensajeErrorTecnico = null)
        {
            /*
             Se debe agregar las validaciones de seguridad
            */
            ProveedorModel modelo = new ProveedorModel();

            try
            {
                if (codigoProveedor == null || codigoProveedor == 0)
                {
                    modelo = new ProveedorModel()
                    {
                        EstadoProveedor = ConfiguracionUtility.ESTADO_INGRESADO
                    };
                }
                else
                {
                    modelo = modelo.Obtener(codigoProveedor);
                }
            }
            catch (Exception ex)
            {
                codigoError = -3;
                tipoMensajeError = EtiquetasUtility.VARI_SIS_GLOB_TIPO_MENSAJE_ERROR;
                mensajeErrorTecnico = "[" + CapaEjecucion.Web.ToString() + "] " +
                                      "[ClasificacionController.Editar()] " +
                                      ex.Message;
                mensajeErrorUsuario = EtiquetasUtility.MENE_SIS_GLOB_ERROR_NO_CONTROLADO;
            }

            ViewBag.AlertType = tipoMensajeError;
            ViewBag.UserMessage = mensajeErrorUsuario;
            ViewBag.DetailsMessage = mensajeErrorTecnico;

            return View(modelo);
        }

        #endregion [GET]

        #region [POST]

        [HttpPost]
        [OutputCache(NoStore = true, Duration = 1)]
        public ActionResult Editar(ProveedorModel modelo)
        {
            int codigoError = 0;
            String tipoMensajeError = String.Empty;
            String mensajeErrorTecnico = String.Empty;
            String mensajeErrorUsuario = String.Empty;

            Byte? codigo = modelo.CodigoProveedor;

            if (codigo == null || codigo == 0)
            {
                modelo = modelo.Ingresar();

                if (modelo.CodigoError == 0)
                {
                    codigoError = 0;
                    tipoMensajeError = EtiquetasUtility.VARI_SIS_GLOB_TIPO_MENSAJE_CONFIRMACION;
                    mensajeErrorUsuario = EtiquetasUtility.MENC_SIS_GLOB_INGRESO_CONFIRMACION;
                    mensajeErrorTecnico = String.Empty;
                }
                else
                {
                    codigoError = modelo.CodigoError;
                    tipoMensajeError = EtiquetasUtility.VARI_SIS_GLOB_TIPO_MENSAJE_ERROR;
                    mensajeErrorUsuario = EtiquetasUtility.MENE_SIS_GLOB_INGRESO_ERROR;
                    mensajeErrorTecnico = modelo.MensajeErrorTecnico;
                }

                codigo = 0;
            }
            else
            {
                modelo = modelo.Editar();

                if (modelo.CodigoError == 0)
                {
                    codigoError = 0;
                    tipoMensajeError = EtiquetasUtility.VARI_SIS_GLOB_TIPO_MENSAJE_CONFIRMACION;
                    mensajeErrorUsuario = EtiquetasUtility.MENC_SIS_GLOB_EDICION_CONFIRMACION;
                    mensajeErrorTecnico = String.Empty;
                }
                else
                {
                    codigoError = modelo.CodigoError;
                    tipoMensajeError = EtiquetasUtility.VARI_SIS_GLOB_TIPO_MENSAJE_ERROR;
                    mensajeErrorUsuario = EtiquetasUtility.MENE_SIS_GLOB_EDICION_ERROR;
                    mensajeErrorTecnico = modelo.MensajeErrorTecnico;
                }
            }

            return RedirectToAction("Editar", new RouteValueDictionary{
                {"controller", "Proveedor"},
                {"action", "Editar"},
                {"codigoProveedor", codigo},
                {"codigoError", codigoError },
                {"tipoMensajeError", tipoMensajeError},
                {"mensajeErrorUsuario", mensajeErrorUsuario},
                {"mensajeErrorTecnico", mensajeErrorTecnico}
            });
        }


        #endregion [POST]
    }
}