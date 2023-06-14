namespace FrmDesign
{
    partial class FormInicio
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
            pnlBotones = new Panel();
            pnlBarraBlanca = new Panel();
            button2 = new Button();
            button3 = new Button();
            btnMenuPartidas = new Button();
            pnlContenedorDelTabControl = new Panel();
            tbcInferfazInicio = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            pnlBotones.SuspendLayout();
            pnlContenedorDelTabControl.SuspendLayout();
            tbcInferfazInicio.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBotones
            // 
            pnlBotones.BackColor = Color.FromArgb(24, 40, 40);
            pnlBotones.Controls.Add(pnlBarraBlanca);
            pnlBotones.Controls.Add(button2);
            pnlBotones.Controls.Add(button3);
            pnlBotones.Controls.Add(btnMenuPartidas);
            pnlBotones.Dock = DockStyle.Top;
            pnlBotones.Location = new Point(0, 0);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(1196, 70);
            pnlBotones.TabIndex = 0;
            // 
            // pnlBarraBlanca
            // 
            pnlBarraBlanca.BackColor = Color.White;
            pnlBarraBlanca.Dock = DockStyle.Bottom;
            pnlBarraBlanca.Location = new Point(0, 66);
            pnlBarraBlanca.Name = "pnlBarraBlanca";
            pnlBarraBlanca.Size = new Size(1196, 4);
            pnlBarraBlanca.TabIndex = 3;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = Color.FromArgb(24, 60, 53);
            button2.Location = new Point(316, 14);
            button2.Name = "button2";
            button2.Size = new Size(215, 56);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.BackColor = Color.FromArgb(24, 60, 53);
            button3.Location = new Point(681, 16);
            button3.Name = "button3";
            button3.Size = new Size(230, 52);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnMenuPartidas
            // 
            btnMenuPartidas.Anchor = AnchorStyles.Top;
            btnMenuPartidas.BackColor = Color.FromArgb(24, 60, 53);
            btnMenuPartidas.Font = new Font("Segoe Print", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuPartidas.Location = new Point(36, 14);
            btnMenuPartidas.Name = "btnMenuPartidas";
            btnMenuPartidas.Size = new Size(208, 56);
            btnMenuPartidas.TabIndex = 0;
            btnMenuPartidas.Text = "Partidas";
            btnMenuPartidas.UseVisualStyleBackColor = false;
            btnMenuPartidas.Click += btnMenuPartidas_Click;
            // 
            // pnlContenedorDelTabControl
            // 
            pnlContenedorDelTabControl.BackColor = Color.FromArgb(24, 60, 53);
            pnlContenedorDelTabControl.Controls.Add(tbcInferfazInicio);
            pnlContenedorDelTabControl.Dock = DockStyle.Fill;
            pnlContenedorDelTabControl.Location = new Point(0, 0);
            pnlContenedorDelTabControl.Name = "pnlContenedorDelTabControl";
            pnlContenedorDelTabControl.Size = new Size(1196, 515);
            pnlContenedorDelTabControl.TabIndex = 1;
            // 
            // tbcInferfazInicio
            // 
            tbcInferfazInicio.Controls.Add(tabPage1);
            tbcInferfazInicio.Controls.Add(tabPage2);
            tbcInferfazInicio.Dock = DockStyle.Fill;
            tbcInferfazInicio.Location = new Point(0, 0);
            tbcInferfazInicio.Name = "tbcInferfazInicio";
            tbcInferfazInicio.SelectedIndex = 0;
            tbcInferfazInicio.Size = new Size(1196, 515);
            tbcInferfazInicio.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(24, 51, 53);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1188, 487);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1188, 441);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 51, 53);
            ClientSize = new Size(1196, 515);
            Controls.Add(pnlBotones);
            Controls.Add(pnlContenedorDelTabControl);
            MinimumSize = new Size(1212, 554);
            Name = "FormInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInicio";
            pnlBotones.ResumeLayout(false);
            pnlContenedorDelTabControl.ResumeLayout(false);
            tbcInferfazInicio.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBotones;
        private Button button2;
        private Button button3;
        private Button btnMenuPartidas;
        private Panel pnlContenedorDelTabControl;
        private TabControl tbcInferfazInicio;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel pnlBarraBlanca;
    }
}