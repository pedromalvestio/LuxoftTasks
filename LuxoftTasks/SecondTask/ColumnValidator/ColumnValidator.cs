using System;
using System.Collections.Generic;
using System.Text;
using LuxoftTasks.SecondTask.RowValidator;

namespace LuxoftTasks.SecondTask.ColumnValidator
{
    class ColumnValidator : IColumnValidator
    {
        public List<IRowValidator> rowValidator = new List<IRowValidator>(){
            new VerifyPreviousRowItem(),
            new VerifyNextRowItem()
        };
        public virtual bool IsColumnValid(char[][] arr, int column)
        {
            return column >= 0 && column < arr.Length;
        }

        public virtual bool VerifyDeadPixel(char[][] arr, int column, int row)
        {
            var deadPixel = rowValidator.FindAll(r => r.IsRowValid(arr, column, row) == true);
            return deadPixel.Find(r => r.VerifyDeadPixel(arr, column, row)) != null;
        }
    }
}
