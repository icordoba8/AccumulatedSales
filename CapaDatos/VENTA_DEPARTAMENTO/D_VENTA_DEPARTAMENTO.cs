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

namespace CapaDatos.VENTA_DEPARTAMENTO
{
    public class D_VENTA_DEPARTAMENTO
    {
        readonly SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public List<E_VENTA_DEPARTAMENTO> GET_VENTAS(string FECHA_INICIAL, string FECHA_FINAL)
        {
            SqlDataReader filas;

            SqlCommand sqlCommand = new SqlCommand("[SP_ACUMULADO_VENTAS_DEPARTAMENTOS]", conexion);
            SqlCommand cmd = sqlCommand;
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@FECHA_INICIAL", FECHA_INICIAL);
            cmd.Parameters.AddWithValue("@FECHA_FINAL", FECHA_FINAL);

            filas = cmd.ExecuteReader();
            List<E_VENTA_DEPARTAMENTO> listar = new List<E_VENTA_DEPARTAMENTO>();
              
            while (filas.Read())
            {
                
                listar.Add(new E_VENTA_DEPARTAMENTO
                {
                    CODDEP = filas.GetString(0).ToString(),
                    NOMBRE = filas.GetString(1).ToString(),
                    TOTAL = filas.GetDecimal(2)
                });
                
                //Console.WriteLine(filas.GetString(0).ToString());

            }
              
            conexion.Close();
            filas.Close();
            return listar;

        }
        
    }

    
}
