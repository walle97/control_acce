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
    public partial class registros : Form
    {
        Conexion c = new Conexion();
        public registros()
        {
            InitializeComponent();
        }

        private void Registros_Load(object sender, EventArgs e)
        {
            /*DgvPersonas.Columns[0].Name = "id";
            DgvPersonas.Columns[1].Name = "Track";
            DgvPersonas.Columns[2].Name = "Title";
            DgvPersonas.Columns[3].Name = "Artist";
            DgvPersonas.Columns[4].Name = "Album";
            DgvPersonas.Columns[4].Name = "Album";*/
            c.cargarregistro(DgvPersonas);
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            reporte2 rep = new reporte2();

            for (int i = 0; i < DgvPersonas.Rows.Count - 1; i++)
            {
                datosreg dat = new datosreg();
                dat.numeroctr = (string)this.DgvPersonas.Rows[i].Cells[1].Value;
                dat.nombre = (string)this.DgvPersonas.Rows[i].Cells[2].Value;
                dat.carrerra = (string)this.DgvPersonas.Rows[i].Cells[3].Value;
                dat.fechareg = (string)this.DgvPersonas.Rows[i].Cells[4].Value;
                dat.horaent = (string)this.DgvPersonas.Rows[i].Cells[5].Value;
                dat.horasal = (string)this.DgvPersonas.Rows[i].Cells[6].Value;
                rep.datosregs.Add(dat);
            }
            rep.ShowDialog();
        }
    }
}
