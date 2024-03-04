using System;
using System.Collections.Generic;

public class WaveData
{
    public const int WAVES = 20;
    public List<List<object>> waves;

    public WaveData()
    {
        waves = new List<List<object>>();
        InitWaves();
        LoadData();
    }

    private void LoadData()
    {
        ABSTL(1, 1, 2, 50);
        ABSTL(2, 1, 6, 60);
        ABSTL(3, 1, 2, 50);
        ABSTL(3, 2, 1, 60);
        ABSTL(3, 1, 2, 50);
        ABSTL(3, 2, 2, 50);
        ABSTL(4, 1, 3, 40);
        ABSTL(4, 2, 1, 40);
        ABSTL(4, 1, 3, 60);
        ABSTL(4, 2, 1, 30);
        ABSTL(5, 1, 1, 350);
        ABSTL(5, 1, 2, 120);
        ABSTL(5, 2, 3, 40);
        ABSTL(5, 1, 4, 50);
        ABSTL(5, 2, 3, 40);
        ABSTL(6, 1, 10, 60);
        ABSTL(6, 2, 10, 90);
        ABSTL(7, 2, 10, 70);
        ABSTL(7, 1, 15, 40);
        ABSTL(8, 1, 15, 50);
        ABSTL(8, 3, 1, 30);
        ABSTL(8, 2, 10, 40);
        ABSTL(9, 1, 40, 40);
        ABSTL(10, 2, 6, 30);
        ABSTL(10, 1, 1, 500);
        ABSTL(10, 2, 10, 30);
        ABSTL(10, 3, 2, 40);
        ABSTL(10, 2, 8, 30);
        ABSTL(11, 2, 1, 300);
        ABSTL(11, 2, 5, 100);
        ABSTL(11, 2, 10, 100);
        ABSTL(11, 2, 12, 50);
        ABSTL(11, 2, 20, 40);
        ABSTL(12, 3, 2, 30);
        ABSTL(12, 1, 15, 40);
        ABSTL(12, 3, 2, 20);
        ABSTL(12, 2, 15, 50);
        ABSTL(12, 5, 1, 100);
        ABSTL(12, 3, 2, 100);
        ABSTL(13, 1, 100, 40);
        ABSTL(14, 2, 5, 15);
        ABSTL(14, 1, 1, 300);
        ABSTL(14, 2, 7, 15);
        ABSTL(14, 1, 1, 300);
        ABSTL(14, 3, 4, 20);
        ABSTL(14, 2, 10, 15);
        ABSTL(15, 1, 20, 30);
        ABSTL(15, 4, 1, 20);
        ABSTL(15, 2, 20, 20);
        ABSTL(16, 4, 1, 30);
        ABSTL(16, 2, 20, 30);
        ABSTL(16, 3, 2, 20);
        ABSTL(16, 4, 1, 40);
        ABSTL(16, 1, 40, 20);
        ABSTL(16, 3, 2, 40);
        ABSTL(17, 1, 20, 40);
        ABSTL(17, 5, 1, 120);
        ABSTL(17, 2, 20, 40);
        ABSTL(17, 3, 4, 40);
        ABSTL(17, 2, 200, 30);
        ABSTL(17, 1, 1, 300);
        ABSTL(17, 3, 4, 40);
        ABSTL(18, 4, 1, 100);
        ABSTL(18, 5, 3, 100);
        ABSTL(18, 4, 1, 60);
        ABSTL(18, 2, 60, 30);
        ABSTL(18, 4, 2, 30);
        ABSTL(18, 5, 3, 80);
        ABSTL(19, 5, 2, 40);
        ABSTL(19, 4, 2, 40);
        ABSTL(19, 3, 4, 60);
        ABSTL(19, 2, 80, 30);
        ABSTL(19, 4, 2, 40);
        ABSTL(19, 5, 2, 40);
        ABSTL(19, 2, 12, 40);
        ABSTL(20, 2, 30, 40);
        ABSTL(20, 1, 60, 20);
        ABSTL(20, 1, 1, 600);
        ABSTL(20, 6, 8, 30);
        ABSTL(20, 5, 6, 40);
        ABSTL(20, 2, 60, 40);
        ABSTL(20, 1, 1, 600);
        ABSTL(20, 4, 8, 40);
        ABSTL(20, 3, 12, 40);
        ABSTL(20, 5, 6, 40);
        ABSTL(20, 2, 60, 30);
    }

    private void ABSTL(uint param1, uint param2, uint param3, uint param4)
    {
        var obj = new Dictionary<string, object>();
        obj["type"] = param2;
        obj["framesDelay"] = param4;

        for (int i = 0; i < param3; i++)
        {
            waves[(int)param1].Add(obj);
        }
    }

    private void InitWaves()
    {
        for (int i = 0; i <= WAVES; i++)
        {
            waves.Add(new List<object>());
        }
    }
}
// javascript

   public class WaveData
   {
      
      public static const WAVES:* = 20;
       
      
      public var waves:Array;
      
      public function WaveData()
      {
         super();
         initWaves();
         loadData();
      }
      
      private function loadData() : *
      {
         ABSTL(1,1,2,50);
         ABSTL(2,1,6,60);
         ABSTL(3,1,2,50);
         ABSTL(3,2,1,60);
         ABSTL(3,1,2,50);
         ABSTL(3,2,2,50);
         ABSTL(4,1,3,40);
         ABSTL(4,2,1,40);
         ABSTL(4,1,3,60);
         ABSTL(4,2,1,30);
         ABSTL(5,1,1,350);
         ABSTL(5,1,2,120);
         ABSTL(5,2,3,40);
         ABSTL(5,1,4,50);
         ABSTL(5,2,3,40);
         ABSTL(6,1,10,60);
         ABSTL(6,2,10,90);
         ABSTL(7,2,10,70);
         ABSTL(7,1,15,40);
         ABSTL(8,1,15,50);
         ABSTL(8,3,1,30);
         ABSTL(8,2,10,40);
         ABSTL(9,1,40,40);
         ABSTL(10,2,6,30);
         ABSTL(10,1,1,500);
         ABSTL(10,2,10,30);
         ABSTL(10,3,2,40);
         ABSTL(10,2,8,30);
         ABSTL(11,2,1,300);
         ABSTL(11,2,5,100);
         ABSTL(11,2,10,100);
         ABSTL(11,2,12,50);
         ABSTL(11,2,20,40);
         ABSTL(12,3,2,30);
         ABSTL(12,1,15,40);
         ABSTL(12,3,2,20);
         ABSTL(12,2,15,50);
         ABSTL(12,5,1,100);
         ABSTL(12,3,2,100);
         ABSTL(13,1,100,40);
         ABSTL(14,2,5,15);
         ABSTL(14,1,1,300);
         ABSTL(14,2,7,15);
         ABSTL(14,1,1,300);
         ABSTL(14,3,4,20);
         ABSTL(14,2,10,15);
         ABSTL(15,1,20,30);
         ABSTL(15,4,1,20);
         ABSTL(15,2,20,20);
         ABSTL(16,4,1,30);
         ABSTL(16,2,20,30);
         ABSTL(16,3,2,20);
         ABSTL(16,4,1,40);
         ABSTL(16,1,40,20);
         ABSTL(16,3,2,40);
         ABSTL(17,1,20,40);
         ABSTL(17,5,1,120);
         ABSTL(17,2,20,40);
         ABSTL(17,3,4,40);
         ABSTL(17,2,200,30);
         ABSTL(17,1,1,300);
         ABSTL(17,3,4,40);
         ABSTL(18,4,1,100);
         ABSTL(18,5,3,100);
         ABSTL(18,4,1,60);
         ABSTL(18,2,60,30);
         ABSTL(18,4,2,30);
         ABSTL(18,5,3,80);
         ABSTL(19,5,2,40);
         ABSTL(19,4,2,40);
         ABSTL(19,3,4,60);
         ABSTL(19,2,80,30);
         ABSTL(19,4,2,40);
         ABSTL(19,5,2,40);
         ABSTL(19,2,12,40);
         ABSTL(20,2,30,40);
         ABSTL(20,1,60,20);
         ABSTL(20,1,1,600);
         ABSTL(20,6,8,30);
         ABSTL(20,5,6,40);
         ABSTL(20,2,60,40);
         ABSTL(20,1,1,600);
         ABSTL(20,4,8,40);
         ABSTL(20,3,12,40);
         ABSTL(20,5,6,40);
         ABSTL(20,2,60,30);
      }
      
      private function ABSTL(param1:uint, param2:uint, param3:uint, param4:uint) : *
      {
         var _loc5_:* = undefined;
         var _loc6_:uint = 0;
         (_loc5_ = new Object()).type = param2;
         _loc5_.framesDelay = param4;
         _loc6_ = 0;
         while(_loc6_ < param3)
         {
            waves[param1].push(_loc5_);
            _loc6_++;
         }
      }
      
      private function initWaves() : *
      {
         var _loc1_:uint = 0;
         waves = new Array();
         _loc1_ = 0;
         while(_loc1_ <= WAVES)
         {
            waves[_loc1_] = new Array();
            _loc1_++;
         }
      }
   }