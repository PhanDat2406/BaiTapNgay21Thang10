using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Bai3
{
    public static class ImageHelper
    {
        public static Image? LoadImageSafely(string? filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
            {
                return null;
            }

            try
            {
                using var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                using var temp = Image.FromStream(fs);
                return new Bitmap(temp);
            }
            catch
            {
                return null;
            }
        }

        public static void EnsureSampleAvatars(string targetDirectory)
        {
            try
            {
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                string avatar1 = Path.Combine(targetDirectory, "avatar1.png");
                string avatar2 = Path.Combine(targetDirectory, "avatar2.png");
                string avatar3 = Path.Combine(targetDirectory, "avatar3.png");

                if (!File.Exists(avatar1)) CreateSimpleAvatar(avatar1, "SV1");
                if (!File.Exists(avatar2)) CreateSimpleAvatar(avatar2, "SV2");
                if (!File.Exists(avatar3)) CreateSimpleAvatar(avatar3, "SV3");
            }
            catch { }
        }

        private static void CreateSimpleAvatar(string filePath, string label)
        {
            using var bmp = new Bitmap(120, 120);
            using var g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(SystemColors.ControlLight);

            using (var pen = new Pen(SystemColors.ControlDark, 2))
            {
                g.DrawRectangle(pen, 1, 1, 117, 117);
                g.DrawEllipse(pen, 30, 20, 60, 60);
                g.DrawArc(pen, 20, 70, 80, 45, 0, 180);
            }

            using (var font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold))
            using (var brush = new SolidBrush(SystemColors.ControlText))
            {
                var sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Far
                };
                g.DrawString(label, font, brush, new RectangleF(0, 0, 120, 115), sf);
            }

            bmp.Save(filePath, ImageFormat.Png);
        }
    }
}
