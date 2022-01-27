using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestingApp.Models
{
    public class Users_Tests
    {
        [Key, Column(Order = 0)]
        public string UserId { get; set; }
        [Key, Column(Order = 1)]
        public int TestId { get; set; }

        public virtual User User { get; set; }
        public virtual Test Test { get; set; }

        public float? Mark { get; set; }
    }
}
