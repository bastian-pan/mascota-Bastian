using System.Timers;
using System.Windows.Forms;

namespace MascotaBastian
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timermascota;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //confi del timer o tiempo que se actualiza
            timermascota = new System.Windows.Forms.Timer();
            timermascota.Interval = 5000;
            timermascota.Tick += Timermascota_Tick;
            timermascota.Start();

            //confi del inicio de la mascota
            pgsHambre.Value = 30;
            pgsFelicidad.Value = 50;
            pgsSueño.Value = 20;
            pgsEnergia.Value = 80;
          

        }



        private void Timermascota_Tick(object sender, EventArgs e)
        {
            barrasProgreso(pgsHambre, 5);
            barrasProgreso(pgsFelicidad, -5);
            barrasProgreso(pgsSueño, 5);
            barrasProgreso(pgsEnergia, -5);

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

            mostrarEstado();
        }

        private void btnDormir_Click(object sender, EventArgs e)
        {
            barrasProgreso(pgsSueño, -50);
            barrasProgreso(pgsEnergia, 50);
            barrasProgreso(pgsHambre, 30);
            barrasProgreso(pgsFelicidad, 20);

            mostrarEstado();

        }

        

        private void btnbaniar_Click(object sender, EventArgs e)
        {
            barrasProgreso(pgsFelicidad, -30);
            barrasProgreso(pgsHambre, 10);
            barrasProgreso (pgsEnergia, -30);

            mostrarEstado();

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

        }
    }
}
