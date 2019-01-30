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

            Subject subject1 = new Subject() { Name = "Maths" };
            Subject subject2 = new Subject() { Name = "Arts" };
            Subject subject3 = new Subject() { Name = "PE" };

            /*db.InsertSubject(subject1);
            db.InsertSubject(subject2);
            db.InsertSubject(subject3);*/

            Mark mark1 = new Mark() { Value = 1, Weight = 5, SubjectID = 1};
            Mark mark2 = new Mark() { Value = 3, Weight = 2, SubjectID = 2};
            Mark mark3 = new Mark() { Value = 4, Weight = 2, SubjectID = 3};

            List<Mark> gottenMarks = db.GetListOf<Mark>().Result;
            List<Subject> gottenSubjects = db.GetListOf<Subject>().Result;
            int GradeSum = 0;
            int WeightSum = 0;
            foreach (Mark znamka in gottenMarks)
            {
                Console.WriteLine("ID:" + znamka.Id);
                GradeSum = GradeSum + (znamka.Value * znamka.Weight);
                Console.WriteLine("GradeSum: "+ GradeSum);
                WeightSum = WeightSum + znamka.Weight;
                Console.WriteLine("WeightSum: " + WeightSum);
            }

            foreach(Subject predmet in gottenSubjects)
            {
                Console.WriteLine(predmet.Name);
            }
            double result = (double)GradeSum / WeightSum;
            Console.WriteLine(result);
        }
    }
}
