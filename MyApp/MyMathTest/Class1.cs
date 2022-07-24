using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MyMathApp;
namespace MyMathTest
{
    [TestFixture]
    public class MathTest
    {
        [Test]
        [TestCase(10,30)]
        public void AddTest(int num1,int num2)
        {
            //Test
            MyMath myMath = new MyMath();
           var actualResult= myMath.Add(num1,num2);
            var expectedResult = num1 + num2;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
