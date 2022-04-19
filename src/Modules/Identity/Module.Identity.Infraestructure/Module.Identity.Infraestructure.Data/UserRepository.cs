using Module.Identity.Core.Entities;
using Module.Identity.Core.Repositories;
using Module.Identity.Core.Services;

namespace Module.Identity.Infraestructure.Data;
public class UserRepository : IUserRepository
{
    public void AddUser(User user)
    {
        Console.WriteLine(user);
        user.GenereNewId();
    }
}
