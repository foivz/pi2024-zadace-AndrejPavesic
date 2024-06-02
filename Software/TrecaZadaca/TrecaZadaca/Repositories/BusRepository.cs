using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using TrecaZadaca.Models;

namespace TrecaZadaca.Repositories
{
    public class BusRepository
    {
        public static List<Bus> GetBuses()
        {
            List<Bus> buses = new List<Bus>();

            string sql = "SELECT * FROM Buses";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read()) {
                Bus bus = CreateObject(reader);
                buses.Add(bus);
            }

            reader.Close();
            DB.CloseConnection();

            return buses;
        }

        private static Bus CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID"].ToString());
            string startingPoint = reader["Starting_point"].ToString();
            string destination = reader["Destination"].ToString();
            string name = reader["Name"].ToString();

            var bus = new Bus
            {
                ID = id,
                startingPoint = startingPoint,
                Destination = destination,
                Name = name
            };
            return bus;
        }
    }
}
