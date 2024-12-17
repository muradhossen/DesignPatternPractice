

using DesignPatternPractice;
using DesignPatternPractice.ChainOfResponsitility;
using DesignPatternPractice.Command;
using DesignPatternPractice.Memento;
using DesignPatternPractice.State;

IController controller = ControllerFactory.GetController(typeof(StateController));

controller.Execute();

Console.ReadKey();

