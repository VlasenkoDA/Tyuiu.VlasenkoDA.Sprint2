using Tyuiu.VlasenkoDA.Sprint2.Task1.V19.Lib;
namespace Tyuiu.VlasenkoDA.Sprint2.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            // Arrange
            var dataService = new DataService();

            // Установим значения для a, b, c, d
            int a = 696;
            int b = 354;
            int c = 423;
            int d = 957;

            // Ожидаемый результат
            bool[] expected = new bool[] { true, false, true, false, true, false };

            // Act
            bool[] result = dataService.GetLogicOperations(a, b, c, d);

            // Assert
            CollectionAssert.AreEqual(expected, result, "The logic operations result is incorrect.");
        }
    }
}
