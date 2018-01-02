using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WsDatCustAcco_Common.Global;
using WsDatCustAcco_Dao.Global;
using WsDatCustAcco_Dao.ModuloGeneral;
using static WsComCustAcco_Common.Enumeradores;
using static WsDatCustAcco_Common.Global.Enumeradores;

namespace WsDatCustAcco_Common.ModuloGeneral
{
    public class ProveedorDat : AccesoBD
    {
        #region [Constructores]

        public ProveedorDat()
        {
            ProcedimientoMantenimiento = "Pa_Mantenimiento_genProveedores";
        }

        #endregion [Constructores]

        #region [Funciones de la clase]

        private ProveedorDao ObtenerDesdeDataRow(DataRow fila)
        {
            ProveedorDao solicitudDao = new ProveedorDao()
            {
                CodigoProveedor = Utilitario.ObtenerValorSeguroByteNull(fila, ProveedorDao.CODIGO_PROVEEDOR),
                NombreProveedor = Utilitario.ObtenerValorSeguroString(fila, ProveedorDao.NOMBRE_PROVEEDOR),
                AliasProveedor = Utilitario.ObtenerValorSeguroString(fila, ProveedorDao.ALIAS_PROVEEDOR),
                EstadoProveedor = Utilitario.ObtenerValorSeguroString(fila, ProveedorDao.ESTADO_PROVEEDOR),
                DescripcionEstadoProveedor = Utilitario.ObtenerValorSeguroString(fila, ProveedorDao.DESCRIPCION_ESTADO_PROVEEDOR)
            };

            solicitudDao = (ProveedorDao)Utilitario.ObtenerDatosAuditoria(fila, solicitudDao);

            return solicitudDao;
        }

        #endregion [Funciones de la clase]

        #region [Variables globales]

        Int16 codigoError = 0;
        String mensajeError = String.Empty;

        #endregion [Variables globales]

        #region [Acciones]

        public ProveedorDao Ingresar(ProveedorDao solicitudDao)
        {
            String procedimiento = ProcedimientoMantenimiento;
            ProveedorDao resultadoDao = new ProveedorDao();

            DataTable dt = new DataTable();
            

            resultadoDao.ResultadoEjecucion = new ResultadoEjecucion();

            try
            {
                List<ParametroDao> parametros = new List<ParametroDao>();

                parametros.Add(new ParametroDao { NombreParametro = "@pnumOperacionMantenimiento", ValorParametro = TipoOperacionMantenimiento.Obtener, TipoDato = DbType.Int16 });
                parametros.Add(new ParametroDao { NombreParametro = "@pnomProveedor", ValorParametro = solicitudDao.NombreProveedor, TipoDato = DbType.String });
                parametros.Add(new ParametroDao { NombreParametro = "@pnomAliasProveedor", ValorParametro=solicitudDao.AliasProveedor, TipoDato=DbType.String});
                parametros.Add(new ParametroDao { NombreParametro = "@pdesTelefono", ValorParametro = solicitudDao.TelefonoProveedor, TipoDato = DbType.String });
                parametros.Add(new ParametroDao { NombreParametro = "@pcocSesion", ValorParametro = solicitudDao.CodigoSesion, TipoDato = DbType.String });
                parametros.Add(new ParametroDao { NombreParametro = "@pusrIngreso", ValorParametro = "Alex", TipoDato = DbType.String });
                parametros.Add(new ParametroDao { NombreParametro = "@pcocIpIngreso", ValorParametro = "127.0.0.1", TipoDato = DbType.String });

                dt = Utilitario.EjecutarProcedimientoDataTable(ProcedimientoMantenimiento, parametros, ref codigoError, ref mensajeError);

                if (codigoError == 0)
                {
                    if (dt.Rows.Count > 0)
                    {
                        solicitudDao.CodigoProveedor = (Byte?)dt.Rows[0][ProveedorDao.CODIGO_PROVEEDOR];
                        resultadoDao = Obtener(solicitudDao.CodigoProveedor, ref codigoError, ref mensajeError);
                    }
                }
                

            }
            catch (Exception ex)
            {
                resultadoDao = new ProveedorDao()
                {
                    ResultadoEjecucion = new ResultadoEjecucion()
                    {
                        CodigoError = -1,
                        MensajeErrorTecnico = "[" + CapaEjecucion.DAT.ToString() + "] " +
                                              "[ProveedorDat.Ingresar()] " +
                                              ex.Message,
                        MensajeErrorUsuario = String.Empty
                    }
                };
            }

            return resultadoDao;
        }

        public ProveedorDao Editar(ProveedorDao solicitudDao)
        {
            String procedimiento = ProcedimientoMantenimiento;
            List<ParametroDao> parametros = new List<ParametroDao>();
            ProveedorDao resultadoDao = new ProveedorDao();
            DataTable dt = new DataTable();
            resultadoDao.ResultadoEjecucion = new ResultadoEjecucion();

            try
            {
                parametros.Add(new ParametroDao { NombreParametro = "@pTipoOperacionMantenimiento", ValorParametro = TipoOperacionMantenimiento.Modificar, TipoDato = DbType.Int16 });
                parametros.Add(new ParametroDao { NombreParametro = "@pCodigoProveedor", ValorParametro = solicitudDao.NombreProveedor, TipoDato = DbType.Byte });
                parametros.Add(new ParametroDao { NombreParametro = "@", ValorParametro = solicitudDao.AliasProveedor, TipoDato = DbType.String });
                parametros.Add(new ParametroDao { NombreParametro = "@", ValorParametro = solicitudDao.TelefonoProveedor, TipoDato = DbType.String });

                dt = Utilitario.EjecutarProcedimientoDataTable(procedimiento, parametros, ref codigoError, ref mensajeError);

                if (codigoError == 0)
                {
                    resultadoDao = Obtener(solicitudDao.CodigoProveedor, ref codigoError, ref mensajeError);
                }
            }
            catch (Exception ex)
            {
                resultadoDao = new ProveedorDao()
                {
                    ResultadoEjecucion = new ResultadoEjecucion()
                    {
                        CodigoError = -1,
                        MensajeErrorTecnico = "[" + CapaEjecucion.DAT.ToString() + "] " +
                                              "[ProveedorDat.Editar()] " +
                                              ex.Message,
                        MensajeErrorUsuario = String.Empty
                    }
                };
            }

            return resultadoDao;
        }

        public ResultadoEjecucion Eliminar(ProveedorDao solicitudDao)
        {
            String procedimiento = ProcedimientoMantenimiento;
            Boolean indicadorResultado = true;
            ProveedorDao resultadoDao = new ProveedorDao();
            ResultadoEjecucion resultado = new ResultadoEjecucion();
            List<ParametroDao> parametros = new List<ParametroDao>();

            try
            {
                parametros.Add(new ParametroDao { NombreParametro = "@pTipoOperacionMantenimiento", ValorParametro = TipoOperacionMantenimiento.Eliminar, TipoDato = DbType.Int16 });
                parametros.Add(new ParametroDao { NombreParametro = "@pCodigoProveedor", ValorParametro = solicitudDao.NombreProveedor, TipoDato = DbType.Byte });

                indicadorResultado = Utilitario.EjecutarProcedimiento(procedimiento, parametros);

                if (!indicadorResultado)
                {
                    //Validar que se generó un error al eliminar
                }
            }
            catch (Exception ex)
            {
                resultado = new ResultadoEjecucion()
                {
                    CodigoError = -1,
                    MensajeErrorTecnico = "[" + CapaEjecucion.DAT.ToString() + "] " +
                                          "[ProveedorDat.Eliminar()] " +
                                          ex.Message,
                    MensajeErrorUsuario = String.Empty
                };
            }

            return resultado;
        }

        public ResultadoEjecucion Activar(ProveedorDao solicitudDao)
        {
            String procedimiento = ProcedimientoMantenimiento;
            Boolean indicadorResultado = true;
            ProveedorDao resultadoDao = new ProveedorDao();
            ResultadoEjecucion resultado = new ResultadoEjecucion();
            List<ParametroDao> parametros = new List<ParametroDao>();

            try
            {
                parametros.Add(new ParametroDao { NombreParametro = "@pTipoOperacionMantenimiento", ValorParametro = TipoOperacionMantenimiento.Eliminar, TipoDato = DbType.Int16 });
                parametros.Add(new ParametroDao { NombreParametro = "@pCodigoProveedor", ValorParametro = solicitudDao.NombreProveedor, TipoDato = DbType.Byte });

                indicadorResultado = Utilitario.EjecutarProcedimiento(procedimiento, parametros);

                if (!indicadorResultado)
                {
                    //Validar que se generó un error al eliminar
                }
            }
            catch (Exception ex)
            {
                resultado = new ResultadoEjecucion()
                {
                    CodigoError = -1,
                    MensajeErrorTecnico = "[" + CapaEjecucion.DAT.ToString() + "] " +
                                          "[ProveedorDat.Activar()] " +
                                          ex.Message,
                    MensajeErrorUsuario = String.Empty
                };
            }

            return resultado;
        }

        public ProveedorDao Obtener(Byte? codigo_Proveedor, ref Int16 codigoError, ref String mensajeError)
        {
            List<ParametroDao> parametros = new List<ParametroDao>();
            ProveedorDao resultadoDao = new ProveedorDao();
            try
            {
                parametros.Add(new ParametroDao { NombreParametro = "@pTipoOperacionMantenimiento", ValorParametro = TipoOperacionMantenimiento.Obtener, TipoDato = DbType.Int16 });
                parametros.Add(new ParametroDao { NombreParametro = "@pcodigo_Proveedor", ValorParametro = codigo_Proveedor, TipoDato = DbType.Byte });

                DataTable resultado = Utilitario.EjecutarProcedimientoDataTable(ProcedimientoMantenimiento, parametros, ref codigoError, ref mensajeError);

                if (codigoError == 0)
                {
                    if (resultado.Rows.Count > 0)
                    {
                        foreach (DataRow fila in resultado.Rows)
                        {
                            resultadoDao = ObtenerDesdeDataRow(fila);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                resultadoDao = new ProveedorDao()
                {
                    ResultadoEjecucion = new ResultadoEjecucion()
                    {
                        CodigoError = -1,
                        MensajeErrorTecnico = "[" + CapaEjecucion.DAT.ToString() + "]" +
                                              "[ProveedorDat.Obtener()]" +
                                              ex.Message,
                        MensajeErrorUsuario = String.Empty
                    }
                };

            }

            return resultadoDao;
        }



        #endregion [Acciones]
    }
}
