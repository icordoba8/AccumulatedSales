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

namespace CapaDatos.VENDEDOR
{
    public class D_VENDEDOR
    {
        readonly SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public List<E_VENDEDOR> BUSCAR_VENDEDOR(string SEARCH)
        {
            SqlDataReader filas;

            SqlCommand sqlCommand = new SqlCommand("SP_BUSCAR_VENDEDOR", conexion);
            SqlCommand cmd = sqlCommand;
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@SEARCH", SEARCH);

            filas = cmd.ExecuteReader();
            List<E_VENDEDOR> listar = new List<E_VENDEDOR>();
              
            while (filas.Read())
            {
                
                listar.Add(new E_VENDEDOR
                {
                    CODVEND = filas.GetString(0).ToString(),
                    NOMBRE = filas.GetString(1).ToString(),
                });
                
                //Console.WriteLine(filas.GetString(0).ToString());

            }
              
            conexion.Close();
            filas.Close();
            return listar;

        }
        
    }

    
}
