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
    public partial class Ejercicio3 : Form
    {
        FormPrincipal form1;
        public Ejercicio3(FormPrincipal form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Ejercicio3_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        private void checkedOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( (FemBtn.Checked || MascBtn.Checked) && (btnCasado.Checked || btnSoltero.Checked))
            {
                resultadoSexo.Text = FemBtn.Checked ? "Femenino" : "Masculino";
                resultadoSexo.Visible = true;
                resultadoEstCiv.Text = btnCasado.Checked ? "Casado" : "Soltero";
                resultadoEstCiv.Visible = true;
            }
            else
            {
                MessageBox.Show("Deben selecionarse las opciones de sexo y estado civil", "Atencion");
            }

            int total = checkedOpciones.CheckedItems.Count;

            resultadoOficio.Text = ""; //Limpia la pantalla de oficios

            for (int i=0; i<total; i++)
            {
                var item = checkedOpciones.CheckedItems[i];
                resultadoOficio.Text += "- " + item.ToString() + "\n";
                resultadoOficio.Visible = true;
            }
           
        }

    }
}
