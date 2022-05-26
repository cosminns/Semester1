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
    public partial class TitleMenu : Form
    {
        public TitleMenu()
        {
            InitializeComponent();
        }

        private void buttonGetInfoByISBM_Click(object sender, EventArgs e)
        {
            if (textBoxISBN.Text.Length > 1)
            {
                this.Hide();
                var titleInfoPage = new TitleInfoPage(textBoxISBN.Text);
                titleInfoPage.Closed += (s, args) => this.Show();
                titleInfoPage.Show();
            }
        }
    }
}
