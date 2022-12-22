namespace ImageListDemo
{
    partial class Form1
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
            this.imageList = new System.Windows.Forms.ListView();
            this.selectedImage = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.btnSaveNext = new System.Windows.Forms.Button();
            this.selectDirectoryBtn = new System.Windows.Forms.Button();
            this.lblVendor = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtVendor = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtmDate = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.selectedImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.imageList.Location = new System.Drawing.Point(11, 39);
            this.imageList.Margin = new System.Windows.Forms.Padding(4);
            this.imageList.Name = "imageList";
            this.imageList.Size = new System.Drawing.Size(197, 654);
            this.imageList.TabIndex = 0;
            this.imageList.UseCompatibleStateImageBehavior = false;
            this.imageList.Visible = false;
            this.imageList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.imageList_ItemSelectionChanged);
            // 
            // selectedImage
            // 
            this.selectedImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedImage.Location = new System.Drawing.Point(234, 39);
            this.selectedImage.Margin = new System.Windows.Forms.Padding(4);
            this.selectedImage.Name = "selectedImage";
            this.selectedImage.Size = new System.Drawing.Size(652, 591);
            this.selectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.selectedImage.TabIndex = 1;
            this.selectedImage.TabStop = false;
            this.selectedImage.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(774, 26);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectDirectoryToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // selectDirectoryToolStripMenuItem
            // 
            this.selectDirectoryToolStripMenuItem.Name = "selectDirectoryToolStripMenuItem";
            this.selectDirectoryToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.selectDirectoryToolStripMenuItem.Text = "Select Directory";
            this.selectDirectoryToolStripMenuItem.Click += new System.EventHandler(this.selectDirectoryToolStripMenuItem_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.previousBtn.Location = new System.Drawing.Point(231, 638);
            this.previousBtn.Margin = new System.Windows.Forms.Padding(4);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(73, 47);
            this.previousBtn.TabIndex = 3;
            this.previousBtn.Text = "Previous";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Visible = false;
            this.previousBtn.Click += new System.EventHandler(this.button_navigation);
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nextBtn.Location = new System.Drawing.Point(331, 638);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(4);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(73, 47);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Visible = false;
            this.nextBtn.Click += new System.EventHandler(this.button_navigation);
            // 
            // btnSaveNext
            // 
            this.btnSaveNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveNext.Location = new System.Drawing.Point(907, 647);
            this.btnSaveNext.Name = "btnSaveNext";
            this.btnSaveNext.Size = new System.Drawing.Size(124, 46);
            this.btnSaveNext.TabIndex = 5;
            this.btnSaveNext.Text = "Save and Next";
            this.btnSaveNext.UseVisualStyleBackColor = true;
            this.btnSaveNext.Visible = false;
            this.btnSaveNext.Click += new System.EventHandler(this.btnSaveNext_Click);
            // 
            // selectDirectoryBtn
            // 
            this.selectDirectoryBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectDirectoryBtn.Location = new System.Drawing.Point(483, 302);
            this.selectDirectoryBtn.Name = "selectDirectoryBtn";
            this.selectDirectoryBtn.Size = new System.Drawing.Size(143, 45);
            this.selectDirectoryBtn.TabIndex = 6;
            this.selectDirectoryBtn.Text = "Select A Directory";
            this.selectDirectoryBtn.UseVisualStyleBackColor = true;
            this.selectDirectoryBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Location = new System.Drawing.Point(886, 69);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(44, 15);
            this.lblVendor.TabIndex = 7;
            this.lblVendor.Text = "Vendor";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(887, 142);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(67, 15);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(892, 201);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 15);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Date";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(891, 265);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(51, 15);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Amount";
            // 
            // txtVendor
            // 
            this.txtVendor.Location = new System.Drawing.Point(879, 91);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.Size = new System.Drawing.Size(98, 23);
            this.txtVendor.TabIndex = 11;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(880, 172);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(103, 23);
            this.txtDescription.TabIndex = 12;
            // 
            // dtmDate
            // 
            this.dtmDate.Location = new System.Drawing.Point(879, 226);
            this.dtmDate.Name = "dtmDate";
            this.dtmDate.Size = new System.Drawing.Size(100, 23);
            this.dtmDate.TabIndex = 13;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(892, 297);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(98, 23);
            this.txtAmount.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 699);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.dtmDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtVendor);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblVendor);
            this.Controls.Add(this.selectDirectoryBtn);
            this.Controls.Add(this.btnSaveNext);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.selectedImage);
            this.Controls.Add(this.imageList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.selectedImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView imageList;
        private System.Windows.Forms.PictureBox selectedImage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectDirectoryToolStripMenuItem;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button btnSaveNext;
        private System.Windows.Forms.Button selectDirectoryBtn;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtVendor;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtmDate;
        private System.Windows.Forms.TextBox txtAmount;
    }
}

