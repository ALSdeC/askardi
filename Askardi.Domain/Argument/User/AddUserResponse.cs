using Askardi.Domain.Interface.Argument;
using System;

namespace Askardi.Domain.Argument.User
{
    public class AddUserResponse : IResponse
    {
        public Guid Id { get; set; }

        public string Message { get; set; }
    }
}
