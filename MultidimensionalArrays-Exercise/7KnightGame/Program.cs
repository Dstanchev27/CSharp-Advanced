namespace _7KnightGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] board = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                string row = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    board[i, j] = row[j];
                }
            }

            int removedKnights = 0;

            int[] rowMoves = { -2, -2, -1, -1, 1, 1, 2, 2 };
            int[] colMoves = { -1, 1, -2, 2, -2, 2, -1, 1 };

            int CountAttacks(int row, int col)
            {
                int attacks = 0;

                for (int i = 0; i < rowMoves.Length; i++)
                {
                    int newRow = row + rowMoves[i];
                    int newCol = col + colMoves[i];

                    if (IsValidPosition(newRow, newCol) && board[newRow, newCol] == 'K')
                    {
                        attacks++;
                    }
                }

                return attacks;
            }

            bool IsValidPosition(int row, int col)
            {
                return row >= 0 && row < n && col >= 0 && col < n;
            }

            while (true)
            {
                int maxAttacks = 0;
                int maxRow = -1;
                int maxCol = -1;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (board[i, j] == 'K')
                        {
                            int attacks = CountAttacks(i, j);
                            if (attacks > maxAttacks)
                            {
                                maxAttacks = attacks;
                                maxRow = i;
                                maxCol = j;
                            }
                        }
                    }
                }

                if (maxAttacks == 0)
                {
                    break;
                }

                board[maxRow, maxCol] = '0';
                removedKnights++;
            }

            Console.WriteLine(removedKnights);
        }
    }
}
