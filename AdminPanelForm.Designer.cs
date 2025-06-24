namespace ресторан_проект
{
    partial class AdminPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            listBoxUsers = new ListBox();
            buttonAddEmployee = new Button();
            buttonAddAdmin = new Button();
            buttonSearchUser = new Button();
            buttonDeleteUser = new Button();
            SuspendLayout();
            // 
            // listBoxUsers
            // 
            listBoxUsers.Anchor = AnchorStyles.None;
            listBoxUsers.BackColor = SystemColors.InfoText;
            listBoxUsers.ForeColor = SystemColors.Menu;
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.Location = new Point(34, 34);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(150, 104);
            listBoxUsers.TabIndex = 0;
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.Anchor = AnchorStyles.None;
            buttonAddEmployee.BackColor = SystemColors.ActiveCaptionText;
            buttonAddEmployee.ForeColor = SystemColors.ButtonFace;
            buttonAddEmployee.Location = new Point(12, 159);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(182, 29);
            buttonAddEmployee.TabIndex = 1;
            buttonAddEmployee.Text = "Добавить сотрудника";
            buttonAddEmployee.UseVisualStyleBackColor = false;
            buttonAddEmployee.Click += buttonAddEmployee_Click_1;
            // 
            // buttonAddAdmin
            // 
            buttonAddAdmin.Anchor = AnchorStyles.None;
            buttonAddAdmin.BackColor = SystemColors.ActiveCaptionText;
            buttonAddAdmin.ForeColor = SystemColors.ButtonFace;
            buttonAddAdmin.Location = new Point(12, 207);
            buttonAddAdmin.Name = "buttonAddAdmin";
            buttonAddAdmin.Size = new Size(182, 29);
            buttonAddAdmin.TabIndex = 2;
            buttonAddAdmin.Text = "Добавить админа";
            buttonAddAdmin.UseVisualStyleBackColor = false;
            buttonAddAdmin.Click += buttonAddAdmin_Click_1;
            // 
            // buttonSearchUser
            // 
            buttonSearchUser.Anchor = AnchorStyles.None;
            buttonSearchUser.BackColor = SystemColors.ActiveCaptionText;
            buttonSearchUser.ForeColor = SystemColors.ButtonFace;
            buttonSearchUser.Location = new Point(12, 256);
            buttonSearchUser.Name = "buttonSearchUser";
            buttonSearchUser.Size = new Size(182, 29);
            buttonSearchUser.TabIndex = 3;
            buttonSearchUser.Text = "найти пользователя";
            buttonSearchUser.UseVisualStyleBackColor = false;
            buttonSearchUser.Click += buttonSearchUser_Click_1;
            // 
            // buttonDeleteUser
            // 
            buttonDeleteUser.Anchor = AnchorStyles.None;
            buttonDeleteUser.BackColor = SystemColors.ActiveCaptionText;
            buttonDeleteUser.ForeColor = SystemColors.ButtonFace;
            buttonDeleteUser.Location = new Point(12, 303);
            buttonDeleteUser.Name = "buttonDeleteUser";
            buttonDeleteUser.Size = new Size(182, 29);
            buttonDeleteUser.TabIndex = 4;
            buttonDeleteUser.Text = "удалить пользователя";
            buttonDeleteUser.UseVisualStyleBackColor = false;
            buttonDeleteUser.Click += buttonDeleteUser_Click_1;
            // 
            // AdminPanelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDeleteUser);
            Controls.Add(buttonSearchUser);
            Controls.Add(buttonAddAdmin);
            Controls.Add(buttonAddEmployee);
            Controls.Add(listBoxUsers);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminPanelForm";
            Text = "Окно админа";
            WindowState = FormWindowState.Minimized;
            Load += AdminPanelForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxUsers;
        private Button buttonAddEmployee;
        private Button buttonAddAdmin;
        private Button buttonSearchUser;
        private Button buttonDeleteUser;
    }
}