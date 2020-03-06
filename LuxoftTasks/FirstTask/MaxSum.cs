namespace LuxoftTasks.FirstTask
{
    class MaxSum
    {
        private int includedSum;
        private int excludedSum;
        private int tempExcludedSum;
        public int FindSum(int[] arr)
        {
            InitializeSum(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                RefreshTempExcludedSum();
                RefreshIncludedSum(arr[i]);
                RefreshExcludedSum();
            }
            return GetBiggerSum();
        }

        private void InitializeSum(int firstArrayElement)
        {
            includedSum = firstArrayElement;
            excludedSum = 0;
            tempExcludedSum = 0;
        }

        private int GetBiggerSum()
        {
            return (includedSum > excludedSum) ? includedSum : excludedSum;
        }

        private void RefreshIncludedSum(int currentArrayPosition){
            includedSum = excludedSum + currentArrayPosition;
        }

        private void RefreshExcludedSum(){
            excludedSum = tempExcludedSum;
        }

        private void RefreshTempExcludedSum(){
            tempExcludedSum = GetBiggerSum();
        }
    }
}

