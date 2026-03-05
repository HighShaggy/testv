
namespace DatabaseService.Core.Interfaces
{
    public interface IDbservice
    {
        Task ConnectAsync();
        Task<string> GetVersionAsync();
        Task DisconnectAsync();
    }
}
