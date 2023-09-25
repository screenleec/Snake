using System;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WindowsFormsApp2
{
    public class Database
    {
        private readonly string dataSource;
        public Database(string dataSource)
        {
            this.dataSource = dataSource;
        }
        public bool InitializeDatabase()
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    string sql_command = "DROP TABLE IF EXISTS users;"
                    + "CREATE TABLE users("
                    + "login TEXT PRIMARY KEY, "
                    + "password TEXT, ";
                    cmd.CommandText = sql_command;
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Dispose();
            }
            return true;
        }

        public bool createUser(string username, string password)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection(dataSource);

                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();

                    cmd.CommandText = string.Format("INSERT INTO users (login, password)"
                    + "VALUES ('{0}', '{1}')",
                    username, Hash(password));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Успешная регистрация!");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nЛогин уже используется");
            }
            return false;
        }
        public bool CheckUser(User user)
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("SELECT count(*) FROM users WHERE login = '{0}' AND password = '{1}'",
                user.login_get(), Hash(user.password_get()));

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 0) return false;

                return true;
            }

            return false;
        }

        private string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

    }
}
