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
            bool nombreDisponible = false;
            foreach(var persona in listBox1.Items)
            {
                if(textBox_nombre.Text.ToUpper() == persona.ToString().ToUpper())
                {
                    MessageBox.Show("Este nombre ya fue ingresado.");
                }else
                {
                    nombreDisponible = true;
                }
            }

            if(nombreDisponible)
            {
                nombreDisponible = false;
                listBox1.Items.Add(textBox_nombre.Text);
                textBox_nombre.Text = string.Empty;
            }

        }
    }
}
