using Microsoft.EntityFrameworkCore;
using TodoList.Server.Data.EntityConfiguration;

namespace TodoList.Server.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<ListOfTodos> ListsOfTodos { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TodoConfiguration());
            modelBuilder.ApplyConfiguration(new ListOfTodosConfiguration());
            modelBuilder.ApplyConfiguration(new UsersConfiguration());
        }
    }
}
