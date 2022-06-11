using Microsoft.AspNetCore.Mvc;
using TopUp1.Facades;
using TopUp1.DAL;
using TopUp1.Facades.Interfaces;

namespace TopUp1.Controllers
{
    public class EncryptionController : Controller
    {
        //Encrypt
        public string EncryptPassword(string password)
        {
            string passPhrase = "Cosmin";

            return Encrypt.EncryptString(password, passPhrase);
        }
        //Decrypt
        public string DecryptPassword(string password)
        {
            string passPhrase = "Cosmin";

            return Encrypt.DecryptString(password, passPhrase);
        }
    }
}
