using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Model;
using eProdaja.Services;

namespace eProdaja.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class KupciController : BaseReadController<Model.Kupci, object>
    {
        public KupciController(IReadService<Kupci, object> service) : base (service)
        {
        }

        //[HttpGet]
        //public IList<Model.Kupci> GetAll([FromQuery] KupciSearchRequest request)
        //{
        //    return _service.GetAll(request);
        //}

    }
}
