using Microsoft.AspNetCore.Mvc;
using TopUp1.Facades;
using TopUp1.DAL;
using TopUp1.Facades.Interfaces;
using TopUp1.Model;

namespace TopUp1.Controllers
{
    public class LoginController : Controller
    {
        UsersController _usersController = new UsersController();
        EncryptionController _encryptionController = new EncryptionController();

        // Login
        [HttpPost]
        [Route("api/login")]
        public BooleanResponse Login(string userName, string password)
        {
            bool isLoggedIn = false;
            var users = _usersController.GetUser(userName);
            
                if (users.Username == userName)
                {
                    password += users.Salt;
                    if (_encryptionController.EncryptPassword(password) == users.Password)
                    {
                        isLoggedIn = true;
                    }
                }
            
            return new BooleanResponse { Response=isLoggedIn};
        }

        // Register
        

    }
}
