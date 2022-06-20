using Domain.PriceDomain;
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
    public class PriceController : ControllerBase
    {
        private readonly IPriceService _priceService;
        private readonly IPriceMapper _priceMapper;
        public PriceController(IPriceService priceService, IPriceMapper priceMapper)
        {
            _priceService = priceService;
            _priceMapper = priceMapper;
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult> Add(Price price)
        {
            return Ok(await _priceService.Add(price));
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult>GetAll()
        {
            return Ok(await _priceService.GetAll());
        }

        [HttpGet]
        [Route("LatestPriceList")]
        public async Task<ActionResult> LatestPriceList(int sourceId, int tickerId)
        {
            return Ok(await _priceService.LatestPriceList(sourceId, tickerId));
        }

        [HttpPost]
        [Route("AddRandomPriceList")]
        public async Task<List<Price>> AddRandomPriceList()
        {
           var priceList = await _priceMapper.AddNewRecords();

            foreach (var price in priceList)
            {
               await _priceService.Add(price);
            }

            return priceList;
        }
    }
}
