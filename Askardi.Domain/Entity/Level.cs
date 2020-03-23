using System;

namespace Askardi.Domain.Entity
{
    class Level
    {
        public Guid Id { get; set; }

        public int Value { get; set; }

        public long Experience { get; set; }

        public byte[] Image { get; set; }
    }
}
