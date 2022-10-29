using System;
using System.Collections.Generic;

namespace command
{
    public class RemoteControl
    {
        private Dictionary<int, ICommand> buttons;
        private ICommand lastCommand;

        public RemoteControl()
        {
            buttons = new Dictionary<int, ICommand>();
        }

        public void SetButtonCommand(int button, ICommand command)
        {
            buttons[button] = command;
        } 

        public void PressButton(int button)
        {
            buttons[button].execute();

            lastCommand = buttons[button];
        }

        public void UndoButton()
        {
            lastCommand.undo();
        }
    }
}
