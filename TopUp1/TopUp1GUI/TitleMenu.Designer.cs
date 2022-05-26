namespace TopUp1GUI
{
    partial class TitleMenu
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
            this.buttonGetInfoByISBM = new System.Windows.Forms.Button();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGetInfoByISBM
            // 
            this.buttonGetInfoByISBM.Location = new System.Drawing.Point(335, 110);
            this.buttonGetInfoByISBM.Name = "buttonGetInfoByISBM";
            this.buttonGetInfoByISBM.Size = new System.Drawing.Size(108, 23);
            this.buttonGetInfoByISBM.TabIndex = 0;
            this.buttonGetInfoByISBM.Text = "Get Title Info";
            this.buttonGetInfoByISBM.UseVisualStyleBackColor = true;
            this.buttonGetInfoByISBM.Click += new System.EventHandler(this.buttonGetInfoByISBM_Click);
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(335, 148);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.PlaceholderText = "Put  title ISBN here";
            this.textBoxISBN.Size = new System.Drawing.Size(108, 23);
            this.textBoxISBN.TabIndex = 1;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(95, 148);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(103, 23);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Create new Title";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // TitleMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.buttonGetInfoByISBM);
            this.Name = "TitleMenu";
            this.Text = "TitleMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonGetInfoByISBM;
        private TextBox textBoxISBN;
        private Button buttonCreate;
    }
}