using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Hai.Entities.Entities;

namespace Hai.DataAcces.Abstract
{
    public interface IGoodsOutRepository
    {
        Task<List<GoodsOut>> GetAllGO();
        Task<GoodsOut> GetGOById(long id);
        Task<GoodsOut> CreateGO(GoodsOut goodso);
        Task<GoodsOut> UpdateGO(GoodsOut goodso);
        Task DeleteGO(long id);
    }
}
