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
                listBox2.Items.Add(listBox1.SelectedItem.ToString()); //Agrega el item a la listBox2
                listBox1.Items.Remove(listBox1.SelectedItem); //Saca el item original del listbox1
            }
            else
            {
                MessageBox.Show("Seleccione el nombre a pasar", "Atención");
            }
        }

        private void buttonPassAll_Click(object sender, EventArgs e)
        {
            foreach (string persona in listBox1.Items)
            {
                listBox2.Items.Add(persona); //Agrega persona a listBox2
            }
            listBox1.Items.Clear();//El foreach necesita que el numero de la lista sea consistente, por lo que la orden de limpiar listbox 1 debe estar afuera del loop.
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e) //esto es un evento, lo que hace es manejar el evento del cerrado, es decir cuando se clickee la cruz del form, este cerrara toda la aplicacion y no solamente esa ventana, evitando 
        {
            form1.Show();
        }
    }
}
