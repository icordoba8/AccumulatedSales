using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos.CLIENTE;
using CapaEntidades;

namespace CapaNegocio.CLIENTE
{
    public class N_CLIENTE
    {
        D_CLIENTE obj = new D_CLIENTE();
        public List<E_CLIENTE> BUSCAR_CLIENTE(string SEARCH)
        {

             return obj.BUSCAR_CLIENTE(SEARCH);
        }
        
    }
}
