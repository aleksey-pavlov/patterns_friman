using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client(new StorageV1());

            client.SetName("client whitch use storage v1");

            Console.WriteLine(client.GetName());


            // This error because StorageV2 not implement Storage interface
            // new Client(new StorageV2());

            var client2 = new Client(new StorageV2Adapter(new StorageV2()));

            client2.SetName("client whitch use storage v2 via adapter");

            Console.WriteLine(client2.GetName());
        }
    }


    class Client
    {
        private Storage _storage;
        public Client(Storage storage)
        {
            this._storage = storage;
        }

        public void SetName(string name)
        {
            _storage.Save(name);
        }

        public string GetName()
        {
            return _storage.Read();
        }
    }


    interface Storage
    {
        void Save(string data);
        string Read();
    }


    class StorageV1 : Storage
    {
        private string _data;

        public void Save(string data)
        {
            _data = data;
        }

        public string Read()
        {
            return _data;
        }
    }


    class StorageV2Adapter : Storage
    {
        private StorageV2 _storage;

        public StorageV2Adapter(StorageV2 storage)
        {
            _storage = storage;
        }

        public string Read()
        {
            return _storage.GetData();
        }

        public void Save(string data)
        {
            _storage.SaveData(data);
        }
    }

    class StorageV2
    {
        private string _data;

        public void SaveData(string data)
        {
            _data = data;
        }

        public string GetData()
        {
            return _data;
        }
    }

}
