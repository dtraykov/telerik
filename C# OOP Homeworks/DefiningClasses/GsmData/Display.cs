using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsmData
{
    public class Display
    {
        private float size;
        private string numberColors;

        public Display()
        {
        }

        public Display(float size)
            : this(size, null)
        {
        }

        public Display(string numberColors)
            : this(0, numberColors)
        {
        }

        public Display(float size, string numberColors)
        {
            this.Size = size;
            this.NumberColors = numberColors;
        }

        public float Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public string NumberColors
        {
            get { return this.numberColors; }
            set { this.numberColors = value; }
        }
    }
}
