using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Student
    {
        private string _name;
        private int _birthMonth;
        private int _birthDate;

        public Student(string name, int birthMonth, int birthDate)
        {
            _name = name;
            if (birthMonth <= 12 && birthMonth >= 1)
            {
                _birthMonth = birthMonth;
            }
            else
            {
                throw new ArgumentException("Birth month does not exist");
            }
            _birthDate = birthDate;
        }

        public string Name
        {
            get { return _name; }
        }

        public int BirthMonth
        {
            get { return _birthMonth; }
        }

        public int BirthDate
        {
            get { return _birthDate; }
        }

        public override string ToString()
        {
            return $"{Name} born on {BirthDate} {BirthMonth}";
        }

        public string BirthSeason()
        {
            if (BirthMonth == 1 || BirthMonth == 2 || BirthMonth == 12)
            {
                return "Winter";
            }

            if (BirthMonth == 3 || BirthMonth == 4 || BirthMonth == 5)
            {
                return "Spring";
            }

            if (BirthMonth == 6 || BirthMonth == 7 || BirthMonth == 8)
            {
                return "Summer";
            }

            if (BirthMonth == 9 || BirthMonth == 10 || BirthMonth == 11)
            {
                return "Fall";
            }

            return "";
        }
    }
}
