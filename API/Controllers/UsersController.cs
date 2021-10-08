using API.Data;
using API.Entitites;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        public UsersController(DataContext context)
        {
            this._context = context;
        }

        public DataContext _context  { get; set; }

        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            return _context.User.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser(int id)
        {
            int[] test = new int[2] ; 
            return _context.User.Find(id);
        
        }
    }
}
