using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using CapaEntidades.PEDIDO;
using System.Data;
using System.Windows.Forms;

namespace CapaDatos.ITEM
{
    public class D_ITEM
    {   
        readonly SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        public string CREAR_ITEM(E_ITEM ITEM)
        {

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SP_CREAR_ITEM", conexion);
                SqlCommand cmd = sqlCommand;
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
               
                cmd.Parameters.AddWithValue("@NUMPEDIDO", ITEM.NUMPEDIDO);
                cmd.Parameters.AddWithValue("@PRODUCTO", ITEM.PRODUCTO);
                cmd.Parameters.AddWithValue("@PRECIO", ITEM.PRECIO);
                cmd.Parameters.AddWithValue("@CANTIDAD", ITEM.CANTIDAD);

                cmd.Parameters.Add("@STATUS", SqlDbType.Char, 10);
                cmd.Parameters["@STATUS"].Direction = ParameterDirection.Output;
               
                cmd.ExecuteNonQuery();
             
                conexion.Close();
                return cmd.Parameters["@STATUS"].Value.ToString();
            }
            catch (Exception e)
            {
              
                return "{0} Exception caught." + e;
            }
            
            

        }
        public List<E_ITEM> GET_ITEMS(string NUMPEDIDO)
        {
            SqlDataReader filas;

            SqlCommand sqlCommand = new SqlCommand("SP_GET_ITEMS", conexion);
            SqlCommand cmd = sqlCommand;
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NUMPEDIDO", NUMPEDIDO);
            filas = cmd.ExecuteReader();
            

            List<E_ITEM> listar = new List<E_ITEM>();
            while (filas.Read())
            {

                listar.Add(new E_ITEM
                {
                    NOMBRE = filas.GetString(0).ToString(),
                    PRECIO = filas.GetDecimal(1),
                    CANTIDAD = filas.GetDecimal(2),
                    SUBTOTAL = filas.GetDecimal(3)
                   
                });

            }
            conexion.Close();

            return listar;
        }
        public void EDITAR_ITEM()
        {
            

        }
        public void ELIMINAR_ITEM()
        {
            

        }
    }

    
}
