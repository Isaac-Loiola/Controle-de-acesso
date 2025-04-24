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
            panel1 = new Panel();
            btnCadastrar = new Button();
            lblLoginSenha = new Label();
            label1 = new Label();
            txtLoginCpf = new TextBox();
            txtLoginSenha = new TextBox();
            btnLogar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(lblLoginSenha);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtLoginCpf);
            panel1.Controls.Add(txtLoginSenha);
            panel1.Location = new Point(381, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 320);
            panel1.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(231, 251);
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
            lblLoginSenha.Location = new Point(100, 193);
            lblLoginSenha.Name = "lblLoginSenha";
            lblLoginSenha.Size = new Size(39, 15);
            lblLoginSenha.TabIndex = 3;
            lblLoginSenha.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 72);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 2;
            label1.Text = "CPF";
            // 
            // txtLoginCpf
            // 
            txtLoginCpf.Location = new Point(100, 90);
            txtLoginCpf.Name = "txtLoginCpf";
            txtLoginCpf.Size = new Size(218, 23);
            txtLoginCpf.TabIndex = 1;
            // 
            // txtLoginSenha
            // 
            txtLoginSenha.Location = new Point(100, 211);
            txtLoginSenha.Name = "txtLoginSenha";
            txtLoginSenha.Size = new Size(218, 23);
            txtLoginSenha.TabIndex = 0;
            txtLoginSenha.TextChanged += textBox1_TextChanged;
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(381, 450);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(154, 50);
            btnLogar.TabIndex = 1;
            btnLogar.Text = "Login";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnLogar_Click;
            // 
            // FrmLoginUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 624);
            Controls.Add(btnLogar);
            Controls.Add(panel1);
            Name = "FrmLoginUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginUsuario";
            Load += LoginUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtLoginCpf;
        private TextBox txtLoginSenha;
        private Label lblLoginSenha;
        private Label label1;
        private Button btnLogar;
        private Button btnCadastrar;
    }
}