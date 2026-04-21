namespace MascotaBastian
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            btnJugar = new Button();
            btnbaniar = new Button();
            btnDormir = new Button();
            btnAlimentar = new Button();
            pgsFelicidad = new ProgressBar();
            pgsSueño = new ProgressBar();
            pgsEnergia = new ProgressBar();
            lblFelicidad = new Label();
            lblSueño = new Label();
            lblenergia = new Label();
            lblHambre = new Label();
            pgsHambre = new ProgressBar();
            btnSalir = new Button();
            lblEstado = new Label();
            lblEdad = new Label();
            pctAdultoN = new PictureBox();
            pctAdultoF = new PictureBox();
            pctAdultoT = new PictureBox();
            pctCachorroT = new PictureBox();
            pctCachorroF = new PictureBox();
            pctCachorroN = new PictureBox();
            pctAncianoN = new PictureBox();
            pctAncianoF = new PictureBox();
            pctAncianoT = new PictureBox();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)pctAdultoN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctAdultoF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctAdultoT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctCachorroT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctCachorroF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctCachorroN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctAncianoN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctAncianoF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctAncianoT).BeginInit();
            SuspendLayout();
            // 
            // btnJugar
            // 
            btnJugar.Location = new Point(314, 250);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(75, 23);
            btnJugar.TabIndex = 10;
            btnJugar.Text = "Jugar";
            btnJugar.UseVisualStyleBackColor = true;
            btnJugar.Click += btnJugar_Click;
            // 
            // btnbaniar
            // 
            btnbaniar.Location = new Point(596, 250);
            btnbaniar.Name = "btnbaniar";
            btnbaniar.Size = new Size(75, 23);
            btnbaniar.TabIndex = 17;
            btnbaniar.Text = "Bañar";
            btnbaniar.UseVisualStyleBackColor = true;
            btnbaniar.Click += btnbaniar_Click_1;
            // 
            // btnDormir
            // 
            btnDormir.Location = new Point(502, 250);
            btnDormir.Name = "btnDormir";
            btnDormir.Size = new Size(75, 23);
            btnDormir.TabIndex = 16;
            btnDormir.Text = "Dormir";
            btnDormir.UseVisualStyleBackColor = true;
            btnDormir.Click += btnDormir_Click;
            // 
            // btnAlimentar
            // 
            btnAlimentar.Location = new Point(405, 250);
            btnAlimentar.Name = "btnAlimentar";
            btnAlimentar.Size = new Size(75, 23);
            btnAlimentar.TabIndex = 15;
            btnAlimentar.Text = "Alimentar";
            btnAlimentar.UseVisualStyleBackColor = true;
            btnAlimentar.Click += btnAlimentar_Click;
            // 
            // pgsFelicidad
            // 
            pgsFelicidad.Location = new Point(481, 155);
            pgsFelicidad.Name = "pgsFelicidad";
            pgsFelicidad.Size = new Size(100, 23);
            pgsFelicidad.TabIndex = 25;
            // 
            // pgsSueño
            // 
            pgsSueño.Location = new Point(481, 126);
            pgsSueño.Name = "pgsSueño";
            pgsSueño.Size = new Size(100, 23);
            pgsSueño.TabIndex = 24;
            // 
            // pgsEnergia
            // 
            pgsEnergia.Location = new Point(481, 97);
            pgsEnergia.Name = "pgsEnergia";
            pgsEnergia.Size = new Size(100, 23);
            pgsEnergia.TabIndex = 23;
            // 
            // lblFelicidad
            // 
            lblFelicidad.AutoSize = true;
            lblFelicidad.Location = new Point(359, 155);
            lblFelicidad.Name = "lblFelicidad";
            lblFelicidad.Size = new Size(57, 15);
            lblFelicidad.TabIndex = 22;
            lblFelicidad.Text = "Felicidad:";
            // 
            // lblSueño
            // 
            lblSueño.AutoSize = true;
            lblSueño.Location = new Point(359, 126);
            lblSueño.Name = "lblSueño";
            lblSueño.Size = new Size(43, 15);
            lblSueño.TabIndex = 21;
            lblSueño.Text = "Sueño:";
            // 
            // lblenergia
            // 
            lblenergia.AutoSize = true;
            lblenergia.Location = new Point(359, 97);
            lblenergia.Name = "lblenergia";
            lblenergia.Size = new Size(49, 15);
            lblenergia.TabIndex = 20;
            lblenergia.Text = "Energia:";
            // 
            // lblHambre
            // 
            lblHambre.AutoSize = true;
            lblHambre.Location = new Point(359, 68);
            lblHambre.Name = "lblHambre";
            lblHambre.Size = new Size(53, 15);
            lblHambre.TabIndex = 19;
            lblHambre.Text = "Hambre:";
            // 
            // pgsHambre
            // 
            pgsHambre.Location = new Point(481, 68);
            pgsHambre.Name = "pgsHambre";
            pgsHambre.Size = new Size(100, 23);
            pgsHambre.TabIndex = 18;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(697, 307);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 26;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(33, 290);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 15);
            lblEstado.TabIndex = 27;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(33, 9);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(0, 15);
            lblEdad.TabIndex = 28;
            // 
            // pctAdultoN
            // 
            pctAdultoN.Image = (Image)resources.GetObject("pctAdultoN.Image");
            pctAdultoN.Location = new Point(33, 52);
            pctAdultoN.Name = "pctAdultoN";
            pctAdultoN.Size = new Size(200, 200);
            pctAdultoN.SizeMode = PictureBoxSizeMode.StretchImage;
            pctAdultoN.TabIndex = 29;
            pctAdultoN.TabStop = false;
            // 
            // pctAdultoF
            // 
            pctAdultoF.Image = (Image)resources.GetObject("pctAdultoF.Image");
            pctAdultoF.Location = new Point(33, 52);
            pctAdultoF.Name = "pctAdultoF";
            pctAdultoF.Size = new Size(200, 200);
            pctAdultoF.SizeMode = PictureBoxSizeMode.StretchImage;
            pctAdultoF.TabIndex = 30;
            pctAdultoF.TabStop = false;
            // 
            // pctAdultoT
            // 
            pctAdultoT.Image = (Image)resources.GetObject("pctAdultoT.Image");
            pctAdultoT.Location = new Point(33, 52);
            pctAdultoT.Name = "pctAdultoT";
            pctAdultoT.Size = new Size(200, 200);
            pctAdultoT.SizeMode = PictureBoxSizeMode.StretchImage;
            pctAdultoT.TabIndex = 31;
            pctAdultoT.TabStop = false;
            // 
            // pctCachorroT
            // 
            pctCachorroT.Image = (Image)resources.GetObject("pctCachorroT.Image");
            pctCachorroT.Location = new Point(33, 52);
            pctCachorroT.Name = "pctCachorroT";
            pctCachorroT.Size = new Size(200, 200);
            pctCachorroT.SizeMode = PictureBoxSizeMode.StretchImage;
            pctCachorroT.TabIndex = 32;
            pctCachorroT.TabStop = false;
            // 
            // pctCachorroF
            // 
            pctCachorroF.Image = (Image)resources.GetObject("pctCachorroF.Image");
            pctCachorroF.Location = new Point(33, 52);
            pctCachorroF.Name = "pctCachorroF";
            pctCachorroF.Size = new Size(200, 200);
            pctCachorroF.SizeMode = PictureBoxSizeMode.StretchImage;
            pctCachorroF.TabIndex = 33;
            pctCachorroF.TabStop = false;
            // 
            // pctCachorroN
            // 
            pctCachorroN.Image = (Image)resources.GetObject("pctCachorroN.Image");
            pctCachorroN.Location = new Point(33, 52);
            pctCachorroN.Name = "pctCachorroN";
            pctCachorroN.Size = new Size(200, 200);
            pctCachorroN.SizeMode = PictureBoxSizeMode.StretchImage;
            pctCachorroN.TabIndex = 34;
            pctCachorroN.TabStop = false;
            // 
            // pctAncianoN
            // 
            pctAncianoN.Image = (Image)resources.GetObject("pctAncianoN.Image");
            pctAncianoN.Location = new Point(33, 52);
            pctAncianoN.Name = "pctAncianoN";
            pctAncianoN.Size = new Size(200, 200);
            pctAncianoN.SizeMode = PictureBoxSizeMode.StretchImage;
            pctAncianoN.TabIndex = 35;
            pctAncianoN.TabStop = false;
            // 
            // pctAncianoF
            // 
            pctAncianoF.Image = (Image)resources.GetObject("pctAncianoF.Image");
            pctAncianoF.Location = new Point(33, 52);
            pctAncianoF.Name = "pctAncianoF";
            pctAncianoF.Size = new Size(200, 200);
            pctAncianoF.SizeMode = PictureBoxSizeMode.StretchImage;
            pctAncianoF.TabIndex = 36;
            pctAncianoF.TabStop = false;
            // 
            // pctAncianoT
            // 
            pctAncianoT.Image = (Image)resources.GetObject("pctAncianoT.Image");
            pctAncianoT.Location = new Point(33, 52);
            pctAncianoT.Name = "pctAncianoT";
            pctAncianoT.Size = new Size(200, 200);
            pctAncianoT.SizeMode = PictureBoxSizeMode.StretchImage;
            pctAncianoT.TabIndex = 37;
            pctAncianoT.TabStop = false;
            pctAncianoT.Click += pictureBox9_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(596, 307);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 38;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 342);
            Controls.Add(btnVolver);
            Controls.Add(pctAncianoT);
            Controls.Add(lblEdad);
            Controls.Add(lblEstado);
            Controls.Add(btnSalir);
            Controls.Add(pgsFelicidad);
            Controls.Add(pgsSueño);
            Controls.Add(pgsEnergia);
            Controls.Add(lblFelicidad);
            Controls.Add(lblSueño);
            Controls.Add(lblenergia);
            Controls.Add(lblHambre);
            Controls.Add(pgsHambre);
            Controls.Add(btnbaniar);
            Controls.Add(btnDormir);
            Controls.Add(btnAlimentar);
            Controls.Add(btnJugar);
            Controls.Add(pctAncianoF);
            Controls.Add(pctAncianoN);
            Controls.Add(pctCachorroN);
            Controls.Add(pctCachorroF);
            Controls.Add(pctCachorroT);
            Controls.Add(pctAdultoT);
            Controls.Add(pctAdultoF);
            Controls.Add(pctAdultoN);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pctAdultoN).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctAdultoF).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctAdultoT).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctCachorroT).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctCachorroF).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctCachorroN).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctAncianoN).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctAncianoF).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctAncianoT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnJugar;
        private Button btnbaniar;
        private Button btnDormir;
        private Button btnAlimentar;
        private ProgressBar pgsFelicidad;
        private ProgressBar pgsSueño;
        private ProgressBar pgsEnergia;
        private Label lblFelicidad;
        private Label lblSueño;
        private Label lblenergia;
        private Label lblHambre;
        private ProgressBar pgsHambre;
        private Button btnSalir;
        private Label lblEstado;
        private Label lblEdad;
        private PictureBox pctAdultoN;
        private PictureBox pctAdultoF;
        private PictureBox pctAdultoT;
        private PictureBox pctCachorroT;
        private PictureBox pctCachorroF;
        private PictureBox pctCachorroN;
        private PictureBox pctAncianoN;
        private PictureBox pctAncianoF;
        private PictureBox pctAncianoT;
        private Button btnVolver;
    }
}