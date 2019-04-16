using ArkanoTest.Service.Computer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace ArkanoTest.Service.Computer.Controllers
{
    public class RamsController : ApiController
    {
        private IRamRepository _ramRepository;

        public RamsController(IRamRepository ramRepository)
        {
            _ramRepository = ramRepository;
        }

        // GET: api/Rams
        [ResponseType(typeof(List<Data.Computer>))]
        public async Task<IHttpActionResult> GetRams()
        {
            var rams = _ramRepository.GetAll().ToList();
            return Ok(rams);
        }
    }
}
