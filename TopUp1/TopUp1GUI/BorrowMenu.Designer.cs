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
            this.buttonCreateBorrow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMemberSSNBorrow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTitleISBNBorrow = new System.Windows.Forms.TextBox();
            this.textBoxVolumeNumberBorrow = new System.Windows.Forms.TextBox();
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
            this.textBoxLendDate.Location = new System.Drawing.Point(462, 131);
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
            this.labelLendDate.Location = new System.Drawing.Point(481, 113);
            this.labelLendDate.Name = "labelLendDate";
            this.labelLendDate.Size = new System.Drawing.Size(60, 15);
            this.labelLendDate.TabIndex = 7;
            this.labelLendDate.Text = "Lend Date";
            // 
            // labelMemberSSN
            // 
            this.labelMemberSSN.AutoSize = true;
            this.labelMemberSSN.Location = new System.Drawing.Point(349, 113);
            this.labelMemberSSN.Name = "labelMemberSSN";
            this.labelMemberSSN.Size = new System.Drawing.Size(76, 15);
            this.labelMemberSSN.TabIndex = 9;
            this.labelMemberSSN.Text = "Member SSN";
            // 
            // textBoxMemberSSN
            // 
            this.textBoxMemberSSN.Location = new System.Drawing.Point(337, 131);
            this.textBoxMemberSSN.Name = "textBoxMemberSSN";
            this.textBoxMemberSSN.Size = new System.Drawing.Size(100, 23);
            this.textBoxMemberSSN.TabIndex = 8;
            // 
            // buttonCreateBorrow
            // 
            this.buttonCreateBorrow.Location = new System.Drawing.Point(388, 188);
            this.buttonCreateBorrow.Name = "buttonCreateBorrow";
            this.buttonCreateBorrow.Size = new System.Drawing.Size(113, 23);
            this.buttonCreateBorrow.TabIndex = 10;
            this.buttonCreateBorrow.Text = "Borrow Book";
            this.buttonCreateBorrow.UseVisualStyleBackColor = true;
            this.buttonCreateBorrow.Click += new System.EventHandler(this.buttonCreateBorrow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Member SSN";
            // 
            // textBoxMemberSSNBorrow
            // 
            this.textBoxMemberSSNBorrow.Location = new System.Drawing.Point(337, 253);
            this.textBoxMemberSSNBorrow.Name = "textBoxMemberSSNBorrow";
            this.textBoxMemberSSNBorrow.Size = new System.Drawing.Size(100, 23);
            this.textBoxMemberSSNBorrow.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Volume Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Title ISBN";
            // 
            // textBoxTitleISBNBorrow
            // 
            this.textBoxTitleISBNBorrow.Location = new System.Drawing.Point(46, 253);
            this.textBoxTitleISBNBorrow.Name = "textBoxTitleISBNBorrow";
            this.textBoxTitleISBNBorrow.Size = new System.Drawing.Size(100, 23);
            this.textBoxTitleISBNBorrow.TabIndex = 12;
            // 
            // textBoxVolumeNumberBorrow
            // 
            this.textBoxVolumeNumberBorrow.Location = new System.Drawing.Point(207, 253);
            this.textBoxVolumeNumberBorrow.Name = "textBoxVolumeNumberBorrow";
            this.textBoxVolumeNumberBorrow.Size = new System.Drawing.Size(100, 23);
            this.textBoxVolumeNumberBorrow.TabIndex = 11;
            // 
            // BorrowMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMemberSSNBorrow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTitleISBNBorrow);
            this.Controls.Add(this.textBoxVolumeNumberBorrow);
            this.Controls.Add(this.buttonCreateBorrow);
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
        private Button buttonCreateBorrow;
        private Label label1;
        private TextBox textBoxMemberSSNBorrow;
        private Label label2;
        private Label label3;
        private TextBox textBoxTitleISBNBorrow;
        private TextBox textBoxVolumeNumberBorrow;
    }
}