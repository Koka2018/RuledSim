using Microsoft.VisualStudio.TestTools.UnitTesting;
using RuledGear;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuledGear.Tests
{
    [TestClass()]
    public class RuleTests
    {
        [TestClass]
        public class コンストラクタ
        {

            [TestMethod()]
            public void インスタンスできること()
            {
                var rule = new Rule();
                Assert.IsNotNull(rule);
                Assert.AreEqual(string.Empty, rule.Name);
            }

            [TestMethod()]
            [DataRow("Name")]
            [DataRow("@")]
            [DataRow("$")]
            [DataRow("a,b")]
            [DataRow("a=b")]
            [DataRow("a$b")]
            [DataRow("#ab")]
            [DataRow("あいうえお")]
            [DataRow("12345")]
            public void インスタンスできること_引数1(string name)
            {
                var rule = new Rule(name);
                Assert.IsNotNull(rule);
                Assert.AreEqual(name, rule.Name);
            }


            [TestMethod()]
            [ExpectedException(typeof(ArgumentException))]
            [DataRow(null)]
            [DataRow("")]
            public void コンストラクタの引数が不正の場合例外を発生すること(string name)
            {
                var rule = new Rule(name);
            }
        }
    }
}