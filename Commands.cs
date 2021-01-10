using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using MySqlConnector.Authentication;
using MySqlConnector.Logging;
using MySqlConnector;

namespace PSBNebeskyServer
{
    class Commands
    {
        MySqlConnection connection;
        public void CreateConnection()
        {
            connection = new MySqlConnection("Database=DATABASE_NAME;Data Source=localhost;User Id=USER_NAME;Password=USER_PASS");
        }

        class UserLogOn
        {
            public bool Validate(string user, SecureString pass)
            {
                bool validateUser = false;

                return validateUser;
            }
        }

        class UserBalance
        {

        }

        class UserMoneyDeposit
        {

        }

        class UserMoneyWithdrawal
        {

        }

        class UserNewTransaction
        {

        }

        class UserTransactionHistory
        {

        }
    }
}
