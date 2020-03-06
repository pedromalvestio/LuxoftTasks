﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LuxoftTasks.SecondTask.ColumnValidator
{
    public interface IColumnValidator
    {
        bool IsColumnValid(char[][] arr, int column);

        bool VerifyDeadPixel(char[][] arr, int column, int row);
    }
}
