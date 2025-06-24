namespace ресторан_проект
{
    partial class Teller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teller));
            listBoxOrders = new ListBox();
            buttonAddOrder = new Button();
            buttonSearchOrder = new Button();
            buttonDeleteOrder = new Button();
            listBoxOrdersonl = new ListBox();
            label1 = new Label();
            listBoxOnlineOrders = new ListBox();
            listBoxOfflineOrders = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // listBoxOrders
            // 
            listBoxOrders.Anchor = AnchorStyles.None;
            listBoxOrders.BackColor = SystemColors.InfoText;
            listBoxOrders.ForeColor = SystemColors.Menu;
            listBoxOrders.FormattingEnabled = true;
            listBoxOrders.Location = new Point(97, 32);
            listBoxOrders.Name = "listBoxOrders";
            listBoxOrders.Size = new Size(225, 104);
            listBoxOrders.TabIndex = 0;
            listBoxOrders.SelectedIndexChanged += listBoxOrders_SelectedIndexChanged;
            // 
            // buttonAddOrder
            // 
            buttonAddOrder.Anchor = AnchorStyles.None;
            buttonAddOrder.BackColor = SystemColors.ActiveCaptionText;
            buttonAddOrder.ForeColor = SystemColors.ButtonFace;
            buttonAddOrder.Location = new Point(124, 156);
            buttonAddOrder.Name = "buttonAddOrder";
            buttonAddOrder.Size = new Size(150, 29);
            buttonAddOrder.TabIndex = 1;
            buttonAddOrder.Text = "добавить заказ";
            buttonAddOrder.UseVisualStyleBackColor = false;
            buttonAddOrder.Click += buttonAddOrder_Click;
            // 
            // buttonSearchOrder
            // 
            buttonSearchOrder.Anchor = AnchorStyles.None;
            buttonSearchOrder.BackColor = SystemColors.ActiveCaptionText;
            buttonSearchOrder.ForeColor = SystemColors.ButtonHighlight;
            buttonSearchOrder.Location = new Point(124, 216);
            buttonSearchOrder.Name = "buttonSearchOrder";
            buttonSearchOrder.Size = new Size(150, 29);
            buttonSearchOrder.TabIndex = 2;
            buttonSearchOrder.Text = "редактировать";
            buttonSearchOrder.UseVisualStyleBackColor = false;
            buttonSearchOrder.Click += button1_Click;
            // 
            // buttonDeleteOrder
            // 
            buttonDeleteOrder.Anchor = AnchorStyles.None;
            buttonDeleteOrder.BackColor = SystemColors.ActiveCaptionText;
            buttonDeleteOrder.ForeColor = SystemColors.ButtonHighlight;
            buttonDeleteOrder.Location = new Point(124, 278);
            buttonDeleteOrder.Name = "buttonDeleteOrder";
            buttonDeleteOrder.Size = new Size(150, 29);
            buttonDeleteOrder.TabIndex = 3;
            buttonDeleteOrder.Text = "удалить заказ";
            buttonDeleteOrder.UseVisualStyleBackColor = false;
            buttonDeleteOrder.Click += button2_Click;
            // 
            // listBoxOrdersonl
            // 
            listBoxOrdersonl.Anchor = AnchorStyles.None;
            listBoxOrdersonl.BackColor = SystemColors.InfoText;
            listBoxOrdersonl.ForeColor = SystemColors.Menu;
            listBoxOrdersonl.FormattingEnabled = true;
            listBoxOrdersonl.Location = new Point(542, 32);
            listBoxOrdersonl.Name = "listBoxOrdersonl";
            listBoxOrdersonl.Size = new Size(317, 104);
            listBoxOrdersonl.TabIndex = 4;
            listBoxOrdersonl.SelectedIndexChanged += listBoxOrdersonl_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(640, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 5;
            label1.Text = "онлайн заказы ";
            // 
            // listBoxOnlineOrders
            // 
            listBoxOnlineOrders.Anchor = AnchorStyles.None;
            listBoxOnlineOrders.BackColor = SystemColors.InfoText;
            listBoxOnlineOrders.ForeColor = SystemColors.Menu;
            listBoxOnlineOrders.FormattingEnabled = true;
            listBoxOnlineOrders.Location = new Point(558, 181);
            listBoxOnlineOrders.Name = "listBoxOnlineOrders";
            listBoxOnlineOrders.Size = new Size(225, 104);
            listBoxOnlineOrders.TabIndex = 6;
            listBoxOnlineOrders.SelectedIndexChanged += listBoxOnlineOrders_SelectedIndexChanged;
            // 
            // listBoxOfflineOrders
            // 
            listBoxOfflineOrders.Anchor = AnchorStyles.None;
            listBoxOfflineOrders.BackColor = SystemColors.InfoText;
            listBoxOfflineOrders.ForeColor = SystemColors.Menu;
            listBoxOfflineOrders.FormattingEnabled = true;
            listBoxOfflineOrders.Location = new Point(558, 311);
            listBoxOfflineOrders.Name = "listBoxOfflineOrders";
            listBoxOfflineOrders.Size = new Size(225, 104);
            listBoxOfflineOrders.TabIndex = 7;
            listBoxOfflineOrders.SelectedIndexChanged += listBoxOfflineOrders_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(558, 139);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 8;
            label2.Text = "выполненые заказы ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(558, 160);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 9;
            label3.Text = "онлайн ";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(558, 288);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 10;
            label4.Text = "в ресторане ";
            label4.Click += label4_Click;
            // 
            // Teller
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 427);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBoxOfflineOrders);
            Controls.Add(listBoxOnlineOrders);
            Controls.Add(label1);
            Controls.Add(listBoxOrdersonl);
            Controls.Add(buttonDeleteOrder);
            Controls.Add(buttonSearchOrder);
            Controls.Add(buttonAddOrder);
            Controls.Add(listBoxOrders);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Teller";
            Text = "Form1";
            WindowState = FormWindowState.Minimized;
            Load += Teller_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxOrders;
        private Button buttonAddOrder;
        private Button button1;
        private Button button2;
        private Button buttonSearchOrder;
        private Button buttonDeleteOrder;
        private ListBox listBoxOrdersonl;
        private Label label1;
        private ListBox listBoxOnlineOrders;
        private ListBox listBoxOfflineOrders;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}