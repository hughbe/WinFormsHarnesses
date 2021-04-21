using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ImageLists : Form
    {
        public ImageLists()
        {
            InitializeComponent();
        }

        private void ImageLists_Load(object sender, EventArgs e)
        {
            depthComboBox.SelectedIndex = 4;
        }

        private void format32bppRgbButton_Click(object sender, EventArgs e)
        {
            var image = new Bitmap(16, 16, PixelFormat.Format32bppRgb);
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    if ((x % 2) == 0)
                    {
                        image.SetPixel(x, y, Color.FromArgb(0, 255, 0, 0));
                    }
                    else
                    {
                        image.SetPixel(x, y, hasAlpha.Checked ? Color.FromArgb(0, 50, 75, 100) : Color.FromArgb(50, 75, 100));
                    }
                }
            }

            SetImage(image);
        }

        private void format32bppArgb_Click(object sender, EventArgs e)
        {
            var image = new Bitmap(16, 16, PixelFormat.Format32bppArgb);
            for (int x = 0; x < 0; x++)// image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    if ((x % 2) == 0)
                    {
                        image.SetPixel(x, y, Color.FromArgb(0, 255, 0, 0));
                    }
                    else
                    {
                        image.SetPixel(x, y, hasAlpha.Checked ? Color.FromArgb(0, 50, 75, 100) : Color.FromArgb(50, 75, 100));
                    }
                }
            }

            SetImage(image);
        }

        private void format32bppPArgb_Click(object sender, EventArgs e)
        {
            var image = new Bitmap(16, 16, PixelFormat.Format32bppPArgb);
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    if ((x % 2) == 0)
                    {
                        image.SetPixel(x, y, Color.FromArgb(0, 255, 0, 0));
                    }
                    else
                    {
                        image.SetPixel(x, y, hasAlpha.Checked ? Color.FromArgb(0, 50, 75, 100) : Color.FromArgb(50, 75, 100));
                    }
                }
            }

            SetImage(image);
        }

        private void SetImage(Image image)
        {
            var list = new ImageList();
            switch (depthComboBox.SelectedIndex)
            {
                case 0:
                    list.ColorDepth = ColorDepth.Depth4Bit;
                    break;
                case 1:
                    list.ColorDepth = ColorDepth.Depth8Bit;
                    break;
                case 2:
                    list.ColorDepth = ColorDepth.Depth16Bit;
                    break;
                case 3:
                    list.ColorDepth = ColorDepth.Depth24Bit;
                    break;
                case 4:
                    list.ColorDepth = ColorDepth.Depth32Bit;
                    break;
                default:
                    throw new NotImplementedException();
            }

            list.Images.Add(image);
            original.Image = image;
            result.Image = list.Images[0];
        }
    }
}
