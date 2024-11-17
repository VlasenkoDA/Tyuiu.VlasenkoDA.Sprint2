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
            // Arrange: ������� ��������� DataService
            var dataService = new DataService();

            // Act: �������� ����� GetCompareOperations � x = 103 � y = 475
            bool[] result = dataService.GetCompareOperations(103, 475);

            // Assert: ���������, ��� ��������� ������������� ���������� �������
            bool[] expected = new bool[] { false, true, true, false, true, false };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}