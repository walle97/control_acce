using System;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            report rep = new report();

            for (int i = 0; i < DgvPersonas.Rows.Count - 1; i++)
            {
                datosalu dat = new datosalu();
                dat.numeroctr = (string)this.DgvPersonas.Rows[i].Cells[1].Value;
                dat.nombre = (string)this.DgvPersonas.Rows[i].Cells[2].Value;
                dat.carrerra = (string)this.DgvPersonas.Rows[i].Cells[3].Value;
                dat.fechanac = (string)this.DgvPersonas.Rows[i].Cells[4].Value;
                dat.numtel = (string)this.DgvPersonas.Rows[i].Cells[5].Value;
                dat.email = (string)this.DgvPersonas.Rows[i].Cells[6].Value;
                rep.datosalus.Add(dat);
            }
            rep.ShowDialog();
        }
    }
}
