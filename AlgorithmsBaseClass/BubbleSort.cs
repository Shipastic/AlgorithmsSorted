using System;   //для использования интерфейса IComparable

namespace AlgorithmsBase
{
    /// <summary>
    /// Метод сортировки пузырьком
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BubbleSort<T> : AlgorithmBase<T> where T: IComparable<T>  // IComparable<T> нужен для использования операторов сравнения <>==  в произвольных типах данных
    {
        //Переопределяем виртуальный метод Sort из базового класса
        protected override void MakeSort()
        {
            var count = Items.Count;

            // за
            for (int j = 0; j < count; j++)
            {
                // цикл выполняет один проход по всем элементам
                for (int i = 0; i < count - 1 - j; i++)
                {
                    var a = Items[i];   // первый элемент 
                    var b = Items[i + 1];   //второй элемент из коллекции

                    //сравниваем a и b, если a > b, то должно вернуть 1
                    if (a.CompareTo(b) == 1)
                    {
                        CompareCount++;
                        // то делаем перестановку
                        Swap(i, i + 1);
                    }
                }

            }
        }
    }
}
