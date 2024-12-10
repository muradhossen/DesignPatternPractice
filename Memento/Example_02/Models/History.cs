namespace DesignPatternPractice.Memento.Example_02.Models;
public class History
{
    private Stack<TextEditorState> _states = new Stack<TextEditorState>();

    public void Save(TextEditorState state) => _states.Push(state);
    public TextEditorState Undo() => _states.Pop();
}
