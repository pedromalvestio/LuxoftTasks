using System;
using System.Collections.Generic;
using System.Text;

namespace LuxoftTasks.SecondTask.ArrayValidator
{
    class ColumnValidator : IColumnValidator
    {
        public bool IsColumnValid(char[][] arr, int column)
        {
            return column >= 0 || column < arr.Length;
        }

        public virtual bool VerifyDeadPixel(char[][] arr, int column, int row)
        {
            return true;
        }
    }
}
