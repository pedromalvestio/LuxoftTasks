using System;
using System.Collections.Generic;
using System.Text;

namespace LuxoftTasks.SecondTask.RowValidator
{
    interface IRowValidator
    {
        bool IsRowValid(char[][] arr, int column, int row);

        bool VerifyDeadPixel(char[][] arr, int column, int row);
    }
}
