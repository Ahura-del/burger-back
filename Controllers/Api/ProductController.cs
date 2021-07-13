using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySQLAPICore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLAPICore.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private MyDBContext myDbContext;

        public ProductController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<Product> Get()
        {
            return myDbContext.Products.ToList();
        }

     
    }
}
