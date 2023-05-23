using System.ComponentModel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetSize();
            pen.Color = button1.BackColor;
        }
        bool drawing = false;
        int start_x, start_y;
        int end_x, end_y;
        int index;
        public class ArrayPoints
        {
            private int index = 0;
            private Point[] points;

            public ArrayPoints(int size)
            {
                if (size <= 0) { size = 2; }
                points = new Point[size];
            }

            public void SetPoint(int x, int y)
            {
                if (index >= points.Length)
                {
                    index = 0;
                }
                points[index] = new Point(x, y);
                index++;
            }
            public void ResetPoint()
            {
                index = 0;
            }
            public int GetCountPoints()
            {
                return index;
            }
            public Point[] GetPoints()
            {
                return points;
            }
        }

        private ArrayPoints arrayPoints = new ArrayPoints(2);

        Bitmap map = new Bitmap(100, 100);

        private void SetSize()
        {
            Rectangle rect = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rect.Width, rect.Height);
            g = Graphics.FromImage(map);
            g.Clear(Color.White);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        Graphics g;
        Pen pen = new Pen(Color.Black, 10f);

        private void button1_Click(object sender, EventArgs e)
        {
            using ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = dlg.Color;
                pen.Color = dlg.Color;
            }
        }

        public void Fill(int x, int y)
        {
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.DrawLine(new Pen(button1.BackColor), x, y, x, y + 1);
            pictureBox1.Invalidate();
            Bitmap map = (Bitmap)pictureBox1.Image;
            if (map.GetPixel(x + 1, y) != button1.BackColor)
            {
                Fill(x + 1, y);
            }
            if (map.GetPixel(x - 1, y) != button1.BackColor)
            {
                Fill(x - 1, y);
            }
            if (map.GetPixel(x, y + 1) != button1.BackColor)
            {
                Fill(x, y + 1);
            }
            if (map.GetPixel(x, y - 1) != button1.BackColor)
            {
                Fill(x, y - 1);
            }

        }
        private void drawpanel_mdown(object sender, MouseEventArgs e)
        {
            if (index != 5)
            {
                drawing = true;
                start_x = e.X;
                start_y = e.Y;
            }
            else
            {
                Fill(e.X, e.Y);
                pictureBox1.Image = map;
            }
        }
        private void drawpanel_mmove(object sender, MouseEventArgs e)
        {
            if (index != 5)
            {
                if (drawing)
                {
                    arrayPoints.SetPoint(e.X, e.Y);
                    if (arrayPoints.GetCountPoints() >= 2)
                    {
                        if (radioButton1.Checked)
                        {
                            index = 0;
                            g.DrawLines(pen, arrayPoints.GetPoints());
                        }
                        else
                        {
                            end_x = e.X;
                            end_y = e.Y;
                        }
                        pictureBox1.Image = map;
                        arrayPoints.SetPoint(e.X, e.Y);
                    }
                }
                else
                {
                    return;
                }
            }
        }
        private void drawpanel_mup(object sender, MouseEventArgs e)
        {
            drawing = false;
            arrayPoints.ResetPoint();
            if (index == 2)
            {
                g.DrawEllipse(pen, Math.Min(start_x, end_x), Math.Min(start_y, end_y), Math.Abs(end_x - start_x), Math.Abs(end_y - start_y));
            }
            else if (index == 3)
            {
                g.DrawRectangle(pen, Math.Min(start_x, end_x), Math.Min(start_y, end_y), Math.Abs(end_x - start_x), Math.Abs(end_y - start_y));
                pictureBox1.Image = map;

            }
            else if (index == 4)
            {
                g.DrawLine(pen, start_x, start_y, end_x, end_y);
            }
            pictureBox1.Image = map;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pen.Width < 50)
            {
                pen.Width += 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pen.Width > 0)
            {
                pen.Width -= 2;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(pictureBox1.BackColor);
            pictureBox1.Image = map;
        }

        private void saveCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG(*.PNG)|*.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName);
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            index = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            index = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            index = 4;
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            index = 5;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG(*.PNG)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(openFileDialog1.FileName);
                g.DrawImage(image, 0, 0);
            }
        }
    }
}