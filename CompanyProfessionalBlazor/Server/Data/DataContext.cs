
using System;

namespace CompanyProfessionalBlazor.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) //vai criar as listas novamente aqui em baixo
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //pegar listas do controller
        {
            modelBuilder.Entity<Offer>().HasData
            (
    }
}
