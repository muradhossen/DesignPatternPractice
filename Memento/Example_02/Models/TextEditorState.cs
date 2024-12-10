namespace DesignPatternPractice.Memento.Example_02.Models;
public class TextEditorState
{
    public string Content { get; }
    public TextEditorState(string content)
    {
        Content = content;
    }
}
