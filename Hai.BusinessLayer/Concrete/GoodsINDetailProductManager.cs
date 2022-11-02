using Hai.BusinessLayer.Abstract;
using Hai.DataAcces.Abstract;
using Hai.DataAcces.Concrete;
using Hai.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hai.BusinessLayer.Concrete
{
    public class GoodsINDetailProductManager : IGoodsINDetailProductService
    {
        private IGoodsINDetailProductRepository _goodsINDetailProductRepository;
        public GoodsINDetailProductManager()
        {
            _goodsINDetailProductRepository = new GoodsINDetailProductRepository();
        }
        public async Task<GoodsINDetailProduct> CreateGIDP(GoodsINDetailProduct goodsdp)
        {
            return await _goodsINDetailProductRepository.CreateGIDP(goodsdp);
        }

        public async Task DeleteGIDP(long Id)
        {
            await _goodsINDetailProductRepository.DeleteGIDP(Id);
        }

        public async Task<List<GoodsINDetailProduct>> GetAllGIDP()
        {
            return await _goodsINDetailProductRepository.GetAllGIDP();
        }

        public async Task<GoodsINDetailProduct> GetGIDPById(long Id)
        {
            return await _goodsINDetailProductRepository.GetGIDPById(Id);
        }

        public async Task<GoodsINDetailProduct> UpdateGIDP(GoodsINDetailProduct goodsdp)
        {
            return await _goodsINDetailProductRepository.UpdateGIDP(goodsdp);
        }
    }
}
