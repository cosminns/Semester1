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
        BorrowBook borrowBook;
        public BorrowBooklnfo(string memberSSN, string titleISBN, string volumeNumber,string lendDate  )
        {

            InitializeComponent();
            borrowBook = restSharpCaller.GetBorrowBookById(titleISBN, Int32.Parse(volumeNumber), Int32.Parse(memberSSN), lendDate);
            textBoxMemberSSN.Text = borrowBook.Member.SSN.ToString();
            textBoxTitleISBN.Text = borrowBook.Volume.Title.ISBN;
            textBoxVolumeNumber.Text = borrowBook.Volume.VolumeNumber.ToString();
            textBoxLandDate.Text = borrowBook.LendDate;
            textBoxDeadLine.Text = borrowBook.DeadLine;
            textBoxReturnDate.Text = borrowBook.ReturnDate;
            returnButton.Enabled = borrowBook.Volume.Borrowed;
        }

        private void labelReturnDate_Click(object sender, EventArgs e)
        {

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            restSharpCaller.ReturnBorrow(borrowBook.Volume.Title.ISBN, borrowBook.Volume.VolumeNumber, borrowBook.Member.SSN, borrowBook.LendDate);
        }
    }
}
