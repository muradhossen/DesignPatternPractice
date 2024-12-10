using DesignPatternPractice.Command.Example_01.Interfaces;

namespace DesignPatternPractice.Command.Example_01.Models;
public class RemoteControl
{
    private ICommand _command;

    public void SetCommand(ICommand command) => _command = command;

    public void PressButton() => _command.Execute();

    public void PressUndo() => _command.Undo();
}
