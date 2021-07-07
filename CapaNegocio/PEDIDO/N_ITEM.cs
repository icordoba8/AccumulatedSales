using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos.ITEM;
using CapaEntidades.PEDIDO;

namespace CapaNegocio.ITEM
{
    public class N_ITEM
    {
        readonly D_ITEM obj = new D_ITEM();
        public string CREAR_ITEM(E_ITEM ITEM)
        {
         return obj.CREAR_ITEM(ITEM);
        }
        public List<E_ITEM> GET_ITEMS(string NUMPEDIDO)
        {
            return obj.GET_ITEMS(NUMPEDIDO);
        }
        public void EDITAR_PEDIDO(E_ITEM ITEM)
        {
            //obj.EDITAR_PEDIDO(PEDIDO);
        }
        public void ELIMINAR_PEDIDO(E_ITEM ITEM)
        {
            //obj.ELIMINAR_PEDIDO(PEDIDO);
        }
    }
}
