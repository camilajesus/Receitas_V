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
    public partial class Apresentação : Form
    {
        public Apresentação()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void LimparTela()
        {
            cmbescolha.Text = "Selecione o perfil";
        }

        private void btnapre_Click(object sender, EventArgs e)
        {
            switch (cmbescolha.Text)
            {
                case "Bolo de Chocolate":
                    Tela_1 tela1 = new Tela_1();
                    tela1.Show();
                    break;
                case "Bolo de Cenoura":
                    Tela_2 tela2 = new Tela_2();
                    tela2.Show();
                    break;
                case "Torta Holandesa":
                    Tela_3 tela3 = new Tela_3();
                    tela3.Show();
                    break;
                default:
                    Tela_4 tela4 = new Tela_4();
                    tela4.Show();
                    break;
            }
            LimparTela();
        }

        private void btnvolta_Click(object sender, EventArgs e)
        {
            Principal princ = new Principal();
            princ.Show();
            Hide();
        }
    }
}
