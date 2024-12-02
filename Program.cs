using Command_Pattern;
using System.Windows.Input;
using ICommand = Command_Pattern.ICommand;

class Program
{
    static void Main(string[] args)
    {
        TextEditor editor = new TextEditor();

        // Ввод текста
        ICommand insertHello = new InsertTextCommand(editor, "Hello");
        editor.ExecuteCommand(insertHello);

        ICommand insertWorld = new InsertTextCommand(editor, " World");
        editor.ExecuteCommand(insertWorld);

        // Удаление текста
        ICommand deleteText = new DeleteTextCommand(editor, 6); // Удаляем " World"
        editor.ExecuteCommand(deleteText);

        // Отмена последней операции (удаления)
        editor.Undo();

        // Отмена последней операции (вставки " World")
        editor.Undo();

        // Отмена последней операции (вставки "Hello")
        editor.Undo();

        // Попытка отмены без доступных операций
        editor.Undo();
    }
}

    