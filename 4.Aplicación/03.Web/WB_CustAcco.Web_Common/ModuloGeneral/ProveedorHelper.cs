using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WB_CustAcco.Web_Common.ClientServices;
using WB_CustAcco.Web_Common.GeneralAppService;
using WsComCustAcco_Common;
using static WsComCustAcco_Common.Enumeradores;

namespace WB_CustAcco.Web_Common.ModuloGeneral
{
    public class ProveedorHelper: GeneralAppClientService
    {
        private static ProveedorHelper instancia;

        public static ProveedorHelper Instanciar()
        {
            if (instancia == null)
            {
                instancia = new ProveedorHelper();
            }

            return instancia;
        }

        public ProveedorDao Ingresar(ProveedorDao solicitudDao)
        {
            ProveedorDao resultadoDao = new ProveedorDao();

            var client = GetServiceClient();

            try
            {
                resultadoDao = client.IngresarProveedor(solicitudDao);
            }
            catch (Exception ex)
            {
                resultadoDao.ResultadoEjecucion = new ResultadoEjecucion()
                {
                    CodigoError = -3,
                    MensajeErrorTecnico = "[" + CapaEjecucion.Web.ToString() + "] " +
                                          "[ClasificacionHelper.Ingresar()] " +
                                          ex.Message,
                    MensajeErrorUsuario = String.Empty
                };
            }
            finally
            {
                CloseServiceClient(client);
            }

            return resultadoDao;
        }

        public ProveedorDao Editar(ProveedorDao solicitudDao)
        {
            ProveedorDao resultadoDao = new ProveedorDao();

            var client = GetServiceClient();

            try
            {
                resultadoDao = client.EditarProveedor(solicitudDao);
            }
            catch (Exception ex)
            {
                resultadoDao.ResultadoEjecucion = new ResultadoEjecucion()
                {
                    CodigoError = -3,
                    MensajeErrorTecnico = "[" + CapaEjecucion.Web.ToString() + "] " +
                                          "[ClasificacionHelper.Editar()] " +
                                          ex.Message,
                    MensajeErrorUsuario = String.Empty
                };
            }
            finally
            {
                CloseServiceClient(client);
            }

            return resultadoDao;
        }

        public ResultadoEjecucion Eliminar(ProveedorDao solicitudDao)
        {
            var client = GetServiceClient();

            ResultadoEjecucion resultado = new ResultadoEjecucion();

            try
            {
                resultado = client.EliminarProveedor(solicitudDao);
            }
            catch (Exception ex)
            {
                resultado = new ResultadoEjecucion()
                {
                    CodigoError = -3,
                    MensajeErrorTecnico = "[" + CapaEjecucion.Web.ToString() + "] " +
                                          "[ProveedorHelper.Eliminar()] " +
                                          ex.Message,
                    MensajeErrorUsuario = String.Empty
                };

            }
            finally
            {
                CloseServiceClient(client);
            }
            return resultado;
        }

        public ResultadoEjecucion Activar(ProveedorDao solicitudDao)
        {
            var client = GetServiceClient();

            ResultadoEjecucion resultado = new ResultadoEjecucion();

            try
            {
                resultado = client.ActivarProveedor(solicitudDao);
            }
            catch (Exception ex)
            {
                resultado = new ResultadoEjecucion()
                {
                    CodigoError = -3,
                    MensajeErrorTecnico = "[" + CapaEjecucion.Web.ToString() + "] " +
                                          "[ProveedorHelper.Activar()] " +
                                          ex.Message,
                    MensajeErrorUsuario = String.Empty
                };
            }
            finally
            {
                CloseServiceClient(client);
            }
            return resultado;
        }

        public ProveedorDao Obtener(Byte? codigoProveedor, ref Int16 codigoError, ref String mensajeError)
        {
            ProveedorDao resultadoDao = new ProveedorDao();

            var client = GetServiceClient();

            try
            {
                resultadoDao = client.ObtenerProveedor(codigoProveedor, ref codigoError, ref mensajeError);
            }
            catch (Exception ex)
            {
                resultadoDao.ResultadoEjecucion = new ResultadoEjecucion()
                {
                    CodigoError = -3,
                    MensajeErrorTecnico = "[" + CapaEjecucion.Web.ToString() + "] " +
                                          "[ProveedorHelper.Obtener()] " +
                                          ex.Message,
                    MensajeErrorUsuario = String.Empty
                };
                
            }
            finally
            {
                CloseServiceClient(client);
            }

            return resultadoDao;
        }
    }
}
