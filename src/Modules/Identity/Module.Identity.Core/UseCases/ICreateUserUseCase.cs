using Module.Identity.Core.Entities;

namespace Module.Identity.Core.UseCases
{
    public interface ICreateUserUseCase
    {
        void CreateNewUser(User user);
    }
}
