using System;

namespace PlottingGrids
{
    class Program
    {
        private const int COLUMNS = 3;
        private const int ROWS = 3;
        private const int SPACE = 10;

        static void Main(string[] args)
        {
            for (int column = 0; column < COLUMNS; column++)
            {
                for (int row = 0; row < ROWS; row++)
                {
                    // Make a square
                    var square = new Shape();
                    square.FillColor = 0x000;
                    square.DrawRectangle(0, 0, 50, 50);
                    square.EndFill();
                    square.Display();

                    // Position the square on the grid
                    square.X = column * (square.Width + SPACE);
                    square.Y = row * (square.Height + SPACE);
                }
            }
        }
    }

    public class Shape
    {
        public int FillColor { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; } = 50;
        public int Height { get; } = 50;

        public void DrawRectangle(int x, int y, int width, int height)
        {
            // Draw rectangle logic
        }

        public void Fill()
        {
            // Fill logic
        }

        public void Display()
        {
            // Display logic
        }
    }
}

/*
package
{
	import flash.display.Shape;
	import flash.display.Sprite;
	
	public class PlottingGrids extends Sprite
	{
		//The number of column and row in the grid
		private const COLUMNS:uint = 3;
		private const ROWS:uint = 3;
		private const SPACE:uint = 10;
		
		public function PlottingGrids()
		{	
			for(var column:int = 0; column < COLUMNS; column++) 
			{
				for(var row:int = 0; row < ROWS; row++) 
				{
					//Make a square
					var square:Shape = new Shape();
					square.graphics.beginFill(0x000); 
					square.graphics.drawRect(0, 0, 50, 50);
					square.graphics.endFill();
					addChild(square);
					
					//Position the square on the grid
					square.x = column * (square.width + SPACE);
					square.y = row * (square.height + SPACE);
				}
			}
		}
	}
}
*/