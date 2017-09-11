using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MobileApp.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("MobileAppContext")
        {
        }

        public DbSet<ClickInfo> ClickInfoes { get; set; }
    }
}