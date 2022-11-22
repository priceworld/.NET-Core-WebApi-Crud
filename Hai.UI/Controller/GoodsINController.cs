using Hai.BusinessLayer.Abstract;
using Hai.BusinessLayer.Concrete;
using Hai.Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hai.UI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsINController : ControllerBase
    {
        private IGoodsINService _goodsService;
        public GoodsINController()
        {
            _goodsService = new GoodsINManager();
        }
        /// <summary>
        /// Get All GoodsIn
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            var goods = await _goodsService.GetAllGI();
            return Ok(goods);
        }
        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetGIById(long id)
        {
            var goods = await _goodsService.GetGIById(id);
            if (goods != null)
            {
                return Ok(goods);
            }
            return NotFound();
        }

        // OrderCode ile request atma
        [HttpGet]
        [Route("[action]/{OrderCode}")]
        public async Task<IActionResult> GetGIByOrderCode(string OrderCode)
        {
            var goods = await _goodsService.GetGIByOrderCode(OrderCode);
            if (goods != null)
            {
                return Ok(goods);
            }
            return NotFound();
        }

        //-------------------------------------------------------------

        //id ve Ordercode ile request atma
        //[HttpGet]
        //[Route("[action]/{id}/{OrderCode}")]
        //public IActionResult GetGIByIdAndOrderCode(string OrderCode)
        //{
        //    return Ok();
        //}

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateGI([FromBody] GoodsIN goods)
        {
            var createdGoodsIn = await _goodsService.CreateGI(goods);
            return CreatedAtAction("Get", new { id = createdGoodsIn.id }, createdGoodsIn);
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateGI([FromBody] GoodsIN goods)
        {
            if (await _goodsService.GetGIById(goods.id) != null)
            {
                return Ok(await _goodsService.UpdateGI(goods));
            }
            return NotFound();
        }
        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            if (await _goodsService.GetGIById(id) != null)
            {
                await _goodsService.DeleteGI(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
