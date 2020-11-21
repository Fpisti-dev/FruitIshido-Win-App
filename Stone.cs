﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FruitIshido
{
    [Serializable]
    public class Stone
    {        
        public string Name { get; set; }
        public string Text { get; set; }
        public Color StoneColor { get; set; }


        public Stone()
        {
        } 

        public Stone(string name, string text, Color stoneColor)
        {                       
            Name = name;
            Text = text;
            StoneColor = stoneColor;
        }

        // Override ToString method
        public override string ToString()
        {
            return "Name: " + Name + ", Text:" + Text + ", Color:" + StoneColor.ToString();
        }
    }
}
