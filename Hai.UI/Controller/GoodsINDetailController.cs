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
    public class GoodsINDetailController : ControllerBase
    {
        private IGoodsINDetailService _goodsINDetailService;
        public GoodsINDetailController()
        {
            _goodsINDetailService = new GoodsINDetailManager();
        }
        /// <summary>
        /// Get All GoodsINDetail
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var goods = await _goodsINDetailService.GetAllGID();
            return Ok(goods);
        }
        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetGIDById(long id)
        {
            var goodsd = await _goodsINDetailService.GetGIDById(id);
            if (goodsd != null)
            {
                return Ok(goodsd);
            }
            return NotFound();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateGID([FromBody] GoodsINDetail goodsd)
        {
            var createdGoodsInDetail = await _goodsINDetailService.CreateGID(goodsd);
            return CreatedAtAction("Get", new { id = createdGoodsInDetail.id }, createdGoodsInDetail);
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateGI([FromBody] GoodsINDetail goodsd)
        {
            if (await _goodsINDetailService.GetGIDById(goodsd.id) != null)
            {
                return Ok(await _goodsINDetailService.UpdateGID(goodsd));
            }
            return NotFound();
        }
        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            if (await _goodsINDetailService.GetGIDById(id) != null)
            {
                await _goodsINDetailService.DeleteGID(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
