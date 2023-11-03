namespace Image_Convertor
{
    partial class Frm_ImageConveror
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ImageConveror));
            this.label1 = new System.Windows.Forms.Label();
            this.NumUD_Height = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.NumUD_Width = new System.Windows.Forms.NumericUpDown();
            this.Dgv_Images = new System.Windows.Forms.DataGridView();
            this.ImagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CheckB_SameHeight = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_ConvToICO = new System.Windows.Forms.Button();
            this.Btn_OpenImagesFolder = new System.Windows.Forms.Button();
            this.PB_ImageViewer = new System.Windows.Forms.PictureBox();
            this.Btn_ConvertImage = new System.Windows.Forms.Button();
            this.Btn_SelectImages = new System.Windows.Forms.Button();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertICOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_OriginalImageHeight = new System.Windows.Forms.Label();
            this.LB_OriginalImageWidth = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pan_OriginalImageInfo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Images)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ImageViewer)).BeginInit();
            this.pan_OriginalImageInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kelson Sans", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image Convertor Size";
            // 
            // NumUD_Height
            // 
            this.NumUD_Height.Font = new System.Drawing.Font("Kelson Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumUD_Height.Location = new System.Drawing.Point(102, 113);
            this.NumUD_Height.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumUD_Height.Name = "NumUD_Height";
            this.NumUD_Height.Size = new System.Drawing.Size(120, 28);
            this.NumUD_Height.TabIndex = 1;
            this.NumUD_Height.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumUD_Height.ValueChanged += new System.EventHandler(this.NumUD_Height_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kelson Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Width";
            // 
            // NumUD_Width
            // 
            this.NumUD_Width.Font = new System.Drawing.Font("Kelson Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumUD_Width.Location = new System.Drawing.Point(102, 164);
            this.NumUD_Width.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumUD_Width.Name = "NumUD_Width";
            this.NumUD_Width.Size = new System.Drawing.Size(120, 28);
            this.NumUD_Width.TabIndex = 3;
            this.NumUD_Width.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumUD_Width.ValueChanged += new System.EventHandler(this.NumUD_Width_ValueChanged);
            // 
            // Dgv_Images
            // 
            this.Dgv_Images.AllowUserToAddRows = false;
            this.Dgv_Images.AllowUserToOrderColumns = true;
            this.Dgv_Images.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Images.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImagePath,
            this.Image});
            this.Dgv_Images.ContextMenuStrip = this.contextMenuStrip1;
            this.Dgv_Images.Location = new System.Drawing.Point(17, 236);
            this.Dgv_Images.Name = "Dgv_Images";
            this.Dgv_Images.ReadOnly = true;
            this.Dgv_Images.RowHeadersWidth = 51;
            this.Dgv_Images.RowTemplate.Height = 26;
            this.Dgv_Images.Size = new System.Drawing.Size(553, 251);
            this.Dgv_Images.TabIndex = 5;
            this.Dgv_Images.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Images_CellContentClick);
            this.Dgv_Images.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Dgv_Images_RowsAdded);
            this.Dgv_Images.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.Dgv_Images_RowsRemoved);
            this.Dgv_Images.SelectionChanged += new System.EventHandler(this.Dgv_Images_SelectionChanged);
            // 
            // ImagePath
            // 
            this.ImagePath.HeaderText = "ImagePath";
            this.ImagePath.MinimumWidth = 6;
            this.ImagePath.Name = "ImagePath";
            this.ImagePath.ReadOnly = true;
            this.ImagePath.Width = 300;
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle5.NullValue")));
            this.Image.DefaultCellStyle = dataGridViewCellStyle5;
            this.Image.HeaderText = "Image";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.convertToImageToolStripMenuItem,
            this.convertICOToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(205, 88);
            // 
            // CheckB_SameHeight
            // 
            this.CheckB_SameHeight.AutoSize = true;
            this.CheckB_SameHeight.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.CheckB_SameHeight.Location = new System.Drawing.Point(228, 137);
            this.CheckB_SameHeight.Name = "CheckB_SameHeight";
            this.CheckB_SameHeight.Size = new System.Drawing.Size(140, 31);
            this.CheckB_SameHeight.TabIndex = 6;
            this.CheckB_SameHeight.Text = "Same Height";
            this.CheckB_SameHeight.UseVisualStyleBackColor = true;
            this.CheckB_SameHeight.CheckedChanged += new System.EventHandler(this.CheckB_SameHeight_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kelson Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "All Images Converted Successfully :-) - Click To Show";
            this.notifyIcon1.BalloonTipTitle = "Converted Successfully";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans Cond", 6F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(228, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "Recommened For .ico images";
            // 
            // Btn_ConvToICO
            // 
            this.Btn_ConvToICO.Enabled = false;
            this.Btn_ConvToICO.Font = new System.Drawing.Font("Kelson Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ConvToICO.Image = global::Image_Convertor.Properties.Resources.ico;
            this.Btn_ConvToICO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ConvToICO.Location = new System.Drawing.Point(586, 320);
            this.Btn_ConvToICO.Name = "Btn_ConvToICO";
            this.Btn_ConvToICO.Size = new System.Drawing.Size(200, 80);
            this.Btn_ConvToICO.TabIndex = 11;
            this.Btn_ConvToICO.Text = "Convert To icon";
            this.Btn_ConvToICO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_ConvToICO.UseVisualStyleBackColor = true;
            this.Btn_ConvToICO.Click += new System.EventHandler(this.Btn_ConvToICO_Click);
            // 
            // Btn_OpenImagesFolder
            // 
            this.Btn_OpenImagesFolder.Font = new System.Drawing.Font("Kelson Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OpenImagesFolder.Image = global::Image_Convertor.Properties.Resources._63_X_63___open_folder;
            this.Btn_OpenImagesFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_OpenImagesFolder.Location = new System.Drawing.Point(586, 407);
            this.Btn_OpenImagesFolder.Name = "Btn_OpenImagesFolder";
            this.Btn_OpenImagesFolder.Size = new System.Drawing.Size(200, 80);
            this.Btn_OpenImagesFolder.TabIndex = 10;
            this.Btn_OpenImagesFolder.Text = "Show Images Folder";
            this.Btn_OpenImagesFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_OpenImagesFolder.UseVisualStyleBackColor = true;
            this.Btn_OpenImagesFolder.Click += new System.EventHandler(this.Btn_OpenImagesFolder_Click);
            // 
            // PB_ImageViewer
            // 
            this.PB_ImageViewer.Location = new System.Drawing.Point(586, 90);
            this.PB_ImageViewer.Name = "PB_ImageViewer";
            this.PB_ImageViewer.Size = new System.Drawing.Size(200, 125);
            this.PB_ImageViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_ImageViewer.TabIndex = 9;
            this.PB_ImageViewer.TabStop = false;
            // 
            // Btn_ConvertImage
            // 
            this.Btn_ConvertImage.Enabled = false;
            this.Btn_ConvertImage.Font = new System.Drawing.Font("Kelson Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ConvertImage.Image = global::Image_Convertor.Properties.Resources.refresh;
            this.Btn_ConvertImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ConvertImage.Location = new System.Drawing.Point(586, 233);
            this.Btn_ConvertImage.Name = "Btn_ConvertImage";
            this.Btn_ConvertImage.Size = new System.Drawing.Size(200, 80);
            this.Btn_ConvertImage.TabIndex = 8;
            this.Btn_ConvertImage.Text = "Convert Image";
            this.Btn_ConvertImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_ConvertImage.UseVisualStyleBackColor = true;
            this.Btn_ConvertImage.Click += new System.EventHandler(this.Btn_ConvertImage_Click);
            // 
            // Btn_SelectImages
            // 
            this.Btn_SelectImages.Font = new System.Drawing.Font("Kelson Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SelectImages.Image = global::Image_Convertor.Properties.Resources._48_X_48___import;
            this.Btn_SelectImages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_SelectImages.Location = new System.Drawing.Point(374, 147);
            this.Btn_SelectImages.Name = "Btn_SelectImages";
            this.Btn_SelectImages.Size = new System.Drawing.Size(196, 80);
            this.Btn_SelectImages.TabIndex = 7;
            this.Btn_SelectImages.Text = "Import Images";
            this.Btn_SelectImages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_SelectImages.UseVisualStyleBackColor = true;
            this.Btn_SelectImages.Click += new System.EventHandler(this.Btn_SelectImages_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Noto Sans Cond", 10.8F, System.Drawing.FontStyle.Bold);
            this.deleteToolStripMenuItem.Image = global::Image_Convertor.Properties.Resources.close;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // convertToImageToolStripMenuItem
            // 
            this.convertToImageToolStripMenuItem.Font = new System.Drawing.Font("Noto Sans Cond", 10.8F);
            this.convertToImageToolStripMenuItem.Image = global::Image_Convertor.Properties.Resources.picasa;
            this.convertToImageToolStripMenuItem.Name = "convertToImageToolStripMenuItem";
            this.convertToImageToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.convertToImageToolStripMenuItem.Text = "Convert To Image";
            this.convertToImageToolStripMenuItem.Click += new System.EventHandler(this.convertToImageToolStripMenuItem_Click);
            // 
            // convertICOToolStripMenuItem
            // 
            this.convertICOToolStripMenuItem.Font = new System.Drawing.Font("Noto Sans Cond", 10.8F);
            this.convertICOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("convertICOToolStripMenuItem.Image")));
            this.convertICOToolStripMenuItem.Name = "convertICOToolStripMenuItem";
            this.convertICOToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.convertICOToolStripMenuItem.Text = "Convert ICO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans Cond", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Original Image Dimansions";
            // 
            // LB_OriginalImageHeight
            // 
            this.LB_OriginalImageHeight.AutoSize = true;
            this.LB_OriginalImageHeight.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.LB_OriginalImageHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LB_OriginalImageHeight.Location = new System.Drawing.Point(24, 30);
            this.LB_OriginalImageHeight.Name = "LB_OriginalImageHeight";
            this.LB_OriginalImageHeight.Size = new System.Drawing.Size(69, 27);
            this.LB_OriginalImageHeight.TabIndex = 14;
            this.LB_OriginalImageHeight.Text = "Height";
            // 
            // LB_OriginalImageWidth
            // 
            this.LB_OriginalImageWidth.AutoSize = true;
            this.LB_OriginalImageWidth.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.LB_OriginalImageWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LB_OriginalImageWidth.Location = new System.Drawing.Point(103, 31);
            this.LB_OriginalImageWidth.Name = "LB_OriginalImageWidth";
            this.LB_OriginalImageWidth.Size = new System.Drawing.Size(63, 27);
            this.LB_OriginalImageWidth.TabIndex = 15;
            this.LB_OriginalImageWidth.Text = "Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans Cond", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(79, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 30);
            this.label6.TabIndex = 16;
            this.label6.Text = "X";
            // 
            // pan_OriginalImageInfo
            // 
            this.pan_OriginalImageInfo.Controls.Add(this.LB_OriginalImageWidth);
            this.pan_OriginalImageInfo.Controls.Add(this.label6);
            this.pan_OriginalImageInfo.Controls.Add(this.label5);
            this.pan_OriginalImageInfo.Controls.Add(this.LB_OriginalImageHeight);
            this.pan_OriginalImageInfo.Location = new System.Drawing.Point(603, 25);
            this.pan_OriginalImageInfo.Name = "pan_OriginalImageInfo";
            this.pan_OriginalImageInfo.Size = new System.Drawing.Size(176, 59);
            this.pan_OriginalImageInfo.TabIndex = 17;
            this.pan_OriginalImageInfo.Visible = false;
            // 
            // Frm_ImageConveror
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_ConvToICO);
            this.Controls.Add(this.Btn_OpenImagesFolder);
            this.Controls.Add(this.PB_ImageViewer);
            this.Controls.Add(this.Btn_ConvertImage);
            this.Controls.Add(this.Btn_SelectImages);
            this.Controls.Add(this.CheckB_SameHeight);
            this.Controls.Add(this.Dgv_Images);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumUD_Width);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumUD_Height);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pan_OriginalImageInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_ImageConveror";
            this.Text = "Image Converor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Images)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_ImageViewer)).EndInit();
            this.pan_OriginalImageInfo.ResumeLayout(false);
            this.pan_OriginalImageInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumUD_Height;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumUD_Width;
        private System.Windows.Forms.DataGridView Dgv_Images;
        private System.Windows.Forms.CheckBox CheckB_SameHeight;
        private System.Windows.Forms.Button Btn_SelectImages;
        private System.Windows.Forms.Button Btn_ConvertImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImagePath;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.PictureBox PB_ImageViewer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button Btn_OpenImagesFolder;
        private System.Windows.Forms.Button Btn_ConvToICO;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertICOToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LB_OriginalImageHeight;
        private System.Windows.Forms.Label LB_OriginalImageWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pan_OriginalImageInfo;
    }
}

