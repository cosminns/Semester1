namespace TopUp1GUI
{
    partial class BorrowMenu
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
            this.labelGetBorrowBook = new System.Windows.Forms.Label();
            this.buttonGetBorrowBook = new System.Windows.Forms.Button();
            this.textBoxVolumeNumber = new System.Windows.Forms.TextBox();
            this.textBoxLendDate = new System.Windows.Forms.TextBox();
            this.textBoxTitleISBN = new System.Windows.Forms.TextBox();
            this.labelTitleISBN = new System.Windows.Forms.Label();
            this.labelVolumeNumber = new System.Windows.Forms.Label();
            this.labelLendDate = new System.Windows.Forms.Label();
            this.labelMemberSSN = new System.Windows.Forms.Label();
            this.textBoxMemberSSN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelGetBorrowBook
            // 
            this.labelGetBorrowBook.AutoSize = true;
            this.labelGetBorrowBook.Location = new System.Drawing.Point(367, 50);
            this.labelGetBorrowBook.Name = "labelGetBorrowBook";
            this.labelGetBorrowBook.Size = new System.Drawing.Size(0, 15);
            this.labelGetBorrowBook.TabIndex = 0;
            // 
            // buttonGetBorrowBook
            // 
            this.buttonGetBorrowBook.Location = new System.Drawing.Point(388, 68);
            this.buttonGetBorrowBook.Name = "buttonGetBorrowBook";
            this.buttonGetBorrowBook.Size = new System.Drawing.Size(113, 23);
            this.buttonGetBorrowBook.TabIndex = 1;
            this.buttonGetBorrowBook.Text = "Get Borrow Book";
            this.buttonGetBorrowBook.UseVisualStyleBackColor = true;
            this.buttonGetBorrowBook.Click += new System.EventHandler(this.buttonGetBorrowBook_Click);
            // 
            // textBoxVolumeNumber
            // 
            this.textBoxVolumeNumber.Location = new System.Drawing.Point(207, 131);
            this.textBoxVolumeNumber.Name = "textBoxVolumeNumber";
            this.textBoxVolumeNumber.Size = new System.Drawing.Size(100, 23);
            this.textBoxVolumeNumber.TabIndex = 2;
            // 
            // textBoxLendDate
            // 
            this.textBoxLendDate.Location = new System.Drawing.Point(352, 134);
            this.textBoxLendDate.Name = "textBoxLendDate";
            this.textBoxLendDate.Size = new System.Drawing.Size(100, 23);
            this.textBoxLendDate.TabIndex = 3;
            // 
            // textBoxTitleISBN
            // 
            this.textBoxTitleISBN.Location = new System.Drawing.Point(46, 131);
            this.textBoxTitleISBN.Name = "textBoxTitleISBN";
            this.textBoxTitleISBN.Size = new System.Drawing.Size(100, 23);
            this.textBoxTitleISBN.TabIndex = 4;
            // 
            // labelTitleISBN
            // 
            this.labelTitleISBN.AutoSize = true;
            this.labelTitleISBN.Location = new System.Drawing.Point(62, 113);
            this.labelTitleISBN.Name = "labelTitleISBN";
            this.labelTitleISBN.Size = new System.Drawing.Size(57, 15);
            this.labelTitleISBN.TabIndex = 5;
            this.labelTitleISBN.Text = "Title ISBN";
            this.labelTitleISBN.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelVolumeNumber
            // 
            this.labelVolumeNumber.AutoSize = true;
            this.labelVolumeNumber.Location = new System.Drawing.Point(213, 113);
            this.labelVolumeNumber.Name = "labelVolumeNumber";
            this.labelVolumeNumber.Size = new System.Drawing.Size(94, 15);
            this.labelVolumeNumber.TabIndex = 6;
            this.labelVolumeNumber.Text = "Volume Number";
            // 
            // labelLendDate
            // 
            this.labelLendDate.AutoSize = true;
            this.labelLendDate.Location = new System.Drawing.Point(377, 113);
            this.labelLendDate.Name = "labelLendDate";
            this.labelLendDate.Size = new System.Drawing.Size(60, 15);
            this.labelLendDate.TabIndex = 7;
            this.labelLendDate.Text = "Lend Date";
            // 
            // labelMemberSSN
            // 
            this.labelMemberSSN.AutoSize = true;
            this.labelMemberSSN.Location = new System.Drawing.Point(526, 113);
            this.labelMemberSSN.Name = "labelMemberSSN";
            this.labelMemberSSN.Size = new System.Drawing.Size(76, 15);
            this.labelMemberSSN.TabIndex = 9;
            this.labelMemberSSN.Text = "Member SSN";
            // 
            // textBoxMemberSSN
            // 
            this.textBoxMemberSSN.Location = new System.Drawing.Point(514, 134);
            this.textBoxMemberSSN.Name = "textBoxMemberSSN";
            this.textBoxMemberSSN.Size = new System.Drawing.Size(100, 23);
            this.textBoxMemberSSN.TabIndex = 8;
            // 
            // BorrowMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMemberSSN);
            this.Controls.Add(this.textBoxMemberSSN);
            this.Controls.Add(this.labelLendDate);
            this.Controls.Add(this.labelVolumeNumber);
            this.Controls.Add(this.labelTitleISBN);
            this.Controls.Add(this.textBoxTitleISBN);
            this.Controls.Add(this.textBoxLendDate);
            this.Controls.Add(this.textBoxVolumeNumber);
            this.Controls.Add(this.buttonGetBorrowBook);
            this.Controls.Add(this.labelGetBorrowBook);
            this.Name = "BorrowMenu";
            this.Text = "BorrowMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelGetBorrowBook;
        private Button buttonGetBorrowBook;
        private TextBox textBoxVolumeNumber;
        private TextBox textBoxLendDate;
        private TextBox textBoxTitleISBN;
        private Label labelTitleISBN;
        private Label labelVolumeNumber;
        private Label labelLendDate;
        private Label labelMemberSSN;
        private TextBox textBoxMemberSSN;
    }
}