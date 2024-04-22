using System;
using System.Timers;

public class MessageDisplay
{
    private Timer _timer;
    private string _message = "";

    public MessageDisplay(string message, int time = 0)
    {
        _message = message;

        _timer = new Timer(time);
        _timer.Elapsed += DisplayMessageHandler;
        _timer.AutoReset = false;
        _timer.Start();
    }

    private void DisplayMessageHandler(object sender, ElapsedEventArgs e)
    {
        Console.WriteLine(_message);
        _timer.Stop();
        _timer.Elapsed -= DisplayMessageHandler;
    }

    public static void Main(string[] args)
    {
        MessageDisplay text = new MessageDisplay("hi", 500);
        Console.WriteLine (text._message);
    }
}