using APIScheduler.Interface;
using APIScheduler.Models.View;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIScheduler.Controllers
{
    [ApiController]
    [Route("api/v1/Home")]
    public class HomeController : Controller
    {
        private readonly ISchedulerAPI scheduler;

        public HomeController(ISchedulerAPI scheduler)
        {
            this.scheduler = scheduler;
        }

        [HttpPost]
        public IActionResult AddMe(AddMeModel model)
        {
            try
            {
                var Result = scheduler.AddMe(model);
                return Ok(Result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
