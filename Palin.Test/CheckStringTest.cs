using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Palin.Test
{
    [TestFixture]
    public class CheckStringTest
    {   
        [Test]
        public void LetsCheck_String_is_Palindrom()
        {
            // arrange
            var instance = new CheckString();

            //act metoda musi zwracac wartosc

            var result1 = instance.letsCheck("Able was I ere I saw Elba");
            var result2 = instance.letsCheck("    ");
            var result3 = instance.letsCheck("");
            var result4 = instance.letsCheck("Ala ma kota");
            // assert

            Assert.AreEqual(true, result1);
            Assert.AreEqual(false, result2);
            Assert.AreEqual(false, result3);
            Assert.AreEqual(false, result4);


        }

    }
}
