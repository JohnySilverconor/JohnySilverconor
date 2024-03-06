using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateText
{
    public class PirateText
    {
        public PirateText(int X, int Y, int Width, string Text = "", string Font = "MinionPro")
        {
            this.X = X;
            this.Y = Y;
            this.Width = Width;
            this.Text = Text;
            this.Font = Font;
            //Color color = (Color)ColorConverter.ConvertFromString("#FFDFD991");
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public string Text { get; set; }
        public string Font { get; set; }
        public int Color { get; set; }
        public int Shadow { get; set; }
    }
}

class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
  }
}