using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos.VENDEDOR;
using CapaEntidades;

namespace CapaNegocio.VENDEDOR
{
    public class N_VENDEDOR
    {
        D_VENDEDOR obj = new D_VENDEDOR();
        public List<E_VENDEDOR> BUSCAR_VENDEDOR(string SEARCH)
        {

             return obj.BUSCAR_VENDEDOR(SEARCH);
        }
        
    }
}
