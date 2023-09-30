

using System.Collections;

namespace LeetCode36
{
    public static class Ans
        
    {
        
        public static bool IsValidSudoku(char[][] board)
        {
            int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            

            Dictionary<int, List<char>> rows = new Dictionary<int, List<char>>()
            {
                { 0, new List<char> { } },
                { 1, new List<char> { } },
                { 2,new List<char> { } },
                { 3, new List<char> { } },
                { 4, new List<char> { } },
                { 5, new List<char> { } },
                { 6, new List<char> { } },
                { 7, new List<char> { } },
                { 8, new List<char> { } }
            };
            Dictionary<int, List<char>> column = new Dictionary<int, List<char>>()
            {
                {0, new List<char> {} },
                {1, new List<char> {} },
                {2,new List<char>{} },
                {3, new List<char> {} },
                {4, new List<char> {} },
                {5, new List<char> {} },
                {6, new List<char> {} },
                {7, new List<char> {} },
                {8, new List<char> {} }
            };
            Dictionary<(int,int), List<char>> squares = new Dictionary<(int,int), List<char>>()
            {
                {(0,0), new List<char> {} },
                {(0,1), new List<char> {} },
                {(0,2), new List<char> {} },
                {(1,0), new List<char> {} },
                {(1,1), new List<char> {} },
                {(1,2), new List<char> {} },
                {(2,0), new List<char> {} },
                {(2,1), new List<char> {} },
                {(2,2) , new List<char>{} }
            };

            
            for (int i = 0; i< 9; i++)
            {
                for(int j = 0; j<9; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if(rows[j].Contains(board[i][j]) 
                            || column[i].Contains(board[i][j]) 
                            || squares[(i / 3, j / 3)].Contains(board[i][j]))
                        {
                         return false;
                        }

                        rows[j].Add(board[i][j]);
                        column[i].Add(board[i][j]);
                        squares[(i / 3, j / 3)].Add(board[i][j]);
                    }

                }
            }
            return true;
            
        }
    }
}
