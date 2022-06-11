using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TopUp1GUI.Caller;

namespace TopUp1GUI
{
    public partial class LoginMenu : Form
    {
        RestSharpCaller restSharpCaller = new RestSharpCaller("https://localhost:7234/api/");
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //TODO: Do login thingy here, yes
            bool loggedIn = restSharpCaller.LogIn(userNameTextField.Text,passwordTextField.Text).Response;
            if (loggedIn)
            {
                this.Hide();
                var mainMenu = new MainMenu();
                mainMenu.Closed += (s, args) => this.Close();
                mainMenu.Show();
            }
        }
    }
}
