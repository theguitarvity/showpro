using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop.model
{
    public class Lote
    {
        public long codLote { get; set; }
        public int numeroLote { get; set; }
        public decimal valor { get; set; }
        public int maximo { get; set; }
        public Evento evento { get; set; }

        
    }
}
