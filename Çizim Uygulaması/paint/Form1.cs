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

namespace paint
{
public partial class Form1 : Form
    {
public Form1()
        {
InitializeComponent();
        }

int _startX;
int _startY;
bool _isMouseDown = false;
Bitmap bitmap;
Graphics graph;
ColorDialog colorDialog1 = new ColorDialog();
private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
if (_isMouseDown)
            {

Pen BlackPen = new Pen(colorDialog1.Color, 10);
SolidBrush brush = new SolidBrush(colorDialog1.Color);

        graph.DrawLine(BlackPen, new Point(_startX, _startY), new Point(e.X, e.Y));
        graph.FillEllipse(brush, e.X - 5, e.Y - 5, 10, 10);

                pictureBox1.Refresh();
            }

            _startX = e.X;
            _startY = e.Y;
        }

private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graph = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
        }

private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _isMouseDown = true;
        }

private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;
        }

private void menuItemColors_Click(object sender, EventArgs e)
        {
DialogResult result = colorDialog1.ShowDialog();

if (result == DialogResult.OK)
            {
Pen BlackPen = new Pen(colorDialog1.Color, 10);

SolidBrush brush = new SolidBrush(colorDialog1.Color);
            }
        }
    }
}

