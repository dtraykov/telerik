using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesAndFoldersTree
{
    class Folder
    {
        private string folderName;
        private List<File> files;
        private List<Folder> childFolders;

        public Folder(string folderName)
        {
            this.FolderName = folderName;
            this.Files = new List<File>();
            this.ChildFolders = new List<Folder>();
        }

        public List<Folder> ChildFolders
        {
            get
            {
                return this.childFolders;
            }
            set
            {
                this.childFolders = value;
            }
        }

        public List<File> Files
        {
            get
            {
                return this.files;
            }
            set
            {
                this.files = value;
            }
        }

        public string FolderName
        {
            get
            {
                return this.folderName;
            }
            set
            {
                this.folderName = value;
            }
        }

        public void DFSTraversal()
        {
        }
    }
}
