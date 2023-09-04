using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApi_CadastrarUser.Models;

namespace WebApi_CadastrarUser.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
