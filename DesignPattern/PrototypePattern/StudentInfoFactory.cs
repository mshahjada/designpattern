using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.PrototypePattern
{
    public class StudentInfoFactory : PrototypeFactory<CourseInfo>, IStudentInfo
    {
        public string Name { get; set; }
        public string StudentId { get; set; }
        public string Semester { get; set; }
        public string Department { get; set; }

        public CourseInfo CourseInfo { get; set; }

    }
}
