using System.Timers;
using System.Windows.Forms;

namespace MascotaBastian
{
    public partial class Form2 : Form
    {
        private System.Windows.Forms.Timer timermascota;

        private int edad = 0;
        private int contadorAcciones = 0;

        private enum Etapa
        {
            Cachorro,
            Adulto,
            Anciano
        }
        private Etapa etapaActual = Etapa.Cachorro;

        private int tiempoCritico = 0;

        public Form2()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //confi del timer o tiempo que se actualiza
            timermascota = new System.Windows.Forms.Timer();
            timermascota.Interval = 3000;
            timermascota.Tick += Timermascota_Tick;
            timermascota.Start();

            //confi del inicio de la mascota
            pgsHambre.Value = 30;
            pgsFelicidad.Value = 50;
            pgsSueño.Value = 20;
            pgsEnergia.Value = 80;

            // ensure all images are hidden and UI shows the correct one for the current stage
            ocultarImagenes();
            mostrarEstado();
        }



        private void Timermascota_Tick(object sender, EventArgs e)
        {
            int desgaste = 5;

            if (etapaActual == Etapa.Adulto)
                desgaste = 7;
            else if (etapaActual == Etapa.Anciano)
                desgaste = 10;

            barrasProgreso(pgsHambre, desgaste);
            barrasProgreso(pgsFelicidad, -desgaste);
            barrasProgreso(pgsSueño, desgaste);
            barrasProgreso(pgsEnergia, -desgaste);

            detectarEstadoCritico();
            mostrarEstado();
        }

        private void barrasProgreso(ProgressBar barra, int valor)
        {
            if (barra.Value + valor > 100)
            {
                barra.Value = 100;
            }
            else if (barra.Value + valor < 0)
            {
                barra.Value = 0;
            }
            else
            {
                barra.Value += valor;
            }
        }
        private void ocultarImagenes()
        {
            pctGatitoF.Visible = false;
            pctGatitoT.Visible = false;
            pctGatitoN.Visible = false;

            pctFeliz.Visible = false;
            pctTriste.Visible = false;
            pctNormal.Visible = false;

            pctAncianoN.Visible = false;
            pctAncianoF.Visible = false;
            pctAncianoT.Visible = false;

        }
        private void mostrarImagen(string estado)
        {
            ocultarImagenes();

            if (etapaActual == Etapa.Cachorro)
            {
                if (estado == "feliz") pctGatitoF.Visible = true;
                else if (estado == "triste") pctGatitoT.Visible = true;
                else pctGatitoN.Visible = true;
            }
            else if (etapaActual == Etapa.Adulto)
            {
                if (estado == "feliz") pctFeliz.Visible = true;
                else if (estado == "triste") pctTriste.Visible = true;
                else pctNormal.Visible = true;
            }
            else
            {
                if (estado == "feliz") pctGatoAncianoF.Visible = true;
                else if (estado == "triste") pctGatoAncianoT.Visible = true;
                else pctGatoAncianoN.Visible = true;
            }

            BringVisiblePictureToFront();
        }
        private void BringVisiblePictureToFront()
        {
            TraerAlFrente(this);
        }

        private void TraerAlFrente(Control contenedor)
        {
            foreach (Control c in contenedor.Controls)
            {
                if (c is PictureBox pb && pb.Visible)
                {
                    pb.BringToFront();
                }

                if (c.HasChildren)
                {
                    TraerAlFrente(c);
                }
            }
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            barrasProgreso(pgsFelicidad, 10);
            barrasProgreso(pgsHambre, 15);
            barrasProgreso(pgsSueño, 20);
            barrasProgreso(pgsEnergia, -10);

            sumarAccion();
            mostrarEstado();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAlimentar_Click(object sender, EventArgs e)
        {
            barrasProgreso(pgsHambre, -20);
            barrasProgreso(pgsFelicidad, 15);
            barrasProgreso(pgsEnergia, 30);

            sumarAccion();
            mostrarEstado();
        }

        private void btnDormir_Click(object sender, EventArgs e)
        {
            barrasProgreso(pgsSueño, -50);
            barrasProgreso(pgsEnergia, 50);
            barrasProgreso(pgsHambre, 30);
            barrasProgreso(pgsFelicidad, 20);

            sumarAccion();
            mostrarEstado();

        }



        private void btnbaniar_Click(object sender, EventArgs e)
        {
            barrasProgreso(pgsFelicidad, -30);
            barrasProgreso(pgsHambre, 10);
            barrasProgreso(pgsEnergia, -30);

            sumarAccion();
            mostrarEstado();

        }

        private void sumarAccion()
        {
            contadorAcciones++;

            if (contadorAcciones >= 10)
            {
                edad++;
                contadorAcciones = 0;
                actualizarEtapa();
            }
        }
        private void actualizarEtapa()
        {
            if (edad < 3)
                etapaActual = Etapa.Cachorro;
            else if (edad < 6)
                etapaActual = Etapa.Adulto;
            else
                etapaActual = Etapa.Anciano;

            mostrarEstado(); // 🔥 importante
        }
        private void mostrarEstado()
        {
            if (pgsHambre.Value > 70)
            {
                lblEstado.Text = "Estoy hambriento";
                mostrarImagen("triste");
            }
            else if (pgsFelicidad.Value < 30)
            {
                lblEstado.Text = "Estoy triste";
                mostrarImagen("triste");
            }
            else if (pgsSueño.Value > 70)
            {
                lblEstado.Text = "Tengo sueño";
                ocultarImagenes();
                pctsuenio.Visible = true;
                BringVisiblePictureToFront();
            }
            else if (pgsEnergia.Value < 30)
            {
                lblEstado.Text = "Estoy cansado";
                ocultarImagenes();
                pctsuenio.Visible = true;
                BringVisiblePictureToFront();
            }
            else
            {
                lblEstado.Text = "Estoy feliz";
                mostrarImagen("feliz");
            }

            lblEdad.Text = "Etapa: " + etapaActual.ToString();
            actualizarBotones();
        }


        private void actualizarBotones()
        {
            btnAlimentar.Enabled = false;
            btnJugar.Enabled = false;
            btnDormir.Enabled = false;
            btnbaniar.Enabled = false;

            if (pgsHambre.Value > 50)
                btnAlimentar.Enabled = true;
            else if (pgsSueño.Value > 70 || pgsEnergia.Value < 30)
                btnDormir.Enabled = true;
            else if (pgsFelicidad.Value < 20)
            {
                btnJugar.Enabled = true;
                btnbaniar.Enabled = true;
            }
            else
            {
                btnAlimentar.Enabled = true;
                btnJugar.Enabled = true;
                btnDormir.Enabled = true;
                btnbaniar.Enabled = true;
            }
        }
        private void detectarEstadoCritico()
        {
            if (pgsFelicidad.Value == 0 || pgsEnergia.Value == 0)
            {
                tiempoCritico += 3; // tu timer es 3 segundos
            }
            else
            {
                tiempoCritico = 0;
            }

            if (tiempoCritico >= 30)
            {
                activarPerrera();
            }
        }
        private void activarPerrera()
        {
            timermascota.Stop();

            lblEstado.Text = "Tu mascota fue llevada a la perrera 😢";

            pctFeliz.Visible = false;
            pctNormal.Visible = false;
            pctTriste.Visible = true;
            pctsuenio.Visible = false;

            btnAlimentar.Enabled = false;
            btnJugar.Enabled = false;
            btnDormir.Enabled = false;
            btnbaniar.Enabled = false;

            MessageBox.Show("Fin del juego");
            Application.Exit();
        }



    }
}
