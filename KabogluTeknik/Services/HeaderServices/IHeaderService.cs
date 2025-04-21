using KabogluTeknik.Entities;

namespace KabogluTeknik.Services.HeaderServices
{
    public interface IHeaderService
    {
        Task<Header> GetHeaderAsync();
        Task UpdateHeaderAsync(Header Header);
        Task CreateHeaderAsync(Header Header);
    }
}
