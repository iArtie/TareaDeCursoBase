using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Infraestructure.Repository;

using SamArt2M1.Forms;

namespace SamArt2M1
{
    
    public partial class Form1 : Form
    {
        Conexion con;
        DataImage IObj = new DataImage();
        public Form1()
        {
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 02;
            barraxd.Value = 0;
            barraxd.Minimum = 0;
            barraxd.Maximum = 100;
            timer1.Start();
        }

        //public void InsertarImagenBytes(char Idc, String username, String contra, String tel, String dir)
        //{

        //    Console.WriteLine(contra);

        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();

        //        SqlParameter[] param = new SqlParameter[5];
        //        param[0] = new SqlParameter("@IDC", SqlDbType.Char);
        //        param[0].Value = Idc;
        //        param[1] = new SqlParameter("@username", SqlDbType.VarChar);
        //        param[1].Value = username;
        //        param[2] = new SqlParameter("@contra", SqlDbType.VarBinary);
        //        param[2].Value = contra;
        //        param[3] = new SqlParameter("@direccion", SqlDbType.VarChar);
        //        param[3].Value = dir;
        //        param[4] = new SqlParameter("@telefono", SqlDbType.Char);
        //        param[4].Value = tel;

        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "CuentaCliente";
        //        cmd.Connection = con.connect;
        //        cmd.Parameters.AddRange(param);

        //        DataSet ds = new DataSet();
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);

        //        da.Fill(ds);
        //    }
        //    catch (Exception)
        //    {

        //        MessageBox.Show("Error en la insercion");
        //        return;
        //    }


        //}

        public void timerProgress() 
        {
        
        
        
        
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            FrmUser UsuarioFrm = new FrmUser();
            FrmAdmin AdminFrm = new FrmAdmin();
            con = new Conexion(textBox1.Text, textBox2.Text);
           
            if (this.con.connect.State == ConnectionState.Open)
            {
            
                if (textBox1.Text == "Administrador" || textBox2.Text == "123456")
                {
                    AdminFrm.Show();
                    Hide();
                }
                if (textBox1.Text != "Administrador" || textBox2.Text != "123456")
                {

                    string consulta = "Select * from Nueva_CuentaCliente where username='" + textBox1.Text + " 'and npassword=   '" + textBox2.Text + " ' ";
                    SqlCommand command = new SqlCommand(consulta, con.connect);
                    SqlDataReader reader;

                    reader = command.ExecuteReader();

                    string consultaImg = "Select perfil from Nueva_CuentaCliente where username='" + textBox1.Text + "'";
                    if (reader.HasRows == true)
                    {
                        MessageBox.Show("Bienvenido! " + textBox1.Text);
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrecta");
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                    SqlCommand command2 = new SqlCommand(consultaImg, con.connect);
                    SqlDataAdapter adp = new SqlDataAdapter(command2);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "img");
                    try
                    {
                        byte[] datos = new byte[0];
                        DataRow dr = ds.Tables["img"].Rows[0];

                        datos = (byte[])dr["perfil"];
                        MemoryStream ms = new MemoryStream(datos);
                        UsuarioFrm.cuiProfilePicture1.Image = Image.FromStream(ms);
                    }
                    catch (Exception)
                    {


                    }



                    UsuarioFrm.lblUser.Text = textBox1.Text;

                    con.connect.Close();
                    if (textBox1.Text != String.Empty && textBox2.Text != String.Empty)
                    {
                        UsuarioFrm.Show();
                        Hide();
                    }
                }
            }
            else 
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
      
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int cont = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity<1)
            {
              
                this.Opacity += 0.1;
              
            }
            barraxd.Value += 1;
            barraxd.Text = barraxd.Value.ToString();
            if (barraxd.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.5;
            if (this.Opacity==0)
            {
                timer2.Stop();
                this.Close(); 
            }
        }

        private void barraxd_Click(object sender, EventArgs e)
        {

        }
    }
}
