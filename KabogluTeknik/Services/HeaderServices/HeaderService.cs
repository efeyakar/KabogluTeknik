using KabogluTeknik.Context;
using KabogluTeknik.Entities;
using Microsoft.EntityFrameworkCore;

namespace KabogluTeknik.Services.HeaderServices
{
    public class HeaderService : IHeaderService
    {
        private readonly GeneralContext _context;

        public HeaderService(GeneralContext context)
        {
            _context = context;
        }

        public async Task CreateHeaderAsync(Header Header)
        {
            await _context.headers.AddAsync(Header);
            await _context.SaveChangesAsync();
        }

        public Task<Header> GetHeaderAsync()
        {
            return _context.headers.FirstOrDefaultAsync();
        }

        public async Task UpdateHeaderAsync(Header Header)
        {
            _context.headers.Update(Header);
            await _context.SaveChangesAsync();
        }
    }
}
