namespace SweetBeanHomeScreen
{
    partial class HomeForm
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
            this.components = new System.ComponentModel.Container();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.dessertButton = new System.Windows.Forms.Button();
            this.sandwichButton = new System.Windows.Forms.Button();
            this.coldButton = new System.Windows.Forms.Button();
            this.hotButton = new System.Windows.Forms.Button();
            this.productsDataSet = new SweetBeanHomeScreen.ProductsDataSet();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new SweetBeanHomeScreen.ProductsDataSetTableAdapters.ItemsTableAdapter();
            this.tableAdapterManager = new SweetBeanHomeScreen.ProductsDataSetTableAdapters.TableAdapterManager();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.menuPanel.Controls.Add(this.dessertButton);
            this.menuPanel.Controls.Add(this.sandwichButton);
            this.menuPanel.Controls.Add(this.coldButton);
            this.menuPanel.Controls.Add(this.hotButton);
            this.menuPanel.Location = new System.Drawing.Point(0, 149);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(272, 633);
            this.menuPanel.TabIndex = 4;
            this.menuPanel.TabStop = true;
            // 
            // dessertButton
            // 
            this.dessertButton.BackColor = System.Drawing.Color.RosyBrown;
            this.dessertButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dessertButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dessertButton.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dessertButton.ForeColor = System.Drawing.Color.SeaShell;
            this.dessertButton.Location = new System.Drawing.Point(0, 477);
            this.dessertButton.Name = "dessertButton";
            this.dessertButton.Size = new System.Drawing.Size(272, 154);
            this.dessertButton.TabIndex = 3;
            this.dessertButton.Text = "Desserts";
            this.dessertButton.UseVisualStyleBackColor = false;
            // 
            // sandwichButton
            // 
            this.sandwichButton.BackColor = System.Drawing.Color.RosyBrown;
            this.sandwichButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.sandwichButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sandwichButton.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sandwichButton.ForeColor = System.Drawing.Color.SeaShell;
            this.sandwichButton.Location = new System.Drawing.Point(0, 326);
            this.sandwichButton.Name = "sandwichButton";
            this.sandwichButton.Size = new System.Drawing.Size(272, 151);
            this.sandwichButton.TabIndex = 2;
            this.sandwichButton.Text = "Sandwiches";
            this.sandwichButton.UseVisualStyleBackColor = false;
            // 
            // coldButton
            // 
            this.coldButton.BackColor = System.Drawing.Color.RosyBrown;
            this.coldButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.coldButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.coldButton.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldButton.ForeColor = System.Drawing.Color.SeaShell;
            this.coldButton.Location = new System.Drawing.Point(0, 156);
            this.coldButton.Name = "coldButton";
            this.coldButton.Size = new System.Drawing.Size(272, 170);
            this.coldButton.TabIndex = 1;
            this.coldButton.Text = "Cold Drinks";
            this.coldButton.UseVisualStyleBackColor = false;
            this.coldButton.Click += new System.EventHandler(this.coldButton_Click);
            // 
            // hotButton
            // 
            this.hotButton.BackColor = System.Drawing.Color.RosyBrown;
            this.hotButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.hotButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hotButton.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotButton.ForeColor = System.Drawing.Color.SeaShell;
            this.hotButton.Location = new System.Drawing.Point(0, 0);
            this.hotButton.Name = "hotButton";
            this.hotButton.Size = new System.Drawing.Size(272, 156);
            this.hotButton.TabIndex = 0;
            this.hotButton.Text = "Hot Drinks";
            this.hotButton.UseVisualStyleBackColor = false;
            this.hotButton.Click += new System.EventHandler(this.hotButton_Click);
            // 
            // productsDataSet
            // 
            this.productsDataSet.DataSetName = "ProductsDataSet";
            this.productsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.productsDataSet;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ItemsTableAdapter = this.itemsTableAdapter;
            this.tableAdapterManager.UpdateOrder = SweetBeanHomeScreen.ProductsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(278, 156);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1176, 624);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 788);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuPanel);
            this.Name = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.Controls.SetChildIndex(this.menuPanel, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button dessertButton;
        private System.Windows.Forms.Button sandwichButton;
        private System.Windows.Forms.Button coldButton;
        private System.Windows.Forms.Button hotButton;
        private ProductsDataSet productsDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private ProductsDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private ProductsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

