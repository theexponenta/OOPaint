using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPaint.Shapes
{
    public class Polyline: Shape
    {
        Point[] points;

        public Polyline(Color color, int lineWidth, Point[] points) : base(color, lineWidth)
        {
            this.points = points;
        }

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(this.color, this.lineWidth);
            graphics.DrawLines(pen, points);
        }

        public override byte[] Serialize()
        {
            throw new NotImplementedException();
        }

        public override void Deserialize(byte[] data)
        {
            throw new NotImplementedException();
        }
    }
}
