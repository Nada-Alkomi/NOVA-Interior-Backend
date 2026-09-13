using NOVA.DAL.Models;

namespace NOVA.DAL.Reopistories
{
    public interface IRepoFurniture
    {
        Task<IEnumerable<FurnitureModel>> GetAllAsync();

        Task<FurnitureModel?> GetByIdAsync(int id);

        Task AddAsync(FurnitureModel furniture);

        Task UpdateAsync(FurnitureModel furniture);

        Task DeleteAsync(int id);
    }
}