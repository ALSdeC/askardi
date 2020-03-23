using System;

namespace Askardi.Domain.Entity
{
    class UserProfile
    {
        public Guid Id { get; set; }

        public User User { get; set; }

        public Profile Profile { get; set; }
    }
}
