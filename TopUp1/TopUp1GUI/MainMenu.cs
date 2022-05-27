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

        private void staffMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var staffMenu = new StaffMenu();
            staffMenu.Closed += (s, args) => this.Show();
            staffMenu.Show();
        }

        private void titleMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var titleMenu = new TitleMenu();
            titleMenu.Closed += (s, args) => this.Show();
            titleMenu.Show();
        }

        private void borrowBookMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var borrowMenu = new BorrowMenu();
            borrowMenu.Closed += (s, args) => this.Show();
            borrowMenu.Show();
        }
    }
}
