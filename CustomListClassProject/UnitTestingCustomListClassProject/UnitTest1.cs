using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;

namespace UnitTestingCustomListClassProject
{
    [TestClass]
    public class CustomListTests
    {

        [TestMethod]
        public void Add_AddItemToEmptyList_ItemGoesToIndexZero()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();
            string expected = "Murdock";
            string actual;

            // act
            testList.Add("Murdock");
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToEmptyList_CountIncrementsByOne()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(82);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddFiveItemToEmptyList_CountBecomesFive()
        {
            //arrange
            CustomList<int> numbers = new CustomList<int>();

            int expected = 5;
            int actual;

            //act
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            numbers.Add(50);
            actual = numbers.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddNineItemToEmptyList_CountBecomesNine()
        {
            //arrange
            CustomList<int> numbers = new CustomList<int>();

            int expected = 9;
            int actual;

            //act
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            numbers.Add(50);
            numbers.Add(60);
            numbers.Add(70);
            numbers.Add(80);
            numbers.Add(90);

            actual = numbers.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        //ArgumentOutOfRangeException: If index is less than zero or index is equal to or greater than Count, 
        //where Count is number of elements in ArrayList.
        //NotSupportedException: If the ArrayList is read-only or the ArrayList has a fixed size.
        //[TestMethod]
        //public void Remove_OneItemFromAnEmptyArray_MaybeThrowException()
        //{
        //    //arrange
        //    CustomList<int> numbers = new CustomList<int>();
        //    int expected = 0;
        //    int actual;
        //    //act
        //    numbers.Remove(10);
        //    actual = numbers.Count;
        //    if(numbers.Count < 0)
        //    {
        //        throw new ArgumentOutOfRangeException("nah fam");
        //    }
        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
        /// <summary>
        /// ADD ABOVE ^
        ///           | 
        ///              |
        /// REMOVE BELOW v
        /// </summary>
        [TestMethod]
        public void Remove_OneItemFromListFirstIndex_ArrayBecomesEmpty()
        {
            //arrange
            int expected = 0;
            int actual;
            CustomList<int> numbers = new CustomList<int>();
            numbers.Add(10);
            //act
            numbers.Remove(10);
            actual = numbers.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_MultipleItemsFromArray_ArrayCountMinusNumberOfItemsRemoved()
        {
            //arrange
            CustomList<int> numbers = new CustomList<int>();
            int expected = 1;
            int actual;

            //act
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Remove(20);
            numbers.Remove(30);
            actual = numbers.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_OneItemFromArraySecondIndex_ArrayCountMinusOne()
        {
            //arrange
            CustomList<int> numbers = new CustomList<int>();
            int expected = 1;
            int actual;

            //act
            numbers.Add(10);
            numbers.Add(20);
            numbers.Remove(20);
            actual = numbers.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_AnItemThatDoesntShareAnArrayValue_ArrayKeepsItsCount()
        {
            //arrange
            CustomList<int> numbers = new CustomList<int>();
            int expected = 1;
            int actual;

            //act
            numbers.Add(10);
            numbers.Add(20);
            numbers.Remove(30);
            actual = numbers.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_OneItemFromListThirdIndex_()
        {
            //arrange
            int expected = 2;
            int actual;

            //act
            CustomList<int> numbers = new CustomList<int>();
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Remove(30);
            actual = numbers.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_OneItemFromListLastIndex_ArrayCountMinusOne()
        {
            //arrange
            CustomList<int> numbers = new CustomList<int>();
            int expected = 2;
            int actual;

            //act
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            actual = numbers.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
     
      /////////////////////////////////////////////////////////TO STRING
     
        [TestMethod]
        public void ToString_MakeAValueAString_AValueBecomesAString()
        {
            // _Making a value into a string accounts for 'Char'and int;
            //arrange
            CustomList<int> numbers = new CustomList<int>();
            string expected = "21, 23";
            string acutal;
            //act
            numbers.Add(21);
            numbers.Add(23);

            acutal = numbers.ToString();
            //assert
            Assert.AreEqual(expected, acutal);
        }
        [TestMethod]
        public void ToString_MakeAStringAString_AStringStaysAString()
        {

            //arrange
            CustomList<string> numbers = new CustomList<string>();
            string expected = "Billy, Bob";
            string actual;
            //act
            numbers.Add("Billy");
            numbers.Add("Bob");

            actual = numbers.ToString();
            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        //public void ToString_ReturnABool_StringReturnsBoolYesOrNo()
        //{

        //    //arrange
        //    CustomList<bool> numbers = new CustomList<bool>();
        //    bool expected = true;
        //    int acutal;
        //    //act
        //    numbers.Add(21 == 21);
        //    numbers.Add(21 == 24);

        //    acutal = //
        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
        public void ToString_()
        {

            //arrange

            //act

            //assert

        }
    }
}
