using System.Timers;
using System.Windows.Forms;

namespace MascotaBastian
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timermascota;

        private int edad = 0;
        private int contadorAcciones = 0;

        private enum Etapa         {
            Cachorro,
            Adulto,
            Anciano
        }
        private Etapa etapaActual = Etapa.Cachorro;

        private int tiempoCritico = 0;

        public Form1()
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



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pgsHambre_Click(object sender, EventArgs e)
        {

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            barrasProgreso(pgsFelicidad, 10);
            barrasProgreso(pgsHambre, 15);
            barrasProgreso(pgsSueño, 20);
            barrasProgreso (pgsEnergia, -10);

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
            barrasProgreso (pgsEnergia, -30);

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
        }
        private void mostrarEstado(){ 
            if (pgsHambre.Value > 50)
            {
                lblEstado.Text = "Estoy hambriento, Alimentame karen";
                pctFeliz.Visible = false;
                pctNormal.Visible = true;
                pctTriste.Visible = false;
                pctsuenio.Visible = false;


            }
            else if (pgsFelicidad.Value < 20)
            {
                lblEstado.Text = "Estoy triste, juega conmigo karen";
                pctFeliz.Visible = false;
                pctNormal.Visible = false;
                pctTriste.Visible = true;
                pctsuenio.Visible = false;
            }
            else if (pgsSueño.Value > 70)
            {
                lblEstado.Text = "Tengo mucho sueño";
                pctFeliz.Visible = false;
                pctNormal.Visible = false;
                pctTriste.Visible = false;
                pctsuenio.Visible = true;
            }
            else if (pgsEnergia.Value < 30)
            {
                lblEstado.Text = "Estoy cansado karen";
                pctFeliz.Visible = false;
                pctNormal.Visible = false;
                pctTriste.Visible = false;
                pctsuenio.Visible = true;
            }
            else
            {
                lblEstado.Text = "Estoy feliz karen";
                pctFeliz.Visible = true;
                pctNormal.Visible = false;
                pctTriste.Visible = false;
                pctsuenio.Visible = false;
            }
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
