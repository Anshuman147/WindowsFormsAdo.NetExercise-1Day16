
namespace WindowsFormsAdo.NetExercise_1Day16
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
            this.LabelLoginPage = new System.Windows.Forms.Label();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.TextBoxUserName = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.ButtonSignIn = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelLoginPage
            // 
            this.LabelLoginPage.AutoSize = true;
            this.LabelLoginPage.Location = new System.Drawing.Point(279, 18);
            this.LabelLoginPage.Name = "LabelLoginPage";
            this.LabelLoginPage.Size = new System.Drawing.Size(108, 20);
            this.LabelLoginPage.TabIndex = 0;
            this.LabelLoginPage.Text = "LOGIN PAGE";
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.Location = new System.Drawing.Point(128, 125);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(132, 20);
            this.LabelUserName.TabIndex = 1;
            this.LabelUserName.Text = "User Name/Email";
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Location = new System.Drawing.Point(307, 125);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(267, 26);
            this.TextBoxUserName.TabIndex = 2;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(307, 189);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(267, 26);
            this.TextBoxPassword.TabIndex = 4;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(128, 189);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(78, 20);
            this.LabelPassword.TabIndex = 3;
            this.LabelPassword.Text = "Password";
            // 
            // ButtonSignIn
            // 
            this.ButtonSignIn.Location = new System.Drawing.Point(132, 277);
            this.ButtonSignIn.Name = "ButtonSignIn";
            this.ButtonSignIn.Size = new System.Drawing.Size(79, 42);
            this.ButtonSignIn.TabIndex = 5;
            this.ButtonSignIn.Text = "SIGN IN";
            this.ButtonSignIn.UseVisualStyleBackColor = true;
            this.ButtonSignIn.Click += new System.EventHandler(this.ButtonSignIn_Click);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Location = new System.Drawing.Point(362, 277);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(78, 42);
            this.ButtonReset.TabIndex = 6;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 561);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonSignIn);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.TextBoxUserName);
            this.Controls.Add(this.LabelUserName);
            this.Controls.Add(this.LabelLoginPage);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelLoginPage;
        private System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.TextBox TextBoxUserName;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Button ButtonSignIn;
        private System.Windows.Forms.Button ButtonReset;
    }
}