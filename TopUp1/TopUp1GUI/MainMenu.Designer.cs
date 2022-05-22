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
            this.titleMenuButton.Location = new System.Drawing.Point(503, 234);
            this.titleMenuButton.Name = "titleMenuButton";
            this.titleMenuButton.Size = new System.Drawing.Size(94, 29);
            this.titleMenuButton.TabIndex = 0;
            this.titleMenuButton.Text = "Title Menu";
            this.titleMenuButton.UseVisualStyleBackColor = true;
            // 
            // staffMenuButton
            // 
            this.staffMenuButton.Location = new System.Drawing.Point(369, 157);
            this.staffMenuButton.Name = "staffMenuButton";
            this.staffMenuButton.Size = new System.Drawing.Size(94, 29);
            this.staffMenuButton.TabIndex = 1;
            this.staffMenuButton.Text = "Staff Menu";
            this.staffMenuButton.UseVisualStyleBackColor = true;
            // 
            // memberMenuButton
            // 
            this.memberMenuButton.Location = new System.Drawing.Point(212, 201);
            this.memberMenuButton.Name = "memberMenuButton";
            this.memberMenuButton.Size = new System.Drawing.Size(122, 29);
            this.memberMenuButton.TabIndex = 2;
            this.memberMenuButton.Text = "Member Menu";
            this.memberMenuButton.UseVisualStyleBackColor = true;
            this.memberMenuButton.Click += new System.EventHandler(this.memberMenuButton_Click);
            // 
            // borrowBookMenu
            // 
            this.borrowBookMenu.Location = new System.Drawing.Point(82, 145);
            this.borrowBookMenu.Name = "borrowBookMenu";
            this.borrowBookMenu.Size = new System.Drawing.Size(161, 29);
            this.borrowBookMenu.TabIndex = 3;
            this.borrowBookMenu.Text = "Borrow Book Menu";
            this.borrowBookMenu.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.borrowBookMenu);
            this.Controls.Add(this.memberMenuButton);
            this.Controls.Add(this.staffMenuButton);
            this.Controls.Add(this.titleMenuButton);
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