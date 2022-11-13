using System;

namespace proxy
{
    public class ServerProxy : IServer
    {
        private IServer server { get; set; }

        public ServerProxy(IServer server)
        {
            this.server = server;
        }

        public void GetData(IUser user)
        {
            if (user.GetRole() == UserRole.User)
            {
                Console.WriteLine("Access denied");
                return;
            }

            server.GetData(user);
        }
    }
}