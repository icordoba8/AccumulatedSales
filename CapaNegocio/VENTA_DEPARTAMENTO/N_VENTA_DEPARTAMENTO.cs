using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos.VENTA_DEPARTAMENTO;
using CapaEntidades;

namespace CapaNegocio.VENTA_DEPARTAMENTO
{
    public class N_VENTA_DEPARTAMENTO
    {
        D_VENTA_DEPARTAMENTO obj = new D_VENTA_DEPARTAMENTO();
        public List<E_VENTA_DEPARTAMENTO> GET_VENTAS(string FECHA_INICIAL, string FECHA_FINAL)
        {

            return obj.GET_VENTAS(FECHA_INICIAL, FECHA_FINAL);
        }
        
    }
}
