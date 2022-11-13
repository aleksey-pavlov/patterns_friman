
using System;

namespace state
{
    public interface IBuilding
    {
        public void NextState();

        public void GetCurrentState();

        public void SetState(IState state);

        public IState GetThreeState();

        public IState GetTwoState();

        public IState GetFirstState();
    }
}