namespace SweetBeanBase
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.cartButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.accountButton = new System.Windows.Forms.Button();
            this.headerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cartButton
            // 
            this.cartButton.Image = ((System.Drawing.Image)(resources.GetObject("cartButton.Image")));
            this.cartButton.Location = new System.Drawing.Point(83, 32);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(96, 84);
            this.cartButton.TabIndex = 1;
            this.cartButton.UseVisualStyleBackColor = true;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Location = new System.Drawing.Point(499, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(393, 125);
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // accountButton
            // 
            this.accountButton.Image = global::SweetBeanBase.Properties.Resources.account;
            this.accountButton.Location = new System.Drawing.Point(1273, 32);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(106, 99);
            this.accountButton.TabIndex = 2;
            this.accountButton.UseVisualStyleBackColor = true;
            // 
            // headerPictureBox
            // 
            this.headerPictureBox.BackColor = System.Drawing.Color.SeaShell;
            this.headerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.headerPictureBox.Location = new System.Drawing.Point(0, 0);
            this.headerPictureBox.Name = "headerPictureBox";
            this.headerPictureBox.Size = new System.Drawing.Size(1446, 150);
            this.headerPictureBox.TabIndex = 3;
            this.headerPictureBox.TabStop = false;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1449, 719);
            this.Controls.Add(this.accountButton);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.headerPictureBox);
            this.Name = "BaseForm";
            this.Text = "Sweet Bean Cafe";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.Button accountButton;
        private System.Windows.Forms.PictureBox headerPictureBox;
    }
}

