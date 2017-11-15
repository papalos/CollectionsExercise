using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array7
{
    /*Для задания 5*/
    class Student
    {
        public string familyName;
        public string firstName;
        public int course;
        public int valueMath;
        public int valuePhysics;
        public int valueInf;

        public Student(string familyName, string firstName, int course, int valueMath, int valuePhysics, int valueInf)
        {
            this.familyName = familyName;
            this.firstName = firstName;
            this.course = course;
            this.valueMath = valueMath;
            this.valuePhysics = valuePhysics;
            this.valueInf = valueInf;
        }
    }
}
