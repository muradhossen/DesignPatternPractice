namespace DesignPatternPractice.ChainOfResponsitility.Example_01.Interfaces;
public abstract class LogHandler
{
    protected LogHandler NextHandler;

    public void SetNext(LogHandler nextHandler)
    {
        NextHandler = nextHandler;
    }
    public abstract void Handle(string message, LogLevel level);
}
