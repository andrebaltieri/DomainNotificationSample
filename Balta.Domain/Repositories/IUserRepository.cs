using Balta.Domain.Entities;

namespace Balta.Domain.Repositories
{
    public interface IUserRepository
    {
        void Save(User user);
    }
}
