using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShaldinDA.Sprint4.Task6.V19.Lib
{
    public class DataService : ISprint4Task6V19
    {
        public int Calculate(string[] array)
        {
            string[] longElements = Array.FindAll(array, element => element.Length > 5);
            return longElements.Length;
        }
    }
}
