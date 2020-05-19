using System.Collections.Generic;
using System.Threading.Tasks;
using VatanAPI.Core.Models;

namespace VatanAPI.Core.Repositories
{
    public interface IUserRepository
    {
        Task AddAsync(User user, ERole[] userRoles);
        Task<User> FindByEmailAsync(string email);
        Task<IEnumerable<User>> ListAsync();
    }
}