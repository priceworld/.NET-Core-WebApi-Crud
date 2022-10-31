using Hai.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hai.BusinessLayer.Abstract
{
    public interface IGoodsOutService
    {
        Task<List<GoodsOut>> GetAllGO();
        Task<GoodsOut> GetGOById(long id);
        Task<GoodsOut> CreateGO(GoodsOut goodso);
        Task<GoodsOut> UpdateGO(GoodsOut goodso);
        Task DeleteGO(long id);
    }
}
