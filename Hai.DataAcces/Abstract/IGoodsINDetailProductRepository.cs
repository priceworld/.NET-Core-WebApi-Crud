using Hai.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hai.DataAcces.Abstract
{
    public interface IGoodsINDetailProductRepository
    {
        Task<List<GoodsINDetailProduct>> GetAllGIDP();
        Task<GoodsINDetailProduct> GetGIDPById(long Id);
        Task<GoodsINDetailProduct> CreateGIDP(GoodsINDetailProduct goodsdp);
        Task<GoodsINDetailProduct> UpdateGIDP(GoodsINDetailProduct goodsdp);
        Task DeleteGIDP(long Id);
    }
}
