namespace OsanideDesktop
{
    partial class frmLogin
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            txtLogin = new Guna.UI2.WinForms.Guna2TextBox();
            btnEntrar = new Guna.UI2.WinForms.Guna2Button();
            btnSair = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            label3 = new Label();
            lblEsqueciSenha = new Label();
            lblCadastrar = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.round_logo;
            pictureBox1.Location = new Point(244, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(277, 251);
            label1.Name = "label1";
            label1.Size = new Size(242, 21);
            label1.TabIndex = 1;
            label1.Text = "Faça o login em nosso sistema";
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.None;
            txtSenha.BorderRadius = 15;
            txtSenha.CustomizableEdges = customizableEdges7;
            txtSenha.DefaultText = "";
            txtSenha.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSenha.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSenha.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Location = new Point(244, 395);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Insira sua senha";
            txtSenha.SelectedText = "";
            txtSenha.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtSenha.Size = new Size(300, 41);
            txtSenha.TabIndex = 2;
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.None;
            txtLogin.BorderRadius = 15;
            txtLogin.CustomizableEdges = customizableEdges5;
            txtLogin.DefaultText = "";
            txtLogin.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtLogin.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtLogin.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtLogin.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtLogin.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLogin.Font = new Font("Century Gothic", 9F);
            txtLogin.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLogin.Location = new Point(244, 320);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Insira seu login";
            txtLogin.SelectedText = "";
            txtLogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtLogin.Size = new Size(300, 41);
            txtLogin.TabIndex = 3;
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.None;
            btnEntrar.BorderRadius = 15;
            btnEntrar.CustomizableEdges = customizableEdges3;
            btnEntrar.DisabledState.BorderColor = Color.DarkGray;
            btnEntrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEntrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEntrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEntrar.FillColor = Color.FromArgb(2, 63, 29);
            btnEntrar.Font = new Font("Century Gothic", 9F);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(244, 473);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEntrar.Size = new Size(142, 45);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.None;
            btnSair.BorderRadius = 15;
            btnSair.CustomizableEdges = customizableEdges1;
            btnSair.DisabledState.BorderColor = Color.DarkGray;
            btnSair.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSair.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSair.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSair.FillColor = Color.FromArgb(64, 64, 64);
            btnSair.Font = new Font("Century Gothic", 9F);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(402, 473);
            btnSair.Name = "btnSair";
            btnSair.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSair.Size = new Size(142, 45);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(244, 296);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(244, 371);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 1;
            label3.Text = "Senha";
            // 
            // lblEsqueciSenha
            // 
            lblEsqueciSenha.Anchor = AnchorStyles.None;
            lblEsqueciSenha.AutoSize = true;
            lblEsqueciSenha.Location = new Point(305, 439);
            lblEsqueciSenha.Name = "lblEsqueciSenha";
            lblEsqueciSenha.Size = new Size(177, 21);
            lblEsqueciSenha.TabIndex = 1;
            lblEsqueciSenha.Text = "Esqueceu sua senha?";
            // 
            // lblCadastrar
            // 
            lblCadastrar.Anchor = AnchorStyles.None;
            lblCadastrar.AutoSize = true;
            lblCadastrar.Location = new Point(277, 563);
            lblCadastrar.Name = "lblCadastrar";
            lblCadastrar.Size = new Size(237, 21);
            lblCadastrar.TabIndex = 1;
            lblCadastrar.Text = "Ainda não está cadastrado?";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(800, 600);
            Controls.Add(btnSair);
            Controls.Add(btnEntrar);
            Controls.Add(txtLogin);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblCadastrar);
            Controls.Add(lblEsqueciSenha);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmLogin";
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private PictureBox pictureBox1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnSair;
        private Guna.UI2.WinForms.Guna2Button btnEntrar;
        private Guna.UI2.WinForms.Guna2TextBox txtLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Label label3;
        private Label label2;
        private Label lblCadastrar;
        private Label lblEsqueciSenha;
    }
}