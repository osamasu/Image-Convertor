using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Image_Convertor
{
    internal class clsConvertToIco
    {
        private static bool _ConvertToIcon(Stream input, Stream output, int Size = 16)
        {
            Bitmap inputBitmap = (Bitmap)Bitmap.FromStream(input);
            if (inputBitmap != null)
            {
                Bitmap newBitmap = new Bitmap(inputBitmap, new Size(Size, Size));

                if (newBitmap != null)
                {
                    // save the resized png into a memory stream for future use
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        newBitmap.Save(memoryStream, ImageFormat.Png);

                        BinaryWriter iconWriter = new BinaryWriter(output);
                        if (output != null && iconWriter != null)
                        {
                            // 0-1 reserved, 0
                            iconWriter.Write((byte)0);
                            iconWriter.Write((byte)0);

                            // 2-3 image type, 1 = icon, 2 = cursor
                            iconWriter.Write((short)1);

                            // 4-5 number of images
                            iconWriter.Write((short)1);

                            // image entry 1
                            // 0 image width
                            iconWriter.Write((byte)Size);
                            // 1 image height
                            iconWriter.Write((byte)Size);

                            // 2 number of colors
                            iconWriter.Write((byte)0);

                            // 3 reserved
                            iconWriter.Write((byte)0);

                            // 4-5 color planes
                            iconWriter.Write((short)0);

                            // 6-7 bits per pixel
                            iconWriter.Write((short)32);

                            // 8-11 size of image data
                            iconWriter.Write((int)memoryStream.Length);

                            // 12-15 offset of image data
                            iconWriter.Write((int)(6 + 16));

                            // write image data
                            // png data must contain the whole png data file
                            iconWriter.Write(memoryStream.ToArray());

                            iconWriter.Flush();


                            return true;
                        }
                    }
                }
                return false;
            }
            return false;
        }

        public static void ConvertToIcon(string inputPath, string outputPath, int Size)
        {
            string NewImageName = $"{Size} X {Size} - {Path.GetFileNameWithoutExtension(inputPath)}";
            using (FileStream inputStream = new FileStream(inputPath, FileMode.Open, FileAccess.Read))
            using (FileStream outputStream = new FileStream($"{outputPath}/{NewImageName}.ico", FileMode.OpenOrCreate))
            {
                _ConvertToIcon(inputStream, outputStream, Size);

                inputStream.Close();
                outputStream.Close();
            }


        }

        public static byte[] ConvertToIcon(Image image)
        {
            MemoryStream inputStream = new MemoryStream();
            image.Save(inputStream, ImageFormat.Png);
            inputStream.Seek(0, SeekOrigin.Begin);
            MemoryStream outputStream = new MemoryStream();
            int size = image.Size.Width;
            if (_ConvertToIcon(inputStream, outputStream, size))
            {
                return outputStream.ToArray();
            }
            return null;
        }
    }
}