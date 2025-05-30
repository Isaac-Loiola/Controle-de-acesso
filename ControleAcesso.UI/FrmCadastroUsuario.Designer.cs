﻿namespace ControleAcesso.UI
{
    partial class FrmCadastroUsuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroUsuario));
            pnlCadastroUsuario = new Panel();
            button1 = new Button();
            chkExibirSenha = new CheckBox();
            lblSenha = new Label();
            lblTipoUsuario = new Label();
            lblCpf = new Label();
            lblNome = new Label();
            cmb = new ComboBox();
            txtSenha = new TextBox();
            txtCpf = new TextBox();
            txtNome = new TextBox();
            lblCadastroUsuario = new Label();
            btnCadastrar = new Button();
            pnlCadastroUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCadastroUsuario
            // 
            pnlCadastroUsuario.BackColor = Color.Transparent;
            pnlCadastroUsuario.BackgroundImage = (Image)resources.GetObject("pnlCadastroUsuario.BackgroundImage");
            pnlCadastroUsuario.Controls.Add(button1);
            pnlCadastroUsuario.Controls.Add(chkExibirSenha);
            pnlCadastroUsuario.Controls.Add(lblSenha);
            pnlCadastroUsuario.Controls.Add(lblTipoUsuario);
            pnlCadastroUsuario.Controls.Add(lblCpf);
            pnlCadastroUsuario.Controls.Add(lblNome);
            pnlCadastroUsuario.Controls.Add(cmb);
            pnlCadastroUsuario.Controls.Add(txtSenha);
            pnlCadastroUsuario.Controls.Add(txtCpf);
            pnlCadastroUsuario.Controls.Add(txtNome);
            pnlCadastroUsuario.Location = new Point(352, 115);
            pnlCadastroUsuario.Name = "pnlCadastroUsuario";
            pnlCadastroUsuario.Size = new Size(509, 402);
            pnlCadastroUsuario.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Berlin Sans FB", 11.25F);
            button1.Location = new Point(337, 371);
            button1.Name = "button1";
            button1.Size = new Size(57, 25);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chkExibirSenha
            // 
            chkExibirSenha.AutoSize = true;
            chkExibirSenha.Location = new Point(361, 340);
            chkExibirSenha.Name = "chkExibirSenha";
            chkExibirSenha.Size = new Size(15, 14);
            chkExibirSenha.TabIndex = 5;
            chkExibirSenha.UseVisualStyleBackColor = true;
            chkExibirSenha.CheckedChanged += chkExibirSenha_CheckedChanged;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(115, 304);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(46, 17);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha";
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoUsuario.Location = new Point(115, 212);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(85, 17);
            lblTipoUsuario.TabIndex = 4;
            lblTipoUsuario.Text = "Tipo Usuario";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Berlin Sans FB", 11.25F);
            lblCpf.Location = new Point(115, 120);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(34, 17);
            lblCpf.TabIndex = 4;
            lblCpf.Text = "CPF";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(115, 28);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(47, 17);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome";
            // 
            // cmb
            // 
            cmb.BackColor = Color.FromArgb(230, 230, 230);
            cmb.FlatStyle = FlatStyle.Flat;
            cmb.FormattingEnabled = true;
            cmb.Items.AddRange(new object[] { "Adiministrador", "Funcionário", "Visitante" });
            cmb.Location = new Point(123, 243);
            cmb.Name = "cmb";
            cmb.Size = new Size(261, 23);
            cmb.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(230, 230, 230);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Location = new Point(123, 337);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(261, 16);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtCpf
            // 
            txtCpf.BackColor = Color.FromArgb(230, 230, 230);
            txtCpf.BorderStyle = BorderStyle.None;
            txtCpf.Location = new Point(123, 154);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(261, 16);
            txtCpf.TabIndex = 1;
            txtCpf.TextChanged += txtCpf_TextChanged;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(230, 230, 230);
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Location = new Point(123, 61);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(261, 16);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // lblCadastroUsuario
            // 
            lblCadastroUsuario.AutoSize = true;
            lblCadastroUsuario.Font = new Font("Berlin Sans FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCadastroUsuario.Location = new Point(496, 38);
            lblCadastroUsuario.Name = "lblCadastroUsuario";
            lblCadastroUsuario.Size = new Size(213, 26);
            lblCadastroUsuario.TabIndex = 1;
            lblCadastroUsuario.Text = "Cadastro de Usuario";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Transparent;
            btnCadastrar.BackgroundImage = (Image)resources.GetObject("btnCadastrar.BackgroundImage");
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.Black;
            btnCadastrar.Location = new Point(352, 523);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(165, 50);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FrmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 624);
            Controls.Add(btnCadastrar);
            Controls.Add(lblCadastroUsuario);
            Controls.Add(pnlCadastroUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCadastroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConnAccess";
            Load += CadastroUsuario_Load;
            pnlCadastroUsuario.ResumeLayout(false);
            pnlCadastroUsuario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCadastroUsuario;
        private Label lblCadastroUsuario;
        private TextBox txtCpf;
        private TextBox txtNome;
        private ComboBox cmb;
        private TextBox txtSenha;
        private Button btnCadastrar;
        private Label lblSenha;
        private Label lblTipoUsuario;
        private Label lblCpf;
        private Label lblNome;
        private CheckBox chkExibirSenha;
        private Button button1;
    }
}
