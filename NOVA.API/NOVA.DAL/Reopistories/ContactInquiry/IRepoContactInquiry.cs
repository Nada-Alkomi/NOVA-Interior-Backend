
using NOVA.DAL.Models;
namespace NOVA.DAL.Reopistories
{
    public interface IRepoContactInquiry
    {
        Task AddAsync(ContactInquiry inquiry);
        Task<IEnumerable<ContactInquiry>> GetAllAsync();
    }
}
