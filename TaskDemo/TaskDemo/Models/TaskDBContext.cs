using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace TaskDemo.Models
{
    public class TaskDBContext: DbContext
    {
        public TaskDBContext()
            : base("name=TaskDBContext")
        {
        }
        public DbSet<task> tasks { get; set; }
    }
}