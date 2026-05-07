namespace SweetBeanHomeScreen
{
    partial class CartRendering
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartRendering));
            this.cartLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cartItemsListView = new System.Windows.Forms.ListView();
            this.orderLabel = new System.Windows.Forms.Label();
            this.deliveryRadioButton = new System.Windows.Forms.RadioButton();
            this.pickUpRadioButton = new System.Windows.Forms.RadioButton();
            this.taxLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalDisplayLabel = new System.Windows.Forms.Label();
            this.gstLabel = new System.Windows.Forms.Label();
            this.qstLabel = new System.Windows.Forms.Label();
            this.feeLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartLabel
            // 
            this.cartLabel.AutoSize = true;
            this.cartLabel.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cartLabel.Location = new System.Drawing.Point(246, 19);
            this.cartLabel.Name = "cartLabel";
            this.cartLabel.Size = new System.Drawing.Size(127, 30);
            this.cartLabel.TabIndex = 0;
            this.cartLabel.Text = "Your Cart";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cartItemsListView);
            this.panel1.Location = new System.Drawing.Point(50, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 252);
            this.panel1.TabIndex = 1;
            // 
            // cartItemsListView
            // 
            this.cartItemsListView.BackColor = System.Drawing.Color.MistyRose;
            this.cartItemsListView.FullRowSelect = true;
            this.cartItemsListView.GridLines = true;
            this.cartItemsListView.HideSelection = false;
            this.cartItemsListView.Location = new System.Drawing.Point(-3, -3);
            this.cartItemsListView.Name = "cartItemsListView";
            this.cartItemsListView.Size = new System.Drawing.Size(586, 252);
            this.cartItemsListView.TabIndex = 0;
            this.cartItemsListView.UseCompatibleStateImageBehavior = false;
            this.cartItemsListView.View = System.Windows.Forms.View.Details;
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.orderLabel.Location = new System.Drawing.Point(46, 353);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(100, 21);
            this.orderLabel.TabIndex = 2;
            this.orderLabel.Text = "Order Type";
            // 
            // deliveryRadioButton
            // 
            this.deliveryRadioButton.AutoSize = true;
            this.deliveryRadioButton.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deliveryRadioButton.Location = new System.Drawing.Point(50, 377);
            this.deliveryRadioButton.Name = "deliveryRadioButton";
            this.deliveryRadioButton.Size = new System.Drawing.Size(93, 25);
            this.deliveryRadioButton.TabIndex = 3;
            this.deliveryRadioButton.TabStop = true;
            this.deliveryRadioButton.Text = "Delivery";
            this.deliveryRadioButton.UseVisualStyleBackColor = true;
            this.deliveryRadioButton.CheckedChanged += new System.EventHandler(this.deliveryRadioButton_CheckedChanged);
            // 
            // pickUpRadioButton
            // 
            this.pickUpRadioButton.AutoSize = true;
            this.pickUpRadioButton.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickUpRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pickUpRadioButton.Location = new System.Drawing.Point(50, 408);
            this.pickUpRadioButton.Name = "pickUpRadioButton";
            this.pickUpRadioButton.Size = new System.Drawing.Size(91, 25);
            this.pickUpRadioButton.TabIndex = 4;
            this.pickUpRadioButton.TabStop = true;
            this.pickUpRadioButton.Text = "Pick Up";
            this.pickUpRadioButton.UseVisualStyleBackColor = true;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(285, 357);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(77, 20);
            this.taxLabel.TabIndex = 5;
            this.taxLabel.Text = "GST 5%:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "QST 9%:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Delivery Fees:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(511, 349);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(111, 25);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "Order Total";
            // 
            // totalDisplayLabel
            // 
            this.totalDisplayLabel.AutoSize = true;
            this.totalDisplayLabel.Location = new System.Drawing.Point(545, 389);
            this.totalDisplayLabel.Name = "totalDisplayLabel";
            this.totalDisplayLabel.Size = new System.Drawing.Size(44, 16);
            this.totalDisplayLabel.TabIndex = 9;
            this.totalDisplayLabel.Text = "label3";
            // 
            // gstLabel
            // 
            this.gstLabel.AutoSize = true;
            this.gstLabel.Location = new System.Drawing.Point(387, 361);
            this.gstLabel.Name = "gstLabel";
            this.gstLabel.Size = new System.Drawing.Size(44, 16);
            this.gstLabel.TabIndex = 10;
            this.gstLabel.Text = "label3";
            // 
            // qstLabel
            // 
            this.qstLabel.AutoSize = true;
            this.qstLabel.Location = new System.Drawing.Point(387, 389);
            this.qstLabel.Name = "qstLabel";
            this.qstLabel.Size = new System.Drawing.Size(44, 16);
            this.qstLabel.TabIndex = 11;
            this.qstLabel.Text = "label4";
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Location = new System.Drawing.Point(423, 414);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(44, 16);
            this.feeLabel.TabIndex = 12;
            this.feeLabel.Text = "label5";
            // 
            // removeButton
            // 
            this.removeButton.Image = ((System.Drawing.Image)(resources.GetObject("removeButton.Image")));
            this.removeButton.Location = new System.Drawing.Point(639, 108);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(53, 61);
            this.removeButton.TabIndex = 13;
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // CartRendering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.feeLabel);
            this.Controls.Add(this.qstLabel);
            this.Controls.Add(this.gstLabel);
            this.Controls.Add(this.totalDisplayLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.pickUpRadioButton);
            this.Controls.Add(this.deliveryRadioButton);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cartLabel);
            this.Name = "CartRendering";
            this.Size = new System.Drawing.Size(698, 474);
            this.Load += new System.EventHandler(this.CartRendering_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.RadioButton deliveryRadioButton;
        private System.Windows.Forms.RadioButton pickUpRadioButton;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView cartItemsListView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalDisplayLabel;
        private System.Windows.Forms.Label gstLabel;
        private System.Windows.Forms.Label qstLabel;
        private System.Windows.Forms.Label feeLabel;
        private System.Windows.Forms.Button removeButton;
    }
}
