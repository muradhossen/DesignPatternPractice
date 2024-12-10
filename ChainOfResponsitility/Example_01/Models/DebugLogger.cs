using DesignPatternPractice.ChainOfResponsitility.Example_01.Interfaces;

namespace DesignPatternPractice.ChainOfResponsitility.Example_01.Models;
public class DebugLogger : LogHandler
{
    public override void Handle(string message, LogLevel level)
    {
        if (level == LogLevel.Debug)
        {
            Console.WriteLine($"DEBUG : {message}");
        }
        else
        {
            NextHandler?.Handle(message, level);
        }
    }
}
