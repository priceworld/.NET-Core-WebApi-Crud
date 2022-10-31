using Hai.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hai.DataAcces.Abstract
{
    public interface IGoodsINDetailRepository
    {
        Task<List<GoodsINDetail>> GetAllGID();
        Task<GoodsINDetail> GetGIDById(long id);
        Task<GoodsINDetail> CreateGID(GoodsINDetail goodsd);
        Task<GoodsINDetail> UpdateGID(GoodsINDetail goodsd);
        Task DeleteGID(long id);
    }
}
