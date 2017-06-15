using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pré_Greve
{
    public partial class Principal : Form
    {
        Tela_1 frmTela1 = new Tela_1();
        Tela_2 frmTela2 = new Tela_2();
        Tela_3 frmTela3 = new Tela_3();
        Tela_4 frmTela4 = new Tela_4();
        PesquisarReceitas frmTelaInicial = new PesquisarReceitas();

        public void hide()
        {
            this.frmTela1.Hide();
            this.frmTela2.Hide();
            this.frmTela3.Hide();
            this.frmTela4.Hide();
            this.frmTelaInicial.Hide();
        }
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //PesquisarReceitas pesquisar = new PesquisarReceitas();
            //pesquisar.ShowDialog();
        }

        private void loToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tela1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.hide();
            frmTela1.MdiParent = this;
            frmTela1.Show();

            this.toolStripStatusLabel1.Text = "Bolo de Cholocate";
        }

        private void tela2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.hide();
            frmTela2.MdiParent = this;
            frmTela2.Show();

            this.toolStripStatusLabel1.Text = "Bolo de Cenoura";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.hide();
            frmTela3.MdiParent = this;
            frmTela3.Show();

            this.toolStripStatusLabel1.Text = "Torta Holandesa";

        }

        private void tela4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.hide();

            frmTela4.MdiParent = this;
            frmTela4.Show();

            this.toolStripStatusLabel1.Text = "Mousse de Maracujá";
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }


        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formuláriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pesquisarReceitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisarReceitas pesquisar = new PesquisarReceitas();
            pesquisar.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apresentação apre = new Apresentação();
            apre.Show();
        }
    }
}
