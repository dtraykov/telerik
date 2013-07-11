/* Define classes File { string name, int size } and 
 * Folder { string name, File[] files, Folder[] childFolders } 
 * and using them build a tree keeping all files and folders on the hard drive 
 * starting from C:\WINDOWS. Implement a method that calculates the sum of the 
 * file sizes in given subtree of the tree and test it accordingly. 
 * Use recursive DFS traversal.
 */
namespace FilesAndFoldersTree
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Program
    {
        public static double ColculateSizeWithDFS()
        {

        }

        static void Main(string[] args)
        {
            /* 
             * Днес беше тежък ден в работата и отивам с колегите да се напием.
             * Знам, че ще ме нахраните много, знам и за разпределението на времето.
             * Обещавам, че на всички коментари, ще отговоря с "Да".
             * Трябва и да се разпуска стига толкова задачи. 
             */

            string path = @"C:\Windows";
            string fileExtension = "*.exe";

        }
    }
}
