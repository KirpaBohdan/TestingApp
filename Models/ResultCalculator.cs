using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingApp.Models
{
    public static class ResultCalculator
    {
        public static int GetResult(AnswearsViewModel model, ApplicationContext db)
        {
            int correctAnswears = 0;
            var answears = db.Answears.Where(a => model.Answears.Contains(a.Id));

            foreach (var answear in answears)
            {
                if (answear.IsCorrect)
                    correctAnswears++;
            }
            SaveResults(model.UserName, model.TestId, correctAnswears, db);
            return correctAnswears;
        }
        static void SaveResults(string userName, int testId, int correctAnswears, ApplicationContext db)
        {
            Users_Tests user_test = db.Users_Tests
                .Include(ut => ut.User)
                .Where(ut => ut.User.UserName == userName && ut.TestId == testId)
                .FirstOrDefault();

            user_test.Mark = correctAnswears;
            db.SaveChangesAsync();
        }
    }
}
