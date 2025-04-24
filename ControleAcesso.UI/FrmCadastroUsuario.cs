using ControleAcesso.Core;

namespace ControleAcesso.UI
{
    public partial class FrmCadastroUsuario : Form
    {
        public FrmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // TODO Refinar validação!
            
            Usuario usuario = new(txtNome.Text, txtCpf.Text, cmb.SelectedIndex + 1, txtSenha.Text);
            usuario.Cadastrar();

            MessageBox.Show($"{usuario.Nome} cadastrado com sucesso!");

            FrmControleAcesso frmControleAcesso = new();
            this.Hide();
        }

        private void chkExibirSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExibirSenha.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }

        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
