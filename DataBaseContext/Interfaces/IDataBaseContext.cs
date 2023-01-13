using Microsoft.EntityFrameworkCore;
using Models;

namespace DataBaseContext.Interfaces
{
    public interface IDataBaseContext
    {
        public DbSet<PizzaModel> PizzaDataModels { get; set; }

        public DbSet<PizzaModel> GetDataModels();

        public void SaveData();
    }
}
