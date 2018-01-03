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
    public class Conexion
    {
        public static SqlConnection conexion;

        public static bool getConexion()
        {
            bool connection_open;

            try
            {
                //conexion = new SqlConnection("server=msqlaws.csiftz7i1ill.us-east-1.rds.amazonaws.com,1433; database=BDCustAcco ; integrated security = true");

                conexion = new SqlConnection("server=msqlaws.csiftz7i1ill.us-east-1.rds.amazonaws.com,1433;database=BDCustAcco;Integrated Security=False;User Id=admin;Password=abc..123;MultipleActiveResultSets=True");
                conexion.Open();
                connection_open = true;
            }
            catch (Exception e)
            {
                connection_open = false;
            }
            return connection_open;
        }

        public static void cerrarConexion()
        {
            conexion.Close();
        }
    }
}
