public class Strong
{
    public static double EaseIn(double param1, double param2, double param3, double param4)
    {
        double t = param1 / param4;
        return param3 * t * t * t * t * t + param2;
    }

    public static double EaseOut(double param1, double param2, double param3, double param4)
    {
        double t = param1 / param4 - 1;
        return param3 * (t * t * t * t * t + 1) + param2;
    }

    public static double EaseInOut(double param1, double param2, double param3, double param4)
    {
        double t = param1 / (param4 / 2);
        if (t < 1)
        {
            return param3 / 2 * t * t * t * t * t + param2;
        }
        t -= 2;
        return param3 / 2 * (t * t * t * t * t + 2) + param2;
    }
}
//javascript
public class Strong
   {
       
      
      public function Strong()
      {
         super();
      }
      
      public static function easeIn(param1:Number, param2:Number, param3:Number, param4:Number) : Number
      {
         return param3 * (param1 = param1 / param4) * param1 * param1 * param1 * param1 + param2;
      }
      
      public static function easeOut(param1:Number, param2:Number, param3:Number, param4:Number) : Number
      {
         return param3 * ((param1 = param1 / param4 - 1) * param1 * param1 * param1 * param1 + 1) + param2;
      }
      
      public static function easeInOut(param1:Number, param2:Number, param3:Number, param4:Number) : Number
      {
         if((param1 = param1 / (param4 / 2)) < 1)
         {
            return param3 / 2 * param1 * param1 * param1 * param1 * param1 + param2;
         }
         return param3 / 2 * ((param1 = param1 - 2) * param1 * param1 * param1 * param1 + 2) + param2;
      }
   }
}