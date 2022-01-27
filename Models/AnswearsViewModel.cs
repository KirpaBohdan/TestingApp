using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingApp.Models
{
    public class AnswearsViewModel
    {
        public string UserName { get; set; }
        public int TestId { get; set; }
        public int[] Questions { get; set; }
        public int[] Answears { get; set; }
    }
}
