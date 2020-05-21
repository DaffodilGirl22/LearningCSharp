using System;

namespace LearningCSharp
{
    class Student
    {

        public string name;
        public string degree;
        public double grade;

        public Student (
            string aName, string aDegree, double aGrade)
        {
            name = aName;
            degree = aDegree;
            grade = aGrade;
        }

        public bool HasHonours()
        {
            bool result = (grade >= 50.0) ? true : false;
            grade = 77.4;  // This resets each students "grade"
            return result;
        }

    }
}
