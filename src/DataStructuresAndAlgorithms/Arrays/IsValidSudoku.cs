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
                    // Calculate starting row/col for the i-th sub-grid (i maps to grids left-to-right, top-to-bottom)
                    int rowStart = 3 * (i / 3); // rowStart = 0, 0, 0, 3, 3, 3, 6, 6, 6 for i = 0..8
                    int colStart = 3 * (i % 3); // colStart = 0, 3, 6, 0, 3, 6, 0, 3, 6 for i = 0..8

                    // Calculate current cell's position within the sub-grid (j iterates over 9 cells in the sub-grid)
                    int subRow = rowStart + j / 3; // j/3 offsets by 0, 0, 0, 1, 1, 1, 2, 2, 2 within the sub-grid rows
                    int subCol = colStart + j % 3; // j%3 offsets by 0, 1, 2 cycling through each column in the sub-grid
                    char cellValue = board[subRow][subCol];

                    if (cellValue != '.' && !cube.Add(cellValue))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        // Alternative: Single HashSet<string> approach — easier to remember
        public bool IsValidSudokuV2(char[][] board)
        {
            var seen = new HashSet<string>();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    char c = board[i][j];
                    if (c == '.') continue;
                    if (!seen.Add($"row{i}:{c}") ||
                        !seen.Add($"col{j}:{c}") ||
                        // i/3 maps rows 0-2 → 0, 3-5 → 1, 6-8 → 2 (box row index)
                        // j/3 maps cols 0-2 → 0, 3-5 → 1, 6-8 → 2 (box col index)
                        // Together they identify which of the 9 boxes (0,0 to 2,2) the cell belongs to
                        // e.g. cell (4,7) → box "1,2", cell (1,2) → box "0,0"
                        !seen.Add($"box{i / 3},{j / 3}:{c}"))
                        return false;
                }
            }
            return true;
        }
    }
}
