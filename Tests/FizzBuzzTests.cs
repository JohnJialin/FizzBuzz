using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        Helper helper = new Helper();

        [TestInitialize]
        public void Initialize()
        {

        }

        [TestMethod]
        public void ConvertStringToIntArrayTestShouldReturnResultNoError()
        {
            //Arrange
            string[] stringArray = { "1", "2", "3" };

            //Act
            var result = helper.ConvertStringToIntArray(stringArray);

            //Assert
            Assert.AreEqual(3, result.Length);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(3, result[2]);
        }


        [TestMethod]
        public void FizzBuzzValuesTestShouldReturnResultNoError()
        {
            //Arrange
            int[] numberArray = { 1, 2, 3, -1 };

            //Act
            var result = helper.FizzBuzzValues(numberArray);

            //Assert
            Assert.AreEqual(6, result.Count);
            Assert.AreEqual("1", result[0]);
            Assert.AreEqual("1", result[1]);
            Assert.AreEqual("2", result[2]);
            Assert.AreEqual("2", result[3]);
            Assert.AreEqual("Fizz", result[4]);
            Assert.AreEqual("Invalid Item", result[5]);
        }
    }
}