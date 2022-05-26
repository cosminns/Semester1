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
    public partial class TitleInfoPage : Form
    {
        RestSharpCaller restSharpCaller = new RestSharpCaller("https://localhost:7234/api/");
        public TitleInfoPage(string ISBN)
        {
           
            InitializeComponent();
            Title title = restSharpCaller.GetTitleById(ISBN);
            textBoxISBN.Text = title.ISBN;
            textBoxTitleDesc.Text=title.TitleDesc;
            textBoxTitle.Text=title.TitleTitle;
            textBoxPublisher.Text=title.Publisher;
            textBoxPublishingDate.Text=title.PublishingDate;
            textBoxSubjectArea.Text=title.SubjectArea;
            textBoxTitleType.Text=title.TitleType;
            textBoxTitleStatus.Text=title.TitleStatus;
            authorsListBox.Items.Clear();
            foreach (string author in title.Authors)
            {
                authorsListBox.Items.Add(author);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        { 
            restSharpCaller.UpdateTitle(textBoxISBN.Text,textBoxTitleDesc.Text,textBoxTitle.Text,textBoxPublisher.Text,textBoxPublishingDate.Text,textBoxSubjectArea.Text,textBoxTitleType.Text,textBoxTitleStatus.Text);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            restSharpCaller.DeleteTitle(textBoxISBN.Text);
        }
    }
}
