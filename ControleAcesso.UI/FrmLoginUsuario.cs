using ControleAcesso.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAcesso.UI
{
    public partial class FrmLoginUsuario : Form
    {
        public FrmLoginUsuario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new(txtLoginCpf.Text, txtLoginSenha.Text);
            if (usuario.VerificarLogin())
            {
                FrmControleAcesso frmControleAcesso = new();
                frmControleAcesso.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("CPF ou senha incorreto");
            }
                
        }
    }
}
