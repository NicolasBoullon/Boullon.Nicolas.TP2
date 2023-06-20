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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            pnlBotones = new Panel();
            pnlBarraBlanca = new Panel();
            btnHistorialRanking = new Button();
            btnMenuPartidas = new Button();
            pnlContenedorDelTabControl = new Panel();
            tbcInferfazInicio = new TabControl();
            tbpPartidas = new TabPage();
            gpbCrearMesa = new GroupBox();
            btnCrearJugador = new Button();
            lblJugadorDos = new Label();
            cmbJugadorDos = new ComboBox();
            btnCrearMesa = new Button();
            cmbJugadorUno = new ComboBox();
            lblJugadorUno = new Label();
            pcbMisterDados = new PictureBox();
            tbpHistorialRanking = new TabPage();
            lblHistorialDePartidas = new Label();
            lblRankingDeVictorias = new Label();
            dtgvRankingVictorias = new DataGridView();
            dtgvHistorialPartidas = new DataGridView();
            JugadorUno = new DataGridViewTextBoxColumn();
            JugadorDos = new DataGridViewTextBoxColumn();
            Puntos = new DataGridViewTextBoxColumn();
            Punto = new DataGridViewTextBoxColumn();
            JugadorGanador = new DataGridViewTextBoxColumn();
            FechaPartida = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            pnlBotones.SuspendLayout();
            pnlContenedorDelTabControl.SuspendLayout();
            tbcInferfazInicio.SuspendLayout();
            tbpPartidas.SuspendLayout();
            gpbCrearMesa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbMisterDados).BeginInit();
            tbpHistorialRanking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvRankingVictorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvHistorialPartidas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlBotones
            // 
            pnlBotones.BackColor = Color.FromArgb(24, 40, 40);
            pnlBotones.Controls.Add(pnlBarraBlanca);
            pnlBotones.Controls.Add(btnHistorialRanking);
            pnlBotones.Controls.Add(btnMenuPartidas);
            pnlBotones.Dock = DockStyle.Top;
            pnlBotones.Location = new Point(0, 0);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(724, 70);
            pnlBotones.TabIndex = 0;
            // 
            // pnlBarraBlanca
            // 
            pnlBarraBlanca.BackColor = Color.White;
            pnlBarraBlanca.Dock = DockStyle.Bottom;
            pnlBarraBlanca.Location = new Point(0, 66);
            pnlBarraBlanca.Name = "pnlBarraBlanca";
            pnlBarraBlanca.Size = new Size(724, 4);
            pnlBarraBlanca.TabIndex = 3;
            // 
            // btnHistorialRanking
            // 
            btnHistorialRanking.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnHistorialRanking.BackColor = Color.FromArgb(24, 60, 53);
            btnHistorialRanking.Font = new Font("Segoe Print", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnHistorialRanking.ForeColor = Color.Snow;
            btnHistorialRanking.Location = new Point(392, 27);
            btnHistorialRanking.Name = "btnHistorialRanking";
            btnHistorialRanking.Size = new Size(315, 43);
            btnHistorialRanking.TabIndex = 1;
            btnHistorialRanking.Text = "Historial";
            btnHistorialRanking.UseVisualStyleBackColor = false;
            btnHistorialRanking.Click += button2_Click;
            // 
            // btnMenuPartidas
            // 
            btnMenuPartidas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnMenuPartidas.BackColor = Color.FromArgb(24, 60, 53);
            btnMenuPartidas.Font = new Font("Segoe Print", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuPartidas.ForeColor = Color.Snow;
            btnMenuPartidas.Location = new Point(16, 27);
            btnMenuPartidas.Name = "btnMenuPartidas";
            btnMenuPartidas.Size = new Size(315, 43);
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
            pnlContenedorDelTabControl.Size = new Size(724, 571);
            pnlContenedorDelTabControl.TabIndex = 1;
            // 
            // tbcInferfazInicio
            // 
            tbcInferfazInicio.Controls.Add(tbpPartidas);
            tbcInferfazInicio.Controls.Add(tbpHistorialRanking);
            tbcInferfazInicio.Dock = DockStyle.Fill;
            tbcInferfazInicio.Location = new Point(0, 0);
            tbcInferfazInicio.Name = "tbcInferfazInicio";
            tbcInferfazInicio.SelectedIndex = 0;
            tbcInferfazInicio.Size = new Size(724, 571);
            tbcInferfazInicio.TabIndex = 0;
            // 
            // tbpPartidas
            // 
            tbpPartidas.BackColor = Color.FromArgb(24, 51, 53);
            tbpPartidas.Controls.Add(gpbCrearMesa);
            tbpPartidas.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbpPartidas.Location = new Point(4, 24);
            tbpPartidas.Name = "tbpPartidas";
            tbpPartidas.Padding = new Padding(3);
            tbpPartidas.Size = new Size(716, 543);
            tbpPartidas.TabIndex = 0;
            tbpPartidas.Text = "tbpPartidas";
            // 
            // gpbCrearMesa
            // 
            gpbCrearMesa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gpbCrearMesa.Controls.Add(btnCrearJugador);
            gpbCrearMesa.Controls.Add(lblJugadorDos);
            gpbCrearMesa.Controls.Add(cmbJugadorDos);
            gpbCrearMesa.Controls.Add(btnCrearMesa);
            gpbCrearMesa.Controls.Add(cmbJugadorUno);
            gpbCrearMesa.Controls.Add(lblJugadorUno);
            gpbCrearMesa.Controls.Add(pcbMisterDados);
            gpbCrearMesa.Font = new Font("Segoe Print", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            gpbCrearMesa.ForeColor = Color.Snow;
            gpbCrearMesa.Location = new Point(6, 54);
            gpbCrearMesa.Name = "gpbCrearMesa";
            gpbCrearMesa.Size = new Size(703, 481);
            gpbCrearMesa.TabIndex = 4;
            gpbCrearMesa.TabStop = false;
            gpbCrearMesa.Text = "Crear Mesa de Juego";
            // 
            // btnCrearJugador
            // 
            btnCrearJugador.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCrearJugador.BackColor = Color.FromArgb(24, 60, 53);
            btnCrearJugador.Font = new Font("Segoe Print", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearJugador.Location = new Point(452, 137);
            btnCrearJugador.Name = "btnCrearJugador";
            btnCrearJugador.Size = new Size(223, 52);
            btnCrearJugador.TabIndex = 5;
            btnCrearJugador.Text = "Crear Jugador";
            btnCrearJugador.UseVisualStyleBackColor = false;
            btnCrearJugador.Click += btnCrearJugador_Click;
            // 
            // lblJugadorDos
            // 
            lblJugadorDos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblJugadorDos.AutoSize = true;
            lblJugadorDos.Font = new Font("Segoe Print", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblJugadorDos.ForeColor = Color.Snow;
            lblJugadorDos.Location = new Point(488, 65);
            lblJugadorDos.Name = "lblJugadorDos";
            lblJugadorDos.Size = new Size(148, 36);
            lblJugadorDos.TabIndex = 3;
            lblJugadorDos.Text = "Jugador Dos";
            // 
            // cmbJugadorDos
            // 
            cmbJugadorDos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbJugadorDos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJugadorDos.Font = new Font("Segoe Print", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbJugadorDos.FormattingEnabled = true;
            cmbJugadorDos.Location = new Point(452, 104);
            cmbJugadorDos.MaxDropDownItems = 100;
            cmbJugadorDos.MaxLength = 50;
            cmbJugadorDos.Name = "cmbJugadorDos";
            cmbJugadorDos.Size = new Size(223, 27);
            cmbJugadorDos.TabIndex = 1;
            // 
            // btnCrearMesa
            // 
            btnCrearMesa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCrearMesa.BackColor = Color.FromArgb(24, 60, 53);
            btnCrearMesa.Font = new Font("Segoe Print", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearMesa.Location = new Point(20, 137);
            btnCrearMesa.Name = "btnCrearMesa";
            btnCrearMesa.Size = new Size(223, 52);
            btnCrearMesa.TabIndex = 4;
            btnCrearMesa.Text = "Crear Mesa";
            btnCrearMesa.UseVisualStyleBackColor = false;
            btnCrearMesa.Click += btnCrearMesa_Click;
            // 
            // cmbJugadorUno
            // 
            cmbJugadorUno.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbJugadorUno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJugadorUno.Font = new Font("Segoe Print", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbJugadorUno.FormattingEnabled = true;
            cmbJugadorUno.Location = new Point(20, 104);
            cmbJugadorUno.MaxDropDownItems = 100;
            cmbJugadorUno.MaxLength = 50;
            cmbJugadorUno.Name = "cmbJugadorUno";
            cmbJugadorUno.Size = new Size(223, 27);
            cmbJugadorUno.TabIndex = 0;
            cmbJugadorUno.TextChanged += cmbJugadorUno_TextChanged;
            // 
            // lblJugadorUno
            // 
            lblJugadorUno.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblJugadorUno.AutoSize = true;
            lblJugadorUno.Font = new Font("Segoe Print", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblJugadorUno.ForeColor = Color.Snow;
            lblJugadorUno.Location = new Point(60, 65);
            lblJugadorUno.Name = "lblJugadorUno";
            lblJugadorUno.Size = new Size(152, 36);
            lblJugadorUno.TabIndex = 2;
            lblJugadorUno.Text = "Jugador Uno";
            // 
            // pcbMisterDados
            // 
            pcbMisterDados.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pcbMisterDados.Image = (Image)resources.GetObject("pcbMisterDados.Image");
            pcbMisterDados.Location = new Point(30, 65);
            pcbMisterDados.Name = "pcbMisterDados";
            pcbMisterDados.Size = new Size(667, 410);
            pcbMisterDados.SizeMode = PictureBoxSizeMode.Zoom;
            pcbMisterDados.TabIndex = 6;
            pcbMisterDados.TabStop = false;
            // 
            // tbpHistorialRanking
            // 
            tbpHistorialRanking.BackColor = Color.FromArgb(24, 51, 53);
            tbpHistorialRanking.Controls.Add(lblHistorialDePartidas);
            tbpHistorialRanking.Controls.Add(lblRankingDeVictorias);
            tbpHistorialRanking.Controls.Add(dtgvRankingVictorias);
            tbpHistorialRanking.Controls.Add(dtgvHistorialPartidas);
            tbpHistorialRanking.Controls.Add(pictureBox1);
            tbpHistorialRanking.Location = new Point(4, 24);
            tbpHistorialRanking.Name = "tbpHistorialRanking";
            tbpHistorialRanking.Padding = new Padding(3);
            tbpHistorialRanking.Size = new Size(716, 543);
            tbpHistorialRanking.TabIndex = 1;
            tbpHistorialRanking.Text = "tbpHistorialRanking";
            // 
            // lblHistorialDePartidas
            // 
            lblHistorialDePartidas.AutoSize = true;
            lblHistorialDePartidas.Font = new Font("Segoe Print", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHistorialDePartidas.ForeColor = Color.Snow;
            lblHistorialDePartidas.Location = new Point(432, 47);
            lblHistorialDePartidas.Name = "lblHistorialDePartidas";
            lblHistorialDePartidas.Size = new Size(234, 36);
            lblHistorialDePartidas.TabIndex = 4;
            lblHistorialDePartidas.Text = "Historial de Partidas";
            // 
            // lblRankingDeVictorias
            // 
            lblRankingDeVictorias.AutoSize = true;
            lblRankingDeVictorias.Font = new Font("Segoe Print", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRankingDeVictorias.ForeColor = Color.Snow;
            lblRankingDeVictorias.Location = new Point(4, 50);
            lblRankingDeVictorias.Name = "lblRankingDeVictorias";
            lblRankingDeVictorias.Size = new Size(233, 36);
            lblRankingDeVictorias.TabIndex = 3;
            lblRankingDeVictorias.Text = "Ranking de Victorias";
            // 
            // dtgvRankingVictorias
            // 
            dtgvRankingVictorias.AllowUserToAddRows = false;
            dtgvRankingVictorias.AllowUserToDeleteRows = false;
            dtgvRankingVictorias.AllowUserToResizeColumns = false;
            dtgvRankingVictorias.AllowUserToResizeRows = false;
            dtgvRankingVictorias.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dtgvRankingVictorias.BackgroundColor = Color.FromArgb(24, 51, 53);
            dtgvRankingVictorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvRankingVictorias.GridColor = SystemColors.ControlDarkDark;
            dtgvRankingVictorias.Location = new Point(12, 86);
            dtgvRankingVictorias.Name = "dtgvRankingVictorias";
            dtgvRankingVictorias.ReadOnly = true;
            dtgvRankingVictorias.RowHeadersVisible = false;
            dtgvRankingVictorias.RowTemplate.Height = 25;
            dtgvRankingVictorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvRankingVictorias.Size = new Size(244, 449);
            dtgvRankingVictorias.TabIndex = 0;
            // 
            // dtgvHistorialPartidas
            // 
            dtgvHistorialPartidas.AllowUserToAddRows = false;
            dtgvHistorialPartidas.AllowUserToDeleteRows = false;
            dtgvHistorialPartidas.AllowUserToResizeColumns = false;
            dtgvHistorialPartidas.AllowUserToResizeRows = false;
            dtgvHistorialPartidas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvHistorialPartidas.BackgroundColor = Color.FromArgb(24, 51, 53);
            dtgvHistorialPartidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvHistorialPartidas.Columns.AddRange(new DataGridViewColumn[] { JugadorUno, JugadorDos, Puntos, Punto, JugadorGanador, FechaPartida });
            dtgvHistorialPartidas.Location = new Point(423, 86);
            dtgvHistorialPartidas.Name = "dtgvHistorialPartidas";
            dtgvHistorialPartidas.ReadOnly = true;
            dtgvHistorialPartidas.RowHeadersVisible = false;
            dtgvHistorialPartidas.RowTemplate.Height = 25;
            dtgvHistorialPartidas.Size = new Size(280, 451);
            dtgvHistorialPartidas.TabIndex = 2;
            // 
            // JugadorUno
            // 
            JugadorUno.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            JugadorUno.HeaderText = "Jugador Ganador";
            JugadorUno.Name = "JugadorUno";
            JugadorUno.ReadOnly = true;
            JugadorUno.Resizable = DataGridViewTriState.False;
            JugadorUno.SortMode = DataGridViewColumnSortMode.NotSortable;
            JugadorUno.Width = 93;
            // 
            // JugadorDos
            // 
            JugadorDos.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            JugadorDos.HeaderText = "Jugador Perdedor";
            JugadorDos.Name = "JugadorDos";
            JugadorDos.ReadOnly = true;
            JugadorDos.Width = 115;
            // 
            // Puntos
            // 
            Puntos.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Puntos.HeaderText = "Puntos Ganador";
            Puntos.Name = "Puntos";
            Puntos.ReadOnly = true;
            Puntos.Width = 107;
            // 
            // Punto
            // 
            Punto.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Punto.HeaderText = "Puntos Perdedor";
            Punto.Name = "Punto";
            Punto.ReadOnly = true;
            Punto.Width = 110;
            // 
            // JugadorGanador
            // 
            JugadorGanador.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            JugadorGanador.HeaderText = "Ganador";
            JugadorGanador.Name = "JugadorGanador";
            JugadorGanador.ReadOnly = true;
            JugadorGanador.Width = 77;
            // 
            // FechaPartida
            // 
            FechaPartida.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FechaPartida.HeaderText = "Fecha de Juego";
            FechaPartida.Name = "FechaPartida";
            FechaPartida.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(76, 172);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(496, 460);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 51, 53);
            ClientSize = new Size(724, 571);
            Controls.Add(pnlBotones);
            Controls.Add(pnlContenedorDelTabControl);
            MaximumSize = new Size(1100, 610);
            MinimumSize = new Size(740, 610);
            Name = "FormInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInicio";
            pnlBotones.ResumeLayout(false);
            pnlContenedorDelTabControl.ResumeLayout(false);
            tbcInferfazInicio.ResumeLayout(false);
            tbpPartidas.ResumeLayout(false);
            gpbCrearMesa.ResumeLayout(false);
            gpbCrearMesa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbMisterDados).EndInit();
            tbpHistorialRanking.ResumeLayout(false);
            tbpHistorialRanking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvRankingVictorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvHistorialPartidas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBotones;
        private Button btnHistorialRanking;
        private Button btnMenuPartidas;
        private Panel pnlContenedorDelTabControl;
        private TabControl tbcInferfazInicio;
        private TabPage tbpPartidas;
        private TabPage tbpHistorialRanking;
        private Panel pnlBarraBlanca;
        private ComboBox cmbJugadorDos;
        private ComboBox cmbJugadorUno;
        private GroupBox gpbCrearMesa;
        private Button btnCrearJugador;
        private Button btnCrearMesa;
        private Label lblJugadorDos;
        private Label lblJugadorUno;
        private PictureBox pcbMisterDados;
        private DataGridView dtgvRankingVictorias;
        private PictureBox pictureBox1;
        private DataGridView dtgvHistorialPartidas;
        private Label lblHistorialDePartidas;
        private Label lblRankingDeVictorias;
        private DataGridViewTextBoxColumn JugadorUno;
        private DataGridViewTextBoxColumn JugadorDos;
        private DataGridViewTextBoxColumn Puntos;
        private DataGridViewTextBoxColumn Punto;
        private DataGridViewTextBoxColumn JugadorGanador;
        private DataGridViewTextBoxColumn FechaPartida;
    }
}