using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos.PRODUCTO;
using CapaEntidades;

namespace CapaNegocio.PRODUCTO
{
    public class N_PRODUCTO
    {
        D_PRODUCTO obj = new D_PRODUCTO();
        public List<E_PRODUCTO> BUSCAR_PRODUCTO(string SEARCH)
        {

            return obj.BUSCAR_PRODUCTO(SEARCH);
        }
        
    }
}
