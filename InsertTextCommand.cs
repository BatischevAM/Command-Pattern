using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Command_Pattern
{
    public class InsertTextCommand : ICommand
    {
        private readonly TextEditor _editor;
        private readonly string _text;

        public InsertTextCommand(TextEditor editor, string text)
        {
            _editor = editor;
            _text = text;
        }

        public void Execute()
        {
            _editor.InsertText(_text);
        }

        public void Undo()
        {
            _editor.DeleteText(_text.Length);
        }
    }
}
