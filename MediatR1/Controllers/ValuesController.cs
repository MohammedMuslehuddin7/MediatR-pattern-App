using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MediatR1.MediatR.Commands;
using MediatR1.MediatR.Queries;
using Microsoft.AspNetCore.Mvc;

namespace MediatR1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public IMediator _mediatR;
        public ValuesController(IMediator obj)
        {
            _mediatR = obj;
        }

        [HttpGet]
        public IActionResult GetValue()
        {
            ReadNumber read = new ReadNumber();
            read.Number1 = 15;
            var a = _mediatR.Send(read);
            return Ok(a.Result);
        }
        [HttpGet]
        public IActionResult AddNumbers()
        {
            AddNumbersCommand numbers = new AddNumbersCommand();
            numbers.Number1 = 17;
            numbers.Number2 = 23;
            var data = _mediatR.Send(numbers);
            return Ok(data.Result);

        }
        [HttpGet]
        public IActionResult GetAllVoters()
        {
            GetAllVoterInfoQuery obj = new GetAllVoterInfoQuery();
            var data = _mediatR.Send(obj);
            return Ok(data.Result);
        }
        [HttpPost]
        public IActionResult AddVoters(AddVotersCommand data)
        {
            _mediatR.Send(data);
            return Ok(true);
        }
        [HttpPost]
        public IActionResult UpdateVotersInfo(UpdateVotersInfoCommand data)
        {
            _mediatR.Send(data);
            return Ok(true);
        }
        [HttpDelete]
        public IActionResult RemoveVoterInfo(RemoveVoterInfoCommand data)
        {
            _mediatR.Send(data);
            return Ok(true);
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
