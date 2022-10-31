using Hai.DataAcces.Abstract;
using Hai.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hai.DataAcces.Concrete
{
    public class GoodsInRepository : IGoodsInRepository
    {
        public async Task<GoodsIN> CreateGI(GoodsIN goods)
        {
            using (var goodsInDbContext = new HaiDbContext())
            {
                goodsInDbContext.GoodsIN.Add(goods);
                await goodsInDbContext.SaveChangesAsync();
                return goods;
            }
        }

        public async Task DeleteGI(long id)
        {
            using (var goodsInDbContext = new HaiDbContext())
            {
                var deletedGoodsIn = await GetGIById(id);
                goodsInDbContext.GoodsIN.Remove(deletedGoodsIn);
                await goodsInDbContext.SaveChangesAsync();
            }
        }

        public async Task<List<GoodsIN>> GetAllGI()
        {
            using (var goodsInDbContext = new HaiDbContext())
            {
                return await goodsInDbContext.GoodsIN.ToListAsync();
            }
        }

        public async Task<GoodsIN> GetGIById(long id)
        {
            using (var goodsInDbContext = new HaiDbContext())
            {
                return await goodsInDbContext.GoodsIN.FindAsync(id);
            }
        }

        public async Task<GoodsIN> GetGIByOrderCode(string OrderCode)
        {
            using (var goodsInDbContext = new HaiDbContext())
            {
                return await goodsInDbContext.GoodsIN.FirstOrDefaultAsync(x => x.OrderCode.ToLower() == OrderCode.ToLower());
            }
        }

        public async Task<GoodsIN> UpdateGI(GoodsIN goods)
        {
            using (var goodsInDbContext = new HaiDbContext())
            {
                goodsInDbContext.GoodsIN.Update(goods);
                goodsInDbContext.SaveChanges();
                return goods;
            }
        }
    }
}
