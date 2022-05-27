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
    public partial class BorrowBooklnfo : Form
    {
        RestSharpCaller restSharpCaller = new RestSharpCaller("https://localhost:7234/api/");
        public BorrowBooklnfo(string memberSSN, string titleISBN, string volumeNumber,string lendDate  )
        {

            InitializeComponent();
            BorrowBook borowBook = restSharpCaller.GetBorrowBookById(titleISBN, Int32.Parse(volumeNumber), Int32.Parse(memberSSN), lendDate);
            textBoxMemberSSN.Text = borowBook.Member.SSN.ToString();
            textBoxTitleISBN.Text = borowBook.Volume.Title.ISBN;
            textBoxVolumeNumber.Text = borowBook.Volume.VolumeNumber.ToString();
            textBoxLandDate.Text = borowBook.LendDate;
            textBoxReturnDate.Text = borowBook.ReturnDate;
        }
    }
}
