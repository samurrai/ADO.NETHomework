using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADOHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ШадикьянР\source\repos\ADOHomework\ADOHomework\DB.mdf;Integrated Security=True";
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = "create table [Group](Id int primary key, Name nvarchar(100) not null)";
                var transaction = connection.BeginTransaction();
                command.Transaction = transaction;
                transaction.Commit();
                command.ExecuteReader();
            }
        }
    }
}
