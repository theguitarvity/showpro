using desktop.model.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop.model
{
    public class Evento
    {
        public long codEvento { get; set; }
        public String nomeEvento { get; set; }
        public DateTime dtEvento { get; set; }
        public DateTime horaEvento { get; set; }
        public string detalhesEvento { get; set; }
        public TipoEvento tipoEvento { get; set; }
        public Local localEvento { get; set; }



        public void adicionarAtracao(Atracao atracao)
        {
            Evento_AtracaoDAO dao = new Evento_AtracaoDAO();
            try
            {
                dao.vincular(this, atracao);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        
    }
}
