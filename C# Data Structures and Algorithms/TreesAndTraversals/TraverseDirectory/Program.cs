/*Write a program to traverse the directory C:\WINDOWS and all its subdirectories 
 * recursively and to display all files matching the mask *.exe. Use the class System.IO.Directory.
 */
namespace TraverseDirectory
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Program
    {
        private static List<string> files = new List<string>();

        public static void TraverseDirectory(string path, string fileExtension)
        {
            try
            {
                string[] currentDirFiles = Directory.GetFiles(path, fileExtension);
                files.AddRange(currentDirFiles);

                string[] directories = Directory.GetDirectories(path);

                foreach (var directory in directories)
                {
                    TraverseDirectory(directory, fileExtension);
                }
            }
            catch (System.UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Main(string[] args)
        {
            string path = @"C:\Windows";
            string fileExtension = "*.exe";

            TraverseDirectory(path, fileExtension);
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
        }
    }
}
