namespace ресторан_проект
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            registerButton = new Button();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.None;
            usernameTextBox.BackColor = SystemColors.InfoText;
            usernameTextBox.ForeColor = SystemColors.Menu;
            usernameTextBox.Location = new Point(328, 146);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(125, 27);
            usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.None;
            passwordTextBox.BackColor = SystemColors.InfoText;
            passwordTextBox.ForeColor = SystemColors.Menu;
            passwordTextBox.Location = new Point(328, 200);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(125, 27);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // registerButton
            // 
            registerButton.Anchor = AnchorStyles.None;
            registerButton.BackColor = SystemColors.ActiveCaptionText;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.ForeColor = SystemColors.ButtonFace;
            registerButton.Location = new Point(328, 255);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(125, 29);
            registerButton.TabIndex = 2;
            registerButton.Text = "регистрация ";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click_1;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(registerButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Cursor = Cursors.Hand;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            Text = "Окно регистрации";
            WindowState = FormWindowState.Minimized;
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button registerButton;
    }
}