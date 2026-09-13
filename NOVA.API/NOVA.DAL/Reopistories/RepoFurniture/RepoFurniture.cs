using Microsoft.EntityFrameworkCore;
using NOVA.DAL.Data;
using NOVA.DAL.Models;
using NOVA.DAL.Reopistories;

namespace NOVA.DAL.Reopistories
{
    public class RepoFurniture :IRepoFurniture
    {
        private readonly AppDbContext _context;

        public RepoFurniture(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(FurnitureModel furniture)
        {
            await _context.Furnitures.AddAsync(furniture);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var furniture = await _context.Furnitures.FindAsync(id);

            if (furniture != null)
            {
                _context.Furnitures.Remove(furniture);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<FurnitureModel>> GetAllAsync()
        {
            return await _context.Furnitures.ToListAsync();
        }

        public async Task<FurnitureModel?> GetByIdAsync(int id)
        {
            return await _context.Furnitures.FindAsync(id);
        }

        public async Task UpdateAsync(FurnitureModel furniture)
        {
            _context.Furnitures.Update(furniture);
            await _context.SaveChangesAsync();
        }
    }
}