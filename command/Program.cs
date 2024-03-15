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

            var conditionerOnCommand = new ConditionerOnCommend(new Conditioner());

            remoteControl.SetButtonCommand(2, conditionerOnCommand);

            remoteControl.PressButton(1);

            remoteControl.UndoButton();

            remoteControl.PressButton(2);

            remoteControl.UndoButton();
        }
    }
}
