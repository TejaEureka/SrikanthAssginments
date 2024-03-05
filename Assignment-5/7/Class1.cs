using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFundamentals
{
    internal class Program
    {
        static void Main()
        {
            
            Console.Write("Enter Ticker Symbol: ");
            string tickerSymbol = Console.ReadLine();

            
            string connectionString = "Server=endeavourtech.ddns.net;Port=31240;User Id=evr_sql_app;Password=5LViU5pLkSjRHECec9NF4wRxxV;Database=StocksDB;";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                
                conn.Open();

                
                NpgsqlCommand cmd = new NpgsqlCommand($"SELECT * FROM endeavour.stock_fundamentals WHERE ticker_symbol = @tickerSymbol", conn);
                cmd.Parameters.AddWithValue("tickerSymbol", tickerSymbol);

                
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    
                    if (reader.Read())
                    {
                        
                        Console.WriteLine($"ticker_symbol: {reader["ticker_symbol"]}");
                        Console.WriteLine($"subsector_id: {reader["subsector_id"]}");
                        Console.WriteLine($"sector_id: {reader["sector_id"]}");
                        Console.WriteLine($"market_cap: {reader["market_cap"]}");
                        Console.WriteLine($"current_ratio: {reader["current_ratio"]}");
                        Console.WriteLine($"price_to_book_ratio: {reader["price_to_book_ratio"]}");
                        Console.WriteLine($"peg: {reader["peg"]}");
                        Console.WriteLine($"epsqq: {reader["epsqq"]}");
                        Console.WriteLine($"eps_nxtyear: {reader["eps_nxtyear"]}");
                        Console.WriteLine($"eps_ttm: {reader["eps_ttm"]}");
                        Console.WriteLine($"roe: {reader["roe"]}");
                        Console.WriteLine($"insider_ownership: {reader["insider_ownership"]}");
                        Console.WriteLine($"debt_equity_ratio: {reader["debt_equity_ratio"]}");
                        Console.WriteLine($"trailing_pe: {reader["trailing_pe"]}");
                        Console.WriteLine($"forward_pe: {reader["forward_pe"]}");
                    }
                    else
                    {
                        
                        Console.WriteLine("Ticker Symbol not found");
                    }
                }
            }
        }
    }
}
