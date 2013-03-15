/* 1.We are given a school. In the school there are classes of students. Each class has a set of teachers. 
 * Each teacher teaches a set of disciplines. Students have name and unique class number.
 * Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures 
 * and number of exercises. Both teachers and students are people. Students, classes, teachers and disciplines 
 * could have optional comments (free text block).
 * Your task is to identify the classes (in terms of  OOP) and their attributes and operations,
 * encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolProject
{
    public class Disciplines : ICommentable
    {
        private string name;
        private int lectures;
        private int exercises;

        public Disciplines(string name, int lectures, int exercises)
            : this(name, lectures, exercises, null)
        {
        }

        public Disciplines(string name, int lectures, int exercises, string tag)
        {
            this.Name = name;
            this.Lectures = lectures;
            this.Exercises = exercises;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentException("The name of discipline can't be empty or less than 2 letters!");
                }

                this.name = value;
            }
        }

        public int Exercises
        {
            get
            {
                return this.exercises;
            }

            set
            {
                this.exercises = value;
            }
        }

        public int Lectures
        {
            get
            {
                return this.lectures;
            }

            set
            {
                this.lectures = value;
            }
        }

        public List<string> Comments { get; set; }

        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }

        public override string ToString()
        {
            return string.Format("{0}: {1} lectures, {2} exercises", this.name, this.lectures, this.exercises);
        }
    }
}
