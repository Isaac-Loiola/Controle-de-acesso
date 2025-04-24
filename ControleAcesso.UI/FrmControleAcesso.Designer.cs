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
            dataGridView1 = new DataGridView();
            clnIdUsuario = new DataGridViewTextBoxColumn();
            clnDataHora = new DataGridViewTextBoxColumn();
            clnTipoOperacao = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clnIdUsuario, clnDataHora, clnTipoOperacao });
            dataGridView1.Location = new Point(334, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(538, 515);
            dataGridView1.TabIndex = 0;
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
            Controls.Add(dataGridView1);
            Name = "FrmControleAcesso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ControleAcesso";
            Load += FrmControleAcesso_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clnIdUsuario;
        private DataGridViewTextBoxColumn clnDataHora;
        private DataGridViewTextBoxColumn clnTipoOperacao;
    }
}