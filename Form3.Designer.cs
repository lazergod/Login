namespace Login
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            lblPassword = new Label();
            label1 = new Label();
            btnClose = new Button();
            emailDomainComboBox = new ComboBox();
            txtUsuario = new TextBox();
            btnIngresar = new Button();
            checkPassword = new CheckBox();
            txtPassword = new TextBox();
            linklblLogin = new LinkLabel();
            linklblRegistro = new LinkLabel();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(9, 114);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(119, 28);
            lblPassword.TabIndex = 26;
            lblPassword.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 31);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 25;
            label1.Text = "Usuario:";
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = Properties.Resources.Close;
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.Location = new Point(591, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 35);
            btnClose.TabIndex = 24;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // emailDomainComboBox
            // 
            emailDomainComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            emailDomainComboBox.FormattingEnabled = true;
            emailDomainComboBox.Location = new Point(303, 62);
            emailDomainComboBox.Name = "emailDomainComboBox";
            emailDomainComboBox.Size = new Size(181, 28);
            emailDomainComboBox.TabIndex = 21;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(102, 62);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(195, 27);
            txtUsuario.TabIndex = 20;
            txtUsuario.KeyDown += txtUsuario_KeyDown;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(177, 215);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(154, 56);
            btnIngresar.TabIndex = 19;
            btnIngresar.Text = "Siguiente";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // checkPassword
            // 
            checkPassword.AutoSize = true;
            checkPassword.BackColor = Color.Transparent;
            checkPassword.Location = new Point(258, 166);
            checkPassword.Name = "checkPassword";
            checkPassword.Size = new Size(158, 24);
            checkPassword.TabIndex = 17;
            checkPassword.Text = "Mostrar contraseña";
            checkPassword.UseVisualStyleBackColor = false;
            checkPassword.CheckedChanged += checkPassword_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(102, 164);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 27);
            txtPassword.TabIndex = 16;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // linklblLogin
            // 
            linklblLogin.AutoSize = true;
            linklblLogin.BackColor = Color.Transparent;
            linklblLogin.Location = new Point(676, 251);
            linklblLogin.Name = "linklblLogin";
            linklblLogin.Size = new Size(162, 20);
            linklblLogin.TabIndex = 27;
            linklblLogin.TabStop = true;
            linklblLogin.Text = "¿No tienes una cuenta?";
            // 
            // linklblRegistro
            // 
            linklblRegistro.AutoSize = true;
            linklblRegistro.BackColor = Color.Transparent;
            linklblRegistro.Location = new Point(406, 233);
            linklblRegistro.Name = "linklblRegistro";
            linklblRegistro.Size = new Size(162, 20);
            linklblRegistro.TabIndex = 28;
            linklblRegistro.TabStop = true;
            linklblRegistro.Text = "¿No tienes una cuenta?";
            linklblRegistro.LinkClicked += linklblRegistro_LinkClicked;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(638, 313);
            Controls.Add(linklblRegistro);
            Controls.Add(linklblLogin);
            Controls.Add(lblPassword);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(emailDomainComboBox);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(checkPassword);
            Controls.Add(txtPassword);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPassword;
        private Label label1;
        private Button btnClose;
        private ComboBox emailDomainComboBox;
        private TextBox txtUsuario;
        private Button btnIngresar;
        private CheckBox checkPassword;
        private TextBox txtPassword;
        private LinkLabel linklblLogin;
        private LinkLabel linklblRegistro;
    }
}