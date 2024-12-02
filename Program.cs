using Command_Pattern;
using System.Windows.Input;
using ICommand = Command_Pattern.ICommand;

class Program
{
    static void Main(string[] args)
    {
        TextEditor editor = new TextEditor();
        
        ICommand insertHello = new InsertTextCommand(editor, "Hello");
        editor.ExecuteCommand(insertHello);
        ICommand insertWorld = new InsertTextCommand(editor, " World");
        editor.ExecuteCommand(insertWorld);

        ICommand deleteText = new DeleteTextCommand(editor, 6); // Удаляем " World"
        editor.ExecuteCommand(deleteText);

        editor.Undo();
        editor.Undo();
        editor.Undo();
        editor.Undo();
    }
}

    
