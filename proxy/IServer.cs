using System;

namespace proxy
{
    public interface IServer
    {
        public void GetData(IUser user);
    }
}