﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShaldinDA.Sprint4.Task3.V2.Lib
{
    public class DataService : ISprint4Task3V2
    {
        public int Calculate(int[,] array)
        {
            int max = array[0, 0]; 

            for (int j = 1; j < array.GetLength(1); j++) 
            {
                if (array[0, j] > max)
                {
                    max = array[0, j];
                }
            }

            return max;
        }
    }
}
