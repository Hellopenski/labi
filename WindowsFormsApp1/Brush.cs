﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   abstract class Brush
    {
        public Color BrushColor { get; set; }
        public int Size { get; set; }
        public Brush(Color brushColor,int size)
        {
            BrushColor = brushColor;
            Size = size;
        }
        public virtual void Draw(Bitmap image, int x, int y)
        {

        }
    }
    
}
