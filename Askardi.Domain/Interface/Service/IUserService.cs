using Askardi.Domain.Argument.User;

namespace Askardi.Domain.Interface.Service
{
    public interface IUserService
    {
        AuthUserResponse Authenticate(AuthUserRequest authUserRequest);

        AddUserResponse Add(AddUserRequest addUserRequest);
    }
}
