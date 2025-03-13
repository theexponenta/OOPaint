using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPaint.Shapes
{
    public class RectangleShape : Shape
    {
        float x1, y1, x2, y2;

        public RectangleShape(Color color, int lineWidth, int x1, int y1, int x2, int y2) 
            : base(color, lineWidth)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(this.color, this.lineWidth);
            graphics.DrawRectangle(pen, x1, y1, x2, y2);
        }

        public override byte[] Serialize()
        {
            throw new NotImplementedException();
        }
    }
}
