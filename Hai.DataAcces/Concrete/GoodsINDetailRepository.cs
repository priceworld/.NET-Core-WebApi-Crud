using Hai.DataAcces.Abstract;
using Hai.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hai.DataAcces.Concrete
{
    public class GoodsINDetailRepository : IGoodsINDetailRepository
    {
        public async Task<GoodsINDetail> CreateGID(GoodsINDetail goodsd)
        {
            using (var haiDbContext = new HaiDbContext())
            {
                haiDbContext.GoodsINDetail.Add(goodsd);
                await haiDbContext.SaveChangesAsync();
                return goodsd;
            }
        }

        public async Task DeleteGID(long id)
        {
            using (var haiDbContext = new HaiDbContext())
            {
                var deletedGoodsInDetail = await GetGIDById(id);
                haiDbContext.GoodsINDetail.Remove(deletedGoodsInDetail);
                await haiDbContext.SaveChangesAsync();
            }
        }

        public async Task<List<GoodsINDetail>> GetAllGID()
        {
            using (var haiDbContext = new HaiDbContext())
            {
                return await haiDbContext.GoodsINDetail.ToListAsync();
            }
        }

        public async Task<GoodsINDetail> GetGIDById(long id)
        {
            using (var haiDbContext = new HaiDbContext())
            {
                return await haiDbContext.GoodsINDetail.FindAsync(id);
            }
        }

        public async Task<GoodsINDetail> UpdateGID(GoodsINDetail goodsd)
        {
            using (var haiDbContext = new HaiDbContext())
            {
                haiDbContext.GoodsINDetail.Update(goodsd);
                haiDbContext.SaveChanges();
                return goodsd;
            }
        }
    }
}
