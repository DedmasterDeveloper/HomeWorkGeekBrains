using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthLessonTaskThree
{
    class FilterStudent
    {
        private static string[] separators = { " " };
        private List<string> _students = new List<string>();
        private List<string> studentOut = new List<string>();

        public List<string> Student 
        {
            get { return _students; }
            set { _students = value; }
        }

        public FilterStudent(List<string> Students)
        {
            _students = Students;
        }

        public FilterStudent() { }

        

        public List<string> lvlFilter(List<int> lvl)
        {
            foreach(string student in _students)
            {
                string[] studentInfo = student.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                foreach(int Lvl in lvl)
                {
                    if(Lvl == Convert.ToInt32(studentInfo[2]))
                    {
                        studentOut.Add($"{studentInfo[0]} {studentInfo[1]} {studentInfo[2]} {studentInfo[3]}");
                    }
                }
            }

            return studentOut;
        }

    }
}
