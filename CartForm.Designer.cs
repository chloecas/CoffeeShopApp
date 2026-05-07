namespace SweetBeanHomeScreen
{
    partial class CartForm
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
            this.sweatBeanDbDataSet1 = new SweetBeanHomeScreen.SweatBeanDbDataSet();
            this.ordersTableAdapter1 = new SweetBeanHomeScreen.SweatBeanDbDataSetTableAdapters.OrdersTableAdapter();
            this.orderItemsTableAdapter1 = new SweetBeanHomeScreen.SweatBeanDbDataSetTableAdapters.OrderItemsTableAdapter();
            this.titleLabel = new System.Windows.Forms.Label();
            this.accountButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.orderButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.cartRendering1 = new SweetBeanHomeScreen.CartRendering();
            ((System.ComponentModel.ISupportInitialize)(this.sweatBeanDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sweatBeanDbDataSet1
            // 
            this.sweatBeanDbDataSet1.DataSetName = "SweatBeanDbDataSet";
            this.sweatBeanDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // orderItemsTableAdapter1
            // 
            this.orderItemsTableAdapter1.ClearBeforeFill = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(398, 58);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(174, 41);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Checkout";
            // 
            // accountButton
            // 
            this.accountButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accountButton.Image = global::SweetBeanHomeScreen.Properties.Resources.account;
            this.accountButton.Location = new System.Drawing.Point(42, 24);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(99, 94);
            this.accountButton.TabIndex = 1;
            this.accountButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SeaShell;
            this.pictureBox1.Image = global::SweetBeanHomeScreen.Properties.Resources.CoffeShopLogo;
            this.pictureBox1.Location = new System.Drawing.Point(806, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.SeaShell;
            this.richTextBox1.Location = new System.Drawing.Point(0, -4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1009, 153);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cartRendering1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(54, 168);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(699, 480);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // orderButton
            // 
            this.orderButton.BackColor = System.Drawing.Color.RosyBrown;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.orderButton.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.orderButton.Location = new System.Drawing.Point(834, 446);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(89, 65);
            this.orderButton.TabIndex = 5;
            this.orderButton.Text = "Place Order";
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.RosyBrown;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.Location = new System.Drawing.Point(825, 570);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(113, 65);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Continue Shopping";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // cartRendering1
            // 
            this.cartRendering1.BackColor = System.Drawing.Color.RosyBrown;
            this.cartRendering1.Location = new System.Drawing.Point(3, 3);
            this.cartRendering1.Name = "cartRendering1";
            this.cartRendering1.Size = new System.Drawing.Size(695, 474);
            this.cartRendering1.TabIndex = 0;
            // 
            // CartForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1007, 687);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.accountButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.richTextBox1);
            this.Name = "CartForm";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.CartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sweatBeanDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SweatBeanDbDataSet sweatBeanDbDataSet1;
        private SweatBeanDbDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private SweatBeanDbDataSetTableAdapters.OrderItemsTableAdapter orderItemsTableAdapter1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button accountButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CartRendering cartRendering1;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button backButton;
    }
}