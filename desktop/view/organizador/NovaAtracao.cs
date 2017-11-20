using desktop.model;
using desktop.model.dao;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop.view.organizador
{
    public partial class NovaAtracao : MetroForm
    {
        private AtracaoDAO atracaoDao = new AtracaoDAO();
        private Evento_AtracaoDAO vinculadorDAO = new Evento_AtracaoDAO();
        private EventoDAO eventoDAO = new EventoDAO();
        long codAtracao;
        private Evento evento;

        private Atracao getForm()
        {
            Atracao atracao = new Atracao();
            Random random = new Random();
            this.codAtracao = random.Next(1111111,9999999);
            atracao.codAtracao = codAtracao;
            atracao.nomeAtracao = txtNome.Text;
            atracao.tipoAtracao = txtTipo.Text;
            atracao.detalhesAtracao = rtxtDetalhes.Text;
            return atracao;

        }
        private void limpar()
        {
            txtNome.Clear();
            txtTipo.Clear();
            rtxtDetalhes.Clear();
            
        }

        public NovaAtracao(long codEvento)
        {
            InitializeComponent();
            evento = eventoDAO.buscarPorID(codEvento);
            
        }

        private void NovaAtracao_Load(object sender, EventArgs e)
        {

        }

        private void tileAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Atracao atracao = getForm();
                atracaoDao.inserir(atracao);
                vinculadorDAO.vincular(evento, atracao);
                
                MessageBox.Show("Atração vinculada com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void tileLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
