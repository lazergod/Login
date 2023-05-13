namespace Login
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtPassword2 = new TextBox();
            txtPassword = new TextBox();
            checkPassword = new CheckBox();
            lblPropiedades = new Label();
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            emailDomainComboBox = new ComboBox();
            btnStop = new Button();
            btnPlay = new Button();
            btnClose = new Button();
            label1 = new Label();
            lblPassword = new Label();
            linklblLogin = new LinkLabel();
            SuspendLayout();
            // 
            // txtPassword2
            // 
            txtPassword2.Location = new Point(243, 185);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.Size = new Size(150, 27);
            txtPassword2.TabIndex = 0;
            txtPassword2.UseSystemPasswordChar = true;
            txtPassword2.TextChanged += txtPassword2_TextChanged;
            txtPassword2.KeyDown += txtPassword2_KeyDown;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(87, 185);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // checkPassword
            // 
            checkPassword.AutoSize = true;
            checkPassword.BackColor = Color.Transparent;
            checkPassword.Location = new Point(399, 185);
            checkPassword.Name = "checkPassword";
            checkPassword.Size = new Size(158, 24);
            checkPassword.TabIndex = 2;
            checkPassword.Text = "Mostrar contraseña";
            checkPassword.UseVisualStyleBackColor = false;
            checkPassword.CheckedChanged += checkPassword_CheckedChanged;
            // 
            // lblPropiedades
            // 
            lblPropiedades.AutoSize = true;
            lblPropiedades.BackColor = Color.WhiteSmoke;
            lblPropiedades.Location = new Point(72, 233);
            lblPropiedades.Name = "lblPropiedades";
            lblPropiedades.Size = new Size(506, 20);
            lblPropiedades.TabIndex = 3;
            lblPropiedades.Text = "Usa 8 o más caracteres con una combinación de letras, números y símbolos";
            lblPropiedades.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(153, 274);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(154, 56);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Siguiente";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(90, 80);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(195, 27);
            txtUsuario.TabIndex = 6;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            txtUsuario.KeyDown += txtUsuario_KeyDown;
            txtUsuario.KeyPress += txtUsuario_KeyPress;
            // 
            // emailDomainComboBox
            // 
            emailDomainComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            emailDomainComboBox.FormattingEnabled = true;
            emailDomainComboBox.Location = new Point(291, 80);
            emailDomainComboBox.Name = "emailDomainComboBox";
            emailDomainComboBox.Size = new Size(181, 28);
            emailDomainComboBox.TabIndex = 7;
            // 
            // btnStop
            // 
            btnStop.BackgroundImage = Properties.Resources.Sound;
            btnStop.BackgroundImageLayout = ImageLayout.Stretch;
            btnStop.Location = new Point(610, 315);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(35, 35);
            btnStop.TabIndex = 9;
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnPlay
            // 
            btnPlay.BackgroundImage = Properties.Resources.Mute;
            btnPlay.BackgroundImageLayout = ImageLayout.Stretch;
            btnPlay.Location = new Point(610, 315);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(35, 35);
            btnPlay.TabIndex = 10;
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Visible = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = Properties.Resources.Close;
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.Location = new Point(609, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 35);
            btnClose.TabIndex = 12;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 37);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 13;
            label1.Text = "Usuario:";
            label1.Click += label1_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(30, 138);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(119, 28);
            lblPassword.TabIndex = 14;
            lblPassword.Text = "Contraseña:";
            // 
            // linklblLogin
            // 
            linklblLogin.AutoSize = true;
            linklblLogin.BackColor = Color.Transparent;
            linklblLogin.Location = new Point(400, 292);
            linklblLogin.Name = "linklblLogin";
            linklblLogin.Size = new Size(157, 20);
            linklblLogin.TabIndex = 15;
            linklblLogin.TabStop = true;
            linklblLogin.Text = "¿Ya tienes una cuenta?";
            linklblLogin.LinkClicked += linklblLogin_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(656, 360);
            Controls.Add(linklblLogin);
            Controls.Add(lblPassword);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnPlay);
            Controls.Add(btnStop);
            Controls.Add(emailDomainComboBox);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(lblPropiedades);
            Controls.Add(checkPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtPassword2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "App - Registro";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword2;
        private TextBox txtPassword;
        private CheckBox checkPassword;
        private Label lblPropiedades;
        private Button btnIngresar;
        private TextBox txtUsuario;
        private ComboBox emailDomainComboBox;
        private Button btnStop;
        private Button btnPlay;
        private Button btnClose;
        private Label label1;
        private Label lblPassword;
        private LinkLabel linklblLogin;
    }
}