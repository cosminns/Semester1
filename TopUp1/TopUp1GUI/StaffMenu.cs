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
    public partial class StaffMenu : Form
    {
        public StaffMenu()
        {
            InitializeComponent();
        }

        private void GetStaffBySSNButton_Click(object sender, EventArgs e)
        {
            if (textBoxForSSN.Text.Length > 1)
            {
                this.Hide();
                var staffInfoPage = new StaffInfoPage(int.Parse(textBoxForSSN.Text));
                staffInfoPage.Closed += (s, args) => this.Show();
                staffInfoPage.Show();
            }
        }
    }
}
