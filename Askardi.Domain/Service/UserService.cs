using Askardi.Domain.Argument.User;
using Askardi.Domain.Interface.Repository;
using Askardi.Domain.Interface.Service;
using System;

namespace Askardi.Domain.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository UserRepository;

        public UserService(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        public AddUserResponse Add(AddUserRequest addUserRequest)
        {
            Guid id = UserRepository.Add(addUserRequest);

            return new AddUserResponse { Id = id, Message = "Operation sucess!" };
        }

        public AuthUserResponse Authenticate(AuthUserRequest authUserRequest)
        {
            if (authUserRequest == null) throw new NotImplementedException();
            //test git repo
            return UserRepository.Authenticate(authUserRequest);

        }
    }
}
