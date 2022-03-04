using Microsoft.EntityFrameworkCore;
using Stock.Core.Model;
using Stock.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Repository.Repositories
{
    public class StockRepository : IStockRepository
    {
        protected readonly AppDbContext _context;
        private readonly DbSet<StockInfo> _dbSet;

        public StockRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<StockInfo>();
        }

        public async Task<StockInfo> GetAllByVariantCodeAsync(int variantId, int productId)
        {
            return await _context.Stock.Where(x => x.VariantId == variantId && x.ProductId == productId).GroupBy(x => new { x.VariantId, x.ProductId }).Select(x => new StockInfo
            {
                Quantity = x.Sum(y => y.Quantity),
                VariantId = x.Key.VariantId,
                ProductId = x.Key.ProductId,
                CreatedDate = x.OrderBy(y=>y.CreatedDate).Select(z => z.CreatedDate).FirstOrDefault(),
                UpdatedDate = x.Min(y => y.CreatedDate)
            }).FirstOrDefaultAsync();
        }

        public async Task<List<StockInfo>> GetQuantityByVariantId(int productId)
        {
            List<StockInfo> result = new List<StockInfo>();

            return await _context.Stock.Where(x => x.ProductId == productId).ToListAsync();
        }


    }
}

