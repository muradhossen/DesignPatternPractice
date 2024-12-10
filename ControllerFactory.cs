using DesignPatternPractice.ChainOfResponsitility;
using DesignPatternPractice.Command;
using DesignPatternPractice.Memento;

namespace DesignPatternPractice;
public static class ControllerFactory
{
    public static IController GetController(Type type)
    {
        if (typeof(MementoController) == type)
        {
            return new MementoController();
        }
        else if (typeof(ChainOfResponsibilityController) == type)
        {
            return new ChainOfResponsibilityController();
        }
        else if (typeof(CommandController) == type)
        {
            return new CommandController();
        }
        throw new ArgumentException("Invalid type!!");
    }
}
