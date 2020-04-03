using AlgorithmsBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsBaseClass
{
    public class CoctailSort<T> : AlgorithmBase<T> where T : IComparable<T>
    {
        public override void Sort()
        {
            int left = 0;
            int right = Items.Count - 1;

            while (left < right)
            {
                // проходим все элементы слева - направо масимальный элемент перемещаем вправо
                for (int i = left; i < right; i++)
                {
                    if(Items[i].CompareTo(Items[i + 1]) == 1)
                    {
                        Swap(i, i + 1);
                    }
                }
                right--;
                //проходим все элементы справа - налево минимальный элемент передвигаем влево
                for (int i = right; i > left; i--)
                {
                    if (Items[i].CompareTo(Items[i - 1]) == -1)
                    {
                        Swap(i, i - 1);
                    }
                }
                left++;
            }
        }
    }
}
