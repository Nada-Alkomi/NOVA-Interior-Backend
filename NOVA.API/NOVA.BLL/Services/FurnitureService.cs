using NOVA.BLL.Dtos;
using NOVA.BLL.Interfaces;
using NOVA.DAL.Models;
using NOVA.DAL.Reopistories;


namespace NOVA.BLL.Services
{
    public class FurnitureService : IFurnitureService
    {
        private readonly IRepoFurniture _repository;

        public FurnitureService(IRepoFurniture repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<FurnitureDto>> GetAllAsync()
        {
            var furniture = await _repository.GetAllAsync();

            return furniture.Select(f => new FurnitureDto
            {
                Id = f.Id,
                Name = f.Name,
                Category = f.Category,
                ImageUrl = f.ImageUrl
            });
        }

        public async Task<FurnitureDto?> GetByIdAsync(int id)
        {
            var furniture = await _repository.GetByIdAsync(id);

            if (furniture == null)
                return null;

            return new FurnitureDto
            {
                Id = furniture.Id,
                Name = furniture.Name,
                Category = furniture.Category,
                ImageUrl = furniture.ImageUrl
            };
        }

        public async Task AddAsync(CreateFurnitureDto dto)
        {
            var furniture = new FurnitureModel
            {
                Name = dto.Name,
                Category = dto.Category,
                ImageUrl = dto.ImageUrl
            };

            await _repository.AddAsync(furniture);
        }

        public async Task UpdateAsync(UpdateFurnitureDto dto)
        {
            var furniture = await _repository.GetByIdAsync(dto.Id);

            if (furniture == null)
                throw new KeyNotFoundException("Furniture not found.");

            furniture.Name = dto.Name;
            furniture.Category = dto.Category;
            furniture.ImageUrl = dto.ImageUrl;

            await _repository.UpdateAsync(furniture);
        }

        public async Task DeleteAsync(int id)
        {
            var furniture = await _repository.GetByIdAsync(id);

            if (furniture == null)
                throw new KeyNotFoundException("Furniture not found.");

            await _repository.DeleteAsync(id);
        }
    }
}