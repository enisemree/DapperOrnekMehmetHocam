using Dapper;
using DataAccess.Entities;
using DataAccess.Repositories.Abstract;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concrete
{
    public class LessonRepository : ILessonRepository
    {
        IDbConnection conn;
        public LessonRepository()
        {
            var connectionString = "Host=localhost;Port=5432;Username=postegres;Password=12345;Database=School";
            conn = new NpgsqlConnection(connectionString);
        }


        public async Task<List<Lesson>> GetAllAsync()
        {
            var sql = $@"select * from ""MAIN"".""Lesson""";
            var list = await conn.QueryAsync<Lesson>(sql);

            return list.ToList();
        }

        public async Task<Lesson> GetByIdAsync(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("id", id);
            var sql = $@"select * from ""MAIN"".""Lesson"" where ""Id"" = " + id;
            var data = await conn.QueryFirstOrDefaultAsync<Lesson>(sql,parameters);
            return data;
        }
        public void OpenConnection()
        {
            conn.Open();
        }
        
        public void CloseConnection()
        {
            conn?.Close();
        }

        public Task<List<Lesson>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
