﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_acce
{
    public partial class alumnos : Form
    {
        Conexion c = new Conexion();
        public alumnos()
        {
            InitializeComponent();
        }
        

        private void Alumnos_Load(object sender, EventArgs e)
        {
            c.cargaralumnos(DgvPersonas);
        }
    }
}
