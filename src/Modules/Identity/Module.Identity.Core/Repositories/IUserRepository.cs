using Module.Identity.Core.Entities;

namespace Module.Identity.Core.Repositories
{
    public interface IUserRepository
    {
        void AddUser(User user);
    }
}
