using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsBase.Tests
{
    [TestClass()]
    public class BubbleSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            //arrange
            var bubble = new BubbleSort<int>();

                var rnd = new Random();

                var items = new List<int>();

                for (int i = 0; i < 50; i++)
                {

                items.Add(rnd.Next(0, 100));

                }

                //добавляем готовую коллекцию
                 bubble.Items.AddRange(items);
                 items.Sort();  //стандартная встроенная сортировка

                 //act
                 bubble.Sort();

            //assert - проверяет объекты на равенство
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i], bubble.Items[i]);
            }
        }
    }
}