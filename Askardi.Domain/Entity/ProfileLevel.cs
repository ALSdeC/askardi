using System;

namespace Askardi.Domain.Entity
{
    class ProfileLevel
    {
        public Guid Id { get; set; }

        public Profile Profile { get; set; }

        public Level Level { get; set; }

        public DateTime ReachDate { get; set; }
    }
}
