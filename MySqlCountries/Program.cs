using System;
using System.Data.SQLite;

namespace MySqlCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadCountries();
        }

        private static void ReadCountries()
        {
            Database databaseObj = new Database();

            string query = "SELECT Country.countryname AS Country, Capital.capitalname as Capital FROM Capital JOIN Country on Capital.countryid = Country.rowid";

            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObj.myConnection);
            databaseObj.OpenConnection();

            SQLiteDataReader data = myCommand.ExecuteReader();

            if (data.HasRows)
            {
                while (data.Read())
                {
                    Console.WriteLine($"Country: {data["Country"]}, Capital: {data["Capital"]}");
                }
            }

            databaseObj.CloseConnection();

        }


    }
}
