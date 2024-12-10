using DesignPatternPractice.ChainOfResponsitility.Example_01.Interfaces;

namespace DesignPatternPractice.ChainOfResponsitility.Example_01.Models;
public class InfoLogger : LogHandler
{
    public override void Handle(string message, LogLevel level)
    {
        if (level == LogLevel.Info)
        {
            Console.WriteLine($"INFO: {message}");
        }
        else
        {
            NextHandler?.Handle(message, level);
        }
    }
}
