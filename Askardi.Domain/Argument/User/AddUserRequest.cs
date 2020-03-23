using Askardi.Domain.Enum;
using Askardi.Domain.Interface.Argument;
using Askardi.Domain.ValueObjects;

namespace Askardi.Domain.Argument.User
{
    public class AddUserRequest : IRequest
    {
        public Name Name { get; set; }

        public string Password { get; set; }

        public Email Email { get; set; }

        public EUserType UserType { get; set; }
    }
}
