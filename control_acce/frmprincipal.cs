﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_acce
{
    
    public partial class frmprincipal : Form
    {
        Conexion c = new Conexion();
        public frmprincipal()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            txtpass.PasswordChar = '*';



        }

        public void activarbtn()
        {
            btnreg.Visible = true;
            btnalum.Visible = true;
            //btnrepo.Visible = true;
            btncerrarse.Visible = true;
            //btnAdminlogin.Visible = false;
            txtuser.Visible = false;
            txtpass.Visible = false;
            lbluser.Visible = false;
            lblpass.Visible = false;
            btnini.Visible = false;
            label6.Visible = false;




        }

        public void desbtn()
        {
            btnreg.Visible = false;
            btnalum.Visible = false;
            //btnrepo.Visible = false;
            btncerrarse.Visible = false;
            //btnAdminlogin.Visible = true;
            txtuser.Visible = true;
            txtpass.Visible = true;
            lbluser.Visible = true;
            lblpass.Visible = true;
            btnini.Visible = true;
            label6.Visible = true;
        }

        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        

        
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        int lx, ly;
        int sw, sh;
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void PanelBarraTitulo_Move(object sender, EventArgs e)
        {
            

        }

        private void PanelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void BtnCtrlAcc_Click(object sender, EventArgs e)
        {
            //this.Close();
            AbrirFormulario<control_acce>();  
            btnCtrlAcc.BackColor = Color.FromArgb(12, 61, 92);
            btnAgregarAlu.BackColor = Color.FromArgb(4, 41, 68);
            btnAdminlogin.BackColor = Color.FromArgb(4, 41, 68);
            btnalum.BackColor = Color.FromArgb(4, 41, 68);
            btnreg.BackColor = Color.FromArgb(4, 41, 68);

        }

        private void BtnAgregarAlu_Click(object sender, EventArgs e)
        {
            //this.Close();
            AbrirFormulario<agregar_alum>();
            btnCtrlAcc.BackColor = Color.FromArgb(4, 41, 68);
            btnAgregarAlu.BackColor = Color.FromArgb(12, 61, 92);
            btnAdminlogin.BackColor = Color.FromArgb(4, 41, 68);
            btnalum.BackColor = Color.FromArgb(4, 41, 68);
            btnreg.BackColor = Color.FromArgb(4, 41, 68);
        }

        private void BtnAdminlogin_Click(object sender, EventArgs e)
        {
            //this.Close();
            AbrirFormulario<login>();
            btnCtrlAcc.BackColor = Color.FromArgb(4, 41, 68);
            btnAgregarAlu.BackColor = Color.FromArgb(4, 41, 68);
            btnAdminlogin.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Btncerrarse_Click(object sender, EventArgs e)
        {

            desbtn();
            AbrirFormulario<control_acce>();
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
                activarbtn();
                txtuser.Text = "";
                txtpass.Text = "";

                //this.Close();         




            }
        }

        private void Txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lblpass_Click(object sender, EventArgs e)
        {

        }

        private void Txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbluser_Click(object sender, EventArgs e)
        {

        }

        private void Btnreg_Click(object sender, EventArgs e)
        {
            AbrirFormulario<registros>();
            btnCtrlAcc.BackColor = Color.FromArgb(4, 41, 68);
            btnAgregarAlu.BackColor = Color.FromArgb(4, 41, 68);
            btnAdminlogin.BackColor = Color.FromArgb(4, 41, 68);
            btnalum.BackColor = Color.FromArgb(4, 41, 68);
            btnreg.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void Btnalum_Click(object sender, EventArgs e)
        {
            AbrirFormulario<alumnos>();
            btnCtrlAcc.BackColor = Color.FromArgb(4, 41, 68);
            btnAgregarAlu.BackColor = Color.FromArgb(4, 41, 68);
            btnAdminlogin.BackColor = Color.FromArgb(4, 41, 68);
            btnalum.BackColor = Color.FromArgb(12, 61, 92);
            btnreg.BackColor = Color.FromArgb(4, 41, 68);
        }

        private void Btnrepo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<reportes>();
            btnCtrlAcc.BackColor = Color.FromArgb(4, 41, 68);
            btnAgregarAlu.BackColor = Color.FromArgb(12, 61, 92);
            btnAdminlogin.BackColor = Color.FromArgb(4, 41, 68);
        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //abrir fomulario
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
    }
}
