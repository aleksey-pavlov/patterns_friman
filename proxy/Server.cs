using System;

namespace proxy
{
    public class Server : IServer
    {
        public void GetData(IUser user)
        {
            Console.WriteLine($"SomeData for {user.GetRole()}");
        }
    }
}