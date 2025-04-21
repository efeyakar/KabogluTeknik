using KabogluTeknik.Entities;

namespace KabogluTeknik.Services.GeneralServices
{
    public interface IGeneralService
    {
        Task<General> GetGeneralAsync();
        Task UpdateGeneralAsync(General General);
        Task CreateGeneralAsync(General General);
    }
}
