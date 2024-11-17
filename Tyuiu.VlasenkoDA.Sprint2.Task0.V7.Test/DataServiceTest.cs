using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VlasenkoDA.Sprint2.Task0.V7.Lib;

namespace Tyuiu.VlasenkoDA.Sprint2.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            // Arrange: создаем экземпл€р DataService
            var dataService = new DataService();

            // Act: вызываем метод GetCompareOperations с x = 103 и y = 475
            bool[] result = dataService.GetCompareOperations(103, 475);

            // Assert: провер€ем, что результат соответствует ожидаемому массиву
            bool[] expected = new bool[] { false, true, true, false, true, false };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}