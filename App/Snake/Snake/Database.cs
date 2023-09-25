using System;
using System.Data;
using System.Data.SQLite;

namespace Snake
{
    public class Database
    {
        private readonly string dataSource;
        public Database(string dataSource)
        {
            this.dataSource = dataSource;
        }

        public int UserHighScore (string user)
        {
            int score = -1;
            SQLiteConnection conn = new SQLiteConnection(dataSource);

            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("SELECT score FROM rateTable WHERE user = '{0}'", user);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            score = Convert.ToInt32(reader.GetValue(0));
                        }
                        return score;
                    }
                    return score = 0;
                }
            }

            return score;
        }

        public void WriteUserHighScore (string user, int newHS)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection(dataSource);

                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();

                    cmd.CommandText = string.Format("SELECT count(*) FROM rateTable WHERE user = '{0}'",
                    user);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 0)
                    {
                        cmd.CommandText = string.Format("INSERT INTO rateTable (user,score) VALUES ('{0}','{1}')", user, newHS);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        cmd.CommandText = string.Format("UPDATE rateTable SET score='{0}' WHERE user='{1}'", newHS, user);
                        cmd.ExecuteNonQuery();
                    }
                }
            } 
            
            catch (Exception ex)
            {
                return;
            }
        }
    }
}
