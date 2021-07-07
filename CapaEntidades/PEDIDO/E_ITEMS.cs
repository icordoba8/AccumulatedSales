using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.PEDIDO
{
    public class E_ITEM
    {
        public String NUMPEDIDO { get; set; }

        public String NOMBRE { get; set; }
        public String PRODUCTO { get; set; }
        public Decimal PRECIO { get; set; }
        public Decimal CANTIDAD { get; set; }
        public Decimal SUBTOTAL { get; set; }
       
    }
}
