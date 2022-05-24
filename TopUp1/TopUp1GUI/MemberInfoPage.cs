﻿/*using System;
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
        

        public   MemberInfoPage(int memberSSN)
        {
            InitializeComponent();
            
            RestSharpCaller restSharpCaller = new RestSharpCaller("https://localhost:7234/api/");
             Member member=restSharpCaller.GetMemberBySSN(memberSSN);
            textBoxSSN.Text = member.SSN.ToString();
            textBoxName.Text = member.Name;
            textBoxHaddress.Text = member.HomeAddress;
            textBoxDoB.Text = member.BirthDate;
            textBoxCaddress.Text = member.CampusAddress;
            textBoxJoinDate.Text = member.JoinDate;
            checkBoxIsProfessor.Checked = member.IsProfessor;
            textBoxCardNumber.Text=member.Card.CardNumber.ToString();
            textBoxExpiryDate.Text=member.Card.ExpiryDate.ToString();
            textBoxPhoto.Text=member.Card.Photo;
            phoneNumbersListBox.Items.Clear();
            foreach(string phoneNumber in member.PhoneNumbers)
            {
                phoneNumbersListBox.Items.Add(phoneNumber);
            }

        }

        

        private void updateMemberButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteMemberButton_Click(object sender, EventArgs e)
        {

        }
    }
}
