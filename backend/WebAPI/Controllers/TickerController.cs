using Domain.TickerDomain;
using Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TickerController : ControllerBase
    {
        private readonly ITickerService _tickerService;
        public TickerController(ITickerService tickerService)
        {
            _tickerService = tickerService;
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult> Add(Ticker ticker)
        {
            return Ok(await _tickerService.Add(ticker));
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            return Ok(await _tickerService.GetAll());
        }
    }
}
