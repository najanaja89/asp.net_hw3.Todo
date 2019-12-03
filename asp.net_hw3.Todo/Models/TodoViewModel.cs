using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp.net_hw3.Todo.Models
{
    public class TodoViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TagViewModel Tag { get; set; }
    }
}