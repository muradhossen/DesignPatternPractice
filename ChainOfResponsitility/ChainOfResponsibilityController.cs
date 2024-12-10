using DesignPatternPractice.ChainOfResponsitility.Example_01.Models;
using DesignPatternPractice.ChainOfResponsitility.Example_01;

namespace DesignPatternPractice.ChainOfResponsitility;
public class ChainOfResponsibilityController : IController
{
    public void Execute()
    {
        var infoLogger = new InfoLogger();
        var debugLogger = new DebugLogger();
        var errorLogger = new ErrorLogger();

        infoLogger.SetNext(debugLogger);
        debugLogger.SetNext(errorLogger);

        var logger = infoLogger;

        logger.Handle("This is an info message", LogLevel.Info);
        logger.Handle("This is a debug message", LogLevel.Debug);
        logger.Handle("This is an error message", LogLevel.Error);
    }
}
