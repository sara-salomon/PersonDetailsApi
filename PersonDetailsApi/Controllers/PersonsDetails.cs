using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonDetails.BLL.FunctionsBll;

namespace PersonDetailsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsDetailsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<UserDTO> Get()
        {
            return Ok(PersonDetails.BLL.FunctionsBll.UsersBll.GetUsers());
        } 
        [HttpPost]
        public void Post([FromBody] UserDTO user)
        {
            UsersBll userBl = new UsersBll();
            userBl.PostUser(user);
        }
    }
}
