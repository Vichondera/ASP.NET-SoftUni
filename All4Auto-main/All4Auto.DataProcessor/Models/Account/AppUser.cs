namespace All4Auto.DataProcessor.Models.Account
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    public class AppUser : IdentityUser
    {
        [StringLength(20)]
        public string? FirstName { get; set; }

        [StringLength(20)]
        public string? LastName { get; set; }

       public string? UserId { get; set; }

    }
}
