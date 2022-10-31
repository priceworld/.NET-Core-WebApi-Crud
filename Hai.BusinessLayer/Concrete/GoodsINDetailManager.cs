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
    public class GoodsINDetailManager : IGoodsINDetailService
    {
        private IGoodsINDetailRepository _goodsINDetailRepository;
        public GoodsINDetailManager()
        {
            _goodsINDetailRepository = new GoodsINDetailRepository();
        }

        public async Task<GoodsINDetail> CreateGID(GoodsINDetail goodsd)
        {
            return await _goodsINDetailRepository.CreateGID(goodsd);
        }

        public async Task DeleteGID(long id)
        {
            await _goodsINDetailRepository.DeleteGID(id);
        }

        public async Task<List<GoodsINDetail>> GetAllGID()
        {
            return await _goodsINDetailRepository.GetAllGID();
        }

        public async Task<GoodsINDetail> GetGIDById(long id)
        {
            return await _goodsINDetailRepository.GetGIDById(id);
        }

        public async Task<GoodsINDetail> UpdateGID(GoodsINDetail goodsd)
        {
            return await _goodsINDetailRepository.UpdateGID(goodsd);
        }
    }
}
