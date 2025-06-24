namespace ресторан_проект
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            listBoxMenu = new ListBox();
            listBoxCart = new ListBox();
            labelTotal = new Label();
            buttonPlaceOrder = new Button();
            buttonAddToCart = new Button();
            buttonClearCart = new Button();
            buttonRemoveFromCart = new Button();
            SuspendLayout();
            // 
            // listBoxMenu
            // 
            listBoxMenu.Anchor = AnchorStyles.None;
            listBoxMenu.BackColor = SystemColors.InfoText;
            listBoxMenu.ForeColor = SystemColors.Menu;
            listBoxMenu.FormattingEnabled = true;
            listBoxMenu.Location = new Point(84, 31);
            listBoxMenu.Name = "listBoxMenu";
            listBoxMenu.Size = new Size(640, 104);
            listBoxMenu.TabIndex = 1;
            // 
            // listBoxCart
            // 
            listBoxCart.Anchor = AnchorStyles.None;
            listBoxCart.BackColor = SystemColors.InfoText;
            listBoxCart.ForeColor = SystemColors.Menu;
            listBoxCart.FormattingEnabled = true;
            listBoxCart.Location = new Point(134, 188);
            listBoxCart.Name = "listBoxCart";
            listBoxCart.Size = new Size(243, 104);
            listBoxCart.TabIndex = 2;
            // 
            // labelTotal
            // 
            labelTotal.Anchor = AnchorStyles.None;
            labelTotal.AutoSize = true;
            labelTotal.BackColor = SystemColors.ActiveCaptionText;
            labelTotal.ForeColor = SystemColors.ButtonHighlight;
            labelTotal.Location = new Point(456, 155);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(50, 20);
            labelTotal.TabIndex = 3;
            labelTotal.Text = "label1";
            labelTotal.Visible = false;
            // 
            // buttonPlaceOrder
            // 
            buttonPlaceOrder.Anchor = AnchorStyles.None;
            buttonPlaceOrder.BackColor = SystemColors.ActiveCaptionText;
            buttonPlaceOrder.ForeColor = SystemColors.ControlLightLight;
            buttonPlaceOrder.Location = new Point(430, 251);
            buttonPlaceOrder.Name = "buttonPlaceOrder";
            buttonPlaceOrder.Size = new Size(94, 29);
            buttonPlaceOrder.TabIndex = 4;
            buttonPlaceOrder.Text = "заказать";
            buttonPlaceOrder.UseVisualStyleBackColor = false;
            buttonPlaceOrder.Click += buttonPlaceOrder_Click_1;
            // 
            // buttonAddToCart
            // 
            buttonAddToCart.Anchor = AnchorStyles.None;
            buttonAddToCart.BackColor = SystemColors.ActiveCaptionText;
            buttonAddToCart.ForeColor = SystemColors.ButtonFace;
            buttonAddToCart.Location = new Point(430, 189);
            buttonAddToCart.Name = "buttonAddToCart";
            buttonAddToCart.Size = new Size(94, 29);
            buttonAddToCart.TabIndex = 5;
            buttonAddToCart.Text = "добавить";
            buttonAddToCart.UseVisualStyleBackColor = false;
            buttonAddToCart.Click += buttonAddToCart_Click;
            // 
            // buttonClearCart
            // 
            buttonClearCart.Anchor = AnchorStyles.None;
            buttonClearCart.BackColor = SystemColors.ActiveCaptionText;
            buttonClearCart.ForeColor = SystemColors.ButtonHighlight;
            buttonClearCart.Location = new Point(566, 251);
            buttonClearCart.Name = "buttonClearCart";
            buttonClearCart.Size = new Size(94, 29);
            buttonClearCart.TabIndex = 6;
            buttonClearCart.Text = "очистить";
            buttonClearCart.UseVisualStyleBackColor = false;
            buttonClearCart.Click += buttonClearCart_Click_1;
            // 
            // buttonRemoveFromCart
            // 
            buttonRemoveFromCart.Anchor = AnchorStyles.None;
            buttonRemoveFromCart.BackColor = SystemColors.ActiveCaptionText;
            buttonRemoveFromCart.ForeColor = SystemColors.ButtonHighlight;
            buttonRemoveFromCart.Location = new Point(566, 189);
            buttonRemoveFromCart.Name = "buttonRemoveFromCart";
            buttonRemoveFromCart.Size = new Size(94, 29);
            buttonRemoveFromCart.TabIndex = 7;
            buttonRemoveFromCart.Text = "убрать";
            buttonRemoveFromCart.UseVisualStyleBackColor = false;
            buttonRemoveFromCart.Click += buttonRemoveFromCart_Click_1;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRemoveFromCart);
            Controls.Add(buttonClearCart);
            Controls.Add(buttonAddToCart);
            Controls.Add(buttonPlaceOrder);
            Controls.Add(labelTotal);
            Controls.Add(listBoxCart);
            Controls.Add(listBoxMenu);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MenuForm";
            Text = "Окно клиента";
            WindowState = FormWindowState.Minimized;
            Load += MenuForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCategories;
        private ListBox listBoxMenu;
        private ListBox listBoxCart;
        private Label labelTotal;
        private Button buttonPlaceOrder;
        private Button buttonAddToCart;
        private Button buttonClearCart;
        private Button buttonRemoveFromCart;
    }
}