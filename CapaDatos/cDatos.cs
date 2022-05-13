using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    public class cDatos
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable D_Login(CapaEntidades.cEntidades obje)
        {
            SqlCommand cmd = new SqlCommand("sp_Login", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usu", obje.usu1);
            cmd.Parameters.AddWithValue("@usu", obje.pas1);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dTable = new DataTable();
            da.Fill(dTable);
            return dTable;
        }
    }

}
