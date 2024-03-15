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

    public class ConditionerOnCommend : ICommand
    {
        private Conditioner conditioner;

        public ConditionerOnCommend(Conditioner conditioner)
        {
            this.conditioner = conditioner;
        }

        public void execute()
        {
            conditioner.On();
        }

        public void undo()
        {
            conditioner.Off();
        }
    }
}
