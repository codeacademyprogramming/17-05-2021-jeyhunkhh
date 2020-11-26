using System;
using System.Collections.Generic;
using System.Text;

namespace _220620
{
    class Modem
    {
        public string Name { get; set; }

        private string _password;

        private int _capacity;
        public int Capacity => _capacity;

        private int _connectionCount;
        public int ConnectionCount => _connectionCount;

        public Modem(string name,string password)
        {
            this.Name = name;
            this._password = password;
            this._capacity = 5;
        }

        public bool Connect(string password)
        {
            if (password != _password) return false;

            if (_connectionCount >= _capacity) return false;

            _connectionCount++;

            return true;
        }

        public void Disconnect()
        {
            _connectionCount--;
        }

        public bool ChangePassword(string oldPassword,string newPassword,bool logoutAll=false)
        {
            if (oldPassword != _password) return false;

            _password = newPassword;

            if (logoutAll)
            {
                _connectionCount = 0;
            }

            return true;
        }
    }
}
