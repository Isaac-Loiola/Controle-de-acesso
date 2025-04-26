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
    public partial class FrmControleAcesso : Form
    {
        public FrmControleAcesso()
        {
            InitializeComponent();
        }

        private void FrmControleAcesso_Load(object sender, EventArgs e)
        {

            int linha = 0;
            var registros = RegistroAcesso.ListarRegistros();
            foreach (var lista in registros)
            {
                dgvListaRegistro.Rows.Add();
                dgvListaRegistro.Rows[linha].Cells[0].Value = lista.UsuarioId;
                dgvListaRegistro.Rows[linha].Cells[1].Value = lista.DataHora;
                dgvListaRegistro.Rows[linha].Cells[2].Value = lista.TipoOperacao == 0 ? "Saída" : "Entrada";


                linha++;
            }

            linha = 0;
            var usuarios = Usuario.ListarUsuarios();
            foreach (var lista in usuarios)
            {
                dgvListaUsuarios.Rows.Add();
                dgvListaUsuarios.Rows[linha].Cells[0].Value = lista.Nome;
                dgvListaUsuarios.Rows[linha].Cells[1].Value = lista.TipoUsuario;
                dgvListaUsuarios.Rows[linha].Cells[2].Value = lista.DataCriacao;

                linha++;
            }
        }

        private void FrmControleAcesso_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegistroAcesso.SaidaAcesso();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarPorNome_Enter(object sender, EventArgs e)
        {

        }

        private void txtBuscarPorNome_KeyPress(object sender, KeyPressEventArgs e)
        {

            int linha = 0;
            var registrosNome = RegistroAcesso.ListarRegistroPorNomeDeUsuario(txtBuscarPorNome.Text);

            dgvListaRegistro.Rows.Clear();
            foreach (var lista in registrosNome)
            {
                dgvListaRegistro.Rows.Add();
                dgvListaRegistro.Rows[linha].Cells[0].Value = lista.UsuarioId;
                dgvListaRegistro.Rows[linha].Cells[1].Value = lista.DataHora;
                dgvListaRegistro.Rows[linha].Cells[2].Value = lista.TipoOperacao == 0 ? "Saída" : "Entrada";

                linha++;
            }

        }

        private void txtBuscarPorNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarPorNome_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            int linha = 0;
            var registros = RegistroAcesso.ListarRegistros();

            dgvListaRegistro.Rows.Clear();

            foreach (var lista in registros)
            {
                dgvListaRegistro.Rows.Add();
                dgvListaRegistro.Rows[linha].Cells[0].Value = lista.UsuarioId;
                dgvListaRegistro.Rows[linha].Cells[1].Value = lista.DataHora;
                dgvListaRegistro.Rows[linha].Cells[2].Value = lista.TipoOperacao == 0 ? "Saída" : "Entrada";


                linha++;
            }
        }
    }
}
