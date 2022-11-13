namespace state
{
    public abstract class State : IState
    {
        protected IBuilding Building { get; set; }

        public State(IBuilding building)
        {
            Building = building;
        }

        public abstract void NextState();

        public abstract string GetState();
    }

    public class FirstState : State
    {
        public FirstState(IBuilding building) : base(building) { }

        public override string GetState()
        {
            return "FirstState";
        }

        public override void NextState()
        {
            Building.SetState(Building.GetTwoState());
        }
    }

    public class TwoState : State
    {
        public TwoState(IBuilding building) : base(building) { }

        public override string GetState()
        {
            return "TwoState";
        }

        public override void NextState()
        {
            Building.SetState(Building.GetThreeState());
        }
    }

    public class ThreeState : State
    {
        public ThreeState(IBuilding building) : base(building) { }

        public override string GetState()
        {
            return "ThreeState";
        }

        public override void NextState()
        {
            Building.SetState(Building.GetFirstState());
        }
    }
}