using System;

namespace Askardi.Domain.Entity
{
    class Profile
    {
        public Guid Id { get; set; }

        public string Nickname { get; set; }

        public byte[] Image { get; set; }

        public long Experience { get; set; }
    }
}
