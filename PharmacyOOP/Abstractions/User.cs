using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyOOP.Abstractions
{
    public abstract class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Login { get; set; }

        public string HashPassword { get; set; }

        public string Email { get; set; }


    }
}
