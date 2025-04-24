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
            ((System.ComponentModel.ISupportInitialize)dgvListaRegistro).BeginInit();
            SuspendLayout();
            // 
            // dgvListaRegistro
            // 
            dgvListaRegistro.AllowUserToAddRows = false;
            dgvListaRegistro.AllowUserToDeleteRows = false;
            dgvListaRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaRegistro.Columns.AddRange(new DataGridViewColumn[] { clnIdUsuario, clnDataHora, clnTipoOperacao });
            dgvListaRegistro.Location = new Point(12, 60);
            dgvListaRegistro.Name = "dgvListaRegistro";
            dgvListaRegistro.ReadOnly = true;
            dgvListaRegistro.RowHeadersVisible = false;
            dgvListaRegistro.Size = new Size(499, 539);
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
            // FrmControleAcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 624);
            Controls.Add(dgvListaRegistro);
            Name = "FrmControleAcesso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ControleAcesso";
            FormClosing += FrmControleAcesso_FormClosing;
            Load += FrmControleAcesso_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaRegistro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaRegistro;
        private DataGridViewTextBoxColumn clnIdUsuario;
        private DataGridViewTextBoxColumn clnDataHora;
        private DataGridViewTextBoxColumn clnTipoOperacao;
    }
}