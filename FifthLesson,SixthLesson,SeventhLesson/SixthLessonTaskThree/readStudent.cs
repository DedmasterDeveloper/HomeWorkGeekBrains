using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SixthLessonTaskThree
{
    class readStudent
    {
        public readStudent(string Path)
        {
            if(File.Exists(Path))
            {
                _path = Path;
            }
        }
        private string _path;

        public string Path
        {
            get
            {
                return _path;
            }
            set
            {
                _path = value;
            }
        }

        public List<string> getStudent()
        {
            StreamReader streamReader = new StreamReader(_path);
            List<string> Student = new List<string>();
            while(!streamReader.EndOfStream)
            {
                Student.Add(streamReader.ReadLine());
            }
            return Student;
        }
    }
}
