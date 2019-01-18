using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BenchmarkController : ControllerBase
    {
        private BenchmarkService _benchmarkService;

        public BenchmarkController(BenchmarkService benchmarkService)
        {
            _benchmarkService = benchmarkService;
        }

         // GET api/benchmark/{id}
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("test");
        }

        // GET api/benchmark/{id}
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_benchmarkService.GetHeavilyRequestedObjectById(id));
        }
    }
}
