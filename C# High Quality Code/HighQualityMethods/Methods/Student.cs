namespace Methods
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private string otherInfo;

        public Student(string firstName, string lastName, DateTime birthDate)
            : this(firstName, lastName, birthDate, null)
        {
        }

        public Student(string firstName, string lastName, DateTime birthDate, string otherInfo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.OtherInfo = otherInfo;
        }

        public DateTime BirthDate
        {
            get
            {
                return this.birthDate;
            }

            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Your birth date is bigger than today.");
                }

                this.birthDate = value;
            }
        }

        public string OtherInfo
        {
            get
            {
                return this.otherInfo;
            }

            set
            {
                this.otherInfo = value;
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
                if (value.Length < 2)
                {
                    throw new ArgumentException("Your last name is too short. Please insert at last 2 symbols.");
                }

                this.lastName = value;
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
                if (value.Length < 2)
                {
                    throw new ArgumentException("Your first name is too short. Please insert at last 2 symbols.");
                }

                this.firstName = value;
            }
        }

        public bool IsOlderThan(Student other)
        {
            DateTime firstDate = this.BirthDate;
            DateTime secondDate = other.BirthDate;

            if (firstDate > DateTime.Now || secondDate > DateTime.Now)
            {
                throw new ArgumentException("Your birth date is bigger than today.");
            }

            return firstDate > secondDate;
        }
    }
}
