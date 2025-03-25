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
    public partial class Ejercicio2: Form
    {
        FormPrincipal form1; //Creo una instancia local de un formulario, que tomara las mismas caracteristicas que el form1 principal.
        public Ejercicio2(FormPrincipal form1) //Cambio el constructor para que reciba por parametro al form principal.
        {
            InitializeComponent();
            this.form1 = form1; //El FormPrincipal vacio que contiene Ejercicio2 es igualado a form1 por parametro.

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void labelApellido_Click(object sender, EventArgs e)
        {

        }

        private void Ejercicio2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }
    }
}
