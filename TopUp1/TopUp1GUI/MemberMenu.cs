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
    public partial class MemberMenu : Form
    {
        public MemberMenu()
        {
            InitializeComponent();
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {

        }

        private void getMemberInfoButton_Click(object sender, EventArgs e)
        {
            if (memberSSNTextField.Text.Length > 1)
            {
                this.Hide();
                var memberInfoPage = new MemberInfoPage(int.Parse(memberSSNTextField.Text));
                memberInfoPage.Closed += (s, args) => this.Show();
                memberInfoPage.Show();
            }
        }
    }
}
