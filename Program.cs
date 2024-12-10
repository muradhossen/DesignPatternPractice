

using DesignPatternPractice;
using DesignPatternPractice.ChainOfResponsitility;
using DesignPatternPractice.Command;
using DesignPatternPractice.Memento;

IController controller = ControllerFactory.GetController(typeof(CommandController));

controller.Execute();

Console.ReadKey();

