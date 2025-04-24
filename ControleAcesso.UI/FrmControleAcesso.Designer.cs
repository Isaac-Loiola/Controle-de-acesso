namespace ControleAcesso.UI
{
    partial class FrmControleAcesso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvListaRegistro = new DataGridView();
            clnIdUsuario = new DataGridViewTextBoxColumn();
            clnDataHora = new DataGridViewTextBoxColumn();
            clnTipoOperacao = new DataGridViewTextBoxColumn();
            dgvUsuarios = new DataGridView();
            clnNome = new DataGridViewTextBoxColumn();
            clnTipoUsuario = new DataGridViewTextBoxColumn();
            clnDataOperacao = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvListaRegistro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvListaRegistro
            // 
            dgvListaRegistro.AllowUserToAddRows = false;
            dgvListaRegistro.AllowUserToDeleteRows = false;
            dgvListaRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaRegistro.Columns.AddRange(new DataGridViewColumn[] { clnIdUsuario, clnDataHora, clnTipoOperacao });
            dgvListaRegistro.Location = new Point(43, 100);
            dgvListaRegistro.Name = "dgvListaRegistro";
            dgvListaRegistro.ReadOnly = true;
            dgvListaRegistro.RowHeadersVisible = false;
            dgvListaRegistro.Size = new Size(499, 417);
            dgvListaRegistro.TabIndex = 0;
            // 
            // clnIdUsuario
            // 
            clnIdUsuario.Frozen = true;
            clnIdUsuario.HeaderText = "Id Usuario";
            clnIdUsuario.Name = "clnIdUsuario";
            clnIdUsuario.ReadOnly = true;
            // 
            // clnDataHora
            // 
            clnDataHora.Frozen = true;
            clnDataHora.HeaderText = "Data e Hora";
            clnDataHora.Name = "clnDataHora";
            clnDataHora.ReadOnly = true;
            clnDataHora.Width = 250;
            // 
            // clnTipoOperacao
            // 
            clnTipoOperacao.Frozen = true;
            clnTipoOperacao.HeaderText = "Tipo da Operacao";
            clnTipoOperacao.Name = "clnTipoOperacao";
            clnTipoOperacao.ReadOnly = true;
            clnTipoOperacao.Width = 150;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnNome, clnTipoUsuario, clnDataOperacao });
            dgvUsuarios.Location = new Point(625, 100);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.Size = new Size(499, 417);
            dgvUsuarios.TabIndex = 1;
            // 
            // clnNome
            // 
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 250;
            // 
            // clnTipoUsuario
            // 
            clnTipoUsuario.HeaderText = "Tipo Usuario";
            clnTipoUsuario.Name = "clnTipoUsuario";
            clnTipoUsuario.ReadOnly = true;
            // 
            // clnDataOperacao
            // 
            clnDataOperacao.HeaderText = "Data de Operação";
            clnDataOperacao.Name = "clnDataOperacao";
            clnDataOperacao.ReadOnly = true;
            clnDataOperacao.Width = 146;
            // 
            // FrmControleAcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 624);
            Controls.Add(dgvUsuarios);
            Controls.Add(dgvListaRegistro);
            Name = "FrmControleAcesso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ControleAcesso";
            FormClosing += FrmControleAcesso_FormClosing;
            Load += FrmControleAcesso_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaRegistro).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaRegistro;
        private DataGridViewTextBoxColumn clnIdUsuario;
        private DataGridViewTextBoxColumn clnDataHora;
        private DataGridViewTextBoxColumn clnTipoOperacao;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnTipoUsuario;
        private DataGridViewTextBoxColumn clnDataOperacao;
    }
}