using DesignPatternPractice.Command.Example_01.Interfaces;

namespace DesignPatternPractice.Command.Example_01.Models;
public class TurnOnCommand : ICommand
{
    private readonly Light _light;

    public TurnOnCommand(Light light) => _light = light;

    public void Execute() => _light.TurnOn();
    public void Undo() => _light.TurnOff();
}
