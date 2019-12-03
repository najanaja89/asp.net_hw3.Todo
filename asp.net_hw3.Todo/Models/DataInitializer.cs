using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace asp.net_hw3.Todo.Models
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<TodoDataContext>
    {
        //public override void InitializeDatabase(ShopContext context)
        //      {
        //          context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction
        //              , string.Format("ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE", context.Database.Connection.Database));

        //          base.InitializeDatabase(context);
        //      }

        protected override void Seed(TodoDataContext context)
        {

            var tag = new Tag
            {
                TagName = "TestTagName"
            };
            var todo = new Todo
            {
                Name = "TestName",
                Description = "TestDescription"
            };
            tag.Todos.Add(todo);
            todo.Tags.Add(tag);


            context.Todos.Add(todo);
            context.Tags.Add(tag);
            context.SaveChanges();
        }

    }
}