using System.Threading.Tasks;
using Wolfgang.Models;

namespace Wolfgang.Helpers
{
    public interface IAPIHelpers
    {
        Task<AuthenticateUser> Authenticate(string username, string password);
    }
}