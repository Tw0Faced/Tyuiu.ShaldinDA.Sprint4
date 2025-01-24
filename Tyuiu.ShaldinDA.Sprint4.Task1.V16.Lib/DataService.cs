using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShaldinDA.Sprint4.Task1.V16.Lib
{
    public class DataService : ISprint4Task1V16
    {
        public int Calculate(int[] array)
        {
            int product = 1; 
            bool hasOdd = false; 

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    product *= array[i];
                    hasOdd = true;
                }
            }

            return hasOdd ? product : 0; 
        }
    }
}
