using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SectorLookup
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter sector ID: ");
            if (int.TryParse(Console.ReadLine(), out int sectorId))
            {
                string connectionString = "Server=endeavourtech.ddns.net;Port=31240;User Id=evr_sql_app;Password=5LViU5pLkSjRHECec9NF4wRxxV;Database=StocksDB;";

                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    NpgsqlCommand cmd = new NpgsqlCommand("SELECT sector_name FROM endeavour.sector_lookup WHERE sector_id = @sectorId", conn);
                    cmd.Parameters.AddWithValue("sectorId", sectorId);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string sectorName = result.ToString();
                        Console.WriteLine($"Sector Name: {sectorName}");
                    }
                    else
                    {
                        Console.WriteLine("Sector ID not found");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid sector ID.");
            }
        }
    }
}
