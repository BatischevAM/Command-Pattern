using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Command_Pattern
{
    public class DeleteTextCommand : ICommand
    {
        private readonly TextEditor _editor;
        private readonly int _length;
        private string _deletedText;

        public DeleteTextCommand(TextEditor editor, int length)
        {
            _editor = editor;
            _length = length;
        }

        public void Execute()
        {
            _deletedText = _editor.DeleteText(_length);
        }

        public void Undo()
        {
            if (_deletedText != null)
            {
                _editor.InsertText(_deletedText);
            }
        }
    }
}
