using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPriceHistory
{
    internal class Program
    {
        static void Main()
        {
            string connectionString = "Server=endeavourtech.ddns.net;Port=31240;User Id=evr_sql_app;Password=5LViU5pLkSjRHECec9NF4wRxxV;Database=StocksDB;";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT ticker_symbol, MAX(trading_date) AS latest_date, close_price " +
                                                    "FROM endeavour.stocks_price_history sph " +
                                                    "WHERE ticker_symbol LIKE 'A%' " +
                                                    "GROUP BY ticker_symbol, close_price", conn);

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Ticker Symbol: {reader["ticker_symbol"]}");
                        Console.WriteLine($"Latest Date: {reader["latest_date"]}");
                        Console.WriteLine($"Close Price: {reader["close_price"]}");
                        Console.WriteLine();
                    }

                    if (!reader.HasRows)
                    {
                        Console.WriteLine("No stock price history found for stock symbols starting with 'A'.");
                    }
                }
            }
        }
    }
}
