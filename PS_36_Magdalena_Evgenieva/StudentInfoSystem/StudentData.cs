using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class StudentData
    {
        static public List<Student> TestStudents { get; private set; }

       public StudentData()
        {
            TestStudents = new List<Student>();
            TestStudents.Add(new Student());
            TestStudents[0].name = "Mariya";
            TestStudents[0].faculty = "FKST";
            TestStudents[0].specialty = "ITI";
            TestStudents[0].degree = "bachelor";
            TestStudents[0].status = "certified";
            TestStudents[0].facultyNumber = "50121903" ;
            TestStudents[0].course = "1";
            TestStudents[0].stream = "2";
            TestStudents[0].group = "32";
        }

        public List<Student> GetTestStudents()
        {
            return TestStudents;
        }
    }

}
