using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop.model
{
    public class Pedido
    {
        public long codPedido { get; set; }
        public Cliente cliente { get; set; }
        public decimal totalPedido { get; set; }

    }
}
