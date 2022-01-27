using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingApp.Models;

namespace TestingApp.Controllers
{
    public class TestController : Controller
    {
        private readonly ApplicationContext db;
        private readonly UserManager<User> _userManager;
        public TestController(ApplicationContext context, UserManager<User> userManager)
        {
            db = context;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index(int id)
        {
            Test test = db.Tests
                .Include(t => t.Users_Tests)
                .ToList()
                .Where(t => t.Id == id)
                .FirstOrDefault();

            return View(test);
        }
        [HttpPost]
        public IActionResult StartTest(int id)
        {
            var test = db.Tests
                .Include(t => t.Questions)
                .ThenInclude(q => q.Answears)
                .SingleOrDefault(t => t.Id == id);

            return View(test);
        }
        [HttpPost]
        public IActionResult GetResult(AnswearsViewModel model)
        {
            int correctNum = ResultCalculator.GetResult(model, db);
            string resultString = correctNum + "/" + model.Questions.Length.ToString();
            return View("GetResult", resultString);
        }
    }
}
