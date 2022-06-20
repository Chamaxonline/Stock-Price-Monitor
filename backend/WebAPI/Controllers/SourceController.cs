using Domain.SourceDomain;
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
    public class SourceController : ControllerBase
    {
        private readonly ISourceService _sourceService;
        public SourceController(ISourceService sourceService)
        {
            _sourceService = sourceService;
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult> Add(Source source)
        {
            return Ok(await _sourceService.Add(source));
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult> Get()
        {
            return Ok(await _sourceService.GetAll());
        }
    }
}
