using System;

public class MouseRecord
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Button { get; set; }
    public int Wheel { get; set; }

    public MouseRecord(int x, int y, int button, int wheel)
    {
        X = x;
        Y = y;
        Button = button;
        Wheel = wheel;
    }
}
/* original
public class MouseRecord
   {
       
      
      public var x:int;
      
      public var y:int;
      
      public var button:int;
      
      public var wheel:int;
      
      public function MouseRecord(X:int, Y:int, Button:int, Wheel:int)
      {
         super();
         this.x = X;
         this.y = Y;
         this.button = Button;
         this.wheel = Wheel;
      }
   }
*/
Replace the empty string Data with your actual data.
The MouseRecord class represents the mouse data with properties for X, Y, and two buttons (Button1 and Button2).
Make sure to complete the rest of your logic within the Main method.
Feel free to adapt this code snippet to your specific use case! 😊