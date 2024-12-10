namespace DesignPatternPractice.Memento.Example_02.Models;
public class TextEditor
{
    public string Content { get; set; }
    public TextEditorState SaveState() => new TextEditorState(Content);
    public void RestoreState(TextEditorState state) => Content = state.Content;
}
