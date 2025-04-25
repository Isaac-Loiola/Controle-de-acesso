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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControleAcesso));
            dgvListaRegistro = new DataGridView();
            clnIdUsuario = new DataGridViewTextBoxColumn();
            clnDataHora = new DataGridViewTextBoxColumn();
            clnTipoOperacao = new DataGridViewTextBoxColumn();
            dgvListaUsuarios = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            clnNome = new DataGridViewTextBoxColumn();
            clnTipoUsuario = new DataGridViewTextBoxColumn();
            clnDataOperacao = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvListaRegistro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListaRegistro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaRegistro.Columns.AddRange(new DataGridViewColumn[] { clnIdUsuario, clnDataHora, clnTipoOperacao });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListaRegistro.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnNome, clnTipoUsuario, clnDataOperacao });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvListaUsuarios.DefaultCellStyle = dataGridViewCellStyle4;
            dgvListaUsuarios.GridColor = Color.White;
            dgvListaUsuarios.Location = new Point(9, 13);
            dgvListaUsuarios.MultiSelect = false;
            dgvListaUsuarios.Name = "dgvListaUsuarios";
            dgvListaUsuarios.ReadOnly = true;
            dgvListaUsuarios.RowHeadersVisible = false;
            dgvListaUsuarios.Size = new Size(502, 417);
            dgvListaUsuarios.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(12, 606);
            panel1.Name = "panel1";
            panel1.Size = new Size(1119, 468);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(dgvListaRegistro);
            panel2.Location = new Point(32, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(520, 441);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(dgvListaUsuarios);
            panel3.Location = new Point(593, 129);
            panel3.Name = "panel3";
            panel3.Size = new Size(520, 441);
            panel3.TabIndex = 4;
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
            // FrmControleAcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 624);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmControleAcesso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ControleAcesso";
            FormClosing += FrmControleAcesso_FormClosing;
            Load += FrmControleAcesso_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaRegistro).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaRegistro;
        private DataGridViewTextBoxColumn clnIdUsuario;
        private DataGridViewTextBoxColumn clnDataHora;
        private DataGridViewTextBoxColumn clnTipoOperacao;
        private DataGridView dgvListaUsuarios;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnTipoUsuario;
        private DataGridViewTextBoxColumn clnDataOperacao;
    }
}