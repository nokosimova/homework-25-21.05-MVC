using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using Dapper;

namespace FirstVebApp.Models
{
    public class ExportData
    {
        public string ConnectionString = "Data source=KosimovaNodira; Initial catalog = NewDB; Integrated Security=True;";
        public List<Person> ReadFromPerson()
        {
            try
            {
                using (IDbConnection con = new SqlConnection(ConnectionString))
                {
                    return con.Query<Person>($"select * from {typeof(Person).Name?.ToUpper()}").ToList();
                }
            }
            catch (SqlException x)
            {
                Console.WriteLine($"Error:{x.Message}");
                return null;
            }
        }
    }
}
