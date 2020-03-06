using System;
using System.Collections.Generic;
using System.Text;
using LuxoftTasks.SecondTask.Utility;

namespace LuxoftTasks.SecondTask.RowValidator
{
    class VerifyPreviousRowItem : RowValidator
    {
        public override bool IsRowValid(char[][] arr, int column, int row)
        {
            return base.IsRowValid(arr, column, row-1);
        }
        public override bool VerifyDeadPixel(char[][] arr, int column, int row)
        {
            return base.VerifyDeadPixel(arr, column, row-1);
        }
    }
}
