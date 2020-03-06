using System.Collections.Generic;
using LuxoftTasks.SecondTask.ColumnValidator;
using LuxoftTasks.SecondTask.Utility;

namespace LuxoftTasks.SecondTask
{
    class DeadPixels
    {
        List<IColumnValidator> columnValidator = new List<IColumnValidator>(){
            new VerifyPrevoiusColumn(),
            new VerifyNextColumn()
        };
        public int CountGroups(char[][] monitor)
        {
            int deadPixels = 0;
            for (int i = 0; i < monitor.Length; i++)
                for (int j = 0; j < monitor[i].Length; j++)
                {
                    if (PixelUtility.IsDeadPixel(monitor[i][j]))
                    {
                        var validColumns = columnValidator.FindAll(c => c.IsColumnValid(monitor, i) == true);
                        if (validColumns.Find(c => c.VerifyDeadPixel(monitor, i, j)) != null)
                        {
                            deadPixels++;
                        }
                    }
                }
            return deadPixels;
        }

    }
}