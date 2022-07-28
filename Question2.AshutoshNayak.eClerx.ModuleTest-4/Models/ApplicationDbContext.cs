using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Question2.AshutoshNayak.eClerx.ModuleTest_4.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("EclerxConn")
        {

        }
        public DbSet<BookDetails> Books{ get; set; }
    }
}