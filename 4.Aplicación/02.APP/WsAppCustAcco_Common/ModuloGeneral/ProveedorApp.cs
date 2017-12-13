using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WsDatCustAcco_Common.ModuloGeneral;
using WsDatCustAcco_Dao.Global;
using WsDatCustAcco_Dao.ModuloGeneral;
using static WsComCustAcco_Common.Enumeradores;

namespace WsAppCustAcco_Common.ModuloGeneral
{
    public class ProveedorApp
    {
        static ProveedorDat dat = new ProveedorDat();

        public static ProveedorDao Ingresar(ProveedorDao solicitudDao)
        {
            ProveedorDao resultadoDao = new ProveedorDao();

            try
            {
                resultadoDao = dat.Ingresar(solicitudDao);
            }
            catch (Exception ex)
            {
                resultadoDao = new ProveedorDao()
                {
                    ResultadoEjecucion = new ResultadoEjecucion()
                    {
                        CodigoError = -2,
                        MensajeErrorTecnico = "[" + CapaEjecucion.APP.ToString() + "] " +
                                                              "[ProveedorApp.Ingresar()] " +
                                                              ex.Message,
                        MensajeErrorUsuario = String.Empty
                    }
                };
            }

            return resultadoDao;
        }

        public static ProveedorDao Editar(ProveedorDao solicitudDao)
        {
            ProveedorDao resultadoDao = new ProveedorDao();
            try
            {
                resultadoDao = dat.Editar(solicitudDao);
            }
            catch (Exception ex)
            {
                resultadoDao = new ProveedorDao()
                {
                    ResultadoEjecucion = new ResultadoEjecucion()
                    {
                        CodigoError = -2,
                        MensajeErrorTecnico = "[" + CapaEjecucion.APP.ToString() + "] " +
                                                                             "[ProveedorApp.Editar()] " +
                                                                             ex.Message,
                        MensajeErrorUsuario = String.Empty
                    }
                };
            }

            return resultadoDao;
        }

        public static ResultadoEjecucion Eliminar(ProveedorDao solicitudDao)
        {
            ResultadoEjecucion resultado = new ResultadoEjecucion();
            try
            {
                resultado = dat.Eliminar(solicitudDao);
            }
            catch (Exception ex)
            {
                resultado = new ResultadoEjecucion()
                {
                    CodigoError = -2,
                    MensajeErrorTecnico = "[" + CapaEjecucion.APP.ToString() + "] " +
                                          "[ProveedorApp.Eliminar()] " +
                                           ex.Message,
                    MensajeErrorUsuario = String.Empty
                };
            }

            return resultado;
        }

        public static ResultadoEjecucion Activar(ProveedorDao solicitudDao)
        {
            ResultadoEjecucion resultado = new ResultadoEjecucion();
            try
            {
                resultado = dat.Activar(solicitudDao);
            }
            catch (Exception ex)
            {
                resultado = new ResultadoEjecucion()
                {
                    CodigoError = -2,
                    MensajeErrorTecnico = "[" + CapaEjecucion.APP.ToString() + "] " +
                                          "[ProveedorApp.Activar()] " +
                                           ex.Message,
                    MensajeErrorUsuario = String.Empty
                };
            }

            return resultado;
        }

        public static ProveedorDao Obtener(Byte? codigoProveedor, ref Int16 codigoError, ref String mensajeError)
        {
            ProveedorDao resultadoDao = new ProveedorDao();
            try
            {
                resultadoDao = dat.Obtener(codigoProveedor, ref codigoError, ref mensajeError);
            }
            catch (Exception ex)
            {
                resultadoDao = new ProveedorDao()
                {
                    ResultadoEjecucion = new ResultadoEjecucion()
                    {
                        CodigoError = -2,
                        MensajeErrorTecnico = "[" + CapaEjecucion.APP.ToString() + "] " +
                                              "[ProveedorApp.Obtener()] " +
                                              ex.Message,
                        MensajeErrorUsuario = String.Empty
                    }
                };
            }

            return resultadoDao;
        }
    }
}
