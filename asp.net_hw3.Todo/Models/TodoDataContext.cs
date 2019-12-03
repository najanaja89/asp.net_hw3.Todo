namespace asp.net_hw3.Todo.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TodoDataContext : DbContext
    {
        // Your context has been configured to use a 'TodoDataContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'asp.net_hw3.Todo.Models.TodoDataContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TodoDataContext' 
        // connection string in the application configuration file.
        public TodoDataContext()
            : base("name=TodoDataContext")
        {
            Database.SetInitializer(new DataInitializer());
        }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Tag> Tags { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}