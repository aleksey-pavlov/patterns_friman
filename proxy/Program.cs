using System;

namespace proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new Server();
            var serverProxy = new ServerProxy(server);
            var user = new User(UserRole.User);

            server.GetData(user);

            serverProxy.GetData(user);

            var userAdmin = new User(UserRole.Admin);

            serverProxy.GetData(userAdmin);
        }
    }
}
