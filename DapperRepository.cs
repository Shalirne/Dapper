using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Npgsql;

namespace DapperWork
{
    public class DapperRepository
    {
        public static IEnumerable<Movies> GetInfo(string info)
        {
            using (var conn = new NpgsqlConnection(Config.SqlConnectionString))
            {
                string sql = $"SELECT title FROM film WHERE title = @info";
                return conn.Query<Movies>(sql, new { info });
            }
        }
        public static IEnumerable<Movies> GetInfo(int info)
        {
            using (var conn = new NpgsqlConnection(Config.SqlConnectionString))
            {
                string sql = $"SELECT title FROM film WHERE length > @info";
                return conn.Query<Movies>(sql, new { info });
            }
        }
        public static IEnumerable<Movies> GetInfo()
        {
            using (var conn = new NpgsqlConnection(Config.SqlConnectionString))
            {
                string sql = "SELECT DISTINCT first_name FROM actor";
                return conn.Query<Movies>(sql);
            }
        }
        //public static IEnumerable<Movies> GetInfo1(string info) - получение количества фильмов с определенный рейтингом
        //{
        //    using (var conn = new NpgsqlConnection(Config.SqlConnectionString))
        //    {
        //        string sql = $"SELECT rating, COUNT(film) FROM film WHERE CAST(rating AS CHAR(15)) LIKE '%{info}%' GROUP BY rating";
        //        return conn.Query<Movies>(sql);
        //    }
        //}
    }
}
