
using System;

namespace state
{
    public class Building : IBuilding
    {
        protected IState FirstState { get; set; }
        protected IState TwoState { get; set; }
        protected IState ThreeState { get; set; }

        protected IState State { get; set; }

        public Building()
        {
            FirstState = new FirstState(this);
            TwoState = new TwoState(this);
            ThreeState = new ThreeState(this);
            State = FirstState;
        }

        public void NextState()
        {
            State.NextState();
        }

        public void GetCurrentState()
        {
            Console.WriteLine(State.GetState());
        }

        public void SetState(IState state)
        {
            State = state;
        }

        public IState GetThreeState()
        {
            return ThreeState;
        }

        public IState GetTwoState()
        {
            return TwoState;
        }

        public IState GetFirstState()
        {
            return FirstState;
        }
    }
}