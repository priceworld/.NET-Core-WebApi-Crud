using Hai.BusinessLayer.Abstract;
using Hai.DataAcces.Abstract;
using Hai.DataAcces.Concrete;
using Hai.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hai.BusinessLayer.Concrete
{
    public class GoodsINManager : IGoodsINService
    {
        private IGoodsInRepository _goodsInRepository;
        public GoodsINManager()
        {
            _goodsInRepository = new GoodsInRepository();
        }
        public async Task<GoodsIN> CreateGI(GoodsIN goods)
        {
            return await _goodsInRepository.CreateGI(goods);
        }

        public async Task DeleteGI(long id)
        {
            await _goodsInRepository.DeleteGI(id);
        }

        public async Task<List<GoodsIN>> GetAllGI()
        {
            return await _goodsInRepository.GetAllGI();
        }

        public async Task<GoodsIN> GetGIById(long id)
        {
            return await _goodsInRepository.GetGIById(id);
        }
        public async Task<GoodsIN> GetGIByOrderCode(string OrderCode)
        {
            return await _goodsInRepository.GetGIByOrderCode(OrderCode);
        }

        public async Task<GoodsIN> UpdateGI(GoodsIN goods)
        {
            return await _goodsInRepository.UpdateGI(goods);
        }
    }
}
