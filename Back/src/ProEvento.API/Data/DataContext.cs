using Microsoft.EntityFrameworkCore;
using ProEvento.API.models;

namespace ProEvento.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Evento> Evento { get; set; }
    }
}