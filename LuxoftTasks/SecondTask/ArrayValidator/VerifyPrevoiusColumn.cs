using System;
using System.Collections.Generic;
using System.Text;

namespace LuxoftTasks.SecondTask.ArrayValidator
{
    class VerifyPrevoiusColumn : ColumnValidator
    {
        public override bool VerifyDeadPixel(char[][] arr, int column, int row)
        {
            return base.VerifyDeadPixel(arr, column, row);
        }
    }
}
