using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookWeb.Models.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWeb.Models.Logic.Tests
{
    [TestClass()]
    public class ForTestTests
    {
        [TestMethod()]
        public void aIsNull()
        {
            var target = new ForTest();

            var res = target.test(null,"b");

            Assert.IsNull(res);
        }

        [TestMethod()]
        public void bIsNull()
        {
            var target = new ForTest();

            var res = target.test("a", null);

            Assert.IsNull(res);
        }

        [TestMethod()]
        public void abIsNull()
        {
            var target = new ForTest();

            var res = target.test(null, null);

            Assert.IsNull(res);
        }

        [TestMethod()]
        public void aCanNotToInt()
        {
            var target = new ForTest();

            var res = target.test("a", "1");

            Assert.IsNull(res);
        }

        [TestMethod()]
        public void bCanNotToInt()
        {
            var target = new ForTest();

            var res = target.test("1", "b");

            Assert.IsNull(res);
        }

        [TestMethod()]
        public void abCanNotToInt()
        {
            var target = new ForTest();

            var res = target.test("a", "b");

            Assert.IsNull(res);
        }

        [TestMethod()]
        public void aBigger()
        {
            var target = new ForTest();

            var res = target.test("2", "1");

            Assert.IsTrue(res==1);
        }

        [TestMethod()]
        public void aEqualsb()
        {
            var target = new ForTest();

            var res = target.test("2", "2");

            Assert.IsTrue(res == 4);
        }

        [TestMethod()]
        public void bBigger()
        {
            var target = new ForTest();

            var res = target.test("1", "2");

            Assert.IsTrue(res == 3);
        }
    }
}