namespace TopUp1GUI
{
    partial class TitleInfoPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelISBN = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxTitleDesc = new System.Windows.Forms.TextBox();
            this.labelTitleDesc = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.textBoxPublishingDate = new System.Windows.Forms.TextBox();
            this.labelPublishDate = new System.Windows.Forms.Label();
            this.textBoxSubjectArea = new System.Windows.Forms.TextBox();
            this.labelSubArea = new System.Windows.Forms.Label();
            this.textBoxTitleType = new System.Windows.Forms.TextBox();
            this.labelTitleType = new System.Windows.Forms.Label();
            this.textBoxTitleStatus = new System.Windows.Forms.TextBox();
            this.labelTitleStatus = new System.Windows.Forms.Label();
            this.authorsListBox = new System.Windows.Forms.ListBox();
            this.labelAuthors = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(35, 50);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(32, 15);
            this.labelISBN.TabIndex = 0;
            this.labelISBN.Text = "ISBN";
            this.labelISBN.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(133, 42);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.ReadOnly = true;
            this.textBoxISBN.Size = new System.Drawing.Size(100, 23);
            this.textBoxISBN.TabIndex = 1;
            // 
            // textBoxTitleDesc
            // 
            this.textBoxTitleDesc.Location = new System.Drawing.Point(133, 76);
            this.textBoxTitleDesc.Name = "textBoxTitleDesc";
            this.textBoxTitleDesc.Size = new System.Drawing.Size(100, 23);
            this.textBoxTitleDesc.TabIndex = 3;
            // 
            // labelTitleDesc
            // 
            this.labelTitleDesc.AutoSize = true;
            this.labelTitleDesc.Location = new System.Drawing.Point(35, 79);
            this.labelTitleDesc.Name = "labelTitleDesc";
            this.labelTitleDesc.Size = new System.Drawing.Size(92, 15);
            this.labelTitleDesc.TabIndex = 2;
            this.labelTitleDesc.Text = "Title Description";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(133, 105);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 23);
            this.textBoxTitle.TabIndex = 5;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(35, 108);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(29, 15);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Title";
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(133, 134);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(100, 23);
            this.textBoxPublisher.TabIndex = 7;
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(35, 137);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(56, 15);
            this.labelPublisher.TabIndex = 6;
            this.labelPublisher.Text = "Publisher";
            // 
            // textBoxPublishingDate
            // 
            this.textBoxPublishingDate.Location = new System.Drawing.Point(133, 163);
            this.textBoxPublishingDate.Name = "textBoxPublishingDate";
            this.textBoxPublishingDate.Size = new System.Drawing.Size(100, 23);
            this.textBoxPublishingDate.TabIndex = 9;
            // 
            // labelPublishDate
            // 
            this.labelPublishDate.AutoSize = true;
            this.labelPublishDate.Location = new System.Drawing.Point(35, 166);
            this.labelPublishDate.Name = "labelPublishDate";
            this.labelPublishDate.Size = new System.Drawing.Size(90, 15);
            this.labelPublishDate.TabIndex = 8;
            this.labelPublishDate.Text = "Publishing Date";
            // 
            // textBoxSubjectArea
            // 
            this.textBoxSubjectArea.Location = new System.Drawing.Point(133, 192);
            this.textBoxSubjectArea.Name = "textBoxSubjectArea";
            this.textBoxSubjectArea.Size = new System.Drawing.Size(100, 23);
            this.textBoxSubjectArea.TabIndex = 11;
            // 
            // labelSubArea
            // 
            this.labelSubArea.AutoSize = true;
            this.labelSubArea.Location = new System.Drawing.Point(35, 195);
            this.labelSubArea.Name = "labelSubArea";
            this.labelSubArea.Size = new System.Drawing.Size(73, 15);
            this.labelSubArea.TabIndex = 10;
            this.labelSubArea.Text = "Subject Area";
            // 
            // textBoxTitleType
            // 
            this.textBoxTitleType.Location = new System.Drawing.Point(133, 221);
            this.textBoxTitleType.Name = "textBoxTitleType";
            this.textBoxTitleType.Size = new System.Drawing.Size(100, 23);
            this.textBoxTitleType.TabIndex = 13;
            // 
            // labelTitleType
            // 
            this.labelTitleType.AutoSize = true;
            this.labelTitleType.Location = new System.Drawing.Point(35, 224);
            this.labelTitleType.Name = "labelTitleType";
            this.labelTitleType.Size = new System.Drawing.Size(56, 15);
            this.labelTitleType.TabIndex = 12;
            this.labelTitleType.Text = "Title Type";
            // 
            // textBoxTitleStatus
            // 
            this.textBoxTitleStatus.Location = new System.Drawing.Point(133, 250);
            this.textBoxTitleStatus.Name = "textBoxTitleStatus";
            this.textBoxTitleStatus.Size = new System.Drawing.Size(100, 23);
            this.textBoxTitleStatus.TabIndex = 15;
            // 
            // labelTitleStatus
            // 
            this.labelTitleStatus.AutoSize = true;
            this.labelTitleStatus.Location = new System.Drawing.Point(35, 253);
            this.labelTitleStatus.Name = "labelTitleStatus";
            this.labelTitleStatus.Size = new System.Drawing.Size(64, 15);
            this.labelTitleStatus.TabIndex = 14;
            this.labelTitleStatus.Text = "Title Status";
            // 
            // authorsListBox
            // 
            this.authorsListBox.FormattingEnabled = true;
            this.authorsListBox.ItemHeight = 15;
            this.authorsListBox.Location = new System.Drawing.Point(133, 307);
            this.authorsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.authorsListBox.Name = "authorsListBox";
            this.authorsListBox.Size = new System.Drawing.Size(132, 79);
            this.authorsListBox.TabIndex = 18;
            // 
            // labelAuthors
            // 
            this.labelAuthors.AutoSize = true;
            this.labelAuthors.Location = new System.Drawing.Point(35, 320);
            this.labelAuthors.Name = "labelAuthors";
            this.labelAuthors.Size = new System.Drawing.Size(49, 15);
            this.labelAuthors.TabIndex = 19;
            this.labelAuthors.Text = "Authors";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(451, 160);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 20;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(451, 108);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // TitleInfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelAuthors);
            this.Controls.Add(this.authorsListBox);
            this.Controls.Add(this.textBoxTitleStatus);
            this.Controls.Add(this.labelTitleStatus);
            this.Controls.Add(this.textBoxTitleType);
            this.Controls.Add(this.labelTitleType);
            this.Controls.Add(this.textBoxSubjectArea);
            this.Controls.Add(this.labelSubArea);
            this.Controls.Add(this.textBoxPublishingDate);
            this.Controls.Add(this.labelPublishDate);
            this.Controls.Add(this.textBoxPublisher);
            this.Controls.Add(this.labelPublisher);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxTitleDesc);
            this.Controls.Add(this.labelTitleDesc);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.labelISBN);
            this.Name = "TitleInfoPage";
            this.Text = "TitleInfoPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelISBN;
        private TextBox textBoxISBN;
        private TextBox textBoxTitleDesc;
        private Label labelTitleDesc;
        private TextBox textBoxTitle;
        private Label labelTitle;
        private TextBox textBoxPublisher;
        private Label labelPublisher;
        private TextBox textBoxPublishingDate;
        private Label labelPublishDate;
        private TextBox textBoxSubjectArea;
        private Label labelSubArea;
        private TextBox textBoxTitleType;
        private Label labelTitleType;
        private TextBox textBoxTitleStatus;
        private Label labelTitleStatus;
        private ListBox authorsListBox;
        private Label labelAuthors;
        private Button buttonUpdate;
        private Button buttonDelete;
    }
}