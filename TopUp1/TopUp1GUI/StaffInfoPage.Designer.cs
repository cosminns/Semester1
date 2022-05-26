namespace TopUp1GUI
{
    partial class StaffInfoPage
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
            this.textBoxSSN = new System.Windows.Forms.TextBox();
            this.labelSSN = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelHomeAddress = new System.Windows.Forms.Label();
            this.textBoxHAddress = new System.Windows.Forms.TextBox();
            this.labelDoB = new System.Windows.Forms.Label();
            this.textBoxDoB = new System.Windows.Forms.TextBox();
            this.labelRoleName = new System.Windows.Forms.Label();
            this.textRole = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSSN
            // 
            this.textBoxSSN.Location = new System.Drawing.Point(112, 60);
            this.textBoxSSN.Name = "textBoxSSN";
            this.textBoxSSN.Size = new System.Drawing.Size(100, 23);
            this.textBoxSSN.TabIndex = 0;
            // 
            // labelSSN
            // 
            this.labelSSN.AutoSize = true;
            this.labelSSN.Location = new System.Drawing.Point(52, 60);
            this.labelSSN.Name = "labelSSN";
            this.labelSSN.Size = new System.Drawing.Size(28, 15);
            this.labelSSN.TabIndex = 1;
            this.labelSSN.Text = "SSN";
            this.labelSSN.Click += new System.EventHandler(this.labelSSN_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(52, 89);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 15);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(112, 89);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 3;
            // 
            // labelHomeAddress
            // 
            this.labelHomeAddress.AutoSize = true;
            this.labelHomeAddress.Location = new System.Drawing.Point(21, 121);
            this.labelHomeAddress.Name = "labelHomeAddress";
            this.labelHomeAddress.Size = new System.Drawing.Size(85, 15);
            this.labelHomeAddress.TabIndex = 5;
            this.labelHomeAddress.Text = "Home Address";
            // 
            // textBoxHAddress
            // 
            this.textBoxHAddress.Location = new System.Drawing.Point(112, 118);
            this.textBoxHAddress.Name = "textBoxHAddress";
            this.textBoxHAddress.Size = new System.Drawing.Size(100, 23);
            this.textBoxHAddress.TabIndex = 4;
            // 
            // labelDoB
            // 
            this.labelDoB.AutoSize = true;
            this.labelDoB.Location = new System.Drawing.Point(53, 148);
            this.labelDoB.Name = "labelDoB";
            this.labelDoB.Size = new System.Drawing.Size(29, 15);
            this.labelDoB.TabIndex = 7;
            this.labelDoB.Text = "DoB";
            // 
            // textBoxDoB
            // 
            this.textBoxDoB.Location = new System.Drawing.Point(112, 147);
            this.textBoxDoB.Name = "textBoxDoB";
            this.textBoxDoB.Size = new System.Drawing.Size(100, 23);
            this.textBoxDoB.TabIndex = 6;
            // 
            // labelRoleName
            // 
            this.labelRoleName.AutoSize = true;
            this.labelRoleName.Location = new System.Drawing.Point(53, 177);
            this.labelRoleName.Name = "labelRoleName";
            this.labelRoleName.Size = new System.Drawing.Size(30, 15);
            this.labelRoleName.TabIndex = 9;
            this.labelRoleName.Text = "Role";
            // 
            // textRole
            // 
            this.textRole.Location = new System.Drawing.Point(112, 176);
            this.textRole.Name = "textRole";
            this.textRole.Size = new System.Drawing.Size(100, 23);
            this.textRole.TabIndex = 8;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(273, 250);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(112, 250);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // StaffInfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelRoleName);
            this.Controls.Add(this.textRole);
            this.Controls.Add(this.labelDoB);
            this.Controls.Add(this.textBoxDoB);
            this.Controls.Add(this.labelHomeAddress);
            this.Controls.Add(this.textBoxHAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSSN);
            this.Controls.Add(this.textBoxSSN);
            this.Name = "StaffInfoPage";
            this.Text = "StaffInfoPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxSSN;
        private Label labelSSN;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelHomeAddress;
        private TextBox textBoxHAddress;
        private Label labelDoB;
        private TextBox textBoxDoB;
        private Label labelRoleName;
        private TextBox textRole;
        private Button buttonDelete;
        private Button buttonUpdate;
    }
}