using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestingApp.Models
{
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "text")]
        public string Description { get; set; }
        public List<Users_Tests> Users_Tests { get; set; } = new List<Users_Tests>();
        public List<Question> Questions { get; set; } = new List<Question>();
    }
}
