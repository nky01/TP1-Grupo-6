﻿using System;
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
    }
}
