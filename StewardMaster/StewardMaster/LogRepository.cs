using StewardMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StewardMaster
{
    public class LogRepository
    {
        private readonly StewardMasterContext _dbContext;

        public LogRepository()
        {
            _dbContext = new StewardMasterContext();
        }

        public void Save(LogEntryModel logEntry)
        {
            _dbContext.LogEntries.Add(logEntry);
            _dbContext.SaveChanges();
        }

        public IEnumerable<LogEntryModel> GetAllEntries()
        {
            return _dbContext.LogEntries.ToList();
        }
    }
}