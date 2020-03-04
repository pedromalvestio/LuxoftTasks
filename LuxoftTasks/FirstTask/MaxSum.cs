namespace LuxoftTasks.FirstTask
{
    class MaxSum
    {
        private int incl;
        private int excl;
        private int excl_new;
        public int FindSum(int[] arr)
        {
            InitializeSum(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                /* current max excluding i */
                excl_new = GetBiggerSum();

                /* current max including i */
                incl = excl + arr[i];
                excl = excl_new;
            }

            /* return max of incl and excl */
            return GetBiggerSum();
        }

        private void InitializeSum(int firstArrayElement)
        {
            incl = firstArrayElement;
            excl = 0;
            excl_new = 0;
        }

        private int GetBiggerSum()
        {
            return (incl > excl) ? incl : excl;
        }
    }
}

