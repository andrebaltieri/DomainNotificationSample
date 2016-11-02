using Balta.Data.Contexts;
using Balta.Domain.Entities;
using Balta.Domain.Repositories;

namespace Balta.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private BaltaDataContext _context;

        public UserRepository(BaltaDataContext context)
        {
            _context = context;
        }

        public void Save(User user)
        {
            _context.Users.Add(user);
        }
    }
}
