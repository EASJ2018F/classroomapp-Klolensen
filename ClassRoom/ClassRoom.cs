using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ClassRoom
    {
        private string _className;
        private List<Student> _classList;
        private DateTime _semesterStart;

        public ClassRoom(string className, List<Student> classList, DateTime semesterStart)
        {
            _className = className;
            _classList = classList;
            _semesterStart = semesterStart;
        }

        public string ClassName
        {
            get { return _className; }
        }

        public List<Student> ClassList
        {
            get { return _classList; }
        }

        public DateTime SemesterStart
        {
            get { return _semesterStart; }
        }

        public void SeasonalBirthdays()
        {
            int winter = 0;
            int spring = 0;
            int summer = 0;
            int fall = 0;

            foreach (var student in ClassList)
            {
                if (student.BirthSeason() == "Winter")
                {
                    winter += 1;
                }

                if (student.BirthSeason() == "Spring")
                {
                    spring += 1;
                }

                if (student.BirthSeason() == "Summer")
                {
                    summer += 1;
                }

                if (student.BirthSeason() == "Fall")
                {
                    fall += 1;
                }
                
            }

            Console.WriteLine($"Born in Winter: {winter}\n" +
                              $"Born in Spring: {spring}\n" +
                              $"Born in Summer: {summer}\n" +
                              $"Born in Fall: {fall}");
        }
    }
}
