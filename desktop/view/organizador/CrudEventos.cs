using desktop.model;
using desktop.model.dao;
using MetroFramework.Controls;
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
    public partial class CrudEventos : Form
    {
        private EventoDAO dao = new EventoDAO();
        public CrudEventos()
        {
            InitializeComponent();
            listarEventos();

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            NovoEvento novoEvento = new NovoEvento();
            novoEvento.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tile_Click(object sender, EventArgs e)
        {
            long codEvento = ObterCodigoEvento(sender);
           
            Vinculador vinc = new Vinculador(codEvento);
            vinc.Show();
        }

        private long ObterCodigoEvento(object sender)
        {
            long cod = 0;
            MetroTile tile;
            if (sender is MetroTile) {
                tile = (MetroTile)sender;
                cod = long.Parse(tile.Name);
                    
            }
            return cod;
        }

        private void construirCardEvento(Evento evento, int index, int init)
        {
            
            this.tileEvento = new MetroFramework.Controls.MetroTile();
            this.tileEvento.Location = new System.Drawing.Point(init, 4);
            this.tileEvento.Name = Convert.ToString(evento.codEvento);
            this.tileEvento.Size = new System.Drawing.Size(126, 152);
            this.tileEvento.TabIndex = 0;
            this.tileEvento.Text = evento.nomeEvento;
            //this.tileEvento.Dock = DockStyle.Left;
            this.tileEvento.Margin = new Padding(10);
            this.tileEvento.TabIndex = index;
            this.tileEvento.Click += new System.EventHandler(this.tile_Click);
        }

       

        private void listarEventos()
        {
            int init = 9, index = 0;
            this.panelEventos = new Panel();
            this.panelEventos.Dock = DockStyle.Top;
            this.panelEventos.Name = "panelEventos";
            this.panelEventos.Height = 152;
            this.panelCenter.Controls.Add(panelEventos);
            //this.panelEventos.TabIndex = 2;
            //this.pageEventos.Controls.Add(panelEventos);

            foreach (Evento evento in dao.listar())
            {

                if (index % 4 != 0)
                {
                    construirCardEvento(evento, index, init);
                    this.panelEventos.Controls.Add(this.tileEvento);
                }
                else
                {
                    init = 9;
                    construirCardEvento(evento, index, init);
                    this.panelEventos = new Panel();
                    this.panelEventos.Dock = DockStyle.Top;

                    this.panelEventos.Name = "panelEventos" + index;
                    this.panelEventos.Size = new System.Drawing.Size(this.panelCenter.Height, 159);
                    //this.panelEventos.TabIndex = 2;
                    this.panelEventos.Controls.Add(tileEvento);
                    this.panelCenter.Controls.Add(panelEventos);

                }

                index++;
                init += 132;
                
            }
        }
    }
}
