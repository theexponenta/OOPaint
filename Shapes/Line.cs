using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPaint.Shapes
{
    public class Line : Shape
    {
        Point point1;
        Point point2;

        public Line(Color color, int lineWidth, Point point1, Point point2) : base(color, lineWidth)
        {
            this.point1 = point1;
            this.point2 = point2;
        }

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(this.color, this.lineWidth);
            graphics.DrawLine(pen, point1, point2);
        }

        public override byte[] Serialize()
        {
            throw new NotImplementedException();
        }
    }
}
