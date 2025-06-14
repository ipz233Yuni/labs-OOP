using ShapesLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox.CreateGraphics();
            g.Clear(Color.White);

            for (int i = 0; i < 20; i++)
            {
                int x = rnd.Next(pictureBox.Width);
                int y = rnd.Next(pictureBox.Height);

                int choice = rnd.Next(5);
                Shape shape;

                switch (choice)
                {
                    case 0:
                        shape = new ShapesLibrary.Rectangle(x, y, rnd.Next(20, 100), rnd.Next(20, 100), Color.Black);
                        break;
                    case 1:
                        shape = new Circle(x, y, Color.Black, rnd.Next(20, 50));
                        break;
                    case 2:
                        shape = new Ellipse(x, y, rnd.Next(20, 50), rnd.Next(20, 50), Color.Black);
                        break;
                    case 3:
                        shape = new ShapesLibrary.Point(x, y, Color.Black);
                        break;
                    case 4:
                        shape = new Line();
                        break;
                    default:
                        shape = new ShapesLibrary.Rectangle(x, y, rnd.Next(pictureBox.Width), rnd.Next(pictureBox.Height), Color.Black);
                        break;
                }

                shape.Draw(g);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox.CreateGraphics();
            g.Clear(Color.White);
        }
    }
}
