using System;   //для использования метода Random()
using System.Collections.Generic; //  для использования обобщений типа <T>

namespace AlgorithmsBase
{
    public class AlgorithmBase<T> 
    {
        public List<T> Items { get; set; } = new List<T>();

        /// <summary>
        /// Метод перестановки с использованием временной третьей переменной tmp
        /// </summary>
        /// <param name="positionA"></param>
        /// <param name="positionB"></param>
        protected void Swap(int positionA, int positionB)
        {
            if (positionA < Items.Count && positionB < Items.Count)
            {
                var tmp = Items[positionA];

                Items[positionA] = Items[positionB];

                Items[positionB] = tmp;
            }
        }

        /// <summary>
        /// Виртуальный метод сортировки
        /// </summary>
        // Нужно переопределять в каждом методе сортировки
        public virtual void Sort()
        {
            Items.Sort();
        }

        /// <summary>
        /// виртуальный метод для наполнения коллекции рандомными значениями
        /// </summary>
        /// <param name="count"></param>
        public virtual void FillRandom(T count)
        {
            
        }

    }
}
