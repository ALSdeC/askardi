using Askardi.Domain.Enum;
using Askardi.Domain.ValueObjects;
using System;

namespace Askardi.Domain.Entity
{
    class User
    {
        public Guid Id { get; set; }

        public Name Name { get; set; }

        public string Password { get; set; }

        public Email Email { get; set; }

        public EUserType UserType { get; set; }
        
    }
}
