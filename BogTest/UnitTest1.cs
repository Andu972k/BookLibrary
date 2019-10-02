using System;
using BookLibrary.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BogTest
{
    [TestClass]
    public class UnitTest1
    {
        #region InstanceFields

        private Bog _testBog;

        #endregion

        [TestInitialize]
        public void TestSetup()
        {
         _testBog = new Bog();   
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestTitel_TooShort_Property()
        {
            _testBog.Titel = "W";
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestTitel_TooShort_Constructor()
        {
            Bog tempBog = new Bog(" ", "James", 22, "asdfghjkl��zx");
        }

        [TestMethod]
        public void TestTitel()
        {
            Assert.AreEqual(null, _testBog.Titel);
            _testBog.Titel = "We";
            Assert.AreEqual("We", _testBog.Titel);

            Bog tempBog = new Bog("Jorden Rundt p� 80 dage", "James", 500, "asdfghjkl��zx");
            Assert.AreEqual("Jorden Rundt p� 80 dage", tempBog.Titel);
            tempBog.Titel = "Hello World";
            Assert.AreEqual("Hello World", tempBog.Titel);

        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestSidetal_TooSmall_Property()
        {
            _testBog.Sidetal = 9;
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestSidetal_TooBig_Property()
        {
            _testBog.Sidetal = 1001;
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestSidetal_TooSmall_Constructor()
        {
            Bog tempBog = new Bog("We", "James", 9, "asdfghjkl��zx");
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestSidetal_TooBig_Constructor()
        {
            Bog tempBog = new Bog("We", "James", 1001, "asdfghjkl��zx");
        }

        
        [TestMethod]
        public void TestSidetal()
        {
            Assert.AreEqual(0, _testBog.Sidetal);//sidetal er 0 siden det er int's default v�rdi
            _testBog.Sidetal = 10;
            Assert.AreEqual(10, _testBog.Sidetal);
            _testBog.Sidetal = 1000;
            Assert.AreEqual(1000, _testBog.Sidetal);
            _testBog.Sidetal = 500;
            Assert.AreEqual(500, _testBog.Sidetal);

            Bog tempBog = new Bog("Jorden Rundt p� 80 dage", "James", 250, "asdfghjkl��zx");
            Assert.AreEqual(250, tempBog.Sidetal);
            tempBog.Sidetal = 750;
            Assert.AreEqual(750, tempBog.Sidetal);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestIsbn13_12Characters_Property()
        {
            _testBog.Isbn13 = "asdfghjkl��z";
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestIsbn13_14Characters_Property()
        {
            _testBog.Isbn13 = "asdfghjkl��zxc";
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestIsbn13_12Characters_Constructor()
        {
            Bog tempBog = new Bog("We", "James", 500, "asdfghjkl��z");
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestIsbn13_14Characters_Constructor()
        {
            Bog tempBog = new Bog("We", "James", 500, "asdfghjkl��zxc");
        }

        [TestMethod]
        public void TestIsbn13()
        {
            Assert.AreEqual(null, _testBog.Isbn13);
            _testBog.Isbn13 = "asdfghjkl��zx";
            Assert.AreEqual("asdfghjkl��zx", _testBog.Isbn13);

            Bog tempBog = new Bog("Jorden Rundt p� 80 dage", "James", 500, "asdfghjkl�582");
            Assert.AreEqual("asdfghjkl�582", tempBog.Isbn13);
            tempBog.Isbn13 = "qwertyuiop�hg";
            Assert.AreEqual("qwertyuiop�hg", tempBog.Isbn13);
        }

        [TestMethod]
        public void TestToString()
        {
            _testBog.Titel = "We are number one";
            _testBog.Forfatter = "MemeLord";
            _testBog.Sidetal = 1000;
            _testBog.Isbn13 = "MemesRuleeeee";

            Assert.AreEqual("Titel: We are number one, Forfatter: MemeLord, Sidetal: 1000, Isbn13: MemesRuleeeee", _testBog.ToString());
        }
    }
}
