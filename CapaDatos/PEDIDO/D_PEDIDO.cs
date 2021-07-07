using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using CapaEntidades;
using System.Data;
using System.Windows.Forms;

namespace CapaDatos.PEDIDO
{
    public class D_PEDIDO
    {   
        readonly SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        public string CREAR_PEDIDO(E_PEDIDO PEDIDO)
        {

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SP_CREAR_PEDIDO", conexion);
                SqlCommand cmd = sqlCommand;
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
               
                cmd.Parameters.AddWithValue("@CLIENTE", PEDIDO.CLIENTE);
                cmd.Parameters.AddWithValue("@VENDEDOR", PEDIDO.VENDEDOR);

                cmd.Parameters.Add("@NUMPEDIDO", SqlDbType.Char, 10);
                cmd.Parameters["@NUMPEDIDO"].Direction = ParameterDirection.Output;
               
                cmd.ExecuteNonQuery();
             
                conexion.Close();
                return cmd.Parameters["@NUMPEDIDO"].Value.ToString();
            }
            catch (Exception e)
            {
              
                return "{0} Exception caught." + e;
            }
            
            

        }
        public void EDITAR_PEDIDO(E_PEDIDO PEDIDO)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_CREAR_PEDIDO", conexion);
            SqlCommand cmd = sqlCommand;
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NUMPEDIDO", PEDIDO.NUMPEDIDO);
            cmd.Parameters.AddWithValue("@CLIENTE", PEDIDO.CLIENTE);
            cmd.Parameters.AddWithValue("@VENDEDOR", PEDIDO.VENDEDOR);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        public void ELIMINAR_PEDIDO(E_PEDIDO PEDIDO)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_CREAR_PEDIDO", conexion);
            SqlCommand cmd = sqlCommand;
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NUMPEDIDO", PEDIDO.NUMPEDIDO);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }
    }

    
}
