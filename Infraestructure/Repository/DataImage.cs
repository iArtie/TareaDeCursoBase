using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Net.Mime.MediaTypeNames;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Infraestructure.Repository
{
    
    public class DataImage : ImageMasterRepository
    {
        private int id;
        private string username;
        private string email;
        private string npassword;
        private byte[] perfil;
        private string names;
        private string lastnames;
        private DateTime FechaDeNacimiento;
        private int Phone;
        private decimal montoin;

        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string nPassword
        {
            get
            {
                return npassword;
            }

            set
            {
                npassword = value;
            }
        }

        public byte[] Perfil
        {
            get
            {
                return perfil;
            }

            set
            {
                perfil = value;
            }
        }

        public string Names
        {
            get
            {
                return names;
            }

            set
            {
                names = value;
            }
        }

        public string Lastnames
        {
            get
            {
                return lastnames;
            }

            set
            {
                lastnames = value;
            }
        }

        public DateTime FechaDeNacimiento1
        {
            get
            {
                return FechaDeNacimiento;
            }

            set
            {
                FechaDeNacimiento = value;
            }
        }

        public int Phone1
        {
            get
            {
                return Phone;
            }

            set
            {
                Phone = value;
            }
        }

        public decimal Montoin
        {
            get
            {
                return montoin;
            }

            set
            {
                montoin = value;
            }
        }

        //public int ID { get { return id; } set { id = value; } }
        private DataSet ds;
        public DataImage() 
        {
            id = ID;
            Username = username;
            email = Email;
            npassword = nPassword;
            Perfil = perfil;
            names = Names;
            lastnames = Lastnames;
            FechaDeNacimiento = FechaDeNacimiento1;
            Phone = Phone1;
            montoin = Montoin;

        
        }
        //     //Creamos nuestra segunda variabla la cual contendra nuestra segunda consulta sql de insercion
        //     string sqlQuery2 = @"insert into boleta values"
        //         //creamos un segundo objeto sqlcommand
        //     SqlCommand cmd2 = new SqlCommand(sqlQuery2, conn); 
        //foreach (DataGridViewRow row2 in grillaservicio.Rows)
        //{
        ////Sigues la misma logica de arriba
        //}
        ////
        ////si todo los registros fueron insertados correctamente confirmacion las inserciones por medio del 
        ////useo de scope.Complete(), al ejcutarse este nuestra base de datos sera afectada con los datos enviados
        //scope.Complete();


        //Lo de arriba es otro formato, estaba intentando pero si queres intentar, descomentalo y agregalo,
        //puede ser el formato el error

        
            //creamos nuestro objeto Commad a la cual le pasaremos la consulta y el valor de conexion
   //     SqlCommand cmd = new SqlCommand(sqlQuery, conn);      
			//foreach (DataGridViewRow row in grillarepuesto.Rows)
			//{
			//	//Limpiamos nuestra coleccion de parametros, esto solo porque ejecutaremos el comando dentro de un ciclo
			//	//la primer vuelta nuestra coleccion de parametros estaran vacios pero no para las subsecuentes
			//	cmd.Parameters.Clear();
			//	//Enviamos nuestroa valores a la coleccion de parametros
			//	cmd.Parameter.AddWithValue("@nboleta",txtnboleta.Text);
			//	cmd.Parameter.AddWithValue("@fecha",dateTimePicker1.Value);//dateTimePicker1.Text es mejor tomar el Value del DateTimePicker
			//	cmd.Parameter.AddWithValue("@categoria",cbocat.Text);
			//	//resto de asignacion de parametros
			//	//ejecutamos el comando
			//	//recuerda que hasta este momento la base de datos aun no esta afectada puesto que estamos dentro
			//	//de un TransactionScope()
			//	cmd.ExecuteNonQuery();
        private void SaveImg()
         {
            //        string sqlQuery = @"INSERT INTO SaveImg(nuser,email,npassword,nimage)
            //VALUES(@nboleta, @nuser,@email,@npassword,@nimage)";
            string TransactSql = "insert into Nueva_CuentaCliente values(@nuser, @email, @npassword, @nimage,@names,@lastnames,@FechaDeNacimiento,@Phone,@montoin)";
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@nuser", username.ToString()));
            parameters.Add(new SqlParameter("@email", email.ToString()));
            parameters.Add(new SqlParameter("@npassword", npassword.ToString()));
            parameters.Add(new SqlParameter("@nimage", perfil));
            parameters.Add(new SqlParameter("@names", names.ToString()));
            parameters.Add(new SqlParameter("@lastnames", lastnames.ToString()));
            parameters.Add(new SqlParameter("@FechaDeNacimiento", FechaDeNacimiento));
            parameters.Add(new SqlParameter("@Phone", Phone));
            parameters.Add(new SqlParameter("@montoin", montoin));
            ExecuteNonQuery(TransactSql);
        }

        public DataTable ShowUsers() 
        {
            string TransactSql = "select * from Nueva_CuentaCliente";
            return ExecuteReader(TransactSql);
        }
        public DataTable SearchUsers(string user) 
        {
            var conecction = GetConection();
            conecction.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select from Nueva_CuentaCliente where username like '%{0}%'", user), conecction);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conecction.Close();
            return ds.Tables["tabla"];
}
public Boolean DeleteUsers(int id)
{
           
            var conecction = GetConection();
            conecction.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from Nueva_CuentaCliente where ID={0}", id), conecction);
            int Filas = cmd.ExecuteNonQuery();
            conecction.Close();
            if (Filas > 0) 
            {
                return true;
            }else 
            {
                return false;
            }
        }
        public string SaveChanges() 
        {
            string Message = null;

            try
            {
                SaveImg();
                Message = "User added!";
            }
            catch (Exception e)
            {

                Message = e.ToString();
            }
            return Message;
    
        }
    }
}
