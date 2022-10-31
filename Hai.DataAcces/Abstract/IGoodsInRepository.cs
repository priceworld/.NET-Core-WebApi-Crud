using Hai.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hai.DataAcces.Abstract
{
    public interface IGoodsInRepository
    {
        Task<List<GoodsIN>> GetAllGI();
        Task<GoodsIN> GetGIById(long id);
        Task<GoodsIN> GetGIByOrderCode(string OrderCode);
        Task<GoodsIN> CreateGI(GoodsIN goods);
        Task<GoodsIN> UpdateGI(GoodsIN goods);
        Task DeleteGI(long id);
    }
}
