using DesignPatternPractice.ChainOfResponsitility;
using DesignPatternPractice.Command;
using DesignPatternPractice.Memento;
using DesignPatternPractice.State;

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
        else if (typeof(StateController) == type)
        {
            return new StateController();
        }
        throw new ArgumentException("Invalid type!!");
    }
}
