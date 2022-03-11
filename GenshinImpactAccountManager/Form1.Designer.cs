namespace GenshinImpactAccountManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.RegisterButtonLoginPage = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginUsernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegisterButtonLoginPage
            // 
            this.RegisterButtonLoginPage.Location = new System.Drawing.Point(241, 424);
            this.RegisterButtonLoginPage.Name = "RegisterButtonLoginPage";
            this.RegisterButtonLoginPage.Size = new System.Drawing.Size(106, 23);
            this.RegisterButtonLoginPage.TabIndex = 1;
            this.RegisterButtonLoginPage.Text = "Register";
            this.RegisterButtonLoginPage.UseVisualStyleBackColor = true;
            this.RegisterButtonLoginPage.Click += new System.EventHandler(this.RegisterButtonLoginPage_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordLabel.Location = new System.Drawing.Point(162, 340);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(112, 25);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // LoginPasswordTextBox
            // 
            this.LoginPasswordTextBox.Location = new System.Drawing.Point(122, 368);
            this.LoginPasswordTextBox.Name = "LoginPasswordTextBox";
            this.LoginPasswordTextBox.PasswordChar = '●';
            this.LoginPasswordTextBox.Size = new System.Drawing.Size(179, 20);
            this.LoginPasswordTextBox.TabIndex = 5;
            // 
            // LoginUsernameTextBox
            // 
            this.LoginUsernameTextBox.Location = new System.Drawing.Point(122, 301);
            this.LoginUsernameTextBox.Name = "LoginUsernameTextBox";
            this.LoginUsernameTextBox.Size = new System.Drawing.Size(179, 20);
            this.LoginUsernameTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GenshinImpactAccountManager.Properties.Resources.LoginRegisterFormBackground;
            this.ClientSize = new System.Drawing.Size(449, 577);
            this.Controls.Add(this.LoginUsernameTextBox);
            this.Controls.Add(this.LoginPasswordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.RegisterButtonLoginPage);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RegisterButtonLoginPage;
        private System.Windows.Forms.Label PasswordLabel;        
        private System.Windows.Forms.TextBox LoginUsernameTextBox;
        private System.Windows.Forms.TextBox LoginPasswordTextBox;
        private System.Windows.Forms.Label label1;
    }
}