namespace DataStructuresAndAlgorithms.Arrays
{
    public class IsValidSudokuSolution
    {
        public bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                HashSet<char> rows = new HashSet<char>();
                HashSet<char> columns = new HashSet<char>();
                HashSet<char> cube = new HashSet<char>();

                for (int j = 0; j < 9; j++)
                {
                    // Row and Column validation
                    if (board[i][j] != '.' && !rows.Add(board[i][j])) return false;
                    if (board[j][i] != '.' && !columns.Add(board[j][i])) return false;

                    // 3x3 Sub-grid validation
                    // Calculate starting points for the sub-grid
                    int rowStart = 3 * (i / 3); // rowStart = 0
                    int colStart = 3 * (i % 3); // colStart = 0

                    // Calculate current cell's position within the sub-grid
                    int subRow = rowStart + j / 3; // subRow cycles through 0, 0, 0 (for j=0,1,2), then 1, 1, 1 (for j=3,4,5), etc.
                    int subCol = colStart + j % 3; // subCol cycles through 0, 1, 2 for each row of the sub-grid
                    char cellValue = board[subRow][subCol];

                    if (cellValue != '.' && !cube.Add(cellValue))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
