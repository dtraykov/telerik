using System;
using System.Collections.Generic;

namespace SchoolLib
{
    public class School
    {
        private List<Course> courses;

        public School(List<Course> courses)
        {
            this.Courses = courses;
        }

        public List<Course> Courses
        {
            get
            {
                return this.courses;
            }

            set
            {
                this.courses = value;
            }
        }

        public void AddCourse(Course course)
        {
            this.Courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            bool courseFound = false;
            for (int i = 0; i < this.Courses.Count; i++)
            {
                if (this.Courses[i].Name == course.Name)
                {
                    courseFound = true;
                    this.Courses.Remove(course);
                }
            }

            if (!courseFound)
            {
                throw new ArgumentException("The course does not exist in this course, so there is no need to remove it!");
            }
        }
    }
}
