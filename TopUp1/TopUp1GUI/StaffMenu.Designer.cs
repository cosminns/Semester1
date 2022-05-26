namespace TopUp1GUI
{
    partial class StaffMenu
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
            this.GetStaffBySSNButton = new System.Windows.Forms.Button();
            this.textBoxForSSN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetStaffBySSNButton
            // 
            this.GetStaffBySSNButton.Location = new System.Drawing.Point(354, 67);
            this.GetStaffBySSNButton.Name = "GetStaffBySSNButton";
            this.GetStaffBySSNButton.Size = new System.Drawing.Size(109, 23);
            this.GetStaffBySSNButton.TabIndex = 0;
            this.GetStaffBySSNButton.Text = "Get Staff By SSN";
            this.GetStaffBySSNButton.UseVisualStyleBackColor = true;
            this.GetStaffBySSNButton.Click += new System.EventHandler(this.GetStaffBySSNButton_Click);
            // 
            // textBoxForSSN
            // 
            this.textBoxForSSN.Location = new System.Drawing.Point(354, 105);
            this.textBoxForSSN.Name = "textBoxForSSN";
            this.textBoxForSSN.PlaceholderText = "Put Staff SSN here";
            this.textBoxForSSN.Size = new System.Drawing.Size(109, 23);
            this.textBoxForSSN.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add New Staff";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StaffMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxForSSN);
            this.Controls.Add(this.GetStaffBySSNButton);
            this.Name = "StaffMenu";
            this.Text = "StaffMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button GetStaffBySSNButton;
        private TextBox textBoxForSSN;
        private Button button1;
    }
}