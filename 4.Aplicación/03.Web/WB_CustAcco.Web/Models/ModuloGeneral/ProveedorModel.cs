using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WB_CustAcco.Web.Models.Global;
using WB_CustAcco.Web.Utilities;
using WB_CustAcco.Web_Common.GeneralAppService;
using WB_CustAcco.Web_Common.ModuloGeneral;
using static WsComCustAcco_Common.Enumeradores;

namespace WB_CustAcco.Web.Models.ModuloGeneral
{
    public class ProveedorModel : BaseModel
    {
        #region [Propiedades de la clase]

        [Display(Name = EtiquetasUtility.ETIQ_GEN_PRO_CODIGO)]
        [Required(AllowEmptyStrings = false, ErrorMessage = EtiquetasUtility.MENS_SIS_GLOB_REQUERIDO)]
        [Range(1, 254, ErrorMessage = EtiquetasUtility.MENS_SIS_GLOB_FORMATO_INVALIDO)]
        public Byte? CodigoProveedor { get; set; }

        [Display(Name = EtiquetasUtility.ETIQ_GEN_PRO_NOMBRE)]
        [Required(AllowEmptyStrings = false, ErrorMessage = EtiquetasUtility.MENS_SIS_GLOB_REQUERIDO)]
        [MaxLength(120, ErrorMessage = EtiquetasUtility.MENS_SIS_GLOB_FORMATO_INVALIDO)]
        public String NombreProveedor { get; set; }

        [Display(Name = EtiquetasUtility.ETIQ_GEN_PRO_ALIAS)]
        [Required(AllowEmptyStrings = false, ErrorMessage = EtiquetasUtility.ETIQ_SIS_GLOB_REQUERIDO)]
        [MaxLength(120, ErrorMessage = EtiquetasUtility.MENS_SIS_GLOB_FORMATO_INVALIDO)]
        public String AliasProveedor { get; set; }

        [Display(Name = EtiquetasUtility.ETIQ_GEN_PRO_TELEFONO)]
        [Required(AllowEmptyStrings = false, ErrorMessage = EtiquetasUtility.ETIQ_SIS_GLOB_REQUERIDO)]
        [MaxLength(12, ErrorMessage = EtiquetasUtility.MENS_SIS_GLOB_FORMATO_INVALIDO)]
        public String TelefonoProveedor { get; set; }

        [Display(Name = EtiquetasUtility.ETIQ_GEN_PRO_ESTADO)]
        [Required(AllowEmptyStrings = false, ErrorMessage = EtiquetasUtility.ETIQ_SIS_GLOB_REQUERIDO)]
        public String EstadoProveedor { get; set; }

        [Display(Name = EtiquetasUtility.ETIQ_GEN_PRO_ESTADO)]
        public String DescripcionEstadoProveedor { get; set; }

        #endregion [Propiedades de la clase]

        #region [Constructores]

        public ProveedorModel() { }

        #endregion [Constructores]

        #region [Funciones de la clase]

        public ProveedorModel ConvertirAModelo(ProveedorDao dao)
        {
            ProveedorModel modelo = new ProveedorModel();

            modelo.CodigoProveedor = dao.CodigoProveedor;
            modelo.NombreProveedor = dao.NombreProveedor;
            modelo.AliasProveedor = dao.AliasProveedor;
            modelo.TelefonoProveedor = dao.TelefonoProveedor;
            modelo.EstadoProveedor = dao.EstadoProveedor;
            modelo.DescripcionEstadoProveedor = dao.DescripcionEstadoProveedor;

            modelo.UsuarioIngreso = dao.UsuarioIngreso;
            modelo.FechaIngreso = dao.FechaIngreso;
            modelo.IPIngreso = dao.IPIngreso;
            modelo.SesionIngreso = dao.SesionIngreso;

            modelo.UsuarioModifico = dao.UsuarioModifico;
            modelo.FechaModifico = dao.FechaModifico;
            modelo.IPModifico = dao.IPModifico;
            modelo.SesionModifico = dao.SesionModifico;

            modelo.UsuarioActivo = dao.UsuarioActivo;
            modelo.FechaActivo = dao.FechaActivo;
            modelo.IPActivo = dao.IPActivo;
            modelo.SesionActivo = dao.SesionActivo;

            modelo.UsuarioAnulo = dao.UsuarioAnulo;
            modelo.FechaAnulo = dao.FechaAnulo;
            modelo.IPAnulo = dao.IPAnulo;
            modelo.SesionAnulo = dao.SesionAnulo;

            modelo.CodigoError = dao.ResultadoEjecucion.CodigoError;
            modelo.MensajeErrorTecnico = dao.ResultadoEjecucion.MensajeErrorTecnico;
            modelo.MensajeErrorUsuario = dao.ResultadoEjecucion.MensajeErrorUsuario;

            return modelo;
        }


        public ProveedorDao ConvertirADao()
        {
            ProveedorDao dao = new ProveedorDao();

            dao.CodigoProveedor = this.CodigoProveedor;
            dao.NombreProveedor = this.NombreProveedor;
            dao.AliasProveedor = this.AliasProveedor;
            dao.TelefonoProveedor = this.TelefonoProveedor;
            dao.EstadoProveedor = this.EstadoProveedor;

            dao.CodigoSesion = this.CodigoSesion;

            return dao;
        }

        #endregion [Funciones de la clase]

        #region [Acciones]

        public ProveedorModel Ingresar()
        {
            ProveedorModel modelo = new ProveedorModel();
            ProveedorDao dao = ConvertirADao();

            try
            { 

                ProveedorDao resultado = ProveedorHelper.Instanciar().Ingresar(dao);

                modelo = ConvertirAModelo(resultado);
            }
            catch (Exception ex)
            {
                modelo = new ProveedorModel()
                {
                    CodigoError = -3,
                    MensajeErrorTecnico = "[" + CapaEjecucion.Web.ToString() + "] " +
                                          "[ProveedorModel.Ingresar()] " +
                                          ex.Message,
                    MensajeErrorUsuario = EtiquetasUtility.MENE_SIS_GLOB_INGRESO_ERROR
                };
            }

            return modelo;
        }

        public ProveedorModel Editar()
        {
            ProveedorModel modelo = new ProveedorModel();
            ProveedorDao dao = ConvertirADao();

            try
            {
                ProveedorDao resultado = ProveedorHelper.Instanciar().Editar(dao);

                modelo = ConvertirAModelo(resultado);
            }
            catch (Exception ex)
            {

                modelo = new ProveedorModel()
                {
                    CodigoError = -3,
                    MensajeErrorTecnico = "[" + CapaEjecucion.Web.ToString() + "] " +
                                          "[ProveedorModel.Editar()] " +
                                          ex.Message,
                    MensajeErrorUsuario = EtiquetasUtility.MENE_SIS_GLOB_EDICION_ERROR
                };
            }

            return modelo;
        }

        public ProveedorModel Eliminar(ProveedorModel modelo)
        {
            ProveedorDao dao = new ProveedorDao();
            ResultadoEjecucion resultado = new ResultadoEjecucion();

            dao = modelo.ConvertirADao();

            try
            {
                resultado = ProveedorHelper.Instanciar().Eliminar(dao);

                modelo.CodigoError = resultado.CodigoError;
                modelo.MensajeErrorTecnico = resultado.MensajeErrorTecnico;
                modelo.MensajeErrorUsuario = resultado.MensajeErrorUsuario;
            }
            catch (Exception ex)
            {
                resultado = new ResultadoEjecucion()
                {
                    CodigoError = -3,
                    MensajeErrorTecnico = "[" + CapaEjecucion.Web.ToString() + "] " +
                                          "[ProveedorModel.Eliminar()] " +
                                          ex.Message,
                    MensajeErrorUsuario = EtiquetasUtility.MENE_SIS_GLOB_ELIMINACION_ERROR
                };
            }

            return modelo;
        }

        public ProveedorModel Activar(ProveedorModel modelo)
        {
            ProveedorDao dao = new ProveedorDao();
            ResultadoEjecucion resultado = new ResultadoEjecucion();

            dao = modelo.ConvertirADao();

            try
            {
                resultado = ProveedorHelper.Instanciar().Activar(dao);

                modelo.CodigoError = resultado.CodigoError;
                modelo.MensajeErrorTecnico = resultado.MensajeErrorTecnico;
                modelo.MensajeErrorUsuario = resultado.MensajeErrorUsuario;
            }
            catch (Exception ex)
            {
                resultado = new ResultadoEjecucion()
                {
                    CodigoError = -3,
                    MensajeErrorTecnico = "[" + CapaEjecucion.Web.ToString() + "] " +
                                          "[ProveedorModel.Activar()] " +
                                          ex.Message,
                    MensajeErrorUsuario = EtiquetasUtility.MENE_SIS_GLOB_ACTIVACION_ERROR
                };
            }

            return modelo;
        }

        public ProveedorModel Obtener(Byte? codigoClasificacion)
        {
            ProveedorModel modelo = new ProveedorModel();

            try
            {
                //ProveedorDao resultado = ProveedorHelper.Instanciar().Obtener(codigoClasificacion);

                //modelo = ConvertirAModelo(resultado);
            }
            catch (Exception ex)
            {
                modelo = new ProveedorModel()
                {
                    CodigoError = -3,
                    MensajeErrorTecnico = "[" + CapaEjecucion.Web.ToString() + "] " +
                                          "[ProveedorModel.Obtener()] " +
                                          ex.Message,
                    MensajeErrorUsuario = EtiquetasUtility.MENE_SIS_GLOB_BUSCAR_ERROR
                };
                
            }

            return modelo;
        }

       

        #endregion [Acciones]
    }

    public class ProveedorBusquedaModel : BaseBusquedaModel
    {
        #region [Propiedades de la clase]

        
        public Byte? CodigoProveedor { get; set; }
        
        public String NombreProveedor { get; set; }
        
        public String AliasProveedor { get; set; }
        
        public String TelefonoProveedor { get; set; }
        
        public String EstadoProveedor { get; set; }
        
        public String DescripcionEstadoProveedor { get; set; }

        #endregion [Propiedades de la clase]

        #region Constructores

        public ProveedorBusquedaModel() { }

        #endregion Constructores

        #region [Funciones de la clase]

        //public ProveedorBusquedaDao ConvertirADao()
        //{

        //}

        #endregion [Funciones de la clase]
    }
}