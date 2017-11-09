using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop.model
{
    class Ingresso
    {
        public long codIngresso { get; set; }
        public Lote lote { get; set; }
        public Evento evento { get; set; }
        public String codigoBarras { get; set; }
    }
}
