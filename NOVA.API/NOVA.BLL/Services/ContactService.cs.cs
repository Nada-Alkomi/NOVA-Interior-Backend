using NOVA.BLL.Dtos;
using NOVA.DAL.Models;
using NOVA.BLL.Interfaces;
using NOVA.DAL.Reopistories;
namespace NOVA.BLL.Services
{
    public class ContactService : IContactService
    {
          private readonly IRepoContactInquiry _repoContactInquiry;

          public ContactService(IRepoContactInquiry repoContactInquiry)
        {
            _repoContactInquiry = repoContactInquiry;
        }
        public Task AddInquiryAsync(ContactInquiryDto dto)
        {
            var entity = new ContactInquiry
            {
                Name = dto.Name,
                Email = dto.Email,
                Subject = dto.Subject,
                Message = dto.Message
            };
            return _repoContactInquiry.AddAsync(entity);
        }

        public async Task<IEnumerable<ContactInquiryDto>> GetAllAsync()
        {
            var inquiries = await _repoContactInquiry.GetAllAsync();
            return inquiries.Select(i => new ContactInquiryDto
            {
                Name = i.Name,
                Email = i.Email,
                Subject = i.Subject,
                Message = i.Message
            });
        }
    }
}
