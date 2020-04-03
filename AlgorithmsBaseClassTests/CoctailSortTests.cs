using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsBaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsBase;

namespace AlgorithmsBase.Tests
{
    [TestClass()]
    public class CoctailSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            //arrange
            var coctail = new CoctailSort<int>();

            var rnd = new Random();

            var items = new List<int>();

            for (int i = 0; i < 10000; i++)
            {

                items.Add(rnd.Next(0, 100));

            }

            //добавляем готовую коллекцию
            coctail.Items.AddRange(items);
            items.Sort();  //стандартная встроенная сортировка

            //act
            coctail.Sort();

            //assert - проверяет объекты на равенство
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i], coctail.Items[i]);
            }
        }
    }
}