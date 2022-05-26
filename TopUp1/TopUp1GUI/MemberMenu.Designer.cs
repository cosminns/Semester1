namespace TopUp1GUI
{
    partial class MemberMenu
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
            this.createMemberButton = new System.Windows.Forms.Button();
            this.getMemberInfoButton = new System.Windows.Forms.Button();
            this.memberSSNTextField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createMemberButton
            // 
            this.createMemberButton.Location = new System.Drawing.Point(108, 95);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(111, 29);
            this.createMemberButton.TabIndex = 0;
            this.createMemberButton.Text = "Add Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            this.createMemberButton.Click += new System.EventHandler(this.createMemberButton_Click);
            // 
            // getMemberInfoButton
            // 
            this.getMemberInfoButton.Location = new System.Drawing.Point(285, 95);
            this.getMemberInfoButton.Name = "getMemberInfoButton";
            this.getMemberInfoButton.Size = new System.Drawing.Size(156, 29);
            this.getMemberInfoButton.TabIndex = 3;
            this.getMemberInfoButton.Text = "Get Member Info";
            this.getMemberInfoButton.UseVisualStyleBackColor = true;
            this.getMemberInfoButton.Click += new System.EventHandler(this.getMemberInfoButton_Click);
            // 
            // memberSSNTextField
            // 
            this.memberSSNTextField.Location = new System.Drawing.Point(285, 141);
            this.memberSSNTextField.Name = "memberSSNTextField";
            this.memberSSNTextField.PlaceholderText = "Put Member SSN here";
            this.memberSSNTextField.Size = new System.Drawing.Size(153, 27);
            this.memberSSNTextField.TabIndex = 4;
            // 
            // MemberMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.memberSSNTextField);
            this.Controls.Add(this.getMemberInfoButton);
            this.Controls.Add(this.createMemberButton);
            this.Name = "MemberMenu";
            this.Text = "MemberMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button createMemberButton;
        private Button getMemberInfoButton;
        private TextBox memberSSNTextField;
    }
}