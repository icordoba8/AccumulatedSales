using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using CapaEntidades;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace CapaDatos.PRODUCTO
{
    public class D_PRODUCTO
    {
        readonly SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public List<E_PRODUCTO> BUSCAR_PRODUCTO(string SEARCH)
        {
            SqlDataReader filas;

            SqlCommand sqlCommand = new SqlCommand("SP_BUSCAR_PRODUCTO", conexion);
            SqlCommand cmd = sqlCommand;
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@SEARCH", SEARCH.ToLower());

            filas = cmd.ExecuteReader();
            List<E_PRODUCTO> listar = new List<E_PRODUCTO>();
              
            while (filas.Read())
            {
                
                listar.Add(new E_PRODUCTO
                {
                    CODPROD = filas.GetString(0).ToString(),
                    NOMBRE = filas.GetString(1).ToString(),
                    PRECIO = filas.GetDecimal(2)
                });
                
                //Console.WriteLine(filas.GetString(0).ToString());

            }
              
            conexion.Close();
            filas.Close();
            return listar;

        }
        
    }

    
}
