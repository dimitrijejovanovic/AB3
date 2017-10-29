using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABPort.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
       // public IEnumerable<Project> Projects { get; set; }

        public Category() { }
        public Category(string name)
        {
            CategoryName = name;
        }
    }
}