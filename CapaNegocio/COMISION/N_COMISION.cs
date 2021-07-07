using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos.COMISION;
using CapaEntidades;

namespace CapaNegocio.COMISION
{
    public class N_COMISION
    {
        D_COMISION obj = new D_COMISION();
        public List<E_COMISION> GET_COMISIONES(string MES, string ANO)
        {

            return obj.GET_COMISIONES(MES,ANO);
        }
        
    }
}
