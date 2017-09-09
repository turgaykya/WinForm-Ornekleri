using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIPlus
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(553, 407);
            Graphics graphics = Graphics.FromImage(bitmap);
            Color redColor = Color.Red;
            //Color redColor2 = Color.FromArgb(255, 0, 0);

            Pen redPen = new Pen(redColor, 10);
            graphics.DrawLine(redPen, 5, 5, 545, 400);

            pictureBox1.Image = bitmap;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(553, 407);
            Graphics graphics = Graphics.FromImage(bitmap);
            Color blueColor = Color.Blue;
            Pen bluePen = new Pen(blueColor, 10);
            graphics.DrawRectangle(bluePen, 5, 5, 545, 400);
            pictureBox1.Image = bitmap;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(553, 407);
            Graphics graphics = Graphics.FromImage(bitmap);
            Color yellowColor = Color.Yellow;
            Pen yellowPen = new Pen(yellowColor, 10);
            graphics.DrawRectangle(yellowPen, 5, 5, 400, 400);
            pictureBox1.Image = bitmap;
        }

        private void btnElipse_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(553, 407);
            Graphics graphics = Graphics.FromImage(bitmap);
            Color blackColor = Color.Blue;
            Pen blackPen = new Pen(blackColor, 10);
            graphics.DrawEllipse(blackPen, 5, 5, 500, 400);
            pictureBox1.Image = bitmap;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(553, 407);
            Graphics graphics = Graphics.FromImage(bitmap);
            Color aquaColor = Color.Aqua;
            Pen aquaPen = new Pen(aquaColor, 10);
            graphics.DrawEllipse(aquaPen, 5, 5, 400, 400);
            pictureBox1.Image = bitmap;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            pictureBox1.Image = null;

            //pictureBox1.Inage=null;  Alternatif
        }

        private void btnBrush_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(553, 407);
            Graphics graphics = Graphics.FromImage(bitmap);
            Brush blueBrush = Brushes.Blue;
            Rectangle rect = new Rectangle(50, 50, 300, 300);

            graphics.FillRectangle(blueBrush, rect);


            pictureBox1.Image = bitmap;
        }

        
    }
}
