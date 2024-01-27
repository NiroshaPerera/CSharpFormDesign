using System;

namespace FinalMarksForProgramming
{
    internal class Student
    {
        private double test1;
        private double test2;
        private double classTest1;
        private double classTest2;

        public Student(double test1, double test2, double classTest1, double classTest2)
        {
            this.test1 = test1;
            this.test2 = test2;
            this.classTest1 = classTest1;
            this.classTest2 = classTest2;
        }

        internal void CalculateAndDisplayFinalMark(double finalExamMarks, object resultRichTextBox)
        {
            throw new NotImplementedException();
        }

        internal string GetResultMessage()
        {
            throw new NotImplementedException();
        }
    }
}