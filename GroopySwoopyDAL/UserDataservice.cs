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
            using (MySqlConnection con = new MySqlConnection(DatabaseConnection.CreateConnection().ConnectionString))

                try
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * From Region", con))
                    {
                        con.Open();
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            UserDTO user = new UserDTO();
                            user.Id = reader.GetInt32(0);
                            user.Name = reader.GetString(1);



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
    }
}

