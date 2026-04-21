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
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 342);
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
            Name = "Form2";
            Text = "Form2";
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
    }
}