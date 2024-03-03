 using System;

public class Ellipse
{
    protected double _x;
    protected double _y;
    protected double _width;
    protected double _height;

    public Ellipse(double x, double y, double width, double height)
    {
        _x = x;
        _y = y;
        _width = width;
        _height = height;
    }

    public double X
    {
        get { return _x; }
        set { _x = value; }
    }

    public double Y
    {
        get { return _y; }
        set { _y = value; }
    }

    public double Width
    {
        get { return _width; }
        set { _width = value; }
    }

    public double Height
    {
        get { return _height; }
        set { _height = value; }
    }

    public Point Center
    {
        get { return new Point(_x + _width * 0.5, _y + _height * 0.5); }
        set
        {
            _x = value.X - _width * 0.5;
            _y = value.Y - _height * 0.5;
        }
    }
    public Point Size
    {
        get { return new Point(_width, _height); }
    }

    public double Perimeter
    {
        get { return Math.Sqrt(0.5 * (_width * _width + _height * _height)) * Math.PI * 2 * 0.5; }
    }

    public double Area
    {
        get { return Math.PI * (_width * 0.5) * (_height * 0.5); }
    }
   public Point GetPointOfDegree(double degree)
    {
        double radians = (degree - 90) * (Math.PI / 180);
        double halfWidth = _width * 0.5;
        double halfHeight = _height * 0.5;
        double pointX = _x + halfWidth + Math.Cos(radians) * halfWidth;
        double pointY = _y + halfHeight + Math.Sin(radians) * halfHeight;
        return new Point(pointX, pointY);
    }
   public Point GetPointOfDegreeAux(double degree)
    {
        degree = -degree;
        double radians = degree * (Math.PI / 180);
        double halfWidth = _width * 0.5;
        double halfHeight = _height * 0.5;
        double pointX = _x + halfWidth + Math.Cos(radians) * halfWidth;
        double pointY = _y + halfHeight + Math.Sin(radians) * halfHeight;
        return new Point(pointX, pointY);
    }
 public bool ContainsPoint(Point point)
    {
        double halfWidth = _width * 0.5;
        double halfHeight = _height * 0.5;
        double offsetX = point.X - _x - halfWidth;
        double offsetY = point.Y - _y - halfHeight;
        return Math.Pow(offsetX / halfWidth, 2) + Math.Pow(offsetY / halfHeight, 2) <= 1;
    }
 public bool Equals(Ellipse other)
    {
        return _x == other._x && _y == other._y && _width == other._width && _height == other._height;
    }

    public Ellipse Clone(): Ellipse
    {
        return new Ellipse(_x, _y, _width, _height);
    }
}

public class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
}



//
public class Ellipse
   {
      protected var _x:Number;
      protected var _y:Number;
      protected var _width:Number;
      protected var _height:Number;
      public function Ellipse(param1:Number, param2:Number, param3:Number, param4:Number)
      {
         super();
         this.x = param1;
         this.y = param2;
         this.width = param3;
         this.height = param4;
      }
      public function get x() : Number
      { return this._x;}
      
      public function set x(param1:Number) : void
      { this._x = param1;}
      
      public function get y() : Number
      { return this._y;}
 
      public function set y(param1:Number) : void
      { this._y = param1;}
      
      public function get width() : Number
      { return this._width;}
      
      public function set width(param1:Number) : void
      { this._width = param1;}
      
      public function get height() : Number
      { return this._height;}
      
      public function set height(param1:Number) : void
      { this._height = param1;}
      
      public function get center() : Point
      { return new Point(this.x + this.width * 0.5,this.y + this.height * 0.5);
      }
      
      public function set center(param1:Point) : void
      {this.x = param1.x - this.width * 0.5;
         this.y = param1.y - this.height * 0.5;}
      
      public function get size() : Point
      { return new Point(this.width,this.height);}
      
      public function get perimeter() : Number
      { return Math.sqrt(0.5 * (Math.pow(this.width,2) + Math.pow(this.height,2))) * Math.PI * 2 * 0.5;}
      
      public function get area() : Number
      {return Math.PI * (this.width * 0.5) * (this.height * 0.5);
      }
      
      public function getPointOfDegree(param1:Number) : Point
      {
         var _loc2_:Number = (param1 - 90) * (Math.PI / 180);
         var _loc3_:Number = this.width * 0.5;
         var _loc4_:Number = this.height * 0.5;
         return new Point(this.x + _loc3_ + Math.cos(_loc2_) * _loc3_,this.y + _loc4_ + Math.sin(_loc2_) * _loc4_);
      }
      
      public function getPointOfDegreeAux(param1:Number) : Point
      {
         param1 = -param1;
         var _loc2_:Number = param1 * (Math.PI / 180);
         var _loc3_:Number = this.width * 0.5;
         var _loc4_:Number = this.height * 0.5;
         return new Point(this.x + _loc3_ + Math.cos(_loc2_) * _loc3_,this.y + _loc4_ + Math.sin(_loc2_) * _loc4_);
      }
      
      public function containsPoint(param1:Point) : Boolean
      {
         var _loc2_:Number = this.width * 0.5;
         var _loc3_:Number = this.height * 0.5;
         var _loc4_:Number = param1.x - this.x - _loc2_;
         var _loc5_:Number = param1.y - this.y - _loc3_;
         return Math.pow(_loc4_ / _loc2_,2) + Math.pow(_loc5_ / _loc3_,2) <= 1;
      }
      
      public function equals(param1:Ellipse) : Boolean
      {
         return this.x == param1.x && this.y == param1.y && this.width == param1.width && this.height == param1.height;
      }
      
      public function clone() : Ellipse
      {return new Ellipse(this.x,this.y,this.width,this.height);}
   }