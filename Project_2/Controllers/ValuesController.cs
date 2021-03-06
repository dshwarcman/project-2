﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_2.Data;

namespace Project_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets All Values.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetValues() => base.Ok(await _context.Values.ToListAsync());

        /// <summary>
        /// Gets a specific Value.
        /// </summary>
        /// <param name="id"></param> 
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValueAsync(int id) => Ok(await _context.Values.SingleOrDefaultAsync(e => e.Id == id));

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
