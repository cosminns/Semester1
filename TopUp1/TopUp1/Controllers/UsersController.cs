using Microsoft.AspNetCore.Mvc;
using TopUp1.Facades;
using TopUp1.DAL;
using TopUp1.Facades.Interfaces;
using System.Data.SqlClient;
using EndOfSemester3.Models;
using System.Data;

namespace TopUp1.Controllers
{
    public class UsersController : Controller
    {
        public static readonly string connectionString = "Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;";
        // GET: api/Users
        public UserInfo GetUser(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prGetUserInfo", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@Username", username));
                SqlDataReader rdr;
                // execute the command
                rdr = cmd.ExecuteReader();
    
                UserInfo user = new UserInfo();
                while (rdr.Read())
                {
                    user.Username = (string)rdr["UserName"];
                    user.Password = (string)rdr["Password"];
                    user.Salt = (string)rdr["Salt"];
                   
                   
                }

                rdr.Close();

                //create a command to get the authors and add them to the title

                return user;
            }
        }

        // GET: api/Users/username
        

        // CREATE: api/Users
        
    }
}
