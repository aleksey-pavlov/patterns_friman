namespace adapter
{

    public class TurkeyAdapter : Duck
    {
        private Turkey turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            this.turkey = turkey;
        }

        public void Quack()
        {
            turkey.Gobble();
        }

        public void Fly()
        {
            for (var i = 0; i < 5; i++)
                turkey.Fly();
        }
    }
}