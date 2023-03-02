using System;
using System.Linq;

namespace csharpLab4
{
    class Student
    {
        public string FullName;
        public int GroupId;
        public int[] Progress;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student(){ FullName = "Иванов И.И.", GroupId = 1, Progress = new int[]{ 5, 4, 4, 4, 5 } },
                new Student(){ FullName = "Петров П.П.", GroupId = 2, Progress = new int[]{ 4, 5, 5, 4, 4 } },
                new Student(){ FullName = "Сидоров С.С.", GroupId = 3, Progress = new int[]{ 3, 3, 3, 3, 3 } },
                new Student(){ FullName = "Федорова Ф.Ф.", GroupId = 4, Progress = new int[]{ 5, 5, 5, 5, 5 } },
                new Student(){ FullName = "Кириллов К.К.", GroupId = 5, Progress = new int[]{ 4, 4, 5, 5, 4 } },
                new Student(){ FullName = "Павлов П.П.", GroupId = 6, Progress = new int[]{ 4, 4, 4, 4, 3 } },
                new Student(){ FullName = "Сергеев С.С.", GroupId = 7, Progress = new int[]{ 2, 3, 1, 2, 4 } }
            };
            Array.Sort(students, (a, b) => a.Progress.Average().CompareTo(b.Progress.Average()));
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FullName} (группа {student.GroupId})");
            }
        }
    }
}
