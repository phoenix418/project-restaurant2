namespace ресторан_проект
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            registerButton = new Button();
            adress = new Label();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.None;
            usernameTextBox.BackColor = SystemColors.ActiveCaptionText;
            usernameTextBox.ForeColor = SystemColors.Control;
            usernameTextBox.Location = new Point(296, 139);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(211, 27);
            usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.None;
            passwordTextBox.BackColor = SystemColors.ActiveCaptionText;
            passwordTextBox.ForeColor = SystemColors.Control;
            passwordTextBox.Location = new Point(296, 188);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(211, 27);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.None;
            loginButton.BackColor = SystemColors.ControlText;
            loginButton.BackgroundImage = (Image)resources.GetObject("loginButton.BackgroundImage");
            loginButton.BackgroundImageLayout = ImageLayout.Stretch;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.ForeColor = SystemColors.ButtonFace;
            loginButton.Location = new Point(332, 239);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(145, 39);
            loginButton.TabIndex = 2;
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click_1;
            // 
            // registerButton
            // 
            registerButton.Anchor = AnchorStyles.None;
            registerButton.BackColor = SystemColors.ActiveCaptionText;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.ForeColor = SystemColors.ButtonFace;
            registerButton.Location = new Point(332, 297);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(145, 42);
            registerButton.TabIndex = 3;
            registerButton.Text = "регистрация";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click_1;
            // 
            // adress
            // 
            adress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            adress.AutoSize = true;
            adress.Font = new Font("Segoe UI", 9F);
            adress.ForeColor = SystemColors.ControlLight;
            adress.Location = new Point(32, 421);
            adress.Name = "adress";
            adress.Size = new Size(50, 20);
            adress.TabIndex = 4;
            adress.Text = "label1";
            adress.Click += label1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(adress);
            Controls.Add(registerButton);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            Text = "Окно входа";
            WindowState = FormWindowState.Minimized;
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Button registerButton;
        private Label adress;
    }
}
