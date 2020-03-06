using System;
using System.Collections.Generic;
using System.Text;
using LuxoftTasks.SecondTask.Utility;

namespace LuxoftTasks.SecondTask.RowValidator
{
    class RowValidator : IRowValidator
    {
        public virtual bool IsRowValid(char[][] arr, int column, int row)
        {
            return row >= 0 && row < arr[column].Length;
        }

        public virtual bool VerifyDeadPixel(char[][] arr, int column, int row)
        {
            return PixelUtility.IsDeadPixel(arr[column][row]);
        }
    }
}
