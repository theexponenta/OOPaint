using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPaint.Shapes
{
    public class Ellipse : Shape
    {
        float x, y, width, height;

        public Ellipse(Color color, int lineWidth, int x, int y, int width, int height) 
            : base(color, lineWidth)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(this.color, this.lineWidth);
            graphics.DrawEllipse(pen, x, y, width, height);
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
