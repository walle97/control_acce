using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace control_acce
{
    class Conexion
    {

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=control;Integrated Security=True");
                cn.Open();
                //MessageBox.Show("Conectado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
            }
        }

        public string insertar(string num_ctrl1, string nombre1, string Carrera1, string fecha_nac1, string num_tel1, string email1)
        {
            
            string salida = "Se agrego exitosamente";
            try
            {
                cmd = new SqlCommand("Insert into alumnos(num_ctrl,nombre,Carrera,fecha_nac,num_tel,email) values('" + num_ctrl1+ "','" + nombre1 + "','" + Carrera1 + "','" + fecha_nac1 + "','" + num_tel1 + "','" + email1 + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }



        public int personaRegistrada(string num)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from alumnos where num_ctrl=" + num + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            
            return contador;
        }

        public int rev_registro(string num)
        {
            int contador = 0;
            try
            {
                DateTime hoy = DateTime.Now;
                String fechareg = hoy.ToString("MM/dd/yyyy");
                cmd = new SqlCommand("select * from registro_ent where datediff(day, fecha_reg, '"+ fechareg + "') = 0 and fecha_sal IS NULL and num_ctrl='"+ num + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        public void cargardatos(String num_ctrl1, TextBox txtnom, TextBox txtcarr)
        {
            
            try
            {
                cmd = new SqlCommand("Select * from alumnos where num_ctrl=" + num_ctrl1 + "",cn);
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    txtnom.Text = dr["nombre"].ToString();
                    txtcarr.Text = dr["Carrera"].ToString();
                    //dtpFecha.Text = dr["FechaNacimiento"].ToString();

                }
                dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: "+ex.ToString());
            }
            

        }

        public String marcar_ent(string num_ctrl1, string nombre1, string Carrera1, string fecha_reg)
        {
            
            string salida = "Se registro entrada";
            try
            {
                
                cmd = new SqlCommand("Insert into registro_ent(num_ctrl,nombre,Carrera,fecha_reg) values('" + num_ctrl1 + "','" + nombre1 + "','" + Carrera1 + "','" + fecha_reg + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public void cargardatossal(String num_ctrl1, TextBox txtnom, TextBox txtcarr, TextBox txtfechreg, TextBox txthoraent,Label idreg)
        {

            try
            {
                DateTime hoy = DateTime.Now;
                String fechareg = hoy.ToString("MM/dd/yyyy");
                cmd = new SqlCommand("select id_reg,num_ctrl,nombre,CONVERT(CHAR(10), fecha_reg,103) AS Fecha,RIGHT((fecha_reg),7) as Hora,Carrera from registro_ent where datediff(day, fecha_reg, '" + fechareg + "') = 0 and fecha_sal IS NULL and num_ctrl='" + num_ctrl1 + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //String fecha_reg2= dr["fecha_reg"].ToString();
                    
                    //fechareg = hoy.ToString("MM/dd/yyyy HH:mm");
                    //txthoraent.Text = hoy.ToShortTimeString();
                    idreg.Text = dr["id_reg"].ToString();
                    txtnom.Text = dr["nombre"].ToString();
                    txtcarr.Text = dr["Carrera"].ToString();
                    txtfechreg.Text = dr["Fecha"].ToString();
                    txthoraent.Text = dr["Hora"].ToString();
                                       

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }


        }
        public string Marcar_salida(string id, string fecha_sal1)
        {
            string salida = "Se registro salida";
            try
            {

                cmd = new SqlCommand("Update registro_ent set fecha_sal ='" + fecha_sal1 + "' where Id_reg=" + id + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo: " + ex.ToString();
            }
            return salida;
        }


        public int inise(string usuario1,string password1 )
        {
            int contador = 0;
            try
            {
               // DateTime hoy = DateTime.Now;
                //String fechareg = hoy.ToString("MM/dd/yyyy");
                cmd = new SqlCommand("select * from usuarios where usuario='" + usuario1 + "' and password='" + password1 + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        public void cargaralumnos(DataGridView dgv)
        {

            try
            {
                cmd = new SqlCommand("select * from alumnos ", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    while (dr.Read())
                    {
                        String idalu = dr["id"].ToString();
                        String numctrl3 = dr["num_ctrl"].ToString();
                        String Nombre2 = dr["nombre"].ToString();
                        String carrera2 = dr["Carrera"].ToString();
                        String fechanac = dr["fecha_nac"].ToString();
                        String numtel= dr["num_tel"].ToString();
                        String email2 = dr["email"].ToString();                        
                        dgv.Rows.Add(idalu, numctrl3, Nombre2, carrera2, fechanac, numtel, email2);
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }


        }

        public void cargarregistro(DataGridView dgv)
        {

            try
            {
                
                cmd = new SqlCommand("select id_reg,num_ctrl,nombre,CONVERT(CHAR(10), fecha_reg,103) AS Fecha,RIGHT((fecha_reg),7) as Hora,Carrera,CONVERT(CHAR(10), fecha_sal ,103) AS Fechasal,RIGHT((fecha_sal ),7) as Horasal from registro_ent ", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    
                    while (dr.Read()) { 
                    String idreg2  = dr["id_reg"].ToString();
                    String numctrl2 = dr["num_ctrl"].ToString();
                    String Nombre2 = dr["nombre"].ToString();
                    String carrera2 = dr["Carrera"].ToString();
                    String fecha2 = dr["Fecha"].ToString();
                    String hora2= dr["Hora"].ToString();
                    String fecha3 = dr["Fechasal"].ToString();
                    String hora3 = dr["Horasal"].ToString();
                   dgv.Rows.Add(idreg2, numctrl2, Nombre2, carrera2, fecha2, hora2,hora3 );
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }


        }

    }
}
