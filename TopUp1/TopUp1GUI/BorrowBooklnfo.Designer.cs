namespace TopUp1GUI
{
    partial class BorrowBooklnfo
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
            this.labelMemberSSN = new System.Windows.Forms.Label();
            this.textBoxMemberSSN = new System.Windows.Forms.TextBox();
            this.textBoxTitleISBN = new System.Windows.Forms.TextBox();
            this.labelTitleISBN = new System.Windows.Forms.Label();
            this.textBoxVolumeNumber = new System.Windows.Forms.TextBox();
            this.labelVolumeNumber = new System.Windows.Forms.Label();
            this.textBoxLandDate = new System.Windows.Forms.TextBox();
            this.labelLendDate = new System.Windows.Forms.Label();
            this.textBoxDeadLine = new System.Windows.Forms.TextBox();
            this.labelDeadLine = new System.Windows.Forms.Label();
            this.labelReturnDate = new System.Windows.Forms.Label();
            this.textBoxReturnDate = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMemberSSN
            // 
            this.labelMemberSSN.AutoSize = true;
            this.labelMemberSSN.Location = new System.Drawing.Point(71, 60);
            this.labelMemberSSN.Name = "labelMemberSSN";
            this.labelMemberSSN.Size = new System.Drawing.Size(73, 15);
            this.labelMemberSSN.TabIndex = 0;
            this.labelMemberSSN.Text = "MemberSSN";
            // 
            // textBoxMemberSSN
            // 
            this.textBoxMemberSSN.Location = new System.Drawing.Point(150, 60);
            this.textBoxMemberSSN.Name = "textBoxMemberSSN";
            this.textBoxMemberSSN.Size = new System.Drawing.Size(100, 23);
            this.textBoxMemberSSN.TabIndex = 1;
            // 
            // textBoxTitleISBN
            // 
            this.textBoxTitleISBN.Location = new System.Drawing.Point(150, 89);
            this.textBoxTitleISBN.Name = "textBoxTitleISBN";
            this.textBoxTitleISBN.Size = new System.Drawing.Size(100, 23);
            this.textBoxTitleISBN.TabIndex = 3;
            // 
            // labelTitleISBN
            // 
            this.labelTitleISBN.AutoSize = true;
            this.labelTitleISBN.Location = new System.Drawing.Point(87, 89);
            this.labelTitleISBN.Name = "labelTitleISBN";
            this.labelTitleISBN.Size = new System.Drawing.Size(57, 15);
            this.labelTitleISBN.TabIndex = 2;
            this.labelTitleISBN.Text = "Title ISBN";
            // 
            // textBoxVolumeNumber
            // 
            this.textBoxVolumeNumber.Location = new System.Drawing.Point(150, 118);
            this.textBoxVolumeNumber.Name = "textBoxVolumeNumber";
            this.textBoxVolumeNumber.Size = new System.Drawing.Size(100, 23);
            this.textBoxVolumeNumber.TabIndex = 5;
            // 
            // labelVolumeNumber
            // 
            this.labelVolumeNumber.AutoSize = true;
            this.labelVolumeNumber.Location = new System.Drawing.Point(50, 121);
            this.labelVolumeNumber.Name = "labelVolumeNumber";
            this.labelVolumeNumber.Size = new System.Drawing.Size(94, 15);
            this.labelVolumeNumber.TabIndex = 4;
            this.labelVolumeNumber.Text = "Volume Number";
            // 
            // textBoxLandDate
            // 
            this.textBoxLandDate.Location = new System.Drawing.Point(150, 147);
            this.textBoxLandDate.Name = "textBoxLandDate";
            this.textBoxLandDate.Size = new System.Drawing.Size(100, 23);
            this.textBoxLandDate.TabIndex = 7;
            // 
            // labelLendDate
            // 
            this.labelLendDate.AutoSize = true;
            this.labelLendDate.Location = new System.Drawing.Point(87, 150);
            this.labelLendDate.Name = "labelLendDate";
            this.labelLendDate.Size = new System.Drawing.Size(60, 15);
            this.labelLendDate.TabIndex = 6;
            this.labelLendDate.Text = "Land Date";
            // 
            // textBoxDeadLine
            // 
            this.textBoxDeadLine.Location = new System.Drawing.Point(150, 176);
            this.textBoxDeadLine.Name = "textBoxDeadLine";
            this.textBoxDeadLine.Size = new System.Drawing.Size(100, 23);
            this.textBoxDeadLine.TabIndex = 9;
            // 
            // labelDeadLine
            // 
            this.labelDeadLine.AutoSize = true;
            this.labelDeadLine.Location = new System.Drawing.Point(88, 179);
            this.labelDeadLine.Name = "labelDeadLine";
            this.labelDeadLine.Size = new System.Drawing.Size(56, 15);
            this.labelDeadLine.TabIndex = 8;
            this.labelDeadLine.Text = "DeadLine";
            this.labelDeadLine.Click += new System.EventHandler(this.labelReturnDate_Click);
            // 
            // labelReturnDate
            // 
            this.labelReturnDate.AutoSize = true;
            this.labelReturnDate.Location = new System.Drawing.Point(78, 208);
            this.labelReturnDate.Name = "labelReturnDate";
            this.labelReturnDate.Size = new System.Drawing.Size(66, 15);
            this.labelReturnDate.TabIndex = 10;
            this.labelReturnDate.Text = "ReturnDate";
            // 
            // textBoxReturnDate
            // 
            this.textBoxReturnDate.Location = new System.Drawing.Point(150, 205);
            this.textBoxReturnDate.Name = "textBoxReturnDate";
            this.textBoxReturnDate.Size = new System.Drawing.Size(100, 23);
            this.textBoxReturnDate.TabIndex = 11;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(150, 290);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(100, 23);
            this.returnButton.TabIndex = 12;
            this.returnButton.Text = "ReturnBook";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // BorrowBooklnfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.textBoxReturnDate);
            this.Controls.Add(this.labelReturnDate);
            this.Controls.Add(this.textBoxDeadLine);
            this.Controls.Add(this.labelDeadLine);
            this.Controls.Add(this.textBoxLandDate);
            this.Controls.Add(this.labelLendDate);
            this.Controls.Add(this.textBoxVolumeNumber);
            this.Controls.Add(this.labelVolumeNumber);
            this.Controls.Add(this.textBoxTitleISBN);
            this.Controls.Add(this.labelTitleISBN);
            this.Controls.Add(this.textBoxMemberSSN);
            this.Controls.Add(this.labelMemberSSN);
            this.Name = "BorrowBooklnfo";
            this.Text = "BorrowBooklnfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelMemberSSN;
        private TextBox textBoxMemberSSN;
        private TextBox textBoxTitleISBN;
        private Label labelTitleISBN;
        private TextBox textBoxVolumeNumber;
        private Label labelVolumeNumber;
        private TextBox textBoxLandDate;
        private Label labelLendDate;
        private TextBox textBoxDeadLine;
        private Label labelDeadLine;
        private Label labelReturnDate;
        private TextBox textBoxReturnDate;
        private Button returnButton;
    }
}