namespace state
{
    public interface IState
    {
        string GetState();

        void NextState();
    }
}