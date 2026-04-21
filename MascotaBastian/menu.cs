using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MascotaBastian
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGato_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(this);
            this.Hide();
        }

        private void btnRaton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(this);
            this.Hide();
        }

        private void btnPerro_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show(this);
            this.Hide();
        }
    }
}
