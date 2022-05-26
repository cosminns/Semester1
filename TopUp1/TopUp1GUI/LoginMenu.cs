using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopUp1GUI
{
    public partial class LoginMenu : Form
    {
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //TODO: Do login thingy here, yes
            this.Hide();
            var mainMenu = new MainMenu();
            mainMenu.Closed += (s, args) => this.Close();
            mainMenu.Show();
        }
    }
}
