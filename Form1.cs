using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Image_Convertor
{
    public partial class Frm_ImageConveror : Form
    {

        static string FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"/IConverted Images";


        #region Constructor
        public Frm_ImageConveror()
        {
            InitializeComponent();
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        #region Events

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


            }
        }

        private void Dgv_Images_SelectionChanged(object sender, EventArgs e)
        {

            System.Drawing.Image SelectedImage = null;

            if (Dgv_Images.Rows.Count > 0)
                SelectedImage = (Image)Dgv_Images.CurrentRow.Cells[1].Value;


            PB_ImageViewer.Image = SelectedImage;

            _ShowImageInfo();
        }

        private void Btn_ConvertImage_Click(object sender, EventArgs e)
        {
            for (short i = 0; i < Dgv_Images.RowCount; i++)
            {
                _ConvertToImage(Dgv_Images.Rows[i].Cells[0].Value.ToString());
            }
        }

        private void _OpenImagesFolder()
        {
            System.Diagnostics.Process.Start($@"{FolderPath}\");
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            _OpenImagesFolder();
        }


        private void Btn_OpenImagesFolder_Click(object sender, EventArgs e)
        {
            _OpenImagesFolder();
        }

        private void Btn_ConvToICO_Click(object sender, EventArgs e)
        {
            for (short i = 0; i < Dgv_Images.RowCount; i++)
            {
                _ConvertToICO(Dgv_Images.Rows[i].Cells[0].Value.ToString());
            }
        }


        private void _ShowImageInfo()
        {
            if (Dgv_Images.Rows.Count == 0)
            {
                pan_OriginalImageInfo.Visible = false;
                return;
            }

            LB_OriginalImageHeight.Text = PB_ImageViewer.Image.Height.ToString();
            LB_OriginalImageWidth.Text = PB_ImageViewer.Image.Width.ToString();
            pan_OriginalImageInfo.Visible = true;
        }

        private void _CheckStatusForConvertToICO_Btn()
        {


            Btn_ConvertImage.Enabled = (Dgv_Images.Rows.Count > 0);

            if (Dgv_Images.Rows.Count > 0)
            {
                Btn_ConvToICO.Enabled = true;
            }
            else
                Btn_ConvToICO.Enabled = false;



        }

        private void CheckB_SameHeight_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckB_SameHeight.Checked)
            {
                NumUD_Width.Value = NumUD_Height.Value;

            }


            _CheckStatusForConvertToICO_Btn();

        }

        private void Dgv_Images_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            _CheckStatusForConvertToICO_Btn();
        }

        private void Dgv_Images_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

            _CheckStatusForConvertToICO_Btn();
        }

        private void Dgv_Images_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dgv_Images.Rows.Count == 0 || Dgv_Images.CurrentRow == null)
                return;


            Dgv_Images.Rows.RemoveAt(Dgv_Images.CurrentRow.Index);
        }

        private void convertToImageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            _ConvertToImage(Dgv_Images.Rows[Dgv_Images.CurrentRow.Index].Cells[0].Value.ToString());
        }

        private void convertICOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ConvertToICO(Dgv_Images.Rows[Dgv_Images.CurrentRow.Index].Cells[0].Value.ToString());
        }

        #endregion


        #region Methods
        private void _ConvertToICO(string sImagePath)
        {
            short Height = (short)NumUD_Height.Value;
            short Width = (short)NumUD_Width.Value;

            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }

            clsConvertToIco.ConvertToIcon(sImagePath, FolderPath, Height, Width);

            notifyIcon1.ShowBalloonTip(7000);
        }

        private void _ConvertToImage(string sImagePath)
        {
            short Height = (short)NumUD_Height.Value;
            short Width = (short)NumUD_Width.Value;

            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }

            string ImageName = null;


            System.Drawing.Image sImage = System.Drawing.Image.FromFile(sImagePath);
            Bitmap sConvertedImage = new Bitmap(sImage, new Size(Width, Height));

            ImageName = $"{Height} X {Width} - {Path.GetFileName(sImagePath)}";
            sConvertedImage.Save($@"{FolderPath}\{ImageName}");

            notifyIcon1.ShowBalloonTip(7000);
        }
        #endregion

    }

}