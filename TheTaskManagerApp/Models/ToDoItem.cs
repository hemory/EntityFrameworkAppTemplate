using System.Data.Entity;

namespace TheTaskManagerApp.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class ToDoDbContext : DbContext
    {
        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}