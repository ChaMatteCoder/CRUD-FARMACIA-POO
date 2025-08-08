using Npgsql;
using System;
using System.Data;

namespace FarmaciaPOO
{
    public class Database
    {
        private string connString = "Host=localhost; Port=5432; Username=postgres; Password=91516900; Database=farmacia";

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connString);
        }
    }
}
