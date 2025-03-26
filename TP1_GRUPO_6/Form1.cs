using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_6
{
    public partial class FormPrincipal: Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Ejercicio1_Click(object sender, EventArgs e)
        {
            Form2 formulario2 = new Form2(this);
            formulario2.Show();
            this.Hide();
        }

        private void Ejercicio2_Click(object sender, EventArgs e)
        {
            Ejercicio2 ejercicio2 = new Ejercicio2(this);
            ejercicio2.Show();
            this.Hide();
        }

        private void Ejercicio3_Click(object sender, EventArgs e)
        {
            Ejercicio3 ejercicio3 = new Ejercicio3(this);
            ejercicio3.Show();
            this.Hide();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
