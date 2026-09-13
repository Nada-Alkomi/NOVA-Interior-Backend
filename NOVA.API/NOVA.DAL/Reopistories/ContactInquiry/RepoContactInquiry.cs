using Microsoft.EntityFrameworkCore;
using NOVA.DAL.Data;
using NOVA.DAL.Models;
namespace NOVA.DAL.Reopistories;

public class RepoContactInquiry : IRepoContactInquiry
{


    private readonly AppDbContext _context;

    public RepoContactInquiry(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(ContactInquiry inquiry)
    {
        await _context.ContactInquiries.AddAsync(inquiry);
        await _context.SaveChangesAsync();
    }
    public async Task<IEnumerable<ContactInquiry>> GetAllAsync()
    {
        return await _context.ContactInquiries.ToListAsync();
    }
}
