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
                cmd = new SqlCommand("Select * from registro_ent where num_ctrl='" + num + "' and fecha_reg= '"+ fechareg +"' and fecha_sal IS NULL", cn);
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
            
            string salida = "Se agrego exitosamente";
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

        public string Marcar_salida(int id, string nombre, string apellidos, string fecha_ent1)
        {
            string salida = "Se actualizaron los datos";
            try
            {

                cmd = new SqlCommand("Update Persona set Nombre ='" + nombre + "' ,Apellidos='" + apellidos + "', FechaNacimiento='" + fecha_ent1 + "' where Id=" + id + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo: " + ex.ToString();
            }
            return salida;
        }


    }
}
