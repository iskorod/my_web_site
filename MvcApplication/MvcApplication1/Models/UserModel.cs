using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class UserModel
    {
        private string connStr = "";
        public List<string> GetUserNames()
        {

            SqlConnection myConn = new SqlConnection(connStr);
            myConn.Open();

            SqlCommand command = myConn.CreateCommand();
            command.CommandText = "SELECT email from User";
               
            
           SqlDataReader reader = command.ExecuteReader();
            List<string> emails = new List<string>();
            while (reader.Read())
            {

                emails.Add(reader["email"].ToString());

            }

            return emails;
          
        }
        public int GetUserCount()
        {
            SqlConnection myConn = new SqlConnection(connStr);
            myConn.Open();

            SqlCommand command = myConn.CreateCommand();
            command.CommandText = "SELECT COUNT(*) FROM USER";
            
            int count = Convert.ToInt32( command.ExecuteScalar() );
             return count;
        }
    
    
    
    }



}