using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        string Data = ""; // Initialize your 'Data' string here
        uint i = 0;
        uint l = 0;
        string[] keyPair = null;

        string[] array = Data.Split('k');
        int frame = Convert.ToInt32(array[0]);

        array = array[1].Split('m');
        string keyData = array[0];
        string mouseData = array[1];
string Data = ""; // Initialize your 'Data' string here
        uint i = 0;
        uint l = 0;
        List<Dictionary<string, int>> keys = null;

        string[] array = Data.Split('k');
        string keyData = array[0];

        if (keyData.Length > 0)
        {
            array = keyData.Split(',');
            i = 0;
            l = (uint)array.Length;

            while (i < l)
            {
                string[] keyPair = array[i].Split(':');
                if (keyPair.Length == 2)
                {
                    if (keys == null)
                    {
                        keys = new List<Dictionary<string, int>>();
                    }

                    keys.Add(new Dictionary<string, int>
                    {
                        { "code", Convert.ToInt32(keyPair[0]) },
                        { "value", Convert.ToInt32(keyPair[1]) }
                    });
                }
                i++;
            }
        }
if (mouseData.Length > 0)
        {
            array = mouseData.Split(',');
            if (array.Length >= 4)
            {
                MouseRecord mouse = new MouseRecord(
                    Convert.ToInt32(array[0]),
                    Convert.ToInt32(array[1]),
                    Convert.ToInt32(array[2]),
                    Convert.ToInt32(array[3])
                );

                // Now 'mouse' contains the parsed mouse data
                // You can use it as needed in your C# code
            }
        }
        // Rest of your C# code goes here...
    }
}
/* original code

public function load(Data:String) : FrameRecord
      {
         var i:uint = 0;
         var l:uint = 0;
         var keyPair:Array = null;
         var array:Array = Data.split("k");
         this.frame = int(array[0] as String);
         array = (array[1] as String).split("m");
         var keyData:String = String(array[0]);
         var mouseData:String = String(array[1]);
         if(keyData.length > 0)
         {
            array = keyData.split(",");
            i = 0;
            l = array.length;
            while(i < l)
            {
               keyPair = (array[i++] as String).split(":");
               if(keyPair.length == 2)
               {
                  if(this.keys == null)
                  {
                     this.keys = new Array();
                  }
                  this.keys.push({
                     "code":int(keyPair[0] as String),
                     "value":int(keyPair[1] as String)
                  });
               }
            }
         }
         if(mouseData.length > 0)
         {
            array = mouseData.split(",");
            if(array.length >= 4)
            {
               this.mouse = new MouseRecord(int(array[0] as String),int(array[1] as String),int(array[2] as String),int(array[3] as String));
            }
         }
         return this;
      }

*/