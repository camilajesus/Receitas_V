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
    public partial class PesquisarReceitas : Form
    {
        public PesquisarReceitas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtpesquisar.Text == "bolo de chocolate")
            {
                Tela_1 tela1 = new Tela_1();
                tela1.Show();
            }
            else if(txtpesquisar.Text == "bolo de cenoura")
            {
                Tela_2 tela2 = new Tela_2();
                tela2.Show();
            }
            else if(txtpesquisar.Text == "torta holandesa")
            {
                Tela_3 tela3 = new Tela_3();
                tela3.Show();
            }
            else if(txtpesquisar.Text == "mousse de maracuja")
            {
                Tela_4 tela4 = new Tela_4();
                tela4.Show();
            }
            else
            {
                MessageBox.Show("Busca inválida", "Aviso");
            }
            txtpesquisar.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            btnLimpar.Visible = true;
            txtpesquisar.Clear();
        }
    }
}
