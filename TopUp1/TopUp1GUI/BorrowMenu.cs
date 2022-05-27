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
    public partial class BorrowMenu : Form
    {
        public BorrowMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGetBorrowBook_Click(object sender, EventArgs e)
        {
            if ((textBoxMemberSSN.Text.Length > 1)&&(textBoxVolumeNumber.Text.Length > 1)&&(textBoxTitleISBN.Text.Length > 1)&&(textBoxLendDate.Text.Length > 1))
            {
                this.Hide();
                var borrowBookInfoPage = new BorrowBooklnfo(textBoxMemberSSN.Text,textBoxTitleISBN.Text,textBoxVolumeNumber.Text,textBoxLendDate.Text);
                borrowBookInfoPage.Closed += (s, args) => this.Show();
                borrowBookInfoPage.Show();
            }
        }
    }
}
