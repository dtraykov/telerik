using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolProject
{
    public class Teacher : Person
    {
        private List<Disciplines> discipline;

        public Teacher(string firstName, string lastName, List<Disciplines> discipline)
            : base(firstName, lastName)
        {
            this.Discipline = discipline;
        }

        public List<Disciplines> Discipline
        {
            get
            {
                return this.discipline;
            }

            set
            {
                this.discipline = value;
            }
        }

        public override string ToString()
        {
            StringBuilder teacherInfo = new StringBuilder();

            teacherInfo.AppendLine(string.Format("Teacher: {0}", base.ToString()));
            teacherInfo.AppendLine();
            teacherInfo.AppendLine("Disciplines:");

            foreach (Disciplines discipline in this.discipline)
            {
                teacherInfo.AppendLine(discipline.ToString());
            }

            return teacherInfo.ToString();
        }
    }
}