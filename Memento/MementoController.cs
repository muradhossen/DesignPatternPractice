using DesignPatternPractice.Memento.Example_01.Models;
using DesignPatternPractice.Memento.Example_02.Models;


namespace DesignPatternPractice.Memento;
public class MementoController  : IController
{
    public void Execute()
    {
        //Example01();
        Example02();
    }

    private void Example01()
    {
        Originator originator = new Originator("Super-duper-super-puper-super.");
        Caretaker caretaker = new Caretaker(originator);

        caretaker.Backup();
        originator.DoSomething();

        caretaker.Backup();
        originator.DoSomething();

        caretaker.Backup();
        originator.DoSomething();

        Console.WriteLine();
        caretaker.ShowHistory();

        Console.WriteLine("\nClient: Now, let's rollback!\n");
        caretaker.Undo();

        Console.WriteLine("\n\nClient: Once more!\n");
        caretaker.Undo();
    }

    private void Example02()
    {
        var editor = new TextEditor();
        var history = new History();

        editor.Content = "Version 1";
        history.Save(editor.SaveState());

        editor.Content = "Version 2";
        history.Save(editor.SaveState());

        editor.Content = "Version 3";

        Console.WriteLine($"Current Content: {editor.Content}"); // Version 3
        editor.RestoreState(history.Undo());
        Console.WriteLine($"After Undo: {editor.Content}"); // Version 2
        editor.RestoreState(history.Undo());
        Console.WriteLine($"After Undo: {editor.Content}"); // Version 1
    }

}
