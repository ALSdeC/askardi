using Askardi.Domain.Interface.Argument;

namespace Askardi.Domain.Argument.User
{
    public class AuthUserResponse : IResponse
    {
        public string FirstName { get; set; }

        public string Email { get; set; }
    }
}
