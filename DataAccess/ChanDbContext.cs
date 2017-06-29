using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApi.Models
{
    public class ChanDbContext : DbContext
    {
        public ChanDbContext()
            : base("DefaultConnection")
        {

        }

        public virtual DbSet<SampleDataSet> SampleDataSets { get; set; }

    }
}