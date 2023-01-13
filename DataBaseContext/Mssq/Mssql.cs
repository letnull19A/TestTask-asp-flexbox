using DataBaseContext.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DataBaseContext.Mssq
{
    public sealed class Mssql : DbContext, IDataBaseContext
    {

        public DbSet<PizzaModel> PizzaDataModels { get; set; }

        public Mssql(DbContextOptions<Mssql> option) : base(option)
        {
            Database.EnsureCreated();
        }

        public DbSet<PizzaModel> GetDataModels() => PizzaDataModels;

        public void SaveData() 
        {
            SaveChanges(); 
        }
    }
}
