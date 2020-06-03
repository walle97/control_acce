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
    public partial class agregar_alum : Form
    {
        Conexion c = new Conexion();
        public agregar_alum()
        {
            InitializeComponent();
        }
        private void Agregar_alum_Load(object sender, EventArgs e)
        {
            //Conexion c = new Conexion();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            
            if (c.personaRegistrada(txtnum.Text) == 0)
            {
                DateTime fecha = datenac.Value;
                String fecha1 = fecha.ToString("MM/dd/yyyy");
                MessageBox.Show(c.insertar(txtnum.Text, txtnom.Text, txtcarr.Text, fecha1, txtnumtel.Text,txtemail.Text));
                txtnum.Text = "";
                txtnom.Text = "";
                txtcarr.Text = "";
                txtnumtel.Text = "";
                txtemail.Text = "";
                

            }
            else
            {
                MessageBox.Show("Imposible de regitrar, El registro ya existe");
            }
        }

       
    }
}
