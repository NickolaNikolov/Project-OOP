﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_editor
{
    public class Rectangle : Shape
    {

        public Rectangle(int Width, int Height, Point Position,Color Color) : base(Width, Height, Position,Color) { }


        public override void Paint(Graphics graphics)
        {
            Pen pen = new Pen(Color.DarkRed, 5);
            graphics.DrawRectangle(pen, Position.X - Width/2, Position.Y - Height/2, Width, Height);
        }
    }
}
