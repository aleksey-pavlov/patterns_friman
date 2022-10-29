using System;

namespace command
{
    public interface ICommand
    {
        void execute();
        
        void undo();
    }

    public class LigthOnCommand : ICommand
    {
        private Light light;

        public LigthOnCommand(Light light)
        {
            this.light = light;
        }
        
        public void execute()
        {
            light.On();
        }

        public void undo()
        {
            light.Off();
        }
    }
}
