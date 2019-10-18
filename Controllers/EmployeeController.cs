using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Payroll2.Services;

namespace Payroll2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IDataService _dataService;
        public EmployeeController(IDataService dataService)
        {
            _dataService = dataService;
        }
        // GET: api/Employee
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var data = _dataService.GetById(id);
            if (data != null)
                return Ok(data);
            return NotFound();
        }



        // POST: api/Employee
        [HttpPost]
        public void Post([FromBody] string value)
        {
            //TODO: Write code here to create an employee record.
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            //TODO: Write code here to update an employee record.
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //TODO: Write code here to delete an employee record.
        }
    }
}
