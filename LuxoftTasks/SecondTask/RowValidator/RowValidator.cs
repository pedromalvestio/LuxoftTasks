using System;
using System.Collections.Generic;
using System.Text;

namespace LuxoftTasks.SecondTask.RowValidator
{
    class RowValidator : IRowValidator
    {
        public bool IsRowValid(char[][] arr, int column, int row)
        {
            return row >= 0 || row < arr[column].Length;
        }

        public virtual bool VerifyDeadPixel(char[][] arr, int column, int row)
        {
            return true;
        }
    }
}
