using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WsDatCustAcco_Common.Global
{
    public class AccesoBD
    {
        #region [Variables]

        SqlConnection conexion;
        
        #endregion [Variables]
        // Se debe crear la clase con la conexión a la base de datos. GianCarlos nos va a ayudar con esto.

        public String ProcedimientoMantenimiento { get; set; }

        public bool Conexion()
        {

            try
            {
                SqlConnection conexion = new SqlConnection("server=msqlaws.csiftz7i1ill.us-east-1.rds.amazonaws.com,1433; database=BDCustAcco ; integrated security = true");
                conexion.Open();
            }
            catch (Exception ex)
            {
                return false;  
            }

            //conexion.Close();

            return true;
        }
    }
}
