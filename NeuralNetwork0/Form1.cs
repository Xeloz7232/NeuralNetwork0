using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork0
{
    public partial class Form1 : Form
    {
        public int lastX, lastY;
        public const int N = 10000;
        public Neuron neuron = new Neuron(N);
        public static Random r = new Random();
        public int[] X = new int[N];

        public Form1()
        {
            InitializeComponent();
            if (File.Exists($"Weight.txt"))
            {
                neuron.LoadWeight();
            }
            else
            {
                Random();
            }
            ShowWeightMap();
            Clear();
        }

        private void Clear()
        {
            pbMain.Image = new Bitmap(100, 100);
            Graphics g = Graphics.FromImage(pbMain.Image);
            g.Clear(Color.FromArgb(255, 255, 255, 255));
            lGuess.Text = string.Empty;
        }

        public float function(float x, float a, float b)
        {
            float y;
            if (x <= a)
                y = 0;
            else if (x > a && x < b)
                y = (x - a) / (b - a);
            else y = 1;
            return y;
        }
        public void ShowWeightMap()
        {
            float temp;
            Bitmap bm = new Bitmap(100, 100);
            for (int i = 0; i < N; i++)
            {
                temp = 1 - function(neuron.weight[i], -1f, 1f);
                bm.SetPixel(i % 100, i / 100, Color.FromArgb(255, (int)(255 * temp), (int)(255 * temp), (int)(255 * temp)));
            }
            pbWM.Image = bm;
        }

        public void Random()
        {
            for (int i = 0; i < N; i++)
            {
                neuron.weight[i] = r.Next(-30, 30) / 100f;
            }
        }
        private void bRandom_Click(object sender, EventArgs e)
        {
            Random();
            ShowWeightMap();
            lGuess.Text = "";
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void bGive_Click(object sender, EventArgs e)
        {
            Bitmap bm = (Bitmap)pbMain.Image;
            for (int i = 0; i < N; i++)
            {
                X[i] = bm.GetPixel(i % 100, i / 100) == Color.FromArgb(255, 0, 0, 0) ? 1 : 0;
            }
            neuron.Check(X);
            if (neuron.guess == true)
            {
                lGuess.Text = "X";
            }
            else if (neuron.guess == false)
            {
                lGuess.Text = "O";
            }
        }

        private void bRight_Click(object sender, EventArgs e)
        {
            if (lGuess.Text != "")
            {
                Clear();
                lGuess.Text = "";
            }
        }

        private void bFalse_Click(object sender, EventArgs e)
        {
            neuron.ChangeWeight((float)nudAlpha.Value, X);
            ShowWeightMap();
            Clear();
            lGuess.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            neuron.SaveWeight();
        }

        private void pbMain_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X, y = e.Y;
            Pen p = new Pen(Color.Black, 5);
            Graphics g = Graphics.FromImage(pbMain.Image);
            if (e.Button == MouseButtons.Left)
            {
                g.DrawLine(p, lastX, lastY, x, y);
            }
            p.Dispose(); g.Dispose();
            pbMain.Invalidate();
            lastX = x; lastY = y;
        }
    }
}
