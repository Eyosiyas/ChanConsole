using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    //A Sample Model class that can be mapped to DB entity with CodeFirst Migrations
    public class SampleDataSet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
    }
}