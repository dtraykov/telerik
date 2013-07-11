namespace SchoolLib
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Course
    {
        public const byte MaxStudents = 29;

        private string name;
        private List<Student> students;

        public Course(string name)
            : this(name, null)
        {
        }

        public Course(string name, List<Student> students)
        {
            this.Name = name;
            this.Students = students;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentNullException("Name cannot be missing!");
                }

                this.name = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                this.students = value;
            }
        }

        public void AddStudent(Student student)
        {
            bool studentFound = this.CheckIfStudentIsFound(student);

            if (studentFound)
            {
                throw new ArgumentException("The student has been added already!");
            }

            if (this.Students.Count + 1 < MaxStudents)
            {
                this.Students.Add(student);
            }
            else
            {
                throw new ArgumentOutOfRangeException("The course is full. No more students can be added!");
            }
        }

        public void RemoveStudent(Student student)
        {
            bool studentFound = this.CheckIfStudentIsFound(student);

            if (!studentFound)
            {
                throw new ArgumentException("The student does not exist in this course, so there is no need to remove it!");
            }

            this.Students.Remove(student);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(string.Format("Course name {0}; ", this.Name));

            for (int i = 0; i < this.Students.Count; i++)
            {
                output.Append(this.Students[i]);
            }

            return output.ToString();
        }

        private bool CheckIfStudentIsFound(Student student)
        {
            bool studentFound = false;
            for (int i = 0; i < this.Students.Count; i++)
            {
                if (this.Students[i].UniqueNumber == student.UniqueNumber)
                {
                    studentFound = true;
                }
            }

            return studentFound;
        }
    }
}
