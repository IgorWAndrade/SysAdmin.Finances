using Module.Identity.Core.Entities;
using Module.Identity.Core.Repositories;
using Module.Identity.Core.Services;

namespace Module.Identity.Service;
public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public void CreateUser(User user)
    {
        Console.WriteLine(user);
        user.GenereNewId();
        _userRepository.AddUser(user);  
    }
}
