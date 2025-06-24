namespace ресторан_проект
{
    partial class сook
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
            listBoxOnlineOrders = new ListBox();
            listBoxOfflineOrders = new ListBox();
            btnCompleteOnline = new Button();
            btnCompleteOffline = new Button();
            SuspendLayout();
            // 
            // listBoxOnlineOrders
            // 
            listBoxOnlineOrders.Anchor = AnchorStyles.None;
            listBoxOnlineOrders.BackColor = SystemColors.ActiveCaptionText;
            listBoxOnlineOrders.ForeColor = SystemColors.Control;
            listBoxOnlineOrders.FormattingEnabled = true;
            listBoxOnlineOrders.Location = new Point(34, 100);
            listBoxOnlineOrders.Name = "listBoxOnlineOrders";
            listBoxOnlineOrders.Size = new Size(307, 104);
            listBoxOnlineOrders.TabIndex = 0;
            // 
            // listBoxOfflineOrders
            // 
            listBoxOfflineOrders.Anchor = AnchorStyles.None;
            listBoxOfflineOrders.BackColor = SystemColors.ActiveCaptionText;
            listBoxOfflineOrders.ForeColor = SystemColors.Control;
            listBoxOfflineOrders.FormattingEnabled = true;
            listBoxOfflineOrders.Location = new Point(466, 100);
            listBoxOfflineOrders.Name = "listBoxOfflineOrders";
            listBoxOfflineOrders.Size = new Size(305, 104);
            listBoxOfflineOrders.TabIndex = 1;
            // 
            // btnCompleteOnline
            // 
            btnCompleteOnline.Anchor = AnchorStyles.None;
            btnCompleteOnline.BackColor = SystemColors.ActiveCaptionText;
            btnCompleteOnline.ForeColor = SystemColors.Control;
            btnCompleteOnline.Location = new Point(34, 237);
            btnCompleteOnline.Name = "btnCompleteOnline";
            btnCompleteOnline.Size = new Size(181, 29);
            btnCompleteOnline.TabIndex = 2;
            btnCompleteOnline.Text = "отметки о выполнении";
            btnCompleteOnline.UseVisualStyleBackColor = false;
            btnCompleteOnline.Click += btnCompleteOnline_Click_1;
            // 
            // btnCompleteOffline
            // 
            btnCompleteOffline.Anchor = AnchorStyles.None;
            btnCompleteOffline.BackColor = SystemColors.ActiveCaptionText;
            btnCompleteOffline.ForeColor = SystemColors.Control;
            btnCompleteOffline.Location = new Point(466, 237);
            btnCompleteOffline.Name = "btnCompleteOffline";
            btnCompleteOffline.Size = new Size(182, 29);
            btnCompleteOffline.TabIndex = 3;
            btnCompleteOffline.Text = "отметки о выполнении";
            btnCompleteOffline.UseVisualStyleBackColor = false;
            btnCompleteOffline.Click += btnCompleteOffline_Click_1;
            // 
            // сook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.нарисуй_кухню_в_ресторане_японию_в_будущем__Kandinsky_33;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCompleteOffline);
            Controls.Add(btnCompleteOnline);
            Controls.Add(listBoxOfflineOrders);
            Controls.Add(listBoxOnlineOrders);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "сook";
            Text = "Cookcs";
            Load += сook_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxOnlineOrders;
        private ListBox listBoxOfflineOrders;
        private Button btnCompleteOnline;
        private Button btnCompleteOffline;
    }
}