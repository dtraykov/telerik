using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolProject
{
    public class SchoolClass
    {
        private string identifier;
        private List<Student> student;
        private List<Teacher> teacher;

        public SchoolClass(string identifier, List<Student> students, List<Teacher> techers)
        {
            this.Identifier = identifier;
            this.Students = students;
            this.Teacher = techers;
        }

        public string Identifier
        {
            get
            {
                return this.identifier;
            }

            set
            {
                this.identifier = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.student;
            }

            set
            {
                this.student = value;
            }
        }

        public List<Teacher> Teacher
        {
            get
            {
                return this.teacher;
            }

            set
            {
                this.teacher = value;
            }
        }

        public override string ToString()
        {
            StringBuilder schoolClassInfoBuilder = new StringBuilder();

            schoolClassInfoBuilder.AppendLine(string.Format("Class: {0}", this.identifier));
            schoolClassInfoBuilder.AppendLine();
            schoolClassInfoBuilder.AppendLine("Students:");

            foreach (Student student in this.student)
            {
                schoolClassInfoBuilder.AppendLine(string.Format("{0}", student));
            }

            schoolClassInfoBuilder.AppendLine();
            schoolClassInfoBuilder.AppendLine("Teachers:");

            foreach (Teacher teacher in this.teacher)
            {
                schoolClassInfoBuilder.AppendLine(teacher.ToString());
            }

            return schoolClassInfoBuilder.ToString();
        }
    }
}
