using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class LifeGrid : UserControl
    {
        private bool[][] alive;
        public Color colorAlive;
        public Color colorDead;
        public List<int> rulesCreate;
        public List<int> rulesSurvive;
        private Point mouseLocation;
        private int cellSize;
        public bool brush;
        public int liveCells;

        public int getCellSize()
        {
            return cellSize;
        }

        public LifeGrid()
        {
            liveCells = 0;
            cellSize = 4;
            brush = true;
            InitializeComponent();
            Random rnd = new Random();
            alive = new bool[Height/cellSize][];
            for (int i = 0; i < Height/cellSize; i++)
            {
                alive[i] = new bool[Width/cellSize];
                for (int j = 0; j < Width/cellSize; j++)
                {
                    alive[i][j] = false; //rnd.Next() % 2 == 0;
                }
            }

            rulesCreate = new List<int>();
            rulesCreate.Add(3);

            rulesSurvive = new List<int>();
            rulesSurvive.Add(2);
            rulesSurvive.Add(3);

            colorAlive = Color.Green;
            colorDead = Color.Black;
           
            pictureBox1.Image = new Bitmap(Width, Height);
            mouseLocation = Point.Empty;
            drawCurrentIteration();

        }

        public void drawCurrentIteration()
        {
            SolidBrush brushA = new SolidBrush(colorAlive);
            SolidBrush brushD = new SolidBrush(colorDead);
            liveCells = 0;
            for (int i=0; i<Height/cellSize; i++)
            {
                for(int j=0; j<Width/cellSize; j++)
                {
                    using(var canvas = Graphics.FromImage(pictureBox1.Image))
                    {
                        if (alive[i][j])
                        {
                            canvas.FillRectangle(brushA, i * cellSize, j * cellSize, cellSize, cellSize);
                            liveCells++;
                        }
                        else
                        {
                            canvas.FillRectangle(brushD, i * cellSize, j * cellSize, cellSize, cellSize);
                        }

                    }
                }
            }
            pictureBox1.Refresh();
            brushA.Dispose();
            brushD.Dispose();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (e.Location.X <= Height && e.Location.X >= 0 && e.Location.Y <= Width && e.Location.Y >= 0)
                {
                    mouseLocation = e.Location;
                    alive[mouseLocation.X / cellSize][mouseLocation.Y / cellSize] = brush;
                    drawCurrentIteration();
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left && mouseLocation != Point.Empty)
            {
                if (e.Location.X <= Height && e.Location.X >= 0 && e.Location.Y <= Width && e.Location.Y >= 0)
                {
                    int x0 = mouseLocation.X/cellSize, y0 = mouseLocation.Y/cellSize, x1 = e.X/cellSize, y1 = e.Y/cellSize;

                    bool steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);
                    if (steep) {
                        int t = x0;
                        x0 = y0;
                        y0 = t;
                        t = x1;
                        x1 = y1;
                        y1 = t;
                    }
                    if (x0 > x1) {
                        int t = x0;
                        x0 = x1;
                        x1 = t;
                        t = y0;
                        y0 = y1;
                        y1 = t;
                    }
                    int dX = (x1 - x0), dY = Math.Abs(y1 - y0), err = (dX / 2), ystep = (y0 < y1 ? 1 : -1), y = y0;

                    for (int x = x0; x <= x1; ++x)
                    {
                        if (x < 0 || x >= Width / cellSize || y < 0 || y >= Height / cellSize)
                            break;
                        if (steep)
                            alive[y][x] = brush;
                        else
                            alive[x][y] = brush;
                            err = err - dY;
                        if (err < 0) { y += ystep; err += dX; }
                    }

                    mouseLocation = e.Location;
                    //alive[mouseLocation.X / cellSize][mouseLocation.Y / cellSize] = brush;
                    drawCurrentIteration();
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseLocation = Point.Empty;
        }

        public void computeNextState()
        {
            bool[][] tmp = new bool[Height/cellSize][];
            for(int i=0; i<Height/cellSize; i++)
            {
                tmp[i] = new bool[Width/cellSize];
                for(int j=0; j<Width/cellSize; j++)
                {
                    int count = 0;
                    if(i != 0)
                    {
                        if (j != 0 && alive[i - 1][j - 1])
                            count++;
                        if (alive[i-1][j])
                            count++;
                        if (j < Width/cellSize - 1 && alive[i - 1][j + 1])
                            count++;
                    }
                    if (i < Height/cellSize - 1)
                    {
                        if (j != 0 && alive[i + 1][j - 1])
                            count++;
                        if (alive[i+1][j])
                            count++;
                        if (j < Width/cellSize - 1 && alive[i + 1][j + 1])
                            count++;
                    }
                    if (j != 0 && alive[i][j - 1])
                        count++;
                    if (j < Width/cellSize - 1 && alive[i][j + 1])
                        count++;

                    if (alive[i][j])
                    {
                        bool flag = true;
                        foreach(int rule in rulesSurvive)
                        {
                            if (rule == count)
                            {
                                flag = false;
                                tmp[i][j] = true;
                                break;
                            }
                        }
                        if (flag)
                            tmp[i][j] = false;
                    }
                    else
                    {
                        bool flag = true;
                        foreach (int rule in rulesCreate)
                        {
                            if (rule == count)
                            {
                                flag = false;
                                tmp[i][j] = true;
                                break;
                            }
                        }
                        if (flag)
                            tmp[i][j] = false;
                    }
                }
            }
            alive = tmp;
            drawCurrentIteration();
        }

        private void LifeGrid_Resize(object sender, EventArgs e)
        {
            alive = new bool[Height / cellSize][];
            for (int i = 0; i < Height / cellSize; i++)
            {
                alive[i] = new bool[Width / cellSize];
                for (int j = 0; j < Width / cellSize; j++)
                {
                    alive[i][j] = false; //rnd.Next() % 2 == 0;
                }
            }
            pictureBox1.Image.Dispose();
            pictureBox1.Image = new Bitmap(Width, Height);
            pictureBox1.Refresh();
            drawCurrentIteration();
        }

        public void changeSize(int size)
        {
            cellSize = size;
            LifeGrid_Resize(null, null);
        }
        public void fillRandom()
        {
            Random rnd = new Random();
            for (int i = 0; i < Height / cellSize; i++)
            {
                for (int j = 0; j < Width / cellSize; j++)
                {
                    alive[i][j] = rnd.Next() % 2 == 0;
                }
            }
            drawCurrentIteration();
        }
        public void clear()
        {
            for (int i = 0; i < Height / cellSize; i++)
                for (int j = 0; j < Width / cellSize; j++)
                    alive[i][j] = false;
            drawCurrentIteration();
        }
        public Image getImg()
        {
            return pictureBox1.Image;
        }
    }
}
