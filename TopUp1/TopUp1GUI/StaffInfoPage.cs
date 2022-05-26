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
    public partial class StaffInfoPage : Form
    {
        RestSharpCaller restSharpCaller = new RestSharpCaller("https://localhost:7234/api/");
        public StaffInfoPage(int staffSSN)
        {
            InitializeComponent();
            Staff staff = restSharpCaller.GetStaffById(staffSSN);
            textBoxSSN.Text = staff.SSN.ToString();
            textBoxName.Text = staff.Name;
            textBoxHAddress.Text = staff.HomeAddress;
            textBoxDoB.Text = staff.BirthDate;
            textRole.Text=staff.Role.RoleName;
           
          
            
        }

        private void labelSSN_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            restSharpCaller.UpdateStaff(Int32.Parse(textBoxSSN.Text), 1,textBoxHAddress.Text);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            restSharpCaller.DeleteStaff(Int32.Parse(textBoxSSN.Text));
        }
    }
}
