using DesignPatternPractice.ChainOfResponsitility.Example_01.Interfaces;

namespace DesignPatternPractice.ChainOfResponsitility.Example_01.Models;
public class ErrorLogger : LogHandler
{
    public override void Handle(string message, LogLevel level)
    {
        if (level == LogLevel.Error)
        {
            Console.WriteLine($"ERROR: {message}");
        }
        else
        {
            NextHandler?.Handle(message, level);
        }
    }
}
