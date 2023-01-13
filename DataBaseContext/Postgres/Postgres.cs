using DataBaseContext.Interfaces;
using DataBaseContext.Mssq;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DataBaseContext.Postgres
{
    public sealed class Postgres : DbContext, IDataBaseContext
    {
        public DbSet<PizzaModel> PizzaDataModels { get; set; }

        public Postgres(DbContextOptions<Postgres> option) : base(option)
        {
            Database.EnsureCreated();
        }

        public DbSet<PizzaModel> GetDataModels()
        {
            throw new NotImplementedException();
        }

        public void SaveData()
        {
            throw new NotImplementedException();
        }
    }
}
