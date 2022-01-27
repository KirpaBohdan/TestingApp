using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingApp.Models
{
    public class SampleData
    {
        public static void AddData(ApplicationContext db)
        {
            if (db.Tests.ToList().Count == 0)
            {
                Test test = new Test()
                {
                    Name = "Математика 5 клас",
                    Description = "Рекомендовано для школярів з українською мовою навчання",
                    Questions = new List<Question>()
                    {
                        new Question()
                        {
                            Text = "Виміри прямокутного паралелепіпеда дорівнюють 3см, 2см, 7 см. Знайти його об'єм.",
                            Answears = new List<Answear>()
                            {
                                new Answear()
                                {
                                    Text = "42cm3",
                                    IsCorrect = true
                                },
                                new Answear()
                                {
                                    Text = "42cm2",
                                    IsCorrect = false
                                },
                                new Answear()
                                {
                                    Text = "12cm3",
                                    IsCorrect = false
                                },
                                new Answear()
                                {
                                    Text = "12cm3"
                                }
                            }
                        },
                        new Question()
                        {
                            Text = "Які з наведених формул є формулами для обчислення об'єму прямокутного паралелепіпеда?",
                            Answears = new List<Answear>()
                            {
                                new Answear()
                                {
                                    Text = "V=ab+c",
                                    IsCorrect = false
                                },
                                new Answear()
                                {
                                    Text = "3abc",
                                    IsCorrect = false
                                },
                                new Answear()
                                {
                                    Text = "abc",
                                    IsCorrect = true
                                }
                            }

                        },
                        new Question()
                        {
                            Text = "Знайдіть об’єм куба, ребро якого дорівнює 6 см.",
                            Answears = new List<Answear>()
                            {
                                new Answear()
                                {
                                    Text = "216cm3",
                                    IsCorrect = true
                                },
                                new Answear()
                                {
                                    Text = "116cm3",
                                    IsCorrect = false
                                },
                                new Answear()
                                {
                                    Text = "332cm3",
                                    IsCorrect = false
                                },
                                new Answear()
                                {
                                    Text = "432cm3",
                                    IsCorrect = false
                                }
                            }
                        }
                    }
                };

                db.Tests.Add(test);
                db.SaveChangesAsync();
            }
        }
    }
}
