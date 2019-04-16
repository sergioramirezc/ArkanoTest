using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ArkanoTest.Service.Computer.Data;
using ArkanoTest.Service.Computer.Repository;

namespace ArkanoTest.Service.Computer.Controllers
{
    public class ComputersController : ApiController
    {
        private IComputerRepository _computerRepository;

        public ComputersController(IComputerRepository computerRepository)
        {
            _computerRepository = computerRepository;
        }

        // GET: api/Computers
        [ResponseType(typeof(List<Data.Computer>))]
        public async Task<IHttpActionResult> GetComputers()
        {
            var computers = _computerRepository.GetAll().ToList();
            return Ok(computers);
        }
    }
}