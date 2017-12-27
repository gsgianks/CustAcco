using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WB_CustAcco.Web.Utilities
{
    public class EtiquetasUtility
    {
        /* Para nombrar una etiqueta: ABCD_EFG_HIJK_...
            ABCD -> Funcionalidad:
                ETIQ: Etiqueta.
                BOTO: Botón.
                MENS: Mensaje.
                OPER: Operación (opción de seguridad).
                TITU: Título de ventana.
                VARI: Variables (para no quemar valores).
            EFG -> Módulo:
                GLO: Global.
                GEN: General.
                SEG: Seguridad.
                MAN: Mandatos.
            HIJK -> Prefijo descriptivo de la entidad:
                CBAN: Cuentas Bancarias.
                PAIS: Países.
                AECO: Actividades Económicas.
                Para el caso de las etiquetas para los mensajes del sistema:
                    VALI: Mensajes de validaciones.
                    ERRO: Mensajes de error.
                    INFO: Mensajes de información.
                    PREC: Mensajes de precaución.
                    CONF: Mensajes de confirmación.
            ... -> Nombre descriptivo de la etiqueta:
                CODIGO.
                NOMBRE.
                CODIGO_COMPANIA.
        */

        #region [Mensajes globales de sistema]

        public const String MENS_SIS_GLOB_REQUERIDO = "Requerido";
        public const String MENS_SIS_GLOB_FORMATO_INVALIDO = "Formato inválido";
        public const String MENS_SIS_GLOB_LONGITUD_INVALIDA = "Longitud inválida";
        public const String MENS_SIS_GLOB_NUMERICO_INVALIDO = "El campo tiene que ser numérico";

        public const String MENE_SIS_GLOB_ERROR_NO_CONTROLADO = "Ha ocurrido un problema no controlado. Contacte con el Administrador del Sistema.";

        public const String MENC_SIS_GLOB_INGRESO_CONFIRMACION = "El registro ha sido ingresado satisfactoriamente.";
        public const String MENE_SIS_GLOB_INGRESO_ERROR = "Ha ocurrido un problema al intentar ingresar el registro.";

        public const String MENC_SIS_GLOB_CIERRE_MENSUAL_CONFIRMACION = "El cierre mensual ha sido realizado satisfactoriamente.";
        public const String MENE_SIS_GLOB_CIERRE_MENSUAL_ERROR = "Ha ocurrido un problema al intentar realizar el cierre mensual.";

        public const String MENC_SIS_GLOB_EDICION_CONFIRMACION = "El registro ha sido actualizado satisfactoriamente.";
        public const String MENE_SIS_GLOB_EDICION_ERROR = "Ha ocurrido un problema al intentar actualizar el registro.";

        public const String MENP_SIS_GLOB_COPIAR_REPORTE_CONFIRMACION = "¿Desea copiar el oficio?";
        public const String MENC_SIS_GLOB_COPIAR_REPORTE_CONFIRMACION = "El registro ha sido copiado satisfactoriamente";
        public const String MENE_SIS_GLOB_COPIAR_REPORTE_ERROR = "Ha ocurrido un problema al intentar copiar el registro";

        public const String MENP_SIS_GLOB_ANULACION_CONFIRMACION = "El registro se anulará. ¿Desea continuar?";
        public const String MENC_SIS_GLOB_ANULACION_CONFIRMACION = "El registro ha sido anulado satisfactoriamente.";
        public const String MENE_SIS_GLOB_ANULACION_ERROR = "Ha ocurrido un problema al intentar anular el registro.";

        public const String MENP_SIS_GLOB_ELIMINACION_CONFIRMACION = "El registro se eliminará permanentemente. ¿Desea continuar?";
        public const String MENP_SIS_GLOB_REIMPRESION_CONFIRMACION = "Se realizará la reimpresión. ¿Desea continuar?";
        public const String MENC_SIS_GLOB_ELIMINACION_CONFIRMACION = "El registro ha sido eliminado satisfactoriamente.";
        public const String MENC_SIS_GLOB_REIMPRESION_CONFIRMACION = "Se realizó la reimpresión satisfactoriamente.";
        public const String MENE_SIS_GLOB_ELIMINACION_ERROR = "Ha ocurrido un problema al intentar eliminar el registro.";
        public const String MENE_SIS_GLOB_REIMPRESION_ERROR = "Ha ocurrido un problema al intentar reimprimir el registro.";

        public const String MENP_SIS_GLOB_ACTIVACION_PREGUNTA = "El registro se activará. ¿Desea continuar?";
        public const String MENC_SIS_GLOB_ACTIVACION_CONFIRMACION = "El registro ha sido activado satisfactoriamente.";
        public const String MENE_SIS_GLOB_ACTIVACION_ERROR = "Ha ocurrido un problema al intentar activar el registro.";

        public const String MENE_SIS_GLOB_CONFIRMACION_ERROR = "Ha ocurrido un problema al intentar confirmar el registro.";
        public const String MENC_SIS_GLOB_CONFIRMACION = "El registro ha sido confirmado satisfactoriamente.";

        public const String MENE_SIS_GLOB_REVERSION_ERROR = "Ha ocurrido un problema al intentar reversar el registro.";
        public const String MENC_SIS_GLOB_REVERSION_CONFIRMACION = "El registro ha sido reversado satisfactoriamente.";

        public const String MENE_SIS_GLOB_BUSCAR_ERROR = "Se ha presentado un problema no controlado al intentar ejecutar la consulta.";
        public const String MENI_SIS_GLOB_BUSCAR_SIN_REGISTROS = "No se han encontrado resultados para la búsqueda.";

        public const String MENI_SIS_GLOB_EXPORTAR_SIN_REGISTROS = "No se han seleccionado los registros a exportar.";

        public const String MENE_SIS_GLOB_ACCIONES_INVALIDO = "El control de Acciones no es válido o no se ha encontrado.";

        public const String MENE_SIS_GLOB_REPORTE_ERROR = "Se ha presentado un problema no controlado al intentar generar el reporte.";

        public const String MENE_SIS_GLOB_VALIDAR_NUMERO_FACTURA_ERROR = "El número de factura no es válido";

        public const String MENE_SIS_GLOB_VALIDAR_NUMERO_OFICIO_ERROR = "El número de oficio no es válido";

        public const String MENE_SIS_GLOB_OBTENER_PERIODO_ERROR = "No se pudo obtener el periodo para el número de oficio ingresado";

        public const String MENE_SIS_GLOB_BCO_CONFIRMACION = "El registro ha sido ingresado satisfactoriamente. El sistema notificará cuando la carga finalice";

        #endregion [Mensajes globales de sistema]

        #region [Botones globales de sistema]

        public const String BOTO_SIS_GLOB_REGRESAR = "Regresar";
        public const String BOTO_SIS_GLOB_NUEVO = "Nuevo";
        public const String BOTO_SIS_GLOB_GUARDAR = "Guardar";
        public const String BOTO_SIS_GLOB_BUSCAR = "Buscar";
        public const String BOTO_SIS_GLOB_EXPORTAR_EXCEL = "Exportar";
        public const String BOTO_SIS_GLOB_LIMPIAR = "Limpiar";
        public const String BOTO_SIS_GLOB_AUDITORIA = "Auditoría";
        public const String BOTO_SIS_GLOB_ACEPTAR = "Aceptar";
        public const String BOTO_SIS_GLOB_VALIDAR_CIERRE_MENSUAL = "Validar";
        public const String BOTO_SIS_GLOB_CONFIRMAR = "Confirmar";
        public const String BOTO_SIS_GLOB_REVERSAR = "Reversar";
        public const String BOTO_SIS_GLOB_REPORTE = "Reporte";
        public const String BOTO_SIS_GLOB_CONCILIAR = "Conciliar";
        public const String BOTO_SIS_GLOB_GENERAR = "Generar";
        public const String BOTO_SIS_GLOB_GARANTIAS_RECHAZADAS_ORGANIZACION = "Enviar rechazadas a Organización";
        public const String BOTO_SIS_GLOB_GARANTIAS_RECHAZADAS_BOVEDA = "Enviar rechazadas a Bóveda";
        public const String BOTO_SIS_GLOB_GARANTIAS_INCLUIDAS_BOVEDA = "Enviar incluídas a Bóveda";
        public const String BOTO_SIS_GLOB_ARCHIVO_SICUVAL = "Enviar a SICUVAL";

        #endregion [Botones globales de sistema]

        #region [Etiquetas globales de sistema]

        public const String ETIQ_SIS_GLOB_CATALOGO = "Catálogo";
        public const String ETIQ_SIS_GLOB_MANTENIMIENTO = "Mantenimiento";

        public const String ETIQ_SIS_GLOB_INCLUIR_ANULADOS = "Incluir registros anulados";

        public const String ETIQ_SIS_GLOB_REQUERIDO = "*";
        public const String ETIQ_SIS_GLOB_SELECCIONAR = "Seleccionar";

        public const String ETIQ_SIS_GLOB_ACCIONES = "Acciones";

        public const String ETIQ_SIS_GLOB_EDITAR = "Editar";
        public const String ETIQ_SIS_GLOB_ANULAR = "Anular";
        public const String ETIQ_SIS_GLOB_ACTIVAR = "Activar";
        public const String ETIQ_SIS_GLOB_ELIMINAR = "Eliminar";

        public const String ETIQ_SIS_GLOB_NO_ACCIONES = "Sin acciones permitidas";

        #endregion [Etiquetas globales de sistema]

        #region [Variables globales de sistema]

        public const String VARI_SIS_GLOB_NOMBRE_SISTEMA = "Mandatos | Banco Popular";

        public const String VARI_SIS_GLOB_TIPO_MENSAJE_ERROR = "E";
        public const String VARI_SIS_GLOB_TIPO_MENSAJE_ADVERTENCIA = "A";
        public const String VARI_SIS_GLOB_TIPO_MENSAJE_INFORMACION = "I";
        public const String VARI_SIS_GLOB_TIPO_MENSAJE_CONFIRMACION = "C";

        public const String VARI_MAN_GARA_TIPO_ARCHIVO_ACTUALIZACION = "ACT";
        public const String VARI_MAN_GARA_TIPO_ARCHIVO_INCLUSION = "REP";

        public const String VARI_SIS_GLOB_ACCION_EDITAR = "Editar";
        public const String VARI_SIS_GLOB_ACCION_REIMPRIMIR = "Reimprimir";
        public const String VARI_SIS_GLOB_ACCION_ACTIVAR = "Activar";
        public const String VARI_SIS_GLOB_ACCION_ELIMINAR = "Eliminar";
        public const String VARI_SIS_GLOB_ACCION_ANULAR = "Anular";
        public const String VARI_SIS_GLOB_ACCION_VER_DETALLE = "Ver Detalles";

        #endregion [Variables globales de sistema]

        #region [Inicio de Sesión]

        public const String MENS_SEG_LOGI_NO_PERMITIDO = "Usted no posee los privilegios necesarios para ingresar a esta aplicación.";
        public const String MENS_SEG_LOGI_LOGIN_ERROR = "Ha ocurrido un problema no controlado que no permite validar las credenciales proporcionadas.";

        public const String BOTO_SEG_LOGI_REINTENTAR = "Reintentar";
        public const String BOTO_SEG_LOGI_REINGRESAR = "Ingresar de nuevo";

        #endregion [Inicio de Sesión]

        #region [Pistas de Auditoría]

        public const String TITU_SEC_AUDI_AUDITORIA = "Auditoría";

        public const String ETIQ_SEC_AUDI_COMPANIA = "Compañía";
        public const String ETIQ_SEC_AUDI_SESION = "Código de Sesión";

        public const String ETIQ_SEC_AUDI_USUARIO_INGRESO = "Usuario que ingresó";
        public const String ETIQ_SEC_AUDI_FECHA_INGRESO = "Fecha de ingreso";
        public const String ETIQ_SEC_AUDI_IP_INGRESO = "IP que ingresó";

        public const String ETIQ_SEC_AUDI_USUARIO_MODIFICO = "Usuario que modificó";
        public const String ETIQ_SEC_AUDI_FECHA_MODIFICO = "Fecha de modificación";
        public const String ETIQ_SEC_AUDI_IP_MODIFICO = "IP que modificó";

        public const String ETIQ_SEC_AUDI_USUARIO_ACTIVO = "Usuario que activó";
        public const String ETIQ_SEC_AUDI_FECHA_ACTIVO = "Fecha de activación";
        public const String ETIQ_SEC_AUDI_IP_ACTIVO = "IP que activó";

        public const String ETIQ_SEC_AUDI_USUARIO_ANULO = "Usuario que anuló";
        public const String ETIQ_SEC_AUDI_FECHA_ANULO = "Fecha de anulación";
        public const String ETIQ_SEC_AUDI_IP_ANULO = "IP que anuló";

        #endregion [Pistas de Auditoría]

        #region [Mantenimiento de Proveedores]

        public const String TITU_GEN_PRO_PROVEEDORES = "Mantenimiento de Proveedores";

        public const String ETIQ_GEN_PRO_CODIGO = "Código";
        public const String ETIQ_GEN_PRO_NOMBRE = "Nombre";
        public const String ETIQ_GEN_PRO_ALIAS = "Alias";
        public const String ETIQ_GEN_PRO_TELEFONO = "Teléfono";
        public const String ETIQ_GEN_PRO_ESTADO = "Estado";

        #endregion [Mantenimiento de Proveedores]
    }
}