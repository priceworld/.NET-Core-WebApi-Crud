using Hai.BusinessLayer.Abstract;
using Hai.BusinessLayer.Concrete;
using Hai.Entities.Entities;
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
    public class GoodsOutController : ControllerBase
    {
        private IGoodsOutService _goodsOutService;
        public GoodsOutController()
        {
            _goodsOutService = new GoodsOutManager();
        }
        /// <summary>
        /// Get All GoodsINDetail
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var goodso = await _goodsOutService.GetAllGO();
            return Ok(goodso);
        }
        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetGOById(long id)
        {
            var goodso = await _goodsOutService.GetGOById(id);
            if (goodso != null)
            {
                return Ok(goodso);
            }
            return NotFound();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateGID([FromBody] GoodsOut goodso)
        {
            var createdGoodsOut = await _goodsOutService.CreateGO(goodso);
            return CreatedAtAction("Get", new { id = createdGoodsOut.id }, createdGoodsOut);
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateGO([FromBody] GoodsOut goodso)
        {
            if (await _goodsOutService.GetGOById(goodso.id) != null)
            {
                return Ok(await _goodsOutService.UpdateGO(goodso));
            }
            return NotFound();
        }
        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            if (await _goodsOutService.GetGOById(id) != null)
            {
                await _goodsOutService.DeleteGO(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
