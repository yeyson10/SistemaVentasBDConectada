using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//activarse using
using System.Data.SqlClient;//activarse using

namespace SistemaVentasBDConectada
{
    internal class conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=DESKTOP-A1OPPUQ\\SQLEXPRESS; Initial Catalog=Ventas2022;Integrated Security=true";
            return conexion;
        }
    }
}
