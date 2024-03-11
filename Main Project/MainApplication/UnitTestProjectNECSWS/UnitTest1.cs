using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectNECSWS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_IsLoginValid()
        {
            // Arrange
            const string CHARS_LEN_255 = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstu";

            // Act

            // Assert   
            //Assert.IsTrue(Tools.IsLoginValid("abcdefghijklmnopqrstuvwxyz")); // a to z
            //Assert.IsTrue(Tools.IsLoginValid("ABCDEFGHIJKLMNOPQRSTUVWXYZ")); // A to Z
            //Assert.IsTrue(Tools.IsLoginValid("0123456789"));                // 0 to 9
            //Assert.IsTrue(Tools.IsLoginValid("login with space"));          // space in the middle
            //Assert.IsTrue(Tools.IsLoginValid("login with dot."));           // dot in the end
            //Assert.IsTrue(Tools.IsLoginValid("login with underline_"));     // underline in the end
            //Assert.IsTrue(Tools.IsLoginValid("1234"));                      // minimum 4 characters!
            //Assert.IsTrue(Tools.IsLoginValid(CHARS_LEN_255));               // maximum 255 characters!

            //Assert.IsFalse(Tools.IsLoginValid("                "));         // white space
            //Assert.IsFalse(Tools.IsLoginValid(" LEADING_SPACE"));           // leading space
            //Assert.IsFalse(Tools.IsLoginValid("LAST_SPACE "));              // last space
            //Assert.IsFalse(Tools.IsLoginValid("invalid symbol $"));         // invalid symbol $
            //Assert.IsFalse(Tools.IsLoginValid("invalid symbol %"));         // invalid symbol %
            //Assert.IsFalse(Tools.IsLoginValid(null));                       // null
            //Assert.IsFalse(Tools.IsLoginValid("123"));                      // minimum 4 characters!
            //Assert.IsFalse(Tools.IsLoginValid(CHARS_LEN_255 + "F"));        // maximum 255 characters!
        }

    }
}
