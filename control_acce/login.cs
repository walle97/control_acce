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
    public partial class login : Form
    {
        Conexion c = new Conexion();
        public login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (c.inise(txtuser.Text, txtpass.Text) == 0)
            {
                //DateTime fecha = datenac.Value;
                //String fecha1 = fecha.ToString("MM/dd/yyyy");
                //MessageBox.Show(c.insertar(txtnum.Text, txtnom.Text, txtcarr.Text, fecha1, txtnumtel.Text, txtemail.Text));
                //txtnum.Text = "";
                //txtnom.Text = "";
                //frmprinlog mv = new frmprinlog();
                //mv.Show();

                
                MessageBox.Show("Usuario o password incorrecto");
                txtuser.Text = "";
                txtpass.Text = "";


            }
            else
            {

                frmprincipal pri = new frmprincipal();
                pri.activarbtn();
                

                //this.Close();         




            }
        }
    }
}
