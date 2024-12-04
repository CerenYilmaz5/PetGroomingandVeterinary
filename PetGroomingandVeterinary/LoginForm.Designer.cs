namespace PetGroomingandVeterinary
{
    partial class LoginForm
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
            userNameLabel = new Label();
            passwordLabel = new Label();
            userNameTextbox = new TextBox();
            passwordTextbox = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(136, 89);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(172, 41);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "UserName: ";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(149, 145);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(150, 41);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password:";
            passwordLabel.Click += passwordLabel_Click;
            // 
            // userNameTextbox
            // 
            userNameTextbox.Location = new Point(314, 89);
            userNameTextbox.Name = "userNameTextbox";
            userNameTextbox.Size = new Size(197, 47);
            userNameTextbox.TabIndex = 2;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(314, 145);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(197, 47);
            passwordTextbox.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(387, 222);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(124, 51);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 351);
            Controls.Add(loginButton);
            Controls.Add(passwordTextbox);
            Controls.Add(userNameTextbox);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Font = new Font("Segoe UI", 18F);
            Margin = new Padding(6);
            Name = "LoginForm";
            Text = "LoginScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNameLabel;
        private Label passwordLabel;
        private TextBox userNameTextbox;
        private TextBox passwordTextbox;
        private Button loginButton;
    }
}