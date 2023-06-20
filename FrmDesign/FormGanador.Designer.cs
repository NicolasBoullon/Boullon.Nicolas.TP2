namespace FrmDesign
{
    partial class FormGanador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGanador));
            lblGanador = new Label();
            pcbGanador = new PictureBox();
            lblPerdedor = new Label();
            pcbPerdedor = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbGanador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbPerdedor).BeginInit();
            SuspendLayout();
            // 
            // lblGanador
            // 
            lblGanador.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblGanador.AutoSize = true;
            lblGanador.Font = new Font("Segoe Print", 26.25F, FontStyle.Underline, GraphicsUnit.Point);
            lblGanador.ForeColor = Color.Snow;
            lblGanador.Location = new Point(120, 32);
            lblGanador.Name = "lblGanador";
            lblGanador.Size = new Size(190, 61);
            lblGanador.TabIndex = 7;
            lblGanador.Text = "Ganador:";
            // 
            // pcbGanador
            // 
            pcbGanador.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pcbGanador.Image = Properties.Resources._2_sin_fondo;
            pcbGanador.Location = new Point(-52, -6);
            pcbGanador.Name = "pcbGanador";
            pcbGanador.Size = new Size(234, 151);
            pcbGanador.SizeMode = PictureBoxSizeMode.Zoom;
            pcbGanador.TabIndex = 8;
            pcbGanador.TabStop = false;
            // 
            // lblPerdedor
            // 
            lblPerdedor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPerdedor.AutoSize = true;
            lblPerdedor.Font = new Font("Segoe Print", 26.25F, FontStyle.Underline, GraphicsUnit.Point);
            lblPerdedor.ForeColor = Color.Snow;
            lblPerdedor.Location = new Point(120, 175);
            lblPerdedor.Name = "lblPerdedor";
            lblPerdedor.Size = new Size(200, 61);
            lblPerdedor.TabIndex = 9;
            lblPerdedor.Text = "Perdedor:";
            // 
            // pcbPerdedor
            // 
            pcbPerdedor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pcbPerdedor.Image = Properties.Resources._3_sin_fondo;
            pcbPerdedor.Location = new Point(-124, 56);
            pcbPerdedor.Name = "pcbPerdedor";
            pcbPerdedor.Size = new Size(374, 286);
            pcbPerdedor.SizeMode = PictureBoxSizeMode.Zoom;
            pcbPerdedor.TabIndex = 10;
            pcbPerdedor.TabStop = false;
            // 
            // FormGanador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 51, 53);
            ClientSize = new Size(1066, 276);
            Controls.Add(lblPerdedor);
            Controls.Add(lblGanador);
            Controls.Add(pcbGanador);
            Controls.Add(pcbPerdedor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1082, 315);
            MinimumSize = new Size(1082, 315);
            Name = "FormGanador";
            Text = "Resultados";
            Load += FormGanador_Load;
            ((System.ComponentModel.ISupportInitialize)pcbGanador).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbPerdedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGanador;
        private PictureBox pcbGanador;
        private Label lblPerdedor;
        private PictureBox pcbPerdedor;
    }
}