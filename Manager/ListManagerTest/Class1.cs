using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manager;
using NUnit.Framework;

namespace ListManagerTest
{
    [TestFixture]
    public class ListManagerTests
    {
        private ListManager _listManager;
        private List<int> _testList;

        [SetUp]
        public void Setup()
        {
            _listManager = new ListManager();
            _testList = new List<int>();
        }

        [Test]
        public void AddElement_AddsElementToList()
        {
            _listManager.AddElement(_testList, 10);
            Assert.That(_testList, Contains.Item(10));
        }

        [Test]
        public void RemoveElement_RemovesElementFromList()
        {
            _testList.Add(20);
            _listManager.RemoveElement(_testList, 20);
            Assert.That(_testList, Does.Not.Contain(20));
        }

        [Test]
        public void GetSize_ReturnsCorrectSize()
        {
            _listManager.AddElement(_testList, 5);
            _listManager.AddElement(_testList, 10);
            Assert.That(_listManager.GetSize(_testList), Is.EqualTo(2));
        }
    }
}
