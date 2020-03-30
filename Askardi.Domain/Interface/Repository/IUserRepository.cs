using Askardi.Domain.Argument.User;
using System;

namespace Askardi.Domain.Interface.Repository
{
    public interface IUserRepository
    {
        AuthUserResponse Authenticate(AuthUserRequest authUserRequest);

        Guid Add(AddUserRequest addUserRequest);
    }
}
