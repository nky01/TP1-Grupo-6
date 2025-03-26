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

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            //Verificamos si el nombre y el apellido no estan vacios
            if(textBoxNombre.Text.Trim() != string.Empty && textBoxApellido.Text.Trim() != string.Empty)
            {
                bool nombreExiste = false;
                bool apellidoExiste = false;
                //Revisamos todos las personas registradas en el ListBox
                foreach(string itemPersona in listBoxNombres.Items)
                {
                    string persona = itemPersona;
                    string[] nombre = persona.Split(' ');//Dividimos el nombre y el apellido

                    //Verificamos si el nombre ya esta registrado
                    if (nombre[0].ToUpper() == textBoxNombre.Text.ToUpper() && !nombreExiste)
                    {
                        nombreExiste = true;
                    }

                    //Verificamos si el apellido ya esta registrado
                    if (nombre[1].ToUpper() == textBoxApellido.Text.ToUpper() && !apellidoExiste)
                    {
                        apellidoExiste = true;
                    }
                }

                //Si el nombre y el apellido fueron registrados entonces mostramos una advertencia
                if(nombreExiste && apellidoExiste)
                {
                    MessageBox.Show(textBoxNombre.Text + " " + textBoxApellido.Text + " ya esta registrado.", "Atencion!");
                    textBoxApellido.Text = string.Empty;
                    textBoxNombre.Text = string.Empty;
                }
                else//Si el nombre completo no esta registrado entonces lo añadimos a la ListBox
                {
                    listBoxNombres.Items.Add(textBoxNombre.Text.Trim() + " " + textBoxApellido.Text.Trim());
                    textBoxApellido.Text = string.Empty;
                    textBoxNombre.Text = string.Empty;
                }
            } else//Si el campo nombre o el campo apellido estan vacios mostramos una advertencia.
            {
                MessageBox.Show("Ingrese un nombre y un apellido", "Atencion!");
                textBoxApellido.Text = string.Empty;
                textBoxNombre.Text = string.Empty;
            }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (listBoxNombres.SelectedItem != null)
            {
                listBoxNombres.Items.Remove(listBoxNombres.SelectedItem);
            }
            else
            {
                MessageBox.Show("Debe seleccionar algun nombre de la lista", "Atención!");
            }
        }
    }
}
