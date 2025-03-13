using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPaint.Shapes
{
    public class Polygon : Shape
    {
        Point[] points;

        public Polygon(Color color, int lineWidth, Point[] points) : base(color, lineWidth)
        {
            this.points = points;
        }

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(this.color, this.lineWidth);
            Brush brush = new SolidBrush(color);

            graphics.DrawPolygon(pen, points);
            graphics.FillPolygon(brush, points);
        }

        public override byte[] Serialize()
        {
            throw new NotImplementedException();
        }
    }
}
