using System.Collections.Generic;

namespace LuxoftTasks.SecondTask
{
    class DeadPixels
    {
        public int CountGroups(char[][] monitor)
        {
            //Your solution goes here

            //https://www.hackerrank.com/challenges/connected-cell-in-a-grid/problem

            //https://gist.github.com/jianminchen/4f4d499599c015144e77e5016bd86912

            return 0;
        }

        public static int getMax(int[][] arr, int m, int n)
        {
            bool[][] visited = new bool[m][];

            for (int i = 0; i < m; i++)
                visited[i] = new bool[n];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    visited[i][j] = false;
                }
            int max = 0;
            IList<string> curList = new List<string>();
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    if (!visited[i][j])
                    {
                        int node = arr[i][j];
                        if (node == 1)
                        {
                            IList<string> list = new List<string>();

                            DFS(arr, i, j, visited, m + n, list);

                            if (list.Count > max)
                            {
                                curList = list;
                                max = list.Count;
                            }
                        }
                    }

                }
            return max;
        }

        private static void DFS(int[][] arr, int i, int j, bool[][] visited, int maxStep, IList<string> list)
        {
            int row = arr.Length;
            int col = arr[0].Length;
            if (i < row && i >= 0 && j < col && j >= 0 && maxStep >= 0)
            {
                // node is 1 and not visited. 
                if (arr[i][j] == 1 && !visited[i][j])
                {
                    visited[i][j] = true;

                    list.Add(i.ToString() + ";" + j.ToString());

                    DFS(arr, i - 1, j - 1, visited, maxStep - 1, list);
                    DFS(arr, i - 1, j, visited, maxStep - 1, list);
                    DFS(arr, i - 1, j + 1, visited, maxStep - 1, list);

                    DFS(arr, i, j - 1, visited, maxStep - 1, list);
                    DFS(arr, i, j + 1, visited, maxStep - 1, list);

                    DFS(arr, i + 1, j - 1, visited, maxStep - 1, list);
                    DFS(arr, i + 1, j, visited, maxStep - 1, list);
                    DFS(arr, i + 1, j + 1, visited, maxStep - 1, list);
                }
                else if (arr[i][j] == 0)
                {
                    if (!visited[i][j])
                        visited[i][j] = true;
                }
            }
        }
    }
}