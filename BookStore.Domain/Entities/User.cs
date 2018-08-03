using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace BookStore.Domain.Entities
{
    public class User : IdentityUser<long>
    {
        public DateTime DateOfBirth { get; set; }

        public ICollection<UserSubject> UserSubject { get; set; }
    }
}
