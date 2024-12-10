using DesignPatternPractice.Command.Example_01.Models;

namespace DesignPatternPractice.Command;
public class CommandController : IController
{
    public void Execute()
    {

        var light = new Light();
        var turnOn = new TurnOnCommand(light);
        var turnOff = new TurnOffCommand(light);

        var remote = new RemoteControl();

        remote.SetCommand(turnOn);
        remote.PressButton();  // Light is ON
        remote.PressUndo();    // Light is OFF

        remote.SetCommand(turnOff);
        remote.PressButton();  // Light is OFF
        remote.PressUndo();    // Light is ON
    }
}
