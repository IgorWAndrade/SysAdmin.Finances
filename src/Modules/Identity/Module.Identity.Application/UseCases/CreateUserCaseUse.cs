using Module.Identity.Core.Entities;
using Module.Identity.Core.Services;
using Module.Identity.Core.UseCases;

namespace Module.Identity.Application.UseCases
{
    public class CreateUserCaseUse : ICreateUserUseCase
    {
        private readonly IUserService _userService;

        public CreateUserCaseUse(IUserService userService)
        {
            _userService = userService;
        }

        public void CreateNewUser(User user)
        {
            Console.WriteLine(user);
            user.GenereNewId();
            _userService.CreateUser(user);
        }
    }
}
