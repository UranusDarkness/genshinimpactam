namespace GenshinImpactAccountManager
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.RegisterUsernameTextBox = new System.Windows.Forms.TextBox();
            this.RegisterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.RegisterButtonLoginPage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RegisterEmailTextBox = new System.Windows.Forms.TextBox();
            this.RegisterSerialKeyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegisterUsernameTextBox
            // 
            this.RegisterUsernameTextBox.Location = new System.Drawing.Point(130, 259);
            this.RegisterUsernameTextBox.Name = "RegisterUsernameTextBox";
            this.RegisterUsernameTextBox.Size = new System.Drawing.Size(179, 20);
            this.RegisterUsernameTextBox.TabIndex = 6;
            // 
            // RegisterPasswordTextBox
            // 
            this.RegisterPasswordTextBox.Location = new System.Drawing.Point(130, 326);
            this.RegisterPasswordTextBox.Name = "RegisterPasswordTextBox";
            this.RegisterPasswordTextBox.PasswordChar = '●';
            this.RegisterPasswordTextBox.Size = new System.Drawing.Size(179, 20);
            this.RegisterPasswordTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(170, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordLabel.Location = new System.Drawing.Point(170, 298);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(112, 25);
            this.PasswordLabel.TabIndex = 9;
            this.PasswordLabel.Text = "Password";
            // 
            // RegisterButtonLoginPage
            // 
            this.RegisterButtonLoginPage.Location = new System.Drawing.Point(98, 524);
            this.RegisterButtonLoginPage.Name = "RegisterButtonLoginPage";
            this.RegisterButtonLoginPage.Size = new System.Drawing.Size(106, 23);
            this.RegisterButtonLoginPage.TabIndex = 10;
            this.RegisterButtonLoginPage.Text = "Register";
            this.RegisterButtonLoginPage.UseVisualStyleBackColor = true;
            this.RegisterButtonLoginPage.Click += new System.EventHandler(this.RegisterButtonLoginPage_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Back to login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegisterEmailTextBox
            // 
            this.RegisterEmailTextBox.Location = new System.Drawing.Point(130, 396);
            this.RegisterEmailTextBox.Name = "RegisterEmailTextBox";
            this.RegisterEmailTextBox.Size = new System.Drawing.Size(179, 20);
            this.RegisterEmailTextBox.TabIndex = 8;
            // 
            // RegisterSerialKeyTextBox
            // 
            this.RegisterSerialKeyTextBox.Location = new System.Drawing.Point(130, 463);
            this.RegisterSerialKeyTextBox.Name = "RegisterSerialKeyTextBox";
            this.RegisterSerialKeyTextBox.Size = new System.Drawing.Size(179, 20);
            this.RegisterSerialKeyTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(188, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(170, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Serial Key";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GenshinImpactAccountManager.Properties.Resources.LoginRegisterFormBackground;
            this.ClientSize = new System.Drawing.Size(450, 577);
            this.Controls.Add(this.RegisterEmailTextBox);
            this.Controls.Add(this.RegisterSerialKeyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RegisterUsernameTextBox);
            this.Controls.Add(this.RegisterPasswordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.RegisterButtonLoginPage);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RegisterUsernameTextBox;
        private System.Windows.Forms.TextBox RegisterPasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button RegisterButtonLoginPage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox RegisterEmailTextBox;
        private System.Windows.Forms.TextBox RegisterSerialKeyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}