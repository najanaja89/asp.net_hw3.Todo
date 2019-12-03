using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp.net_hw3.Todo.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

        public Todo()
        {
            Tags = new List<Tag>();
        }

    }
}