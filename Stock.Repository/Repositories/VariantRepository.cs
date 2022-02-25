using Microsoft.EntityFrameworkCore;
using Stock.Core.Model;
using Stock.Core.Repositories;
using Stock.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Repository.Repositories
{
    public class VariantRepository : IVariantRepository
    {
        protected readonly AppDbContext _context;
        private readonly DbSet<Variant> _dbSet;

        public VariantRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<Variant>();
        }

        public async Task<IEnumerable<Variant>> GetVariantByProductId(int productId)
        {
            return await _context.Variants.Where(x => x.ProductId == productId).ToListAsync();
        }

        public async Task<Variant> GetVariantByVariantCode(string variantCode)
        {
           return await _context.Variants.Where(x => x.VariantCode == variantCode).FirstOrDefaultAsync();
        }
    }
}
