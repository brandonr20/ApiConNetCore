using ApiConNetCore.Data;
using ApiConNetCore.ModelsTest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public TestController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Test>>> GetTest()
        {
            return await _dbContext.Tests.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Test>> GetTestById(int id)
        {

            var test = await _dbContext.Tests.FindAsync(id);

            return test;
        }

        [HttpPost]
        public async Task<ActionResult<Test>> PostTest(Test test)
        {
            _dbContext.Tests.Add(test);
            await _dbContext.SaveChangesAsync();

            return Ok(test);
        }

    }
}
