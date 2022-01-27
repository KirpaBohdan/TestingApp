using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingApp.Models
{
    public class User : IdentityUser
    {
        public List<Users_Tests> Users_Tests { get; set; } = new List<Users_Tests>();
    }
}
