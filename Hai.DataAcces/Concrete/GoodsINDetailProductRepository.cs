using Hai.DataAcces.Abstract;
using Hai.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hai.DataAcces.Concrete
{
    public class GoodsINDetailProductRepository : IGoodsINDetailProductRepository
    {
        public async Task<GoodsINDetailProduct> CreateGIDP(GoodsINDetailProduct goodsdp)
        {
            using (var haiDbContext = new HaiDbContext())
            {
                haiDbContext.GIDProduct.Add(goodsdp);
                await haiDbContext.SaveChangesAsync();
                return goodsdp;
            }
        }

        public async Task DeleteGIDP(long Id)
        {
            using (var haiDbContext = new HaiDbContext())
            {
                var deletedGoodsInDetailProduct = await GetGIDPById(Id);
                haiDbContext.GIDProduct.Remove(deletedGoodsInDetailProduct);
                await haiDbContext.SaveChangesAsync();
            }
        }

        public async Task<List<GoodsINDetailProduct>> GetAllGIDP()
        {
            using (var haiDbContext = new HaiDbContext())
            {
                return await haiDbContext.GIDProduct.ToListAsync();
            }
        }

        public async Task<GoodsINDetailProduct> GetGIDPById(long Id)
        {
            using (var haiDbContext = new HaiDbContext())
            {
                return await haiDbContext.GIDProduct.FindAsync(Id);
            }
        }

        public async Task<GoodsINDetailProduct> UpdateGIDP(GoodsINDetailProduct goodsdp)
        {
            using (var haiDbContext = new HaiDbContext())
            {
                haiDbContext.GIDProduct.Update(goodsdp);
                haiDbContext.SaveChanges();
                return goodsdp;
            }
        }
    }
}
