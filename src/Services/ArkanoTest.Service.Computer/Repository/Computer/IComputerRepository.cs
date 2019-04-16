using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkanoTest.Service.Computer.Repository
{
    public interface IComputerRepository
    {
        IEnumerable<Data.Computer> GetAll();
    }
}
