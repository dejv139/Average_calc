using ClassLibrary1;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = DBManager.Database;

            Mark mark1 = new Mark() { Value = 1, Weight = 5, Subject = 1};
            Mark mark2 = new Mark() { Value = 3, Weight = 2, Subject = 2};
            Mark mark3 = new Mark() { Value = 4, Weight = 2, Subject = 1};

            List<Mark> znamky = db.GetItemsNotDoneAsync("SELECT * FROM [Mark] WHERE [Subject] = 2").Result;
            int GradeSum = 0;
            int WeightSum = 0;
            foreach (Mark znamka in znamky)
            {
                Console.WriteLine("ID:" + znamka.Id);
                GradeSum = GradeSum + (znamka.Value * znamka.Weight);
                Console.WriteLine("GradeSum: "+ GradeSum);
                WeightSum = WeightSum + znamka.Weight;
                Console.WriteLine("WeightSum: " + WeightSum);
            }
            double result = (double)GradeSum / WeightSum;
            Console.WriteLine(result);
        }
    }
}
