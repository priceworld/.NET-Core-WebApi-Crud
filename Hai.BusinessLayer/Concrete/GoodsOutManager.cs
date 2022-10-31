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
    public class GoodsOutManager : IGoodsOutService
    {
        private IGoodsOutRepository _goodsOutRepository;
        public GoodsOutManager()
        {
            _goodsOutRepository = new GoodsOutRepository();
        }
        public async Task<GoodsOut> CreateGO(GoodsOut goodso)
        {
            return await _goodsOutRepository.CreateGO(goodso);
        }

        public async Task DeleteGO(long id)
        {
            await _goodsOutRepository.DeleteGO(id);
        }

        public async Task<List<GoodsOut>> GetAllGO()
        {
            return await _goodsOutRepository.GetAllGO();
        }

        public async Task<GoodsOut> GetGOById(long id)
        {
            return await _goodsOutRepository.GetGOById(id);
        }

        public async Task<GoodsOut> UpdateGO(GoodsOut goodso)
        {
            return await _goodsOutRepository.UpdateGO(goodso);
        }
    }
}
