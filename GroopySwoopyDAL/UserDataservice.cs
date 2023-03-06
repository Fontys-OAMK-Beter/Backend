using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroopySwoopyInterfaces;
using GroopySwoopyDTO;
using MySqlConnector;

namespace GroopySwoopyDAL
{
    public class UserDataservice : IUserDataservice
    {
        public List<UserDTO> GetAllUsers()
        {
            

            List<UserDTO> users = new List<UserDTO>();

            using (MySqlConnection con = DatabaseConnection.CreateConnection())

            try
            {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM user", con))
                    {
                        con.Open();
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            UserDTO user = new UserDTO();
                            user.Id = reader.GetInt32(0);
                            user.Name = reader.GetString(1);
                            user.Password = reader.GetString(2);
                            user.Email = reader.GetString(3);



                            users.Add(user);
                        }
                    }


                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.ToString());
                    return null;
                }
                finally
                {
                    con.Close();
                }
            return users;
        }

        public UserDTO GetUserByID(int id)
        {
            UserDTO user = new UserDTO();
            using (MySqlConnection con = DatabaseConnection.CreateConnection())

                try
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM user WHERE id = "+id, con))
                    {
                        con.Open();
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            user.Id = reader.GetInt32(0);
                            user.Name = reader.GetString(1);
                            user.Password = reader.GetString(2);
                            user.Email = reader.GetString(3);
                        }
                    }


                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.ToString());
                    return null;
                }
                finally
                {
                    con.Close();
                }
            return user;
        }
    }
}

