namespace ControleAcesso.UI
{
    partial class CadastroUsuario
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
            pnlCadastroUsuario = new Panel();
            lblCadastroUsuario = new Label();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            txtSenha = new TextBox();
            cmb = new ComboBox();
            btnCadastrar = new Button();
            lblNome = new Label();
            lblCpf = new Label();
            lblTipoUsuario = new Label();
            lblSenha = new Label();
            pnlCadastroUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCadastroUsuario
            // 
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
            // txtNome
            // 
            txtNome.Location = new Point(131, 69);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(226, 23);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += this.txtNome_TextChanged;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(131, 147);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(226, 23);
            txtCpf.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(131, 320);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(226, 23);
            txtSenha.TabIndex = 2;
            // 
            // cmb
            // 
            cmb.FormattingEnabled = true;
            cmb.Items.AddRange(new object[] { "Adiministrador", "Funcionário", "Visitante" });
            cmb.Location = new Point(131, 230);
            cmb.Name = "cmb";
            cmb.Size = new Size(226, 23);
            cmb.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(352, 523);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(165, 50);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += this.btnCadastrar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(131, 51);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(47, 17);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCpf.Location = new Point(131, 127);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(34, 17);
            lblCpf.TabIndex = 4;
            lblCpf.Text = "CPF";
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoUsuario.Location = new Point(131, 210);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(85, 17);
            lblTipoUsuario.TabIndex = 4;
            lblTipoUsuario.Text = "Tipo Usuario";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(131, 300);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(46, 17);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha";
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 624);
            Controls.Add(btnCadastrar);
            Controls.Add(lblCadastroUsuario);
            Controls.Add(pnlCadastroUsuario);
            Name = "CadastroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += this.CadastroUsuario_Load;
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
    }
}
