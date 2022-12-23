using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RoomNumber.Test
{
    [TestClass]
    public class RoomNumberTest
    {
        private readonly RoomNumbers RoomNumber = new RoomNumbers();

        [TestMethod]
        public void TestInput1266_Result1True()
        {
            int number = 1266;
            int expected = 1;
            int actual = RoomNumber.numberOfSets(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInput696969_Result3True()
        {
            int number = 696969;
            int expected = 3;
            int actual = RoomNumber.numberOfSets(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInput122_Result2True()
        {
            int number = 122;
            int expected = 2;
            int actual = RoomNumber.numberOfSets(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInput9999_Result2True()
        {
            int number = 9999;
            int expected = 2;
            int actual = RoomNumber.numberOfSets(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInput12635_Result1()
        {
            int number = 12635;
            int expected = 1;
            int actual = RoomNumber.numberOfSets(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInput888888_Result5False()
        {
            int number = 888888;
            int expected = 5;
            int actual = RoomNumber.numberOfSets(number);
            Assert.AreNotEqual(expected, actual);
        }


        [TestMethod]
        public void TestInputNegative_ResultFailed()
        {
            int number = -500;
            int expected = -1;
            int actual = RoomNumber.numberOfSets(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInputOverflow_ResultFailed()
        {
            int number = 1000001;
            int expected = -1;
            int actual = RoomNumber.numberOfSets(number);
            Assert.AreEqual(expected, actual);
        }

        
    }
}