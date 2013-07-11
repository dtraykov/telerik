using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotatingWalkInMatrix
{
    /// <summary>
    /// Represent all possible directions to traverse
    /// </summary>
    public class PossibleDirection
    {
        private readonly Direction downRight = new Direction(1, 1);
        private readonly Direction down = new Direction(1, 0);
        private readonly Direction downLeft = new Direction(1, -1);
        private readonly Direction left = new Direction(0, -1);
        private readonly Direction upLeft = new Direction(-1, -1);
        private readonly Direction up = new Direction(-1, 0);
        private readonly Direction upRight = new Direction(-1, 1);
        private readonly Direction right = new Direction(0, 1);

        public static Direction[] Generate()
        {
            PossibleDirection current = new PossibleDirection();
            Direction[] possibleDirections = 
            { 
                current.downRight, current.down, current.downLeft, current.left, 
                current.upLeft, current.up, current.upRight, current.right 
            };

            return possibleDirections;
        }

        public static Direction GetInitialDirection()
        {
            PossibleDirection current = new PossibleDirection();
            Direction initialDirection = current.downRight;
            return initialDirection;
        }

        public static Direction GetNextPossibleDirection(Direction direction)
        {
            Direction[] possibleDirections = Generate();
            int index = 0;
            for (int count = 0; count < possibleDirections.Length; count++)
            {
                bool foundDirection =
                    possibleDirections[count].X == direction.X &&
                    possibleDirections[count].Y == direction.Y;
                if (foundDirection && count < possibleDirections.Length - 1)
                {
                    index = count + 1;
                    break;
                }
                else if (foundDirection && count == possibleDirections.Length - 1)
                {
                    index = 0;
                }
            }

            return possibleDirections[index];
        }
    }
}
