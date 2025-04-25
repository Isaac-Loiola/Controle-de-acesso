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
            if( txtCpf.Text != String.Empty && txtNome.Text != String.Empty && cmb.Text != String.Empty && txtSenha.Text != String.Empty)
            {
                Usuario usuario = new(txtNome.Text, txtCpf.Text, cmb.SelectedIndex + 1, txtSenha.Text);
                usuario.Cadastrar();

                MessageBox.Show($"{usuario.Nome} cadastrado com sucesso!");

                RegistroAcesso registrarUsuarioCadastrado = new(usuario.Id);
                registrarUsuarioCadastrado.RegistrarAcesso();

                FrmControleAcesso frmControleAcesso = new();
                frmControleAcesso.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Campos são obrigatórios");
            }
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

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
