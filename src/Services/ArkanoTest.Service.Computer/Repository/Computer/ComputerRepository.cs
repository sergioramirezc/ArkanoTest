using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ArkanoTest.Service.Computer.Data;

namespace ArkanoTest.Service.Computer.Repository
{
    public class ComputerRepository : IComputerRepository
    {
        ComputerDbContext db = new ComputerDbContext();

        public IEnumerable<Data.Computer> GetAll()
        {
            return db.Computers.ToList();
        }
    }
}