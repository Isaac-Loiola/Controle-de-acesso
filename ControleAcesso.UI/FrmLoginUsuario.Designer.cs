namespace ControleAcesso.UI
{
    partial class FrmLoginUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginUsuario));
            panel1 = new Panel();
            chkMostrarSenha = new CheckBox();
            btnCadastrar = new Button();
            lblLoginSenha = new Label();
            label1 = new Label();
            txtLoginCpf = new TextBox();
            txtLoginSenha = new TextBox();
            btnLogar = new Button();
            lblCadastroUsuario = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(chkMostrarSenha);
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(lblLoginSenha);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtLoginCpf);
            panel1.Controls.Add(txtLoginSenha);
            panel1.Location = new Point(352, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(509, 402);
            panel1.TabIndex = 0;
            // 
            // chkMostrarSenha
            // 
            chkMostrarSenha.AutoSize = true;
            chkMostrarSenha.Location = new Point(366, 286);
            chkMostrarSenha.Name = "chkMostrarSenha";
            chkMostrarSenha.Size = new Size(15, 14);
            chkMostrarSenha.TabIndex = 3;
            chkMostrarSenha.UseVisualStyleBackColor = true;
            chkMostrarSenha.CheckedChanged += chkMostrarSenha_CheckedChanged;
            // 
            // btnCadastrar
            // 
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Berlin Sans FB", 11.25F);
            btnCadastrar.Location = new Point(298, 326);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(87, 23);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastre-se";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblLoginSenha
            // 
            lblLoginSenha.AutoSize = true;
            lblLoginSenha.Font = new Font("Berlin Sans FB", 11.25F);
            lblLoginSenha.Location = new Point(123, 251);
            lblLoginSenha.Name = "lblLoginSenha";
            lblLoginSenha.Size = new Size(46, 17);
            lblLoginSenha.TabIndex = 3;
            lblLoginSenha.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 11.25F);
            label1.Location = new Point(123, 95);
            label1.Name = "label1";
            label1.Size = new Size(34, 17);
            label1.TabIndex = 2;
            label1.Text = "CPF";
            // 
            // txtLoginCpf
            // 
            txtLoginCpf.BackColor = Color.FromArgb(230, 230, 230);
            txtLoginCpf.BorderStyle = BorderStyle.None;
            txtLoginCpf.Location = new Point(123, 124);
            txtLoginCpf.Name = "txtLoginCpf";
            txtLoginCpf.Size = new Size(262, 16);
            txtLoginCpf.TabIndex = 1;
            txtLoginCpf.TextChanged += txtLoginCpf_TextChanged;
            // 
            // txtLoginSenha
            // 
            txtLoginSenha.BackColor = Color.FromArgb(230, 230, 230);
            txtLoginSenha.BorderStyle = BorderStyle.None;
            txtLoginSenha.Location = new Point(123, 285);
            txtLoginSenha.Name = "txtLoginSenha";
            txtLoginSenha.Size = new Size(262, 16);
            txtLoginSenha.TabIndex = 0;
            txtLoginSenha.UseSystemPasswordChar = true;
            txtLoginSenha.TextChanged += textBox1_TextChanged;
            // 
            // btnLogar
            // 
            btnLogar.BackColor = Color.Transparent;
            btnLogar.BackgroundImage = (Image)resources.GetObject("btnLogar.BackgroundImage");
            btnLogar.FlatAppearance.BorderSize = 0;
            btnLogar.FlatStyle = FlatStyle.Flat;
            btnLogar.Font = new Font("Berlin Sans FB", 11.25F);
            btnLogar.Location = new Point(352, 523);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(165, 50);
            btnLogar.TabIndex = 1;
            btnLogar.Text = "Login";
            btnLogar.UseVisualStyleBackColor = false;
            btnLogar.Click += btnLogar_Click;
            // 
            // lblCadastroUsuario
            // 
            lblCadastroUsuario.AutoSize = true;
            lblCadastroUsuario.Font = new Font("Berlin Sans FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCadastroUsuario.Location = new Point(573, 38);
            lblCadastroUsuario.Name = "lblCadastroUsuario";
            lblCadastroUsuario.Size = new Size(66, 26);
            lblCadastroUsuario.TabIndex = 2;
            lblCadastroUsuario.Text = "Login";
            // 
            // FrmLoginUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 624);
            Controls.Add(lblCadastroUsuario);
            Controls.Add(btnLogar);
            Controls.Add(panel1);
            Name = "FrmLoginUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginUsuario";
            Load += LoginUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtLoginCpf;
        private TextBox txtLoginSenha;
        private Label lblLoginSenha;
        private Label label1;
        private Button btnLogar;
        private Button btnCadastrar;
        private Label lblCadastroUsuario;
        private CheckBox chkMostrarSenha;
    }
}