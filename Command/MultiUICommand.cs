using CommandPatternExtension.Command;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace CommandPatternExtension.WPF.Command
{
    public class MultiUICommand
        : MultiCommand
    {
        public MultiUICommand(IList<ICommand> commands)
            : base(commands) { }

        public override event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
