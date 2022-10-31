using Hai.DataAcces.Abstract;
using Hai.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hai.DataAcces.Concrete
{
    public class GoodsOutRepository : IGoodsOutRepository
    {
        public async Task<GoodsOut> CreateGO(GoodsOut goodso)
        {
            using (var haiDbContext = new HaiDbContext())
            {
                haiDbContext.GoodsOut.Add(goodso);
                await haiDbContext.SaveChangesAsync();
                return goodso;
            }
        }

        public async Task DeleteGO(long id)
        {
            using (var haiDbContext = new HaiDbContext())
            {
                var deletedGoodsOut = await GetGOById(id);
                haiDbContext.GoodsOut.Remove(deletedGoodsOut);
                await haiDbContext.SaveChangesAsync();
            }
        }

        public async Task<List<GoodsOut>> GetAllGO()
        {
            using (var haiDbContext = new HaiDbContext())
            {
                return await haiDbContext.GoodsOut.ToListAsync();
            }
        }

        public async Task<GoodsOut> GetGOById(long id)
        {
            using (var haiDbContext = new HaiDbContext())
            {
                return await haiDbContext.GoodsOut.FindAsync(id);
            }
        }

        public async Task<GoodsOut> UpdateGO(GoodsOut goodso)
        {
            using (var haiDbContext = new HaiDbContext())
            {
                haiDbContext.GoodsOut.Update(goodso);
                haiDbContext.SaveChanges();
                return goodso;
            }
        }
    }
}
