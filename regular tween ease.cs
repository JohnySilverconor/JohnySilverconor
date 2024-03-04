 public class Regular
{
    public static double EaseIn(double param1, double param2, double param3, double param4)
    {
        return param3 * (param1 = param1 / param4) * param1 + param2;
    }

    public static double EaseOut(double param1, double param2, double param3, double param4)
    {
        return -param3 * (param1 = param1 / param4) * (param1 - 2) + param2;
    }

    public static double EaseInOut(double param1, double param2, double param3, double param4)
    {
        if ((param1 = param1 / (param4 / 2)) < 1)
        {
            return param3 / 2 * param1 * param1 + param2;
        }
        return -param3 / 2 * (--param1 * (param1 - 2) - 1) + param2;
    }
}

// javascript
public class Regular
   {
       
      
      public function Regular()
      {
         super();
      }
      
      public static function easeIn(param1:Number, param2:Number, param3:Number, param4:Number) : Number
      {
         return param3 * (param1 = param1 / param4) * param1 + param2;
      }
      
      public static function easeOut(param1:Number, param2:Number, param3:Number, param4:Number) : Number
      {
         return -param3 * (param1 = param1 / param4) * (param1 - 2) + param2;
      }
      
      public static function easeInOut(param1:Number, param2:Number, param3:Number, param4:Number) : Number
      {
         if((param1 = param1 / (param4 / 2)) < 1)
         {
            return param3 / 2 * param1 * param1 + param2;
         }
         return -param3 / 2 * (--param1 * (param1 - 2) - 1) + param2;
      }
   }