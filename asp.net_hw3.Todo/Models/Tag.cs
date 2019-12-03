using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp.net_hw3.Todo.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string TagName { get; set; }

        public virtual ICollection<Todo> Todos { get; set; }

        public Tag()
        {
            Todos = new List<Todo>();
        }
    }
}