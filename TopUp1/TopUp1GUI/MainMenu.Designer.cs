namespace TopUp1GUI
{
    partial class MainMenu
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
            this.titleMenuButton = new System.Windows.Forms.Button();
            this.staffMenuButton = new System.Windows.Forms.Button();
            this.memberMenuButton = new System.Windows.Forms.Button();
            this.borrowBookMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleMenuButton
            // 
            this.titleMenuButton.Location = new System.Drawing.Point(440, 176);
            this.titleMenuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleMenuButton.Name = "titleMenuButton";
            this.titleMenuButton.Size = new System.Drawing.Size(82, 22);
            this.titleMenuButton.TabIndex = 0;
            this.titleMenuButton.Text = "Title Menu";
            this.titleMenuButton.UseVisualStyleBackColor = true;
            this.titleMenuButton.Click += new System.EventHandler(this.titleMenuButton_Click);
            // 
            // staffMenuButton
            // 
            this.staffMenuButton.Location = new System.Drawing.Point(323, 118);
            this.staffMenuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.staffMenuButton.Name = "staffMenuButton";
            this.staffMenuButton.Size = new System.Drawing.Size(82, 22);
            this.staffMenuButton.TabIndex = 1;
            this.staffMenuButton.Text = "Staff Menu";
            this.staffMenuButton.UseVisualStyleBackColor = true;
            this.staffMenuButton.Click += new System.EventHandler(this.staffMenuButton_Click);
            // 
            // memberMenuButton
            // 
            this.memberMenuButton.Location = new System.Drawing.Point(186, 151);
            this.memberMenuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memberMenuButton.Name = "memberMenuButton";
            this.memberMenuButton.Size = new System.Drawing.Size(107, 22);
            this.memberMenuButton.TabIndex = 2;
            this.memberMenuButton.Text = "Member Menu";
            this.memberMenuButton.UseVisualStyleBackColor = true;
            this.memberMenuButton.Click += new System.EventHandler(this.memberMenuButton_Click);
            // 
            // borrowBookMenu
            // 
            this.borrowBookMenu.Location = new System.Drawing.Point(72, 109);
            this.borrowBookMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.borrowBookMenu.Name = "borrowBookMenu";
            this.borrowBookMenu.Size = new System.Drawing.Size(141, 22);
            this.borrowBookMenu.TabIndex = 3;
            this.borrowBookMenu.Text = "Borrow Book Menu";
            this.borrowBookMenu.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.borrowBookMenu);
            this.Controls.Add(this.memberMenuButton);
            this.Controls.Add(this.staffMenuButton);
            this.Controls.Add(this.titleMenuButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button titleMenuButton;
        private Button staffMenuButton;
        private Button memberMenuButton;
        private Button borrowBookMenu;
    }
}