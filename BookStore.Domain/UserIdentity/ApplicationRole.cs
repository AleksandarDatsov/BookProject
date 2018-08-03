using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace BookStore.Domain.UserIdentity
{
    public class ApplicationRole : IdentityRole<long>
    {
    }
}
