using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ArkanoTest.Service.Computer.Data;

namespace ArkanoTest.Service.Computer.Repository
{
    public class RamRepository : IRamRepository
    {
        ComputerDbContext db = new ComputerDbContext();
        
        public IEnumerable<RAM> GetAll()
        {
            return db.Ram.ToList();
        }
    }
}