using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_3.University
{
    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int socialSecurityNumber;
        private string parmanentAddress;
        private int mobilePhone;
        private string email;
        private int course;
        private University university;
        private Faculty faculty;
        private Specialty specialty;

        public Student(
            string firstName,
            string middleName,
            string lastName,
            int socialSecurityNumber,
            string parmanentAddress,
            int mobilePhone,
            string email,
            int course,
            University university,
            Faculty faculty,
            Specialty specialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SocialSecurityNumber = socialSecurityNumber;
            this.PermanentAddress = parmanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }

        public Specialty Specialty
        {
            get
            {
                return this.specialty;
            }

            set
            {
                this.specialty = value;
            }
        }

        public Faculty Faculty
        {
            get
            {
                return this.faculty;
            }

            set
            {
                this.faculty = value;
            }
        }

        public University University
        {
            get
            {
                return this.university;
            }

            set
            {
                this.university = value;
            }
        }

        public int Course
        {
            get
            {
                return this.course;
            }

            set
            {
                this.course = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.email = value;
            }
        }

        public int MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }

            set
            {
                this.mobilePhone = value;
            }
        }

        public string PermanentAddress
        {
            get
            {
                return this.parmanentAddress;
            }

            set
            {
                this.parmanentAddress = value;
            }
        }

        public int SocialSecurityNumber
        {
            get
            {
                return this.socialSecurityNumber;
            }

            set
            {
                this.socialSecurityNumber = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.lastName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            set
            {
                this.middleName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.firstName = value;
            }
        }

        public static bool operator ==(Student firstStudent, Student secoundStudent)
        {
            return Student.Equals(firstStudent, secoundStudent);
        }

        public static bool operator !=(Student firstStudent, Student secoundStudent)
        {
            return !Student.Equals(firstStudent, secoundStudent);
        }

        public Student Clone()    // Return Deep Copy
        {
            Student newStudent = new Student(
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.SocialSecurityNumber,
                this.PermanentAddress,
                this.MobilePhone,
                this.Email,
                this.Course,
                this.University,
                this.Faculty,
                this.Specialty);
            return newStudent;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student otherStudent)
        {
            if (this.FirstName != otherStudent.FirstName)
            {
                return string.Compare(this.FirstName, otherStudent.FirstName);
            }

            if (this.MiddleName != otherStudent.MiddleName)
            {
                return string.Compare(this.MiddleName, otherStudent.MiddleName);
            }

            if (this.LastName != otherStudent.LastName)
            {
                return string.Compare(this.LastName, otherStudent.LastName);
            }

            if (this.socialSecurityNumber != otherStudent.socialSecurityNumber)
            {
                return (int)(this.socialSecurityNumber - otherStudent.socialSecurityNumber);
            }

            return 0;
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (student == null)
            {
                return false;
            }

            if (!object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }

            if (!object.Equals(this.MiddleName, student.MiddleName))
            {
                return false;
            }

            if (!object.Equals(this.LastName, student.LastName))
            {
                return false;
            }

            if (!object.Equals(this.SocialSecurityNumber, student.SocialSecurityNumber))
            {
                return false;
            }

            // If names and SSN are equal this is the same student
            return true;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = result ^ ((this.lastName != null) ? this.lastName.GetHashCode() : 0);
                result = result ^ this.socialSecurityNumber.GetHashCode();
                return result;
            }
        }

        public override string ToString()
        {
            StringBuilder student = new StringBuilder();
            student.AppendLine(string.Format("Name: {0} {1} {2}", this.firstName, this.middleName, this.lastName));
            student.AppendLine("SSN: " + this.socialSecurityNumber);
            student.AppendLine("Address: " + this.parmanentAddress);
            student.AppendLine("Phone number: " + this.mobilePhone);
            student.AppendLine("Email: " + this.email);
            student.AppendLine("Course: " + this.course);
            student.AppendLine("University: " + this.university);
            student.AppendLine("Faculty: " + this.faculty);
            student.AppendLine("Specialty: " + this.specialty);

            return student.ToString();
        }
    }
}
