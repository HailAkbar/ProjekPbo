using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace ProjekPbo.Database
{
    public class Koneksi
    {
        private static string connString = "Host=localhost;Port=5432;Username=postgres;Password=Sulix;Database=PboSQL";
        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connString);
        }
    }
}
