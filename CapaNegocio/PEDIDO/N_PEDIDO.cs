using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos.PEDIDO;
using CapaEntidades;

namespace CapaNegocio.PEDIDO
{
    public class N_PEDIDO
    {
        readonly D_PEDIDO obj = new D_PEDIDO();
        public string CREAR_PEDIDO(E_PEDIDO PEDIDO)
        {
         return obj.CREAR_PEDIDO(PEDIDO);
        }
        public void EDITAR_PEDIDO(E_PEDIDO PEDIDO)
        {
            obj.EDITAR_PEDIDO(PEDIDO);
        }
        public void ELIMINAR_PEDIDO(E_PEDIDO PEDIDO)
        {
            obj.ELIMINAR_PEDIDO(PEDIDO);
        }
    }
}
