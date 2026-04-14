namespace MascotaBastian
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
            pgsHambre = new ProgressBar();
            pctNormal = new PictureBox();
            lblHambre = new Label();
            lblenergia = new Label();
            lblSueño = new Label();
            lblFelicidad = new Label();
            pgsEnergia = new ProgressBar();
            pgsSueño = new ProgressBar();
            pgsFelicidad = new ProgressBar();
            btnJugar = new Button();
            btnAlimentar = new Button();
            btnDormir = new Button();
            btnSalir = new Button();
            btnbaniar = new Button();
            lblEstado = new Label();
            pctFeliz = new PictureBox();
            pctsuenio = new PictureBox();
            pctTriste = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctNormal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctFeliz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctsuenio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctTriste).BeginInit();
            SuspendLayout();
            // 
            // pgsHambre
            // 
            pgsHambre.Location = new Point(448, 54);
            pgsHambre.Name = "pgsHambre";
            pgsHambre.Size = new Size(100, 23);
            pgsHambre.TabIndex = 0;
            pgsHambre.Click += pgsHambre_Click;
            // 
            // pctNormal
            // 
            pctNormal.Image = (Image)resources.GetObject("pctNormal.Image");
            pctNormal.Location = new Point(29, 54);
            pctNormal.Name = "pctNormal";
            pctNormal.Size = new Size(201, 190);
            pctNormal.SizeMode = PictureBoxSizeMode.StretchImage;
            pctNormal.TabIndex = 1;
            pctNormal.TabStop = false;
            // 
            // lblHambre
            // 
            lblHambre.AutoSize = true;
            lblHambre.Location = new Point(326, 54);
            lblHambre.Name = "lblHambre";
            lblHambre.Size = new Size(53, 15);
            lblHambre.TabIndex = 2;
            lblHambre.Text = "Hambre:";
            lblHambre.Click += label1_Click;
            // 
            // lblenergia
            // 
            lblenergia.AutoSize = true;
            lblenergia.Location = new Point(326, 83);
            lblenergia.Name = "lblenergia";
            lblenergia.Size = new Size(49, 15);
            lblenergia.TabIndex = 3;
            lblenergia.Text = "Energia:";
            // 
            // lblSueño
            // 
            lblSueño.AutoSize = true;
            lblSueño.Location = new Point(326, 112);
            lblSueño.Name = "lblSueño";
            lblSueño.Size = new Size(43, 15);
            lblSueño.TabIndex = 4;
            lblSueño.Text = "Sueño:";
            // 
            // lblFelicidad
            // 
            lblFelicidad.AutoSize = true;
            lblFelicidad.Location = new Point(326, 141);
            lblFelicidad.Name = "lblFelicidad";
            lblFelicidad.Size = new Size(57, 15);
            lblFelicidad.TabIndex = 5;
            lblFelicidad.Text = "Felicidad:";
            // 
            // pgsEnergia
            // 
            pgsEnergia.Location = new Point(448, 83);
            pgsEnergia.Name = "pgsEnergia";
            pgsEnergia.Size = new Size(100, 23);
            pgsEnergia.TabIndex = 6;
            // 
            // pgsSueño
            // 
            pgsSueño.Location = new Point(448, 112);
            pgsSueño.Name = "pgsSueño";
            pgsSueño.Size = new Size(100, 23);
            pgsSueño.TabIndex = 7;
            // 
            // pgsFelicidad
            // 
            pgsFelicidad.Location = new Point(448, 141);
            pgsFelicidad.Name = "pgsFelicidad";
            pgsFelicidad.Size = new Size(100, 23);
            pgsFelicidad.TabIndex = 8;
            // 
            // btnJugar
            // 
            btnJugar.Location = new Point(308, 204);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(75, 23);
            btnJugar.TabIndex = 9;
            btnJugar.Text = "Jugar";
            btnJugar.UseVisualStyleBackColor = true;
            btnJugar.Click += btnJugar_Click;
            // 
            // btnAlimentar
            // 
            btnAlimentar.Location = new Point(406, 204);
            btnAlimentar.Name = "btnAlimentar";
            btnAlimentar.Size = new Size(75, 23);
            btnAlimentar.TabIndex = 10;
            btnAlimentar.Text = "Alimentar";
            btnAlimentar.UseVisualStyleBackColor = true;
            btnAlimentar.Click += btnAlimentar_Click;
            // 
            // btnDormir
            // 
            btnDormir.Location = new Point(503, 204);
            btnDormir.Name = "btnDormir";
            btnDormir.Size = new Size(75, 23);
            btnDormir.TabIndex = 12;
            btnDormir.Text = "Dormir";
            btnDormir.UseVisualStyleBackColor = true;
            btnDormir.Click += btnDormir_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(697, 302);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnbaniar
            // 
            btnbaniar.Location = new Point(597, 204);
            btnbaniar.Name = "btnbaniar";
            btnbaniar.Size = new Size(75, 23);
            btnbaniar.TabIndex = 14;
            btnbaniar.Text = "Bañar";
            btnbaniar.UseVisualStyleBackColor = true;
            btnbaniar.Click += btnbaniar_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(48, 279);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 15);
            lblEstado.TabIndex = 15;
            // 
            // pctFeliz
            // 
            pctFeliz.Image = (Image)resources.GetObject("pctFeliz.Image");
            pctFeliz.Location = new Point(29, 54);
            pctFeliz.Name = "pctFeliz";
            pctFeliz.Size = new Size(201, 190);
            pctFeliz.SizeMode = PictureBoxSizeMode.StretchImage;
            pctFeliz.TabIndex = 16;
            pctFeliz.TabStop = false;
            // 
            // pctsuenio
            // 
            pctsuenio.Image = (Image)resources.GetObject("pctsuenio.Image");
            pctsuenio.Location = new Point(29, 54);
            pctsuenio.Name = "pctsuenio";
            pctsuenio.Size = new Size(201, 190);
            pctsuenio.SizeMode = PictureBoxSizeMode.StretchImage;
            pctsuenio.TabIndex = 17;
            pctsuenio.TabStop = false;
            // 
            // pctTriste
            // 
            pctTriste.Image = (Image)resources.GetObject("pctTriste.Image");
            pctTriste.Location = new Point(29, 54);
            pctTriste.Name = "pctTriste";
            pctTriste.Size = new Size(201, 190);
            pctTriste.SizeMode = PictureBoxSizeMode.StretchImage;
            pctTriste.TabIndex = 18;
            pctTriste.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 341);
            Controls.Add(pctTriste);
            Controls.Add(pctsuenio);
            Controls.Add(pctFeliz);
            Controls.Add(lblEstado);
            Controls.Add(btnbaniar);
            Controls.Add(btnSalir);
            Controls.Add(btnDormir);
            Controls.Add(btnAlimentar);
            Controls.Add(btnJugar);
            Controls.Add(pgsFelicidad);
            Controls.Add(pgsSueño);
            Controls.Add(pgsEnergia);
            Controls.Add(lblFelicidad);
            Controls.Add(lblSueño);
            Controls.Add(lblenergia);
            Controls.Add(lblHambre);
            Controls.Add(pctNormal);
            Controls.Add(pgsHambre);
            Name = "Form1";
            Text = "Firulais";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pctNormal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctFeliz).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctsuenio).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctTriste).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar pgsHambre;
        private PictureBox pctNormal;
        private Label lblHambre;
        private Label lblenergia;
        private Label lblSueño;
        private Label lblFelicidad;
        private ProgressBar pgsEnergia;
        private ProgressBar pgsSueño;
        private ProgressBar pgsFelicidad;
        private Button btnJugar;
        private Button btnAlimentar;
        private Button btnDormir;
        private Button btnSalir;
        private Button btnbaniar;
        private Label lblEstado;
        private PictureBox pctFeliz;
        private PictureBox pctsuenio;
        private PictureBox pctTriste;
    }
}
