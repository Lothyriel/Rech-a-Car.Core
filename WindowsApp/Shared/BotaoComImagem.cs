using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsApp.Shared
{
    [ToolboxItem(true)]
    public class BotaoComImagem : Button
    {

        public new Image Image
        {
            get { return base.Image; }
            set
            {
                Image newImage = new Bitmap(Width, Height);
                using (Graphics g = Graphics.FromImage(newImage))
                {
                    g.DrawImage(value, 0, 0, Width, Height);
                }
                base.Image = RedimensionarImagem(value, this.Width, this.Height);
            }
        }

        private Image RedimensionarImagem(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
            return newImage;
        }
    }
}
