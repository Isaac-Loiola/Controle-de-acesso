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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControleAcesso));
            dgvListaRegistro = new DataGridView();
            clnIdUsuario = new DataGridViewTextBoxColumn();
            clnDataHora = new DataGridViewTextBoxColumn();
            clnTipoOperacao = new DataGridViewTextBoxColumn();
            dgvListaUsuarios = new DataGridView();
            clnNome = new DataGridViewTextBoxColumn();
            clnTipoUsuario = new DataGridViewTextBoxColumn();
            clnDataOperacao = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            txtBuscarPorNome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvListaRegistro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvListaRegistro
            // 
            dgvListaRegistro.AllowUserToAddRows = false;
            dgvListaRegistro.AllowUserToDeleteRows = false;
            dgvListaRegistro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListaRegistro.BackgroundColor = Color.White;
            dgvListaRegistro.BorderStyle = BorderStyle.None;
            dgvListaRegistro.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvListaRegistro.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvListaRegistro.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvListaRegistro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvListaRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaRegistro.Columns.AddRange(new DataGridViewColumn[] { clnIdUsuario, clnDataHora, clnTipoOperacao });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvListaRegistro.DefaultCellStyle = dataGridViewCellStyle6;
            dgvListaRegistro.Location = new Point(10, 13);
            dgvListaRegistro.MultiSelect = false;
            dgvListaRegistro.Name = "dgvListaRegistro";
            dgvListaRegistro.ReadOnly = true;
            dgvListaRegistro.RowHeadersVisible = false;
            dgvListaRegistro.Size = new Size(502, 417);
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
            clnTipoOperacao.Width = 153;
            // 
            // dgvListaUsuarios
            // 
            dgvListaUsuarios.AllowUserToAddRows = false;
            dgvListaUsuarios.AllowUserToDeleteRows = false;
            dgvListaUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListaUsuarios.BackgroundColor = Color.White;
            dgvListaUsuarios.BorderStyle = BorderStyle.None;
            dgvListaUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvListaUsuarios.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvListaUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvListaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnNome, clnTipoUsuario, clnDataOperacao });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvListaUsuarios.DefaultCellStyle = dataGridViewCellStyle8;
            dgvListaUsuarios.GridColor = Color.White;
            dgvListaUsuarios.Location = new Point(9, 13);
            dgvListaUsuarios.MultiSelect = false;
            dgvListaUsuarios.Name = "dgvListaUsuarios";
            dgvListaUsuarios.ReadOnly = true;
            dgvListaUsuarios.RowHeadersVisible = false;
            dgvListaUsuarios.Size = new Size(502, 417);
            dgvListaUsuarios.TabIndex = 1;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 250;
            // 
            // clnTipoUsuario
            // 
            clnTipoUsuario.Frozen = true;
            clnTipoUsuario.HeaderText = "Tipo Usuario";
            clnTipoUsuario.Name = "clnTipoUsuario";
            clnTipoUsuario.ReadOnly = true;
            // 
            // clnDataOperacao
            // 
            clnDataOperacao.Frozen = true;
            clnDataOperacao.HeaderText = "Data de Operação";
            clnDataOperacao.Name = "clnDataOperacao";
            clnDataOperacao.ReadOnly = true;
            clnDataOperacao.Width = 153;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(dgvListaRegistro);
            panel2.Location = new Point(46, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(520, 441);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(dgvListaUsuarios);
            panel3.Location = new Point(607, 112);
            panel3.Name = "panel3";
            panel3.Size = new Size(520, 441);
            panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(448, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 50);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // txtBuscarPorNome
            // 
            txtBuscarPorNome.BackColor = Color.FromArgb(230, 230, 230);
            txtBuscarPorNome.BorderStyle = BorderStyle.None;
            txtBuscarPorNome.Location = new Point(458, 48);
            txtBuscarPorNome.Name = "txtBuscarPorNome";
            txtBuscarPorNome.PlaceholderText = "Buscar por nome";
            txtBuscarPorNome.Size = new Size(262, 16);
            txtBuscarPorNome.TabIndex = 7;
            // 
            // FrmControleAcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 624);
            Controls.Add(txtBuscarPorNome);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "FrmControleAcesso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ControleAcesso";
            FormClosing += FrmControleAcesso_FormClosing;
            Load += FrmControleAcesso_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaRegistro).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListaRegistro;
        private DataGridViewTextBoxColumn clnIdUsuario;
        private DataGridViewTextBoxColumn clnDataHora;
        private DataGridViewTextBoxColumn clnTipoOperacao;
        private DataGridView dgvListaUsuarios;
        private Panel panel2;
        private Panel panel3;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnTipoUsuario;
        private DataGridViewTextBoxColumn clnDataOperacao;
        private PictureBox pictureBox1;
        private TextBox txtBuscarPorNome;
    }
}