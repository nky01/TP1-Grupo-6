using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_6
{
    public partial class Form2 : Form
    {
        FormPrincipal form1;
        public Form2(FormPrincipal form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

            //string nombre = textBox_nombre.Text.Trim().ToUpper(); // lo que hago aca es igual el texto escrito, con un trim por lo que dijo nicky, y luego lo hago mayusculas
            //string auxNombre = textBox_nombre.Text.Trim(); // lo que hago aca es crear una auxilar sin modificar nada

            //if (listBox1.Items.Count == 0) // me fijo si lista esta vacia
            //{
            //    if (string.IsNullOrEmpty(nombre)) // verifico con un string si esta vacio ("")
            //    {
            //        MessageBox.Show("Debe ingresar un nombre.", "Atencion");
            //    }
            //    else
            //    {
            //        listBox1.Items.Add(auxNombre); // agrego uno a la lista, en este caso sin descriminar
            //        textBox_nombre.Text = String.Empty;
            //    }
            //}
            //else // condicion para cuando ya hay por lo menos un nombre cargado
            //{
            //    bool sonIguales = false; // bandera

            //    for (int i = 0; i < listBox1.Items.Count; i++) // lo que hago aca  es recorrer la lista en busqueda de algun item igual
            //    {
            //        if (nombre == listBox1.Items[i].ToString().ToUpper()) // agarro el item y lo comvierto a string y lo hago mayus
            //        {
            //            sonIguales = true;
            //            break; // si son iguales corto ciclo
            //        }

            //        sonIguales = false;
            //    }

            //    if (sonIguales) // pregunto
            //    {
            //        MessageBox.Show("No se permite ingresar dos nombres iguales", "Atencion");
            //    }
            //    else
            //    {
            //        listBox1.Items.Add(auxNombre); // agrego el auxnombre
            //        textBox_nombre.Text = String.Empty;
            //    }

            //}

            if (textBox_nombre.Text.Trim() != "")
            {
                bool existe = false;

                foreach (string item in listBox1.Items)
                {
                    if (textBox_nombre.Text.ToUpper().Trim() == item.ToUpper())
                    {
                        existe = true;
                        break;
                    }
 
                }
                foreach (string item2 in listBox2.Items)
                {
                    if (textBox_nombre.Text.ToUpper().Trim() == item2.ToUpper())
                    {
                        existe = true;
                        break;
                    }
                }
                if (existe)
                {
                    MessageBox.Show("Este nombre ya fue ingresado.", "Atención");
                    textBox_nombre.Text = String.Empty;
                }
                else
                {
                    listBox1.Items.Add(textBox_nombre.Text.Trim());
                    textBox_nombre.Text = String.Empty;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre", "Atención");
            }

        }
        private void buttonPassOne_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null) //Verifico que haya un item seleccionado
            {
                string aux = listBox1.SelectedItem.ToString(); //Auxiliar que contiene el item a ser borrado. Necesita que el SelectedItem sea pasado a string.
                listBox1.Items.Remove(listBox1.SelectedItem); //Saca el item original del listbox1
                listBox2.Items.Add(aux); //Agrega el auxiliar a listbox2
            }
            else
            {
                MessageBox.Show("Seleccione el nombre a pasar");
            }
        }

        private void buttonPassAll_Click(object sender, EventArgs e)
        {
            foreach (string persona in listBox1.Items)
            {
                string aux = persona;
                listBox2.Items.Add(aux); //Agrega el auxiliar a listbox2
            }
            listBox1.Items.Clear();//El foreach necesita que el numero de la lista sea consistente, por lo que la orden de limpiar listbox 1 debe estar afuera del loop.
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e) //esto es un evento, lo que hace es manejar el evento del cerrado, es decir cuando se clickee la cruz del form, este cerrara toda la aplicacion y no solamente esa ventana, evitando 
        {
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
