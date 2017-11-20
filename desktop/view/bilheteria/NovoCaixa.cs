using desktop.model;
using desktop.model.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop.view.bilheteria
{
    public partial class NovoCaixa : Form
    {
        private CaixaDAO dao = new CaixaDAO();
        private BilheteriaMain buildFor;
        long cod;

        private Caixa buildCaixa()
        {
            Caixa caixa = new Caixa();
            Random random = new Random();
            cod = random.Next(1111111,9999999);
            caixa.codCaixa = cod;
            caixa.dataAbertura = System.DateTime.Now;
            caixa.dataFechamento = System.DateTime.Now;
            caixa.totalDiario = 0.00m;
            return caixa;
        }
        public NovoCaixa(Object buildFor)
        {
            buildFor = (BilheteriaMain)buildFor;
            InitializeComponent();
        }

        private void NovoCaixa_Load(object sender, EventArgs e)
        {
            this.metroLabel1.Text += " " + System.DateTime.Now+"?";
        }

        private void tileAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                Caixa caixa = buildCaixa();
                dao.abrir(caixa);
                MessageBox.Show("Caixa referente a "+caixa.dataAbertura.Date.Date+" aberto com sucesso, tenha ótimas vendas!");
                //buildFor.verificarCaixa();
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
