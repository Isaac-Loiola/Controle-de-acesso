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
            var listar = RegistroAcesso.ListarRegistros();
            foreach(var lista in listar)
            {
                dgvListaRegistro.Rows.Add();
                dgvListaRegistro.Rows[linha].Cells[0].Value = lista.UsuarioId;
                dgvListaRegistro.Rows[linha].Cells[1].Value = lista.DataHora;
                dgvListaRegistro.Rows[linha].Cells[2].Value = lista.TipoOperacao;


                linha++;
            }
        }

        private void FrmControleAcesso_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
