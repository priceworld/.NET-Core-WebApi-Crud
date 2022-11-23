using Hai.BusinessLayer.Abstract;
using Hai.BusinessLayer.Concrete;
using Hai.DataAcces.Abstract;
using Hai.DataAcces.Concrete;
using Hai.Entities;
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
    [Authorize]
    public class GoodsINDetailProductController : ControllerBase
    {
        private IGoodsINDetailProductService _goodsINDetailProductService;
        public GoodsINDetailProductController()
        {
            _goodsINDetailProductService = new GoodsINDetailProductManager();
        }
        /// <summary>
        /// Get All GoodsINDetail
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllGIDP()
        {
            var goodsdp = await _goodsINDetailProductService.GetAllGIDP();
            return Ok(goodsdp);
        }
        [HttpGet]
        [Route("[action]/{Id}")]
        public async Task<IActionResult> GetGIDPById(long Id)
        {
            var goodsdp = await _goodsINDetailProductService.GetGIDPById(Id);
            if (goodsdp != null)
            {
                return Ok(goodsdp);
            }
            return NotFound();
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateGIDP([FromBody] GoodsINDetailProduct goodsdp)
        {
            var createdGoodsInDetailProduct = await _goodsINDetailProductService.CreateGIDP(goodsdp);
            return CreatedAtAction("Get", new { id = createdGoodsInDetailProduct.Id }, createdGoodsInDetailProduct);
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateGIDP([FromBody] GoodsINDetailProduct goodsdp)
        {
            if (await _goodsINDetailProductService.GetGIDPById(goodsdp.Id) != null)
            {
                return Ok(await _goodsINDetailProductService.UpdateGIDP(goodsdp));
            }
            return NotFound();
        }
        [HttpDelete]
        [Route("[action]/{Id}")]
        public async Task<IActionResult> DeleteGIDP(long Id)
        {
            if (await _goodsINDetailProductService.GetGIDPById(Id) != null)
            {
                await _goodsINDetailProductService.DeleteGIDP(Id);
                return Ok();
            }
            return NotFound();
        }
    }
}
