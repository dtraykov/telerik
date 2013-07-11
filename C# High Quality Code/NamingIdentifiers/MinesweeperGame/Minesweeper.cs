namespace MinesweeperGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Minesweeper
    {
       public static void Main(string[] args)
        {
            string command = string.Empty;
            char[,] gameField = CreateGameField();
            char[,] bombs = InitializeBombs();
            int playerScore = 0;
            bool isBomb = false;
            List<Score> scoreList = new List<Score>(6);
            int gameFieldRow = 0;
            int gameFieldCol = 0;
            bool isNewGame = true;
            const int MaxScore = 35;
            bool isWon = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine("Let's play Minesweeper!");
                    Console.WriteLine("Try your luck and find the cells without bombs or ...");
                    Console.WriteLine("...you will die.");
                    Console.WriteLine("\n====================================");
                    Console.WriteLine("Menu:");
                    Console.WriteLine("'top' - show the rating");
                    Console.WriteLine("'restart' - start a new game");
                    Console.WriteLine("'exit' - exit the game");
                    Console.WriteLine("'4x5' - example for entering row and col");
                    Console.WriteLine("====================================");
                    DrawGameField(gameField);
                    isNewGame = false;
                }

                Console.Write("Enter row and col [row x col]: ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out gameFieldRow) &&
                    int.TryParse(command[2].ToString(), out gameFieldCol) &&
                        gameFieldRow <= gameField.GetLength(0) && gameFieldCol <= gameField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        PlayerScore(scoreList);
                        break;
                    case "restart":
                        gameField = CreateGameField();
                        bombs = InitializeBombs();
                        DrawGameField(gameField);
                        isBomb = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, Bye!");
                        break;
                    case "turn":
                        if (bombs[gameFieldRow, gameFieldCol] != '*')
                        {
                            if (bombs[gameFieldRow, gameFieldCol] == '-')
                            {
                                PlayerTurn(gameField, bombs, gameFieldRow, gameFieldCol);
                                playerScore++;
                            }

                            if (MaxScore == playerScore)
                            {
                                isWon = true;
                            }
                            else
                            {
                                DrawGameField(gameField);
                            }
                        }
                        else
                        {
                            isBomb = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError: Invalid call\n");
                        break;
                }

                if (isBomb)
                {
                    DrawGameField(bombs);

                    Console.WriteLine("You hit a bomb and ... you are dead. You should try Again");
                    Console.Write("\nPersonal Score: {0} Enter your Nickname: ", playerScore);
                    string playerName = Console.ReadLine();
                    Score newPlayerScore = new Score(playerName, playerScore);
                    if (scoreList.Count < 5)
                    {
                        scoreList.Add(newPlayerScore);
                    }
                    else
                    {
                        for (int i = 0; i < scoreList.Count; i++)
                        {
                            if (scoreList[i].PlayerScore < newPlayerScore.PlayerScore)
                            {
                                scoreList.Insert(i, newPlayerScore);
                                scoreList.RemoveAt(scoreList.Count - 1);
                                break;
                            }
                        }
                    }

                    scoreList.Sort((Score firstPlayer, Score secondPlayer) => secondPlayer.PlayerName.CompareTo(firstPlayer.PlayerName));
                    scoreList.Sort((Score firstPlayer, Score secondPlayer) => secondPlayer.PlayerScore.CompareTo(firstPlayer.PlayerScore));
                    PlayerScore(scoreList);

                    gameField = CreateGameField();
                    bombs = InitializeBombs();
                    playerScore = 0;
                    isBomb = false;
                    isNewGame = true;
                }

                if (isWon)
                {
                    Console.WriteLine("\nGODLIKE! You win!");
                    DrawGameField(bombs);
                    Console.WriteLine("Enter your name: ");
                    string playerName = Console.ReadLine();
                    Score newPlayerScore = new Score(playerName, playerScore);
                    scoreList.Add(newPlayerScore);
                    PlayerScore(scoreList);
                    gameField = CreateGameField();
                    bombs = InitializeBombs();
                    playerScore = 0;
                    isWon = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria!");
            Console.WriteLine("Press any key to continue . . .");
            Console.Read();
        }

        private static void PlayerScore(List<Score> scoreList)
        {
            Console.WriteLine("\nScore:");
            if (scoreList.Count > 0)
            {
                for (int i = 0; i < scoreList.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} opened cells", i + 1, scoreList[i].PlayerName, scoreList[i].PlayerScore);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty score list!\n");
            }
        }

        private static void PlayerTurn(char[,] gameField, char[,] bombs, int gameFieldRow, int gameFieldCol)
        {
            char kolkoBombi = GetSurroundingBombCount(bombs, gameFieldRow, gameFieldCol);
            bombs[gameFieldRow, gameFieldCol] = kolkoBombi;
            gameField[gameFieldRow, gameFieldCol] = kolkoBombi;
        }

        private static void DrawGameField(char[,] gameField)
        {
            int gameFieldCol = gameField.GetLength(0);
            int gameFiledRow = gameField.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int col = 0; col < gameFieldCol; col++)
            {
                Console.Write("{0} | ", col);
                for (int row = 0; row < gameFiledRow; row++)
                {
                    Console.Write(string.Format("{0} ", gameField[col, row]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int gameFiledRow = 5;
            int gameFieldCol = 10;
            char[,] gameField = new char[gameFiledRow, gameFieldCol];
            for (int row = 0; row < gameFiledRow; row++)
            {
                for (int col = 0; col < gameFieldCol; col++)
                {
                    gameField[row, col] = '?';
                }
            }

            return gameField;
        }

        private static char[,] InitializeBombs()
        {
            int gameFieldRow = 5;
            int gameFieldCol = 10;
            char[,] gameField = new char[gameFieldRow, gameFieldCol];

            for (int row = 0; row < gameFieldRow; row++)
            {
                for (int col = 0; col < gameFieldCol; col++)
                {
                    gameField[row, col] = '-';
                }
            }

            List<int> bombs = new List<int>();
            while (bombs.Count < 15)
            {
                Random randomGenerator = new Random();
                int randomLocation = randomGenerator.Next(50);
                if (!bombs.Contains(randomLocation))
                {
                    bombs.Add(randomLocation);
                }
            }

            foreach (int bomb in bombs)
            {
                int col = bomb / gameFieldCol;
                int row = bomb % gameFieldCol;
                if (row == 0 && bomb != 0)
                {
                    col--;
                    row = gameFieldCol;
                }
                else
                {
                    row++;
                }

                gameField[col, row - 1] = '*';
            }

            return gameField;
        }

        private static void CalculateNeighborBombs(char[,] gameField)
        {
            int colLength = gameField.GetLength(0);
            int rowLength = gameField.GetLength(1);

            for (int col = 0; col < colLength; col++)
            {
                for (int row = 0; row < rowLength; row++)
                {
                    if (gameField[col, row] != '*')
                    {
                        char amount = GetSurroundingBombCount(gameField, col, row);
                        gameField[col, row] = amount;
                    }
                }
            }
        }

        private static char GetSurroundingBombCount(char[,] gameField, int gameFieldRow, int gameFieldCol)
        {
            int bombCount = 0;
            int rowLength = gameField.GetLength(0);
            int colLength = gameField.GetLength(1);

            if (gameFieldRow - 1 >= 0)
            {
                if (gameField[gameFieldRow - 1, gameFieldCol] == '*')
                {
                    bombCount++;
                }
            }

            if (gameFieldRow + 1 < rowLength)
            {
                if (gameField[gameFieldRow + 1, gameFieldCol] == '*')
                {
                    bombCount++;
                }
            }

            if (gameFieldCol - 1 >= 0)
            {
                if (gameField[gameFieldRow, gameFieldCol - 1] == '*')
                {
                    bombCount++;
                }
            }

            if (gameFieldCol + 1 < colLength)
            {
                if (gameField[gameFieldRow, gameFieldCol + 1] == '*')
                {
                    bombCount++;
                }
            }

            if ((gameFieldRow - 1 >= 0) && (gameFieldCol - 1 >= 0))
            {
                if (gameField[gameFieldRow - 1, gameFieldCol - 1] == '*')
                {
                    bombCount++;
                }
            }

            if ((gameFieldRow - 1 >= 0) && (gameFieldCol + 1 < colLength))
            {
                if (gameField[gameFieldRow - 1, gameFieldCol + 1] == '*')
                {
                    bombCount++;
                }
            }

            if ((gameFieldRow + 1 < rowLength) && (gameFieldCol - 1 >= 0))
            {
                if (gameField[gameFieldRow + 1, gameFieldCol - 1] == '*')
                {
                    bombCount++;
                }
            }

            if ((gameFieldRow + 1 < rowLength) && (gameFieldCol + 1 < colLength))
            {
                if (gameField[gameFieldRow + 1, gameFieldCol + 1] == '*')
                {
                    bombCount++;
                }
            }

            return char.Parse(bombCount.ToString());
        }
    }
}
