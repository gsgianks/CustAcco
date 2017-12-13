using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WsDatCustAcco_Dao.Global;

namespace WsDatCustAcco_Common.Global
{
    public class Utilitario: Conexion
    {

        #region [ObtenerValorSeguro]

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

        #endregion [ObtenerValorSeguro]

        

        public static Boolean EjecutarProcedimiento(String nombreProcedimiento, List<ParametroDao> parametros)
        {

            getConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = nombreProcedimiento;
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (ParametroDao parametro in parametros)
            {
                cmd.Parameters.AddWithValue(parametro.NombreParametro, parametro.ValorParametro);
            }

            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static DataTable EjecutarProcedimientoDataTable(String nombreProcedimiento, List<ParametroDao> parametros, ref Int16 codigoError, ref String mensajeError)
        {
            DataTable dt = new DataTable();
            try
            {
                if (getConexion())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conexion;
                    cmd.CommandText = nombreProcedimiento;
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (ParametroDao parametro in parametros)
                    {
                        cmd.Parameters.AddWithValue(parametro.NombreParametro, parametro.ValorParametro);
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    cerrarConexion();
                }

            }
            catch (SqlException e)
            {
                codigoError = 99;
                mensajeError = "Error no controlado: " + e.Message;
            }
            return dt;
        }

        //private bool SelectOrden(string tabla, string campo, string condicion)
        //{
        //    bool existe = false;
        //    string sqlConStr = "/*cadena de conexion*/";
        //    string SQL = "SELECT Count(" + campo + ") as numRows FROM " + tabla + " WHERE " + campo + "=@valor;";
        //    SqlConnection sqlConn = new SqlConnection(sqlConStr);
        //    SqlCommand sqlCmd = new SqlCommand(SQL, sqlConn);
        //    SqlDataReader rdr = null;
        //    try
        //    {
        //        sqlConn.Open();
        //        sqlCmd.Parameters.Add("valor", valor);
        //        rdr = sqlCmd.ExecuteReader();
        //        if (rdr.Read())
        //        {
        //            int numOrdenes = (int)rdr["numOrdenes"];
        //            if (numOrdenes > 0) existe = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    finally
        //    {
        //        if (rdr != null) rdr.Close();
        //        sqlConn.Close();
        //    }
        //    return existe;
        //}

        //public DataSet EjecutarProcedimientoDataSet(String nombreProcedimiento, params SqlParameter[] parametros)
        //{
        //    DataSet dataSetResultado;

        //    try
        //    {
        //        getConexion();
        //        //SqlCommand cmd = new SqlCommand();
        //        //cmd.Connection = conexion;
        //        //cmd.CommandText = nombreProcedimiento;
        //        //cmd.CommandType = CommandType.StoredProcedure;

        //        dataSetResultado = ExecuteDataset(conexion, CommandType.StoredProcedure, nombreProcedimiento, parametros);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //    return dataSetResultado;

        //}

    //    public static DataSet ExecuteDataset(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
    //    {
    //        if (connection == null) throw new ArgumentNullException("connection");

    //        // Create a command and prepare it for execution
    //        SqlCommand cmd = new SqlCommand();
    //        bool mustCloseConnection = false;
    //        PrepareCommand(cmd, connection, (SqlTransaction)null, commandType, commandText, commandParameters, out mustCloseConnection);

    //        // Create the DataAdapter & DataSet
    //        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
    //        {
    //            DataSet ds = new DataSet();

    //            // Fill the DataSet using default values for DataTable names, etc
    //            //UtilitariosDal.RegistrarDatosLog(UtilitariosDal.PrepararDatosLog(commandParameters, commandText));
    //            da.Fill(ds);

    //            // Detach the SqlParameters from the command object, so they can be used again
    //            cmd.Parameters.Clear();

    //            if (mustCloseConnection)
    //                connection.Close();

    //            // Return the dataset
    //            return ds;
    //        }
    //    }


    //    private static void PrepareCommand(SqlCommand command, SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText, SqlParameter[] commandParameters, out bool mustCloseConnection)
    //    {
    //        if (command == null) throw new ArgumentNullException("command");

    //        if (commandText == null || commandText.Length == 0) throw new ArgumentNullException("commandText");

    //        // If the provided connection is not open, we will open it
    //        if (connection.State != ConnectionState.Open)
    //        {
    //            mustCloseConnection = true;
    //            connection.Open();
    //        }
    //        else
    //        {
    //            mustCloseConnection = false;
    //        }

    //        // Associate the connection with the command
    //        command.Connection = connection;

    //        // Set the command text (stored procedure name or SQL statement)
    //        command.CommandText = commandText;

    //        // If we were provided a transaction, assign it
    //        if (transaction != null)
    //        {
    //            if (transaction.Connection == null) throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
    //            command.Transaction = transaction;
    //        }

    //        // Set the command type
    //        command.CommandType = commandType;

    //        command.CommandTimeout = 0;

    //        // Attach the command parameters if they are provided
    //        if (commandParameters != null)
    //        {
    //            AttachParameters(command, commandParameters);
    //        }
    //        return;
    //    }
    }
}
