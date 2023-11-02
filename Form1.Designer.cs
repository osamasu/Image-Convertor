namespace Image_Convertor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.NumUD_Height = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.NumUD_Width = new System.Windows.Forms.NumericUpDown();
            this.Dgv_Images = new System.Windows.Forms.DataGridView();
            this.ImagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.CheckB_SameHeight = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.PB_ImageViewer = new System.Windows.Forms.PictureBox();
            this.Btn_ConvertImage = new System.Windows.Forms.Button();
            this.Btn_SelectImages = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Images)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ImageViewer)).BeginInit();
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
            this.Dgv_Images.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Images.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImagePath,
            this.Image});
            this.Dgv_Images.Location = new System.Drawing.Point(17, 215);
            this.Dgv_Images.Name = "Dgv_Images";
            this.Dgv_Images.ReadOnly = true;
            this.Dgv_Images.RowHeadersWidth = 51;
            this.Dgv_Images.RowTemplate.Height = 26;
            this.Dgv_Images.Size = new System.Drawing.Size(553, 264);
            this.Dgv_Images.TabIndex = 5;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.Image.DefaultCellStyle = dataGridViewCellStyle2;
            this.Image.HeaderText = "Image";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            // 
            // CheckB_SameHeight
            // 
            this.CheckB_SameHeight.AutoSize = true;
            this.CheckB_SameHeight.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.CheckB_SameHeight.Location = new System.Drawing.Point(256, 137);
            this.CheckB_SameHeight.Name = "CheckB_SameHeight";
            this.CheckB_SameHeight.Size = new System.Drawing.Size(140, 31);
            this.CheckB_SameHeight.TabIndex = 6;
            this.CheckB_SameHeight.Text = "Same Height";
            this.CheckB_SameHeight.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Kelson Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Image_Convertor.Properties.Resources._63_X_63___open_folder;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(586, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 80);
            this.button1.TabIndex = 10;
            this.button1.Text = "Show Images Folder";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PB_ImageViewer
            // 
            this.PB_ImageViewer.Location = new System.Drawing.Point(586, 80);
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
            this.Btn_ConvertImage.Location = new System.Drawing.Point(586, 301);
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
            this.Btn_SelectImages.Location = new System.Drawing.Point(586, 215);
            this.Btn_SelectImages.Name = "Btn_SelectImages";
            this.Btn_SelectImages.Size = new System.Drawing.Size(200, 80);
            this.Btn_SelectImages.TabIndex = 7;
            this.Btn_SelectImages.Text = "Import Images";
            this.Btn_SelectImages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_SelectImages.UseVisualStyleBackColor = true;
            this.Btn_SelectImages.Click += new System.EventHandler(this.Btn_SelectImages_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(793, 491);
            this.Controls.Add(this.button1);
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
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Images)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ImageViewer)).EndInit();
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
        private System.Windows.Forms.Button button1;
    }
}

