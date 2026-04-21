namespace MascotaBastian
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
            lblEdad = new Label();
            lblEstado = new Label();
            btnSalir = new Button();
            pgsFelicidad = new ProgressBar();
            pgsSueño = new ProgressBar();
            pgsEnergia = new ProgressBar();
            lblFelicidad = new Label();
            lblSueño = new Label();
            lblenergia = new Label();
            lblHambre = new Label();
            pgsHambre = new ProgressBar();
            btnbaniar = new Button();
            btnDormir = new Button();
            btnAlimentar = new Button();
            btnJugar = new Button();
            SuspendLayout();
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(24, 7);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(0, 15);
            lblEdad.TabIndex = 43;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(24, 288);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 15);
            lblEstado.TabIndex = 42;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(688, 305);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 41;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // pgsFelicidad
            // 
            pgsFelicidad.Location = new Point(472, 153);
            pgsFelicidad.Name = "pgsFelicidad";
            pgsFelicidad.Size = new Size(100, 23);
            pgsFelicidad.TabIndex = 40;
            // 
            // pgsSueño
            // 
            pgsSueño.Location = new Point(472, 124);
            pgsSueño.Name = "pgsSueño";
            pgsSueño.Size = new Size(100, 23);
            pgsSueño.TabIndex = 39;
            // 
            // pgsEnergia
            // 
            pgsEnergia.Location = new Point(472, 95);
            pgsEnergia.Name = "pgsEnergia";
            pgsEnergia.Size = new Size(100, 23);
            pgsEnergia.TabIndex = 38;
            // 
            // lblFelicidad
            // 
            lblFelicidad.AutoSize = true;
            lblFelicidad.Location = new Point(350, 153);
            lblFelicidad.Name = "lblFelicidad";
            lblFelicidad.Size = new Size(57, 15);
            lblFelicidad.TabIndex = 37;
            lblFelicidad.Text = "Felicidad:";
            // 
            // lblSueño
            // 
            lblSueño.AutoSize = true;
            lblSueño.Location = new Point(350, 124);
            lblSueño.Name = "lblSueño";
            lblSueño.Size = new Size(43, 15);
            lblSueño.TabIndex = 36;
            lblSueño.Text = "Sueño:";
            // 
            // lblenergia
            // 
            lblenergia.AutoSize = true;
            lblenergia.Location = new Point(350, 95);
            lblenergia.Name = "lblenergia";
            lblenergia.Size = new Size(49, 15);
            lblenergia.TabIndex = 35;
            lblenergia.Text = "Energia:";
            // 
            // lblHambre
            // 
            lblHambre.AutoSize = true;
            lblHambre.Location = new Point(350, 66);
            lblHambre.Name = "lblHambre";
            lblHambre.Size = new Size(53, 15);
            lblHambre.TabIndex = 34;
            lblHambre.Text = "Hambre:";
            // 
            // pgsHambre
            // 
            pgsHambre.Location = new Point(472, 66);
            pgsHambre.Name = "pgsHambre";
            pgsHambre.Size = new Size(100, 23);
            pgsHambre.TabIndex = 33;
            // 
            // btnbaniar
            // 
            btnbaniar.Location = new Point(587, 248);
            btnbaniar.Name = "btnbaniar";
            btnbaniar.Size = new Size(75, 23);
            btnbaniar.TabIndex = 32;
            btnbaniar.Text = "Bañar";
            btnbaniar.UseVisualStyleBackColor = true;
            // 
            // btnDormir
            // 
            btnDormir.Location = new Point(493, 248);
            btnDormir.Name = "btnDormir";
            btnDormir.Size = new Size(75, 23);
            btnDormir.TabIndex = 31;
            btnDormir.Text = "Dormir";
            btnDormir.UseVisualStyleBackColor = true;
            // 
            // btnAlimentar
            // 
            btnAlimentar.Location = new Point(396, 248);
            btnAlimentar.Name = "btnAlimentar";
            btnAlimentar.Size = new Size(75, 23);
            btnAlimentar.TabIndex = 30;
            btnAlimentar.Text = "Alimentar";
            btnAlimentar.UseVisualStyleBackColor = true;
            // 
            // btnJugar
            // 
            btnJugar.Location = new Point(305, 248);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(75, 23);
            btnJugar.TabIndex = 29;
            btnJugar.Text = "Jugar";
            btnJugar.UseVisualStyleBackColor = true;

            // 
            // Form3
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
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEdad;
        private Label lblEstado;
        private Button btnSalir;
        private ProgressBar pgsFelicidad;
        private ProgressBar pgsSueño;
        private ProgressBar pgsEnergia;
        private Label lblFelicidad;
        private Label lblSueño;
        private Label lblenergia;
        private Label lblHambre;
        private ProgressBar pgsHambre;
        private Button btnbaniar;
        private Button btnDormir;
        private Button btnAlimentar;
        private Button btnJugar;
    }
}