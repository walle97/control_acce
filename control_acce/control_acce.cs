using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace control_acce
{
    public partial class control_acce : Form
    {
        Conexion c = new Conexion();
        String fechareg;
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
                    c.cargardatos(txtnum.Text, txtnom, txtcarr);
                    DateTime hoy = DateTime.Now;
                    txtfechreg.Text = hoy.ToShortDateString();
                    fechareg = hoy.ToString("MM/dd/yyyy HH:mm");
                    txthoraent.Text = hoy.ToShortTimeString();
                    MessageBox.Show(c.marcar_ent(txtnum.Text, txtnom.Text, txtcarr.Text, fechareg));
                    //MessageBox.Show("insertar registro de entrada");
                    //Thread.Sleep(8000);
                    txtnum.Text = "";
                    txtnom.Text = "";
                    txtcarr.Text = "";
                    txtfechreg.Text = "";
                    txthoraent.Text = "";
                    txthorasal.Text = "";
                }
                else
                {
                    
                    c.cargardatossal(txtnum.Text, txtnom, txtcarr, txtfechreg, txthoraent);
                    DateTime hoy = DateTime.Now;
                    //txtfechreg.Text = hoy.ToShortDateString();
                    fechareg = hoy.ToString("MM/dd/yyyy HH:mm");
                    txthorasal.Text = hoy.ToShortTimeString();
                    MessageBox.Show("marcar salida");

                    txtnum.Text = "";
                    txtnom.Text = "";
                    txtcarr.Text = "";
                    txtfechreg.Text = "";
                    txthoraent.Text = "";
                    txthorasal.Text = "";
                }
            }

            
        }
    }
}
