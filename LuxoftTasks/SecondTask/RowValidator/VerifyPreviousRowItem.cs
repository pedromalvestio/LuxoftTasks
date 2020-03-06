using System;
using System.Collections.Generic;
using System.Text;

namespace LuxoftTasks.SecondTask.RowValidator
{
    class VerifyPreviousRowItem : RowValidator
    {
        public override bool VerifyDeadPixel(char[][] arr, int column, int row)
        {
            return base.VerifyDeadPixel(arr, column, row);
        }
    }
}
