using System.Collections.Generic;
using OOPaint.Shapes;


namespace OOPaint
{
    public partial class MainForm : Form
    {
        static int defaultLineWidth = 3;

        List<Shape> shapes;
        Graphics graphics;
        Color chosenColor = Color.Black;

        public MainForm()
        {
            shapes = new List<Shape>();
            InitializeComponent();
            graphics = pictureBox.CreateGraphics();
        }

        private void addShape(Shape shape)
        {
            shapes.Add(shape);
            shape.Draw(graphics);
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shape shape in shapes)
            {
                shape.Draw(graphics);
            }
        }

        private void lineToolButton_Click(object sender, EventArgs e)
        {
            Point point1 = new Point(100, 100);
            Point point2 = new Point(200, 200);
            addShape(new Line(chosenColor, defaultLineWidth, point1, point2));
        }

        private void ellipseToolButton_Click(object sender, EventArgs e)
        {
            addShape(new Ellipse(chosenColor, defaultLineWidth, 300, 300, 100, 200));
        }

        private void rectangleToolButton_Click(object sender, EventArgs e)
        {
            addShape(new RectangleShape(chosenColor, defaultLineWidth, 150, 150, 300, 120));
        }

        private void polylineToolButton_Click(object sender, EventArgs e)
        {
            Point[] points =
            {
                new Point(130, 140),
                new Point(210, 215),
                new Point(150, 300)
            };

            addShape(new Polyline(chosenColor, defaultLineWidth, points));
        }

        private void polygonToolButton_Click(object sender, EventArgs e)
        {
            Point[] points =
{
                new Point(300, 100),
                new Point(250, 150),
                new Point(170, 125)
            };

            addShape(new Polygon(chosenColor, defaultLineWidth, points));
        }

        private void rectangleToolButton_Click_1(object sender, EventArgs e)
        {
            addShape(new RectangleShape(chosenColor, defaultLineWidth, 100, 200, 300, 300));
        }

        private void pickColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                chosenColor = colorDialog.Color;
                pickColorButton.BackColor = chosenColor;
            }
        }
    }
}
