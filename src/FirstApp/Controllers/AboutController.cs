using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Controllers
{
    [Route("[controller]")]
    public class AboutController : Controller
    {
        [Route("")]
        public string Phone()
        {
            return "My Name is Ghanshyam Singh";
        }
        [Route("[action]")]
        public string  Country()
        {
            return "India";
        }
    }
}
