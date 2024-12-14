using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateBlank(pictureBox1.Width, pictureBox1.Height);
        }

        Color DefaultColor
        {
            get { return Color.White; }
        }

        void CreateBlank(int width, int heigth)
        {
            var oldImage = pictureBox1.Image;
            var bmp = new Bitmap(width, heigth, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < heigth; j++)
                {
                    bmp.SetPixel(i, j, DefaultColor);
                }
            }
            pictureBox1.Image = bmp;
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
        }
        int _x;
        int _y;
        bool _mouseClicked = false;
        Color SelectedColor
        {
            get { return Color.Black; }
        }
        int SelectedSize
        {
            get { return trackBar1.Value; }
        }
        Brush _selectedBrush;

        private void selectedKvadratButton_Click(object sender, EventArgs e)
        {
            _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void selectedKrugButton_Click(object sender, EventArgs e)
        {
            _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
        }
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_selectedBrush == null)
            {
                return;
            }
            _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
            pictureBox1.Refresh();
            _mouseClicked = true;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseClicked = false;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            _x = e.X > 0 ? e.X : 0;
            _y = e.Y > 0 ? e.Y : 0;
            if (_mouseClicked)
            {
                _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void selectedKrugButton_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;
            int radius = 100;
            DrawCircle(g, centerX, centerY, radius);
        }

        private void DrawCircle(Graphics g, int centerX, int centerY, int radius)
        {
            Pen pen = new Pen(Color.Blue, 2);
            for (int x = -radius; x <= radius; x++)
            {
                int y = (int)Math.Sqrt(radius * radius - x * x);
                g.DrawLine(pen, centerX + x, centerY + y, centerX + x, centerY + y);
                g.DrawLine(pen, centerX + x, centerY - y, centerX + x, centerY - y);
                g.DrawLine(pen, centerX - x, centerY + y, centerX - x, centerY + y);
                g.DrawLine(pen, centerX - x, centerY - y, centerX - x, centerY - y);
            }

        }
    }
}
