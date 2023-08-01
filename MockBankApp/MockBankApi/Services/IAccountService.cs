using MockBankApi.Models;

namespace MockBankApi.Services
{
    public interface IAccountService
    {
        List<Staging> GetAccountService();
        Staging GetAccountById(Guid stagingId);
    }
}
