using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ShoppingWebsite.Models;

namespace ShoppingWebsite.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    [ForeignKey("Language")]
    public string LanguageId { get; set; }
    public Language? Language { get; set; }
}

public class ApplicationUserViewModel
{
    public string Id { get; set; }
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string? PhoneNumber { get; set; }

    public string Language { get; set; }

    public Boolean Lockout { get; set; }
    public Boolean User { get; set; }
    public Boolean Admin { get; set; }
    
}