using Askardi.Domain.Interface.Argument;

namespace Askardi.Domain.Argument.User
{
    public class AuthUserRequest : IRequest
    {
        public string Name { get; set; }

        public string Email { get; set; }
    }
}
