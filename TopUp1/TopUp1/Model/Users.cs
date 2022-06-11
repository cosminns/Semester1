using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EndOfSemester3.Models
{
	public class UserInfo
	{
		public string Username { get; set; }
		public string Password { get; set; }
		public string Salt { get; set; }
		public string SSN { get; set; }

		public UserInfo()
        {
        }
		public UserInfo(string username, string password,  string salt,string SSN)
		{
			this.Username = username;
			this.Password = password;
			this.Salt = salt;
			this.SSN=SSN;
		}
	}
}