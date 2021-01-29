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

            var result = instance.letsCheck("Able was I ere I saw Elba");

            // assert

            Assert.AreEqual("ablEwasIereIsawelbA", result);

        }

    }
}
