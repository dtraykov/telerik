/*
 * A text file students.txt holds information about students and their courses in the following format:
 * Kiril  | Ivanov   | C#
 * Stefka | Nikolova | SQL
 * Stela  | Mineva   | Java
 * Milena | Petrova  | C#
 * Ivan   | Grigorov | C#
 * Ivan   | Kolev    | SQL
 * 
 * Using SortedDictionary<K,T> print the courses in alphabetical order and for each of 
 * them prints the students ordered by family and then by name:
 * 
 * C#: Ivan Grigorov, Kiril Ivanov, Milena Petrova
 * Java: Stela Mineva
 * SQL: Ivan Kolev, Stefka Nikolova
 */

namespace TelerikStudents
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        private static SortedDictionary<string, List<Student>> telerikStudents =
            new SortedDictionary<string, List<Student>>();

        public static void Main(string[] args)
        {
            string path = @"../../students.txt";
            ReadTextFile(path);

            foreach (var pair in telerikStudents)
            {
                Console.Write("{0}: ", pair.Key);
                var sortedStudents = pair.Value.OrderBy(x => x.LastName).ThenBy(x => x.FirstName);

                foreach (var student in sortedStudents)
                {
                    Console.Write("{0} {1}, ", student.FirstName, student.LastName);
                }

                Console.WriteLine();
            }
        }

        private static void ReadTextFile(string path)
        {
            StreamReader reader = new StreamReader(path);
            string[] atributes = new string[2];
            using (reader)
            {
                string inputLine = reader.ReadLine();

                while (!string.IsNullOrEmpty(inputLine))
                {
                    atributes = inputLine.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    PutToDictyonary(atributes);
                    inputLine = reader.ReadLine();
                }
            }
        }

        private static void PutToDictyonary(string[] atributes)
        {
            Student student = new Student(atributes[0].Trim(), atributes[1].Trim());
            if (telerikStudents.ContainsKey(atributes[2].Trim()))
            {
                telerikStudents[atributes[2].Trim()].Add(student);
            }
            else
            {
                telerikStudents.Add(atributes[2].Trim(), new List<Student>() { student });
            }
        }
    }
}
