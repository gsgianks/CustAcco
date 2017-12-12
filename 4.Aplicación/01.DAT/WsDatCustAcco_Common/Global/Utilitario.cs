using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WsDatCustAcco_Dao.Global;

namespace WsDatCustAcco_Common.Global
{
    public class Utilitario
    {
        public static Boolean ObtenerValorSeguroBoolean(DataRow fila, String columna)
        {
            if(fila[columna] != DBNull.Value)
            {
                return (Boolean)fila[columna];
            }
            else
            {
                return false;
            }
        }

        public static Byte? ObtenerValorSeguroByteNull(DataRow fila, String columna)
        {
            if (fila[columna] != DBNull.Value)
            {
                return (Byte?)fila[columna];
            }
            else
            {
                return null;
            }
        }

        public static Byte ObtenerValorSeguroByte(DataRow fila, String columna)
        {
            if (fila[columna] != DBNull.Value)
            {
                return (Byte)fila[columna];
            }
            else
            {
                return 0;
            }
        }

        public static Int16? ObtenerValorSeguroInt16Null(DataRow fila, String columna)
        {
            if (fila[columna] != DBNull.Value)
            {
                return (Int16?)fila[columna];
            }
            else
            {
                return null;
            }
        }

        public static Int16 ObtenerValorSeguroInt16(DataRow fila, String columna)
        {
            if (fila[columna] != DBNull.Value)
            {
                return (Int16)fila[columna];
            }
            else
            {
                return 0;
            }
        }

        public static Int32? ObtenerValorSeguroInt32Null(DataRow fila, String columna)
        {
            if (fila[columna] != DBNull.Value)
            {
                return (Int32?)fila[columna];
            }
            else
            {
                return null;
            }
        }

        public static Int32 ObtenerValorSeguroInt32(DataRow fila, String columna)
        {
            if (fila[columna] != DBNull.Value)
            {
                return (Int32)fila[columna];
            }
            else
            {
                return 0;
            }
        }

        public static Decimal? ObtenerValorSeguroDecimalNull(DataRow fila, String columna)
        {
            if (fila[columna] != DBNull.Value)
            {
                return (Decimal?)fila[columna];
            }
            else
            {
                return null;
            }
        }

        public static Decimal ObtenerValorSeguroDecimal(DataRow fila, String columna)
        {
            if (fila[columna] != DBNull.Value)
            {
                return (Decimal)fila[columna];
            }
            else
            {
                return 0;
            }
        }

        public static String ObtenerValorSeguroString(DataRow fila, String columna)
        {
            if (fila[columna] != DBNull.Value)
            {
                return fila[columna].ToString().Trim();
            }
            else
            {
                return null;
            }
        }

        public static DateTime? ObtenerValorSeguroDateTimeNull(DataRow fila, String columna)
        {
            if (fila[columna] != DBNull.Value)
            {
                return (DateTime?)fila[columna];
            }
            else
            {
                return null;
            }
        }

        public static DateTime ObtenerValorSeguroDateTime(DataRow fila, String columna)
        {
            if (fila[columna] != DBNull.Value)
            {
                return (DateTime)fila[columna];
            }
            else
            {
                return DateTime.MinValue;
            }
        }

        public static BaseDao ObtenerDatosAuditoria(DataRow fila, BaseDao entidad)
        {
            entidad.UsuarioIngreso = ObtenerValorSeguroString(fila, BaseDao.USUARIO_INGRESO);
            entidad.SesionIngreso = ObtenerValorSeguroString(fila, BaseDao.CODIGO_SESION_INGRESO);
            entidad.IPIngreso = ObtenerValorSeguroString(fila, BaseDao.IP_INGRESO);
            entidad.FechaIngreso = ObtenerValorSeguroDateTime(fila, BaseDao.FECHA_INGRESO);

            entidad.UsuarioModifico = ObtenerValorSeguroString(fila, BaseDao.USUARIO_MODIFICO);
            entidad.SesionModifico = ObtenerValorSeguroString(fila, BaseDao.CODIGO_SESION_MODIFICO);
            entidad.IPModifico = ObtenerValorSeguroString(fila, BaseDao.IP_MODIFICO);
            entidad.FechaModifico = ObtenerValorSeguroDateTime(fila, BaseDao.FECHA_MODIFICO);

            entidad.UsuarioActivo = ObtenerValorSeguroString(fila, BaseDao.USUARIO_ACTIVO);
            entidad.SesionActivo = ObtenerValorSeguroString(fila, BaseDao.CODIGO_SESION_ACTIVO);
            entidad.IPActivo = ObtenerValorSeguroString(fila, BaseDao.IP_ACTIVO);
            entidad.FechaActivo = ObtenerValorSeguroDateTime(fila, BaseDao.FECHA_ACTIVO);

            entidad.UsuarioAnulo = ObtenerValorSeguroString(fila, BaseDao.USUARIO_ANULO);
            entidad.SesionAnulo = ObtenerValorSeguroString(fila, BaseDao.CODIGO_SESION_ANULO);
            entidad.IPAnulo = ObtenerValorSeguroString(fila, BaseDao.IP_ANULO);
            entidad.FechaAnulo = ObtenerValorSeguroDateTime(fila, BaseDao.FECHA_ANULO);

            return entidad;
        }
    }
}
