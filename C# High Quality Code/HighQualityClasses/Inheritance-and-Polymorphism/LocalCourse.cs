namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    public class LocalCourse : Course
    {
        private string lab;

        public LocalCourse(string courseName)
            : base(courseName)
        {
        }

        public LocalCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students, string lab)
            : base(courseName, teacherName, students)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                this.lab = value;
            }
        }

        public override string ToString()
        {
            if (this.Lab != null)
            {
                string result = base.ToString() + string.Format("; Lab = {0}", this.Lab) + " }";
                return result;
            }
            else
            {
                return base.ToString() + " }";
            }
        }
    }
}
