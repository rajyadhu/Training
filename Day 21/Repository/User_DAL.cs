using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Sign_up_form.Models;



namespace Sign_up_form.DAL
{
    public class User_DAL
    {
        string connection_string = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

        //Get all users
        public List<User> Get_all_users()
        {
            List<User> usersList = new List<User>();

            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "get_all_users";
                SqlDataAdapter sqlDA = new SqlDataAdapter(command);
                DataTable dtUsers = new DataTable();

                connection.Open();
                sqlDA.Fill(dtUsers);
                connection.Close();

                foreach (DataRow dr in dtUsers.Rows)
                {
                    usersList.Add(new User
                    {
                        FirstName = dr["FirstName"].ToString(),
                        LastName = dr["LastName"].ToString(),
                        Username = dr["Username"].ToString(),
                        Place = dr["Place"].ToString(),
                        PhoneNo = dr["PhoneNo"].ToString()
                    });
                }
            }
            return usersList;
        }

        public void AddUser(User newUser)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlCommand command = new SqlCommand("AddUser", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@FirstName", newUser.FirstName);
                command.Parameters.AddWithValue("@LastName", newUser.LastName);
                command.Parameters.AddWithValue("@Username", newUser.Username);
                command.Parameters.AddWithValue("@Place", newUser.Place);
                command.Parameters.AddWithValue("@PhoneNo", newUser.PhoneNo);
                command.Parameters.AddWithValue("@Password", newUser.Password);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void EditUser(User updatedUser)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlCommand command = new SqlCommand("EditUser", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@FirstName", updatedUser.FirstName);
                command.Parameters.AddWithValue("@LastName", updatedUser.LastName);
                command.Parameters.AddWithValue("@Username", updatedUser.Username);
                command.Parameters.AddWithValue("@Place", updatedUser.Place);
                command.Parameters.AddWithValue("@PhoneNo", updatedUser.PhoneNo);
                command.Parameters.AddWithValue("@Password", updatedUser.Password);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void DeleteUser(string username)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlCommand command = new SqlCommand("DeleteUser", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Username", username);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public User GetUserByUsername(string username)
        {
            User user = null;

            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlCommand command = new SqlCommand("SELECT UserId, FirstName, LastName, Username, Place, PhoneNo, Password  FROM Users WHERE Username = @Username", connection);
                command.Parameters.AddWithValue("@Username", username);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) // Check if a record was found
                {
                    user = new User
                    {
                        UserId = Convert.ToInt32(reader["UserId"]),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"]?.ToString(), // Nullable check
                        Username = reader["Username"].ToString(),
                        Place = reader["Place"].ToString(),
                        PhoneNo = reader["PhoneNo"].ToString(),
                        Password = reader["Password"].ToString()
                    };
                }

                reader.Close();
                connection.Close();
            }

            return user; // Return the user object or null if not found
        }


    }
}