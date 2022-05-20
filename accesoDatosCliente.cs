using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//se usa
using System.Data.SqlClient;//Se usa

namespace SistemaVentasBDConectada
{
    public class accesoDatosCliente
    {
        public List<entidadcliente> ListarCliente() 
        {
            SqlCommand cmd = null;
            List<entidadcliente> lista = new List<entidadcliente>();

            try
            {
                SqlConnection cn = conexion.Conectar();
                cmd = new SqlCommand("Select * from cliente",cn);
                cn.Open(); //conexion.Conectar().Open();
                SqlDataReader dr = cmd.ExecuteReader();//Forma conectada
                while (dr.Read()) 
                { 
                    entidadcliente cli = new entidadcliente();
                    cli.idCliente = Convert.ToInt32(dr["idcliente"]);
                    cli.nombreCliente = dr["nombreCliente"].ToString();
                    cli.apellidoCliente = dr["apellidoCliente"].ToString();
                    cli.ciudadCliente = dr["ciudadCliente"].ToString();
                    cli.direccionCliente = dr["direccionCliente"].ToString();
                    cli.celularCliente = Convert.ToInt32(dr["celularCliente"]);
                    cli.estadoCliente = Convert.ToBoolean(dr["estadoCliente"]);
                    lista.Add(cli);
                }

            }
            catch (Exception ex) 
            {
                throw ex;
            }
            finally { cmd.Connection.Close(); }
            return lista;

        }
        
    }
}
