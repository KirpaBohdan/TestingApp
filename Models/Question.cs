using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestingApp.Models
{
    public class Question
    {
        public int Id { get; set; }
        [Column(TypeName = "text")]
        public string Text { get; set; }
        public Test Test { get; set; }
        public int TestId { get; set; }
        public List<Answear> Answears { get; set; } = new List<Answear>();
    }
}
