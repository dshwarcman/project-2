using System;
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
    public class MessagesController : ControllerBase
    {
        private DataContext _context;

        public MessagesController(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets All Messages.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetMessages() => base.Ok(await _context.Messages.ToListAsync());
    }
}