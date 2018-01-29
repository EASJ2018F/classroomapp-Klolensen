using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            try
            {
                studentList.Add(new Student("Kevin Jensen", 6, 9));
                studentList.Add(new Student("Jackie Namiiro", 5, 21));
                studentList.Add(new Student("Gordon Mikkelsen", 7, 6));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            DateTime startDate = new DateTime(2017, 8, 28);
            ClassRoom classRoom = new ClassRoom("3A", studentList, startDate);

            Console.WriteLine($"{classRoom.ClassName} starts on {classRoom.SemesterStart} and contains the follwoing students:");
            foreach (var student in classRoom.ClassList)
            {
                Console.WriteLine(student);
            }

            classRoom.SeasonalBirthdays();

            Console.ReadKey();
        }
    }
}
