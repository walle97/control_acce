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
    public partial class control_acce : Form
    {
        Conexion c = new Conexion();
        public control_acce()
        {
            InitializeComponent();
        }

        private void Txtnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {

                if (c.rev_registro(txtnum.Text) == 0)
                {
                    // DateTime fecha = datenac.Value;
                    //String fecha1 = fecha.ToString("dd/MM/yyyy");
                    /* MessageBox.Show(c.insertar(txtnum.Text, txtnom.Text, txtcarr.Text, fecha1, txtnumtel.Text, txtemail.Text));
                     txtnum.Text = "";
                     txtnom.Text = "";
                     txtcarr.Text = "";*/

                    MessageBox.Show("insertar registro de entrada");

                }
                else
                {
                    MessageBox.Show("Imposible de regitrar, El registro ya existe");
                }
            }

            
        }
    }
}
