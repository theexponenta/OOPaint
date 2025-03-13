﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPaint.Shapes
{
    public abstract class Shape
    {
        protected Color color;
        protected int lineWidth;

        public Shape(Color color, int lineWidth)
        {
            this.color = color;
            this.lineWidth = lineWidth;
        }

        public Shape(byte[] data)
        {
            throw new NotImplementedException();
        }

        public abstract void Draw(Graphics graphics);

        public abstract byte[] Serialize();
    }
}
