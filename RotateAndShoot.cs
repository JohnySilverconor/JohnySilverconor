using System;
using System.Collections.Generic;
namespace GameObjects
{
    public class GameObject
    {
        // Public properties
        public double Vx { get; set; } = 0;
        public double Vy { get; set; } = 0;

        public GameObject(DisplayObject image, bool center = true)
        {
            // Add the image
            this.Children.Add(image);

            // Center the image if the "center" option is true
            if (center)
            {
                image.X -= image.Width / 2;
                image.Y -= image.Height / 2;
            }
        }
    }

public class RotateAndShoot
{
    private const double SPEED = 3;
    private const double TURN_SPEED = 0.3;
    private const double RANGE = 200;
    private const double FRICTION = 0.96;
    private double _beeAngle;
    private GameObject _bee = new GameObject(new BeeImage());
    private Timer _bulletTimer;
    private List<GameObject> _bullets = new List<GameObject>();

    public RotateAndShoot()
    {
        _bee.x = 275;
        _bee.y = 175;

        _bulletTimer = new Timer(1000);
        _bulletTimer.Elapsed += BulletTimerHandler;

        // Add event listeners
        // Assuming stage is a reference to the stage object
        stage.EnterFrame += EnterFrameHandler;
    }

    private void BulletTimerHandler(object sender, ElapsedEventArgs e)
    {
        // Create a bullet and add it to the stage
        var bulletImage = new BulletImage();
        var bullet = new GameObject(bulletImage);
        stage.AddChild(bullet);

        // Set the bullet's starting position
        int radius = 30;
        bullet.x = _bee.x + (radius * Math.Cos(_beeAngle));
        bullet.y = _bee.y + (radius * Math.Sin(_beeAngle));

        // Set the bullet's velocity based on the angle
        bullet.vx = Math.Cos(_beeAngle) * 2 + _bee.vx;
        bullet.vy = Math.Sin(_beeAngle) * 2 + _bee.vy;

        _bullets.Add(bullet);

        // Find a random start time for the next bullet
        double randomFireTime = Math.Round(new Random().NextDouble() * 1000) + 200;
        _bulletTimer.Interval = randomFireTime;
    }

    private void EnterFrameHandler(object sender, EventArgs e)
    {
        double target_X = stage.MouseX;
        double target_Y = stage.MouseY;

        double vx = target_X - _bee.x;
        double vy = target_Y - _bee.y;

        double distance = Math.Sqrt(vx * vx + vy * vy);
        if (distance <= RANGE)
        {
            double move_X = TURN_SPEED * vx / distance;
            double move_Y = TURN_SPEED * vy / distance;

            _bee.vx += move_X;
            _bee.vy += move_Y;

            double moveDistance = Math.Sqrt(_bee.vx * _bee.vx + _bee.vy * _bee.vy);

            _bee.vx = SPEED * _bee.vx / moveDistance;
            _bee.vy = SPEED * _bee.vy / moveDistance;

            _beeAngle = Math.Atan2(_bee.vy, _bee.vx);

            _bee.rotation = _beeAngle * 180 / Math.PI + 90;

            _bulletTimer.Start();
        }
        else
        {
            _bulletTimer.Stop();
        }

        _bee.vx *= FRICTION;
        _bee.vy *= FRICTION;

        _bee.x += _bee.vx;
        _bee.y += _bee.vy;

        for (int i = 0; i < _bullets.Count; i++)
        {
            var bullet = _bullets[i];
            bullet.x += bullet.vx;
            bullet.y += bullet.vy;

            if (bullet.y < 0 || bullet.x < 0 || bullet.x > stage.StageWidth || bullet.y > stage.StageHeight)
            {
                stage.RemoveChild(bullet);
                bullet = null;
                _bullets.RemoveAt(i);
                i--;
            }
        }
    }
}
}