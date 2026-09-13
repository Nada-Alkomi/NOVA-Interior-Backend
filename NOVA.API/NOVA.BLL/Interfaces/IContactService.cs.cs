using NOVA.BLL.Dtos;

namespace NOVA.BLL.Interfaces
{
    public interface IContactService
    {
        Task AddInquiryAsync(ContactInquiryDto dto);

        Task<IEnumerable<ContactInquiryDto>> GetAllAsync();
    }
}
