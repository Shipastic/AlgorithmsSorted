using System;   //для использования метода Random()
using System.Collections.Generic; //  для использования обобщений типа <T>
using System.Diagnostics;

namespace AlgorithmsBase
{
    public class AlgorithmBase<T> 
    {
        //Добавляем счетчики числа свопов и сравнений
        public int SwapCount { get; protected set; } = 0;
        public int CompareCount { get; protected set; } = 0;
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

                SwapCount++;
            }
        }

        /// <summary>
        /// Виртуальный метод сортировки
        /// </summary>
        // Нужно переопределять в каждом методе сортировки
        public TimeSpan Sort()
        {
            
            var timer = new Stopwatch();// инициализируем таймер для замера времени выполнения аглоритма
            SwapCount = 0;
            timer.Start();//стартуем
            MakeSort();
            timer.Stop();//останавливаем таймер

            return timer.Elapsed;
        }

        protected virtual void MakeSort()
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
