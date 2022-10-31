using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Infraestructure.Repository
{
    public abstract class ImageMasterRepository : WebRepository
    {

        protected List<SqlParameter> parameters;

        protected void ExecuteNonQuery(string transactSql)
        {
            using (var conection = GetConection())
            {
                conection.Open();
               
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conection;
                    comando.CommandText = transactSql;
                    comando.CommandType = CommandType.Text;
                    foreach (SqlParameter item in parameters)
                    {
                        comando.Parameters.Add(item);
                    }
                    comando.ExecuteNonQuery();

                    parameters.Clear();
                }

            }
        }
        protected void ExecuteNonQuerySP(string transactSql)
        {
            using (var conection = GetConection())
            {
                conection.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conection;
                    comando.CommandText = transactSql;
                    comando.CommandType = CommandType.StoredProcedure;
                    foreach (SqlParameter item in parameters)
                    {
                        comando.Parameters.Add(item);
                    }
                    comando.ExecuteNonQuery();

                    parameters.Clear();
                }

            }
        }

        protected DataTable ExecuteReader(string transactSql)
        {
            using (var conection = GetConection())
            {
                conection.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conection;
                    comando.CommandText = transactSql;
                    comando.CommandType = CommandType.Text;
                    SqlDataReader lector = comando.ExecuteReader();

                    using (var tabla = new DataTable()) 
                    {
                        tabla.Load(lector);
                        lector.Dispose();
                        return tabla;
                    }
                    //comando.ExecuteNonQuery();

                    //parameters.Clear();
                }

            }
        }
    }
}
