using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolProject
{
    public class School
    {
        private string name;

        private List<SchoolClass> classes;

        public School(string name, List<SchoolClass> classes)
        {
            this.Name = name;
            this.Classes = classes;
        }

        public List<SchoolClass> Classes
        {
            get
            {
                return this.classes;
            }

            set
            {
                this.classes = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == string.Empty || value.Length < 3)
                {
                    throw new ArgumentException("The name of School can't be empty or less than 2 letters!");
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            StringBuilder schoolInfo = new StringBuilder();
            schoolInfo.AppendLine(new string('=', 80));
            schoolInfo.AppendLine(string.Format("School: {0}", this.Name));

            foreach (SchoolClass schoolClass in this.Classes)
            {
                schoolInfo.AppendLine(new string('=', 80));
                schoolInfo.AppendLine(schoolClass.ToString());
            }

            return schoolInfo.ToString();
        }
    }
}
