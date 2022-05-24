/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;*/
using System;
using System.Net;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TopUp1GUI.Caller;

namespace TopUp1GUI
{
    public partial class MemberInfoPage : Form
    {
        static HttpClient client = new HttpClient();

        public   MemberInfoPage(int memberSSN)
        {
            InitializeComponent();
            
            RestSharpCaller restSharpCaller = new RestSharpCaller("https://localhost:7234/api/");
             Member member=restSharpCaller.GetMemberBySSN(10002354);
        }

        

        private void updateMemberButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteMemberButton_Click(object sender, EventArgs e)
        {

        }
    }
}
