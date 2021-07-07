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

namespace CapaDatos.COMISION
{
    public class D_COMISION
    {
        readonly SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public List<E_COMISION> GET_COMISIONES(string MES, string ANO)
        {
            SqlDataReader filas;

            SqlCommand sqlCommand = new SqlCommand("[SP_COMISIONES]", conexion);
            SqlCommand cmd = sqlCommand;
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@MES", MES);
            cmd.Parameters.AddWithValue("@ANO", ANO);

            filas = cmd.ExecuteReader();
            List<E_COMISION> listar = new List<E_COMISION>();
              
            while (filas.Read())
            {
                
                listar.Add(new E_COMISION
                {
                    NOMBRE = filas.GetString(0).ToString(),
                    VENTAS = filas.GetDecimal(1),
                    COMISION = filas.GetDecimal(2)
                });
                
                //Console.WriteLine(filas.GetString(0).ToString());

            }
              
            conexion.Close();
            filas.Close();
            return listar;

        }

     

    }

    
}
