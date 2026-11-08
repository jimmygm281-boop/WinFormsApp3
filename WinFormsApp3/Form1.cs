using System.Collections.Generic;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private int x0, y0;
        private bool draw;
        private Pen p;
        int x1, y1;
        bool drawing = false;
        List<Point> points = new List<Point>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
            p = new Pen(Color.Black, 1);
            draw = false;
            radioButton1.Checked = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                draw = true;
                x0 = e.X;
                y0 = e.Y;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                g.DrawLine(p, new Point(x0, y0), new Point(e.X, e.Y));

                x0 = e.X;
                y0 = e.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tseverleh_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.DrawRectangle(p, new Rectangle(20, 20,
       panel1.Width - 40, panel1.Height - 40));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.DrawEllipse(p, new Rectangle(20, 20,
        panel1.Width - 40, panel1.Height - 40));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            g.DrawLine(p, new Point(20, 20),
        new Point(panel1.Width - 20, panel1.Height - 20));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(
        10, 10,
        panel1.Width - 20,
        panel1.Height - 20
    );

            g.DrawPie(p, rect, 0, 60);
            g.DrawPie(p, rect, 90, 120);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Point[] pts =
  {
        new Point(20,60),
        new Point(320,60),
        new Point(320,30),
        new Point(380,80),
        new Point(320,130),
        new Point(320,100),
        new Point(20,100)
    };

            g.DrawPolygon(p, pts);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Point[] pts =
   {
        new Point(20,60),
        new Point(320,60),
        new Point(320,30),
        new Point(380,80),
        new Point(320,130),
        new Point(320,100),
        new Point(20,100)
    };

            g.DrawCurve(p, pts);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x0 = e.X;
                y0 = e.Y;
                drawing = true;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                x1 = e.X;
                y1 = e.Y;

                drawing = false;

                int width = Math.Abs(x1 - x0);
                int height = Math.Abs(y1 - y0);

                int left = Math.Min(x0, x1);
                int top = Math.Min(y0, y1);

                Rectangle rect = new Rectangle(left, top, width, height);

                if (radioButton1.Checked)
                {
                    // Тэгш өнцөгт зурах
                    g.DrawRectangle(p, rect);
                }
                else if (radioButton2.Checked)
                {
                    // Шулуун зурах
                    g.DrawLine(p, x0, y0, x1, y1);
                }
                else if (radioButton3.Checked)
                {
                    // Тойрог зурах
                    g.DrawEllipse(p, rect);
                }
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
       
            if (e.Button == MouseButtons.Left)
            {
                if (radioButton4.Checked || radioButton5.Checked)
                {
                    points.Add(e.Location);
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                if (radioButton4.Checked && points.Count >= 3)
                {
                    g.DrawPolygon(p, points.ToArray());
                    points.Clear();
                }
                else if (radioButton5.Checked && points.Count >= 2)
                {
                    g.DrawCurve(p, points.ToArray());
                    points.Clear();
                }
            }
        }
    }
    }



