using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Infraestructure.Repository
{
    public abstract class WebRepository
    {
        private readonly string StConection;
        public WebRepository() 
        {
            StConection = "server = localhost; database=BankAccountSystem; Integrated Security= True";
        }

        protected SqlConnection GetConection() 
        {
            return new SqlConnection(StConection);
        }
    }
}
