﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class UserModel
    {
        private string connStr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Public\my_web_site\MvcApplication\MvcApplication1\App_Data\MainDb1.mdf;Integrated Security=True";
        public List<string> GetUserEmails()
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
            command.CommandText = "SELECT COUNT(*) FROM [USER]";
            
            int count = Convert.ToInt32( command.ExecuteScalar() );
             return count;
        }

        public int GetUserIdByEmail(string email)
        {
            SqlConnection myConn = new SqlConnection(connStr);
            myConn.Open();

            SqlCommand command = myConn.CreateCommand();
            command.CommandText = "SELECT ID FROM USER where email ='"+email+"'";

            int id = Convert.ToInt32(command.ExecuteScalar());
            return id;
        }
 
        


}}