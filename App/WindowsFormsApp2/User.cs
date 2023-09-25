using System;

namespace WindowsFormsApp2
{
    public class User
    {
        private string login;
        private string password;

        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public string login_get()
        {
            return login;
        }

        public string password_get()
        {
            return password;
        }

        public bool IsCorrect()
        {
            Database database = new Database("Data Source = dataBase.db; Version = 3;");

            if (database.CheckUser(this))
                return true;

            return false;
        }
    }
}