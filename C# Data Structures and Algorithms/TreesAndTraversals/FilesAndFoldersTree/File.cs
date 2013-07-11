using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesAndFoldersTree
{
    class File
    {
        private string fileName;
        private int size;

        public File(string fileName, int size)
        {
            this.FileName = fileName;
            this.Size = size;
        }

        public int Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        public string FileName
        {
            get
            {
                return this.fileName;
            }
            set
            {
                this.fileName = value;
            }
        }
    }
}
