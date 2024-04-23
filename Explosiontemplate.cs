using System;
using System.Timers;

namespace MyNamespace
{
    public class Explosion
    {
        //Private properties
        private System.Windows.Controls.Image _explosionImage = new System.Windows.Controls.Image();
        private System.Windows.Controls.Canvas _explosion = new System.Windows.Controls.Canvas();
        private Timer _timer;

        public Explosion()
        {
            _explosion.Children.Add(_explosionImage);
            _explosion.Visibility = System.Windows.Visibility.Hidden;
            
            _timer = new Timer(2000);
            _timer.Elapsed += ExplosionTimeHandler;
        }

        //Public methods
        public void Explode()
        {
            _explosion.Visibility = System.Windows.Visibility.Visible;
            _timer.Start();
        }

        //Private methods
        private void ExplosionTimeHandler(object sender, ElapsedEventArgs e)
        {
            _explosion.Visibility = System.Windows.Visibility.Hidden;
            _timer.Stop();
            _timer.Elapsed -= ExplosionTimeHandler;
        }
    }
}