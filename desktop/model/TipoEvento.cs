using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop.model
{
    public class TipoEvento
    {
        public long codTipo { get; set; }
        public string nomeTipo { get; set; }
        public TipoEvento(long cod, string nome)
        {
            this.codTipo = cod;
            this.nomeTipo = nome; 
        }
    }
}
