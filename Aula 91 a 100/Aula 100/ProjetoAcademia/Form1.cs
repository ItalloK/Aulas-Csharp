using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAcademia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_nomeusuario.Text = "---";
            pb_ledlogado.Image = Properties.Resources.LED_VERMELHO;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Globais.logado)
            {
                if(Globais.nivel >= 2)
                {
                    // Procedimentos
                }
                else
                {
                    MessageBox.Show("Acesso Não Permitido.");
                }
            }
            else
            {
                MessageBox.Show("É nescessário ter um usuario logado.");
            }
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 1)
                {
                    F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
                    f_NovoUsuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso Não Permitido.");
                }
            }
            else
            {
                MessageBox.Show("É nescessário ter um usuario logado.");
            }
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 1)
                {
                    // Procedimentos
                }
                else
                {
                    MessageBox.Show("Acesso Não Permitido.");
                }
            }
            else
            {
                MessageBox.Show("É nescessário ter um usuario logado.");
            }
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                // Procedimentos
            }
            else
            {
                MessageBox.Show("É nescessário ter um usuario logado.");
            }
        }
    }
}
