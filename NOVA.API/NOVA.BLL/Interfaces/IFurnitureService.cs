using NOVA.BLL.Dtos;


namespace NOVA.BLL.Interfaces
{
    public  interface IFurnitureService
    {
        Task<IEnumerable<FurnitureDto>> GetAllAsync();

        Task<FurnitureDto?> GetByIdAsync(int id);

        Task AddAsync(CreateFurnitureDto dto);

        Task UpdateAsync(UpdateFurnitureDto dto);

        Task DeleteAsync(int id);
    }
}
