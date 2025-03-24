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
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonPassOne_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

            //if(textBox_nombre.Text.Trim() != "") // la forma es adecuada si se trata de añadir items sin discriminar pero tiene que haber otra condicion voy a comentar lo tuyo y lo mio lo dejare para que veas que paso
            //{
            //    listBox1.Items.Add(textBox_nombre.Text);
            //    textBox_nombre.Text = String.Empty;
            //}
            //else
            //{
            //    MessageBox.Show("Debe ingresar un nombre.", "Atención");
            //}
            
            string nombre = textBox_nombre.Text.Trim().ToUpper(); // lo que hago aca es igual el texto escrito, con un trim por lo que dijo nicky, y luego lo hago mayusculas
            string auxNombre = textBox_nombre.Text; // lo que hago aca es crear una auxilar sin modificar nada
            if(listBox1.Items.Count == 0) // me fijo si lista esta vacia
            {
                if (string.IsNullOrEmpty(nombre)) // verifico con un string si esta vacio ("")
                {
                    MessageBox.Show("Debe ingresar un nombre.", "Atencion");
                }
                else
                {
                    listBox1.Items.Add(auxNombre); // agrego uno a la lista, en este caso sin descriminar
                }
            }
            else // condicion para cuando ya hay por lo menos un nombre cargado
            {
                bool sonIguales = false; // bandera

                for (int i = 0; i < listBox1.Items.Count; i++) // lo que hago aca  es recorrer la lista en busqueda de algun item igual
                {
                    if (nombre == listBox1.Items[i].ToString().ToUpper()) // agarro el item y lo comvierto a string y lo hago mayus
                    {
                        sonIguales = true;
                        break; // si son iguales corto ciclo
                    }

                    sonIguales = false;
                }

                if (sonIguales) // pregunto
                {
                    MessageBox.Show("No se permite ingresar dos nombres iguales", "Atencion");
                }
                else
                {
                    listBox1.Items.Add(auxNombre); // agrego el auxnombre
                }

            }

            


                //MessageBox.Show(listBox1.Items.Count.ToString());
                /*for (int i = 0;i <= 10;i++)
                {
                    if (textBox_nombre.Text.ToUpper() == listBox1.Items[i].ToString().ToUpper())
                    {
                        MessageBox.Show("Este nombre ya fue ingresado");
                        i = 100;
                    }
                    else
                    {
                        listBox1.Items.Add(textBox_nombre.Text);
                        i = 100;
                    }
                }*/

            //----------------------------------------------

            //    bool nombreDisponible = false;
            //foreach(var persona in listBox1.Items)
            //{
            //    if(textBox_nombre.Text.ToUpper() == persona.ToString().ToUpper())
            //    {
            //        MessageBox.Show("Este nombre ya fue ingresado.");
            //    }else
            //    {
            //        nombreDisponible = true;
            //    }
            //}

            //if(nombreDisponible)
            //{
            //    nombreDisponible = false;
            //    listBox1.Items.Add(textBox_nombre.Text);
            //    textBox_nombre.Text = string.Empty;
            //}

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e) //esto es un evento, lo que hace es manejar el evento del cerrado, es decir cuando se clickee la cruz del form, este cerrara toda la aplicacion y no solamente esa ventana, evitando 
        {
            Application.Exit();
        } 
    }
}
