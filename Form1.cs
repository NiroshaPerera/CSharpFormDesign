using System;
using System.Windows.Forms;

namespace FinalMarksForProgramming
{
    public partial class Form1 : Form
    {
        private Student student;

        public Form1()
        {
            InitializeComponent();
            student = new Student();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateAndDisplayResult();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CalculateAndDisplayResult()
        {
            try
            {
                // Parse input values from TextBoxes
                double test1Marks = double.Parse(textBox1.Text);
                double test2Marks = double.Parse(textBox2.Text);
                double classTest1Marks = double.Parse(textBox3.Text);
                double classTest2Marks = double.Parse(textBox4.Text);
                double finalExaminationMarks = double.Parse(textBox5.Text);

                // Set the marks in the Student object
                student.SetMarks(test1Marks, test2Marks, classTest1Marks, classTest2Marks, finalExaminationMarks);

                // Calculate final mark and display the result in richTextBox1
                student.DisplayResult(richTextBox1);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter valid numeric values.", "Error");
            }
        }

        private void ClearAllFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            richTextBox1.Clear();
        }

        public class Student
        {
            private double test1Marks;
            private double test2Marks;
            private double classTest1Marks;
            private double classTest2Marks;
            private double finalExaminationMarks;

            public Student()
            {
            }

            public void SetMarks(double test1, double test2, double classTest1, double classTest2, double finalExam)
            {
                test1Marks = test1;
                test2Marks = test2;
                classTest1Marks = classTest1;
                classTest2Marks = classTest2;
                finalExaminationMarks = finalExam;
            }

            public void DisplayResult(RichTextBox richTextBox)
            {
                double bestClassTestMark = Math.Max(classTest1Marks, classTest2Marks);

                double finalMark = (test1Marks * 0.15) + (test2Marks * 0.20) + (bestClassTestMark * 0.15) + (finalExaminationMarks * 0.50);

                string resultMessage = (finalMark >= 50) ? "Pass" : "Fail";

                richTextBox.AppendText($"The final marks of the student is: {finalMark:F2}\nThe result is: {resultMessage}\n");
            }
        }
    }
}
