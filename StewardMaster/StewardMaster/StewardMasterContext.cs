using StewardMaster.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StewardMaster
{
    public class StewardMasterContext : DbContext
    {
        public DbSet<LogEntryModel> LogEntries { get; set; }

        public StewardMasterContext()
            : base("DefaultConnection")
        {
        }

        public static StewardMasterContext Create()
        {
            return new StewardMasterContext();
        }
    }
}