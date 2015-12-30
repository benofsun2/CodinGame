using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingameTesting
{
    [TestClass]
    public class UnitTest2
    {

        public UnitTest2()
        {
            TestData td = new TestData();
        }


        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader("100"))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);
     
                    // Act
                    //C .Program.Main();

                    

    
                   // Assert
                   var result = sw.ToString();
                   Assert.IsFalse(result.Contains("S"));
               }
            }
        }
    }
}
