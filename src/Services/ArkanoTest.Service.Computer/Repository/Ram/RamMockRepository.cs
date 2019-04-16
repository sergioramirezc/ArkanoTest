using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ArkanoTest.Service.Computer.Data;

namespace ArkanoTest.Service.Computer.Repository.Ram
{
    public class RamMockRepository : IRamRepository
    {
        IEnumerable<RAM> Rams = new List<RAM>() {
            new RAM() { Id = 1, Brand = new Brand{ Id = 1, Name = "brand"}, Capacity = 4, ItemTag = "RAM-001", SerialNumber = "HQ-111002-9985", Standart = "DDR4" },
            new RAM() { Id = 2, Brand = new Brand{ Id = 1, Name = "brand"}, Capacity = 8, ItemTag = "RAM-002", SerialNumber = "ZP-7778552-5552", Standart = "DDR4" },
            new RAM() { Id = 3, Brand = new Brand{ Id = 1, Name = "brand"}, Capacity = 16, ItemTag = "RAM-003", SerialNumber = "PP-322855-0332", Standart = "DDR3" },
        };
        public IEnumerable<RAM> GetAll()
        {
            return Rams;
        }
    }
}