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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void memberMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var memberMenu = new MemberMenu();
            memberMenu.Closed += (s, args) => this.Show();
            memberMenu.Show();
        }
    }
}
