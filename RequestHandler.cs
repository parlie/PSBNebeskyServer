using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace PSBNebeskyServer
{
    public class RequestHandler
    {
        private enum commands{
            command1, //Request validation of users identity; requires password and user identity; will keep user signed in for certain period of time
            command2, //Request money amount for signed user
            command3, //Requst 
            command4,
            command5,
            command6,
        };

        public void ProccesCommand(string val)
        {
            
        }
    }
}
