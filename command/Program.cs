using System;

namespace command
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl = new RemoteControl();

            var lightOnCommand = new LigthOnCommand(new Light());

            remoteControl.SetButtonCommand(1, lightOnCommand);

            remoteControl.PressButton(1);

            remoteControl.UndoButton();
        }
    }



}
