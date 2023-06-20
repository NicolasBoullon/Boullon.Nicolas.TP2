namespace FrmDesign
{
    partial class FormCrearJugador
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
            gpbCrearJugador = new GroupBox();
            lblNombreJugador = new Label();
            txtCrearJugador = new TextBox();
            btnSalir = new Button();
            btnAceptarCrearJugador = new Button();
            gpbCrearJugador.SuspendLayout();
            SuspendLayout();
            // 
            // gpbCrearJugador
            // 
            gpbCrearJugador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gpbCrearJugador.Controls.Add(lblNombreJugador);
            gpbCrearJugador.Controls.Add(txtCrearJugador);
            gpbCrearJugador.Font = new Font("Segoe Print", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            gpbCrearJugador.ForeColor = Color.Snow;
            gpbCrearJugador.Location = new Point(12, 12);
            gpbCrearJugador.Name = "gpbCrearJugador";
            gpbCrearJugador.Size = new Size(607, 97);
            gpbCrearJugador.TabIndex = 0;
            gpbCrearJugador.TabStop = false;
            gpbCrearJugador.Text = "Crear Jugador:";
            // 
            // lblNombreJugador
            // 
            lblNombreJugador.AutoSize = true;
            lblNombreJugador.Location = new Point(7, 41);
            lblNombreJugador.Name = "lblNombreJugador";
            lblNombreJugador.Size = new Size(234, 36);
            lblNombreJugador.TabIndex = 1;
            lblNombreJugador.Text = "Nombre de Jugador:";
            // 
            // txtCrearJugador
            // 
            txtCrearJugador.Font = new Font("Segoe Print", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearJugador.Location = new Point(256, 44);
            txtCrearJugador.MaxLength = 50;
            txtCrearJugador.Name = "txtCrearJugador";
            txtCrearJugador.Size = new Size(345, 33);
            txtCrearJugador.TabIndex = 0;
            txtCrearJugador.KeyPress += txtCrearJugador_KeyPress;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.BackColor = Color.FromArgb(24, 60, 53);
            btnSalir.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Snow;
            btnSalir.Location = new Point(432, 115);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(187, 38);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAceptarCrearJugador
            // 
            btnAceptarCrearJugador.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAceptarCrearJugador.BackColor = Color.FromArgb(24, 60, 53);
            btnAceptarCrearJugador.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptarCrearJugador.ForeColor = Color.Snow;
            btnAceptarCrearJugador.Location = new Point(12, 115);
            btnAceptarCrearJugador.Name = "btnAceptarCrearJugador";
            btnAceptarCrearJugador.Size = new Size(189, 38);
            btnAceptarCrearJugador.TabIndex = 9;
            btnAceptarCrearJugador.Text = "Crear Jugador";
            btnAceptarCrearJugador.UseVisualStyleBackColor = false;
            btnAceptarCrearJugador.Click += btnAceptarCrearJugador_Click;
            // 
            // FormCrearJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 51, 53);
            ClientSize = new Size(631, 159);
            Controls.Add(btnAceptarCrearJugador);
            Controls.Add(btnSalir);
            Controls.Add(gpbCrearJugador);
            Name = "FormCrearJugador";
            Text = "FormCrearJugador";
            gpbCrearJugador.ResumeLayout(false);
            gpbCrearJugador.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbCrearJugador;
        private Label lblNombreJugador;
        private TextBox txtCrearJugador;
        private Button btnSalir;
        private Button btnAceptarCrearJugador;
    }
}