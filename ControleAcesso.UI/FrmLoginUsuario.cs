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
            // TODO: Refinar Validação!!!

            Autenticador autenticador = new();
            bool verificador = autenticador.ValidarLogin(txtLoginCpf.Text, txtLoginSenha.Text);
            if (verificador)
            {
            // Caso a verificação seja verdadeira, irá pular para outro formulário
                FrmControleAcesso frmControleAcesso = new();
                frmControleAcesso.Show();
                this.Hide();
            }
            else
            {
            // caso a verificação seja falsa, aparecerá uma mensagem.
                MessageBox.Show("CPF ou senha incorreto");
            }

            RegistroAcesso registroAcesso = new(autenticador.IdUsuario, 1);
            registroAcesso.RegistrarAcesso();

        }
    }
}
