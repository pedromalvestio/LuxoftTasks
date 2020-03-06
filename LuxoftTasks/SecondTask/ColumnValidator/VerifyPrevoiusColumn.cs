using System;
using System.Collections.Generic;
using System.Text;

namespace LuxoftTasks.SecondTask.ColumnValidator
{
    class VerifyPrevoiusColumn : ColumnValidator
    {
        public override bool IsColumnValid(char[][] arr, int column){
            return base.IsColumnValid(arr, column-1);
        }
        public override bool VerifyDeadPixel(char[][] arr, int column, int row)
        {
            return base.VerifyDeadPixel(arr, column-1, row);
        }
    }
}
