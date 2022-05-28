namespace TopUp1GUI
{
    partial class CreateMemberPage
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
            this.labelSSN = new System.Windows.Forms.Label();
            this.textBoxSSN = new System.Windows.Forms.TextBox();
            this.buttonCreateMember = new System.Windows.Forms.Button();
            this.textBoxCampusAddress = new System.Windows.Forms.TextBox();
            this.labelCampusAddress = new System.Windows.Forms.Label();
            this.textBoxJoinDate = new System.Windows.Forms.TextBox();
            this.labelJoinDate = new System.Windows.Forms.Label();
            this.checkBoxIsProfessor = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelSSN
            // 
            this.labelSSN.AutoSize = true;
            this.labelSSN.Location = new System.Drawing.Point(92, 51);
            this.labelSSN.Name = "labelSSN";
            this.labelSSN.Size = new System.Drawing.Size(28, 15);
            this.labelSSN.TabIndex = 0;
            this.labelSSN.Text = "SSN";
            // 
            // textBoxSSN
            // 
            this.textBoxSSN.Location = new System.Drawing.Point(148, 48);
            this.textBoxSSN.Name = "textBoxSSN";
            this.textBoxSSN.Size = new System.Drawing.Size(100, 23);
            this.textBoxSSN.TabIndex = 1;
            // 
            // buttonCreateMember
            // 
            this.buttonCreateMember.Location = new System.Drawing.Point(148, 179);
            this.buttonCreateMember.Name = "buttonCreateMember";
            this.buttonCreateMember.Size = new System.Drawing.Size(100, 23);
            this.buttonCreateMember.TabIndex = 2;
            this.buttonCreateMember.Text = "Create Member";
            this.buttonCreateMember.UseVisualStyleBackColor = true;
            // 
            // textBoxCampusAddress
            // 
            this.textBoxCampusAddress.Location = new System.Drawing.Point(148, 77);
            this.textBoxCampusAddress.Name = "textBoxCampusAddress";
            this.textBoxCampusAddress.Size = new System.Drawing.Size(100, 23);
            this.textBoxCampusAddress.TabIndex = 4;
            // 
            // labelCampusAddress
            // 
            this.labelCampusAddress.AutoSize = true;
            this.labelCampusAddress.Location = new System.Drawing.Point(46, 80);
            this.labelCampusAddress.Name = "labelCampusAddress";
            this.labelCampusAddress.Size = new System.Drawing.Size(96, 15);
            this.labelCampusAddress.TabIndex = 3;
            this.labelCampusAddress.Text = "Campus Address";
            // 
            // textBoxJoinDate
            // 
            this.textBoxJoinDate.Location = new System.Drawing.Point(148, 106);
            this.textBoxJoinDate.Name = "textBoxJoinDate";
            this.textBoxJoinDate.Size = new System.Drawing.Size(100, 23);
            this.textBoxJoinDate.TabIndex = 6;
            // 
            // labelJoinDate
            // 
            this.labelJoinDate.AutoSize = true;
            this.labelJoinDate.Location = new System.Drawing.Point(26, 114);
            this.labelJoinDate.Name = "labelJoinDate";
            this.labelJoinDate.Size = new System.Drawing.Size(116, 15);
            this.labelJoinDate.TabIndex = 5;
            this.labelJoinDate.Text = "Join Date automated";
            // 
            // checkBoxIsProfessor
            // 
            this.checkBoxIsProfessor.AutoSize = true;
            this.checkBoxIsProfessor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxIsProfessor.Location = new System.Drawing.Point(72, 134);
            this.checkBoxIsProfessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxIsProfessor.Name = "checkBoxIsProfessor";
            this.checkBoxIsProfessor.Size = new System.Drawing.Size(86, 19);
            this.checkBoxIsProfessor.TabIndex = 18;
            this.checkBoxIsProfessor.Text = "Is Professor";
            this.checkBoxIsProfessor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxIsProfessor.UseVisualStyleBackColor = true;
            // 
            // CreateMemberPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxIsProfessor);
            this.Controls.Add(this.textBoxJoinDate);
            this.Controls.Add(this.labelJoinDate);
            this.Controls.Add(this.textBoxCampusAddress);
            this.Controls.Add(this.labelCampusAddress);
            this.Controls.Add(this.buttonCreateMember);
            this.Controls.Add(this.textBoxSSN);
            this.Controls.Add(this.labelSSN);
            this.Name = "CreateMemberPage";
            this.Text = "CreateMemberPage";
            this.Load += new System.EventHandler(this.CreateMemberPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelSSN;
        private TextBox textBoxSSN;
        private Button buttonCreateMember;
        private TextBox textBoxCampusAddress;
        private Label labelCampusAddress;
        private TextBox textBoxJoinDate;
        private Label labelJoinDate;
        private CheckBox checkBoxIsProfessor;
    }
}