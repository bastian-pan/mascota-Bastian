namespace MascotaBastian
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            lblTitulo = new Label();
            btnGato = new Button();
            btnPerro = new Button();
            btnRaton = new Button();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(256, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(103, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Elige a tu mascota";
            lblTitulo.Click += label1_Click;
            // 
            // btnGato
            // 
            btnGato.Location = new Point(112, 94);
            btnGato.Name = "btnGato";
            btnGato.Size = new Size(75, 23);
            btnGato.TabIndex = 1;
            btnGato.Text = "Gato";
            btnGato.UseVisualStyleBackColor = true;
            btnGato.Click += btnGato_Click;
            // 
            // btnPerro
            // 
            btnPerro.Location = new Point(482, 94);
            btnPerro.Name = "btnPerro";
            btnPerro.Size = new Size(75, 23);
            btnPerro.TabIndex = 2;
            btnPerro.Text = "Perro";
            btnPerro.UseVisualStyleBackColor = true;
            btnPerro.Click += btnPerro_Click;
            // 
            // btnRaton
            // 
            btnRaton.Location = new Point(293, 94);
            btnRaton.Name = "btnRaton";
            btnRaton.Size = new Size(75, 23);
            btnRaton.TabIndex = 3;
            btnRaton.Text = "Raton";
            btnRaton.UseVisualStyleBackColor = true;
            btnRaton.Click += btnRaton_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(293, 305);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(247, 132);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(180, 119);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(444, 132);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(180, 119);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 362);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnRaton);
            Controls.Add(btnPerro);
            Controls.Add(btnGato);
            Controls.Add(lblTitulo);
            Name = "menu";
            Text = "menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnGato;
        private Button btnPerro;
        private Button btnRaton;
        private Button btnSalir;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}