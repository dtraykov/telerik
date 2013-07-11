using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotatingWalkInMatrix
{
    public class Cell
    {
        private int row;
        private int col;

        public Cell(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public int Row
        {
            get
            {
                return this.row;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid input! Cannot create cell with negative row.");
                }

                this.row = value;
            }
        }

        public int Col
        {
            get
            {
                return this.col;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid input! Cannot create cell with negative column.");
                }

                this.col = value;
            }
        }
    }

}
