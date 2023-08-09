using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarfieldSimulationApp
{
    public partial class Form1 : Form
    {
        // Create Star[] array instance
        private Star[] stars = new Star[15000];

        // Create Random generator instance
        private Random random = new Random();

        // Create Graphics GDI+ drawing surface instance
        private Graphics graphics;

        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            graphics.Clear(Color.Black);

            foreach(var star in stars)
            {
                DrawStar(star);
                MoveStar(star);
            }

            pictureBox1.Refresh();
        }

        private void MoveStar(Star star)
        {
            star.Z -= 30;
        }

        /// <summary>
        /// Method that draws stars
        /// </summary>
        /// <param name="star"></param>
        private void DrawStar(Star star)
        {
            float starSize = 7;

            float x = Map(star.X / star.Z, 0, 1, 0, pictureBox1.Width) + pictureBox1.Width / 2;

            float y = Map(star.Y / star.Z, 0, 1, 0, pictureBox1.Height) + pictureBox1.Height / 2;

            graphics.FillEllipse(Brushes.GreenYellow, x, y, starSize, starSize);
        }

        /// <summary>
        /// Convert coordinates that are located in one measurement scale to another
        /// </summary>
        /// <param name="n"></param>
        /// <param name="start1"></param>
        /// <param name="stop1"></param>
        /// <param name="start2"></param>
        /// <param name="stop2"></param>
        /// <returns></returns>
        private float Map(float n, float start1, float stop1, float start2, float stop2)
        {
            return ((n - start1) / (stop1 - start1)) * (stop2 - start2) + start2;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            // Create new Bitmap instance
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            graphics = Graphics.FromImage(pictureBox1.Image);

            // Initialize random coordinate place star
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new Star()
                {
                    X = random.Next(-pictureBox1.Width, pictureBox1.Width),
                    Y = random.Next(-pictureBox1.Height, pictureBox1.Height),
                    Z = random.Next(1, pictureBox1.Width),
                };
            }
            // Initialize timer activity
            timer1.Start();
        }
    }
}
