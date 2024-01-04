using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Database;
using WebApplication1.Database.Models;
using WebApplication1.Database;
using Microsoft.AspNetCore.Cors;

namespace WebApplication1.Controllers
{
    // Restful APIs doc: https://docs.google.com/document/d/1OsX8IjiQQg6jnU3xyKPA5jYwsElN3pdHfE-g2lecdb4/edit
    [Route("api/customer")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public CustomersController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/customer
        [HttpGet]
        [EnableCors("AllowOrigin")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomer()
        {
            if (_context.customers == null)
            {
                return NotFound();
            }
            return await _context.customers
                .ToListAsync();
        }

    
    

       
    }
}
