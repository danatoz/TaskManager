using System;
using Microsoft.EntityFrameworkCore;
using TaskManager.Model;
using Microsoft.Data.Sqlite;

namespace DBToDo
{
    public class TaskContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "Data Source=.\\Tasks.db");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

    }
}
