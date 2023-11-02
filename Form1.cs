using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Image_Convertor
{
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion


        private void NumUD_Width_ValueChanged(object sender, EventArgs e)
        {
            if (CheckB_SameHeight.Checked)
                NumUD_Height.Value = NumUD_Width.Value;
        }

        private void NumUD_Height_ValueChanged(object sender, EventArgs e)
        {
            if (CheckB_SameHeight.Checked)
                NumUD_Width.Value = NumUD_Height.Value;
        }


        private void Btn_SelectImages_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files |*.jpg;*.png;*.ico";
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string sImagePath in openFileDialog1.FileNames)
                {
                    Dgv_Images.Rows.Add(sImagePath,
                        System.Drawing.Image.FromFile(sImagePath));
                }

                Btn_ConvertImage.Enabled = (Dgv_Images.Rows.Count > 0) ? true : false;
            }
        }

        private void Dgv_Images_SelectionChanged(object sender, EventArgs e)
        {

            PB_ImageViewer.Image = (System.Drawing.Image)Dgv_Images.CurrentRow.Cells[1].Value;
        }

        static string FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"/IConverted Images";

        private void Btn_ConvertImage_Click(object sender, EventArgs e)
        {
            short Height = (short)NumUD_Height.Value;
            short Width = (short)NumUD_Width.Value;


            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }

            string sImagePath = null;
            string ImageName = null;

            for (short i = 0; i < Dgv_Images.RowCount - 1; i++)
            {
                sImagePath = Dgv_Images.Rows[i].Cells[0].Value.ToString();
                System.Drawing.Image sImage = System.Drawing.Image.FromFile(sImagePath);

                Bitmap sConvertedImage = new Bitmap(sImage, new Size(Width, Height));

                ImageName = $"{Height} X {Width} - {Path.GetFileName(sImagePath)}";
                sConvertedImage.Save($"{FolderPath}\\ {ImageName}");
            }


            notifyIcon1.ShowBalloonTip(7000);

        }

        private void _OpenImagesFolder()
        {
            System.Diagnostics.Process.Start($@"{FolderPath}\");
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            // Here Code - [ Will open Converted images folder to show ]
            _OpenImagesFolder();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _OpenImagesFolder();
        }
    }
}