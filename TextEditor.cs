using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Command_Pattern
{
    public class TextEditor
    {
        private string _text = string.Empty;
        private readonly Stack<ICommand> _commandHistory = new Stack<ICommand>();

        public void InsertText(string text)
        {
            _text += text;
            Console.WriteLine($"Текст после вставки: {_text}");
        }

        public string DeleteText(int length)
        {
            if (length > _text.Length) length = _text.Length;
            string deletedText = _text.Substring(_text.Length - length);
            _text = _text.Substring(0, _text.Length - length);
            Console.WriteLine($"Текст после удаления: {_text}");
            return deletedText;
        }

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandHistory.Push(command);
        }

        public void Undo()
        {
            if (_commandHistory.Count > 0)
            {
                ICommand command = _commandHistory.Pop();
                command.Undo();
                Console.WriteLine($"Отмена последней команды");
            }
            else
            {
                Console.WriteLine("Нет команд для отмены.");
            }
        }
    }
}
  

