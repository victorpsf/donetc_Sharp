using MySql.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;

using Estudo.Models;

namespace Estudo.Data
{
    public class BaseContext : DbContext
    {
        // deixando o dotnet core gerenciar as conexões com o banco de dados
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {
        }

        // declarando base tabela
        public DbSet<Item> Itens { get; set; }
    }
}