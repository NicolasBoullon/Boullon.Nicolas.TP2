namespace FrmDesign
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pnlLoginUser = new Panel();
            gpbSignIn = new GroupBox();
            txtPassConfirmarCrear = new TextBox();
            lblConfirmarContra = new Label();
            btnRegistrarse = new Button();
            lblNombreCompletoCrear = new Label();
            txtNombreCrear = new TextBox();
            txtPassCrear = new TextBox();
            lblNombreDeUsuarioCrear = new Label();
            txtUserCrear = new TextBox();
            lblContraseñaCrearUser = new Label();
            gpbLogin = new GroupBox();
            btnAutocompletadoLogin = new Button();
            btnIngresarLogin = new Button();
            txtPassLogin = new TextBox();
            txtUserLogin = new TextBox();
            lblPass = new Label();
            lblUser = new Label();
            lblGeneralaTimba = new Label();
            pnlImagenDados = new Panel();
            pnlLoginUser.SuspendLayout();
            gpbSignIn.SuspendLayout();
            gpbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLoginUser
            // 
            pnlLoginUser.BackColor = Color.FromArgb(24, 51, 53);
            pnlLoginUser.Controls.Add(gpbSignIn);
            pnlLoginUser.Controls.Add(gpbLogin);
            pnlLoginUser.Controls.Add(lblGeneralaTimba);
            pnlLoginUser.Dock = DockStyle.Right;
            pnlLoginUser.Location = new Point(843, 0);
            pnlLoginUser.Name = "pnlLoginUser";
            pnlLoginUser.Size = new Size(353, 515);
            pnlLoginUser.TabIndex = 0;
            // 
            // gpbSignIn
            // 
            gpbSignIn.Anchor = AnchorStyles.Right;
            gpbSignIn.Controls.Add(txtPassConfirmarCrear);
            gpbSignIn.Controls.Add(lblConfirmarContra);
            gpbSignIn.Controls.Add(btnRegistrarse);
            gpbSignIn.Controls.Add(lblNombreCompletoCrear);
            gpbSignIn.Controls.Add(txtNombreCrear);
            gpbSignIn.Controls.Add(txtPassCrear);
            gpbSignIn.Controls.Add(lblNombreDeUsuarioCrear);
            gpbSignIn.Controls.Add(txtUserCrear);
            gpbSignIn.Controls.Add(lblContraseñaCrearUser);
            gpbSignIn.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            gpbSignIn.ForeColor = Color.Snow;
            gpbSignIn.Location = new Point(3, 292);
            gpbSignIn.Name = "gpbSignIn";
            gpbSignIn.Size = new Size(344, 215);
            gpbSignIn.TabIndex = 7;
            gpbSignIn.TabStop = false;
            gpbSignIn.Text = "Crear Usuario";
            // 
            // txtPassConfirmarCrear
            // 
            txtPassConfirmarCrear.Anchor = AnchorStyles.None;
            txtPassConfirmarCrear.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassConfirmarCrear.Location = new Point(165, 134);
            txtPassConfirmarCrear.MaxLength = 50;
            txtPassConfirmarCrear.Name = "txtPassConfirmarCrear";
            txtPassConfirmarCrear.Size = new Size(175, 27);
            txtPassConfirmarCrear.TabIndex = 22;
            txtPassConfirmarCrear.UseSystemPasswordChar = true;
            txtPassConfirmarCrear.KeyPress += txtPassConfirmarCrear_KeyPress;
            // 
            // lblConfirmarContra
            // 
            lblConfirmarContra.Anchor = AnchorStyles.None;
            lblConfirmarContra.AutoSize = true;
            lblConfirmarContra.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfirmarContra.Location = new Point(3, 137);
            lblConfirmarContra.Name = "lblConfirmarContra";
            lblConfirmarContra.Size = new Size(160, 20);
            lblConfirmarContra.TabIndex = 21;
            lblConfirmarContra.Text = "Confirmar Contraseña";
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Anchor = AnchorStyles.None;
            btnRegistrarse.BackColor = Color.FromArgb(24, 51, 53);
            btnRegistrarse.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarse.Location = new Point(70, 176);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(201, 31);
            btnRegistrarse.TabIndex = 14;
            btnRegistrarse.Text = "Registrarme";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // lblNombreCompletoCrear
            // 
            lblNombreCompletoCrear.Anchor = AnchorStyles.None;
            lblNombreCompletoCrear.AutoSize = true;
            lblNombreCompletoCrear.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreCompletoCrear.Location = new Point(8, 42);
            lblNombreCompletoCrear.Name = "lblNombreCompletoCrear";
            lblNombreCompletoCrear.Size = new Size(136, 20);
            lblNombreCompletoCrear.TabIndex = 19;
            lblNombreCompletoCrear.Text = "Nombre Completo";
            // 
            // txtNombreCrear
            // 
            txtNombreCrear.Anchor = AnchorStyles.None;
            txtNombreCrear.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombreCrear.Location = new Point(165, 35);
            txtNombreCrear.MaxLength = 50;
            txtNombreCrear.Name = "txtNombreCrear";
            txtNombreCrear.Size = new Size(175, 27);
            txtNombreCrear.TabIndex = 20;
            txtNombreCrear.KeyPress += txtNombreCrear_KeyPress;
            // 
            // txtPassCrear
            // 
            txtPassCrear.Anchor = AnchorStyles.None;
            txtPassCrear.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassCrear.Location = new Point(165, 101);
            txtPassCrear.MaxLength = 50;
            txtPassCrear.Name = "txtPassCrear";
            txtPassCrear.Size = new Size(175, 27);
            txtPassCrear.TabIndex = 18;
            txtPassCrear.UseSystemPasswordChar = true;
            txtPassCrear.KeyPress += txtPassCrear_KeyPress;
            // 
            // lblNombreDeUsuarioCrear
            // 
            lblNombreDeUsuarioCrear.Anchor = AnchorStyles.None;
            lblNombreDeUsuarioCrear.AutoSize = true;
            lblNombreDeUsuarioCrear.Font = new Font("Yu Gothic UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreDeUsuarioCrear.Location = new Point(8, 71);
            lblNombreDeUsuarioCrear.Name = "lblNombreDeUsuarioCrear";
            lblNombreDeUsuarioCrear.Size = new Size(146, 20);
            lblNombreDeUsuarioCrear.TabIndex = 15;
            lblNombreDeUsuarioCrear.Text = "Nombre De Usuario";
            // 
            // txtUserCrear
            // 
            txtUserCrear.Anchor = AnchorStyles.None;
            txtUserCrear.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserCrear.Location = new Point(165, 68);
            txtUserCrear.MaxLength = 50;
            txtUserCrear.Name = "txtUserCrear";
            txtUserCrear.Size = new Size(175, 27);
            txtUserCrear.TabIndex = 17;
            txtUserCrear.KeyPress += txtUserCrear_KeyPress;
            // 
            // lblContraseñaCrearUser
            // 
            lblContraseñaCrearUser.Anchor = AnchorStyles.None;
            lblContraseñaCrearUser.AutoSize = true;
            lblContraseñaCrearUser.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblContraseñaCrearUser.Location = new Point(8, 104);
            lblContraseñaCrearUser.Name = "lblContraseñaCrearUser";
            lblContraseñaCrearUser.Size = new Size(127, 20);
            lblContraseñaCrearUser.TabIndex = 16;
            lblContraseñaCrearUser.Text = "Crear Contraseña";
            // 
            // gpbLogin
            // 
            gpbLogin.Anchor = AnchorStyles.Right;
            gpbLogin.Controls.Add(btnAutocompletadoLogin);
            gpbLogin.Controls.Add(btnIngresarLogin);
            gpbLogin.Controls.Add(txtPassLogin);
            gpbLogin.Controls.Add(txtUserLogin);
            gpbLogin.Controls.Add(lblPass);
            gpbLogin.Controls.Add(lblUser);
            gpbLogin.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            gpbLogin.ForeColor = Color.Snow;
            gpbLogin.Location = new Point(3, 95);
            gpbLogin.Name = "gpbLogin";
            gpbLogin.RightToLeft = RightToLeft.No;
            gpbLogin.Size = new Size(344, 192);
            gpbLogin.TabIndex = 6;
            gpbLogin.TabStop = false;
            gpbLogin.Text = "Ingresar Usuario";
            // 
            // btnAutocompletadoLogin
            // 
            btnAutocompletadoLogin.Anchor = AnchorStyles.None;
            btnAutocompletadoLogin.BackColor = Color.FromArgb(24, 51, 53);
            btnAutocompletadoLogin.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAutocompletadoLogin.Location = new Point(170, 142);
            btnAutocompletadoLogin.Name = "btnAutocompletadoLogin";
            btnAutocompletadoLogin.Size = new Size(161, 34);
            btnAutocompletadoLogin.TabIndex = 11;
            btnAutocompletadoLogin.Text = "Autocompletar";
            btnAutocompletadoLogin.UseVisualStyleBackColor = false;
            btnAutocompletadoLogin.Click += btnAutocompletadoLogin_Click;
            // 
            // btnIngresarLogin
            // 
            btnIngresarLogin.Anchor = AnchorStyles.None;
            btnIngresarLogin.BackColor = Color.FromArgb(24, 51, 53);
            btnIngresarLogin.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresarLogin.Location = new Point(7, 142);
            btnIngresarLogin.Name = "btnIngresarLogin";
            btnIngresarLogin.Size = new Size(160, 34);
            btnIngresarLogin.TabIndex = 10;
            btnIngresarLogin.Text = "Ingresar";
            btnIngresarLogin.UseVisualStyleBackColor = false;
            btnIngresarLogin.Click += btnIngresarLogin_Click;
            // 
            // txtPassLogin
            // 
            txtPassLogin.Anchor = AnchorStyles.None;
            txtPassLogin.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassLogin.Location = new Point(162, 90);
            txtPassLogin.MaxLength = 50;
            txtPassLogin.Name = "txtPassLogin";
            txtPassLogin.Size = new Size(175, 27);
            txtPassLogin.TabIndex = 9;
            txtPassLogin.UseSystemPasswordChar = true;
            txtPassLogin.KeyPress += txtPassLogin_KeyPress;
            // 
            // txtUserLogin
            // 
            txtUserLogin.Anchor = AnchorStyles.None;
            txtUserLogin.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserLogin.Location = new Point(162, 49);
            txtUserLogin.MaxLength = 50;
            txtUserLogin.Name = "txtUserLogin";
            txtUserLogin.Size = new Size(175, 27);
            txtUserLogin.TabIndex = 8;
            txtUserLogin.KeyPress += txtUserLogin_KeyPress;
            // 
            // lblPass
            // 
            lblPass.Anchor = AnchorStyles.None;
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Yu Gothic UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPass.Location = new Point(8, 94);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(97, 23);
            lblPass.TabIndex = 7;
            lblPass.Text = "Contraseña";
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.None;
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Yu Gothic UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(8, 49);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(68, 23);
            lblUser.TabIndex = 6;
            lblUser.Text = "Usuario";
            // 
            // lblGeneralaTimba
            // 
            lblGeneralaTimba.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblGeneralaTimba.AutoSize = true;
            lblGeneralaTimba.Font = new Font("Gabriola", 48.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblGeneralaTimba.ForeColor = Color.Snow;
            lblGeneralaTimba.Location = new Point(-10, -9);
            lblGeneralaTimba.Name = "lblGeneralaTimba";
            lblGeneralaTimba.Size = new Size(376, 119);
            lblGeneralaTimba.TabIndex = 8;
            lblGeneralaTimba.Text = "Generala Timba";
            // 
            // pnlImagenDados
            // 
            pnlImagenDados.BackgroundImage = Properties.Resources.asdfasdfasdfa;
            pnlImagenDados.BackgroundImageLayout = ImageLayout.Stretch;
            pnlImagenDados.Dock = DockStyle.Fill;
            pnlImagenDados.Location = new Point(0, 0);
            pnlImagenDados.Name = "pnlImagenDados";
            pnlImagenDados.Size = new Size(843, 515);
            pnlImagenDados.TabIndex = 1;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 515);
            Controls.Add(pnlImagenDados);
            Controls.Add(pnlLoginUser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1212, 554);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generala Timba";
            Load += FormLogin_Load;
            pnlLoginUser.ResumeLayout(false);
            pnlLoginUser.PerformLayout();
            gpbSignIn.ResumeLayout(false);
            gpbSignIn.PerformLayout();
            gpbLogin.ResumeLayout(false);
            gpbLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLoginUser;
        private Panel pnlImagenDados;
        private GroupBox gpbSignIn;
        private TextBox txtPassConfirmarCrear;
        private Label lblConfirmarContra;
        private Button btnRegistrarse;
        private Label lblNombreCompletoCrear;
        private TextBox txtNombreCrear;
        private TextBox txtPassCrear;
        private Label lblNombreDeUsuarioCrear;
        private TextBox txtUserCrear;
        private Label lblContraseñaCrearUser;
        private GroupBox gpbLogin;
        private Button btnAutocompletadoLogin;
        private Button btnIngresarLogin;
        private TextBox txtPassLogin;
        private TextBox txtUserLogin;
        private Label lblPass;
        private Label lblUser;
        private Label lblGeneralaTimba;
    }
}