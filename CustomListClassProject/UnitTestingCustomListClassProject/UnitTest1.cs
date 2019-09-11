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
            int actual = testList.Count;

            // act
            testList.Add(82);

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddFiveItemToEmptyList_CountBecomesFive()
        {
            //arrange
            CustomList<int> numbers = new CustomList<int>();
            
            int expected = 5;
            int actual = numbers.Count;

            //act
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            numbers.Add(50);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddNineItemToEmptyList_CountBecomesNine()
        {
            //arrange
            CustomList<int> numbers = new CustomList<int>();
  
            int expected = 9;
            int actual = numbers.Count;

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
            //assert
            Assert.AreEqual(expected, actual);
        }
        public void Remove()
        {

        }
    }
}
//set up an index Property at some point to make all of this work - The one....
