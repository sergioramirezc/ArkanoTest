using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkanoTest.Service.Computer.Repository
{
    public interface IRamRepository
    {
        IEnumerable<Data.RAM> GetAll();

    }
}
