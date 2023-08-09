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
        private Star[] star = new Star[15000];

        // Create Random generator instance
        private Random random = new Random();

        // Create Graphics GDI+ drawing surface instance
        private Graphics graphics;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
