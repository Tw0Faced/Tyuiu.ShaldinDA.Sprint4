using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShaldinDA.Sprint4.Task0.V29.Lib
{
    public class DataService : ISprint4Task0V29
    {
        public int GetSumOddArrEl(int[] array)
        {
            int sum = 0;

            foreach (int element in array)
            {
                if (element % 2 != 0)
                {
                    sum += element;
                }
            }

            return sum;
        }
    }
}
