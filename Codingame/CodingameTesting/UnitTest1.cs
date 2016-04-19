using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace CodingameTesting
{
    [TestClass]
    public class UnitTest1
    {
        TestData _td;
        public UnitTest1()
        {
            _td = new TestData();
        }




        [TestMethod]
        public void TestMethod1()
        {
            using(var sw = new StringWriter())
            {
                //StringReader sr; 

                //using (var sr = new StringReader(_td.testdata2.ToString()))
                //{
                       
                    Console.SetOut(sw);
                    //Console.SetIn(sr);

                    Codingame.Hard.Bender.Solution.Main(_td.testdata2.ToArray());

                    var result = Regex.Replace(sw.ToString(), @"\r\n", "|");

                    Assert.IsTrue(result.Contains("SOUTH|SOUTH|EAST|EAST"));
                //}
                
            }

        }

        [TestMethod]
        public void TestMethod2()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                
                Codingame.Hard.Bender.Solution.Main(_td.testdata2.ToArray());

                var result = Regex.Replace(sw.ToString(), @"\r\n", "|");
                Assert.IsTrue(result.Contains("SOUTH|EAST|EAST|EAST|SOUTH|EAST|SOUTH|SOUTH|SOUTH"));
            }

        }

        [TestMethod]
        public void TestMethod3()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                
                Codingame.Hard.Bender.Solution.Main(_td.testdata3.ToArray());

                var result = Regex.Replace(sw.ToString(), @"\r\n", "|");
                Assert.IsTrue(result.Contains("SOUTH|SOUTH|EAST|EAST|EAST|NORTH|NORTH|NORTH|NORTH|NORTH"));
            }

        }

        [TestMethod]
        public void TestMethod4()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                
                Codingame.Hard.Bender.Solution.Main(_td.testdata4.ToArray());

                var result = Regex.Replace(sw.ToString(), @"\r\n", "|");
                Assert.IsTrue(result.Contains("EAST|EAST|EAST|EAST|SOUTH|SOUTH|SOUTH|SOUTH"));
            }

        }

        [TestMethod]
        public void TestMethod5()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
               
                Codingame.Hard.Bender.Solution.Main(_td.testdata5.ToArray());

                var result = Regex.Replace(sw.ToString(), @"\r\n", "|");
                Assert.IsTrue(result.Contains("SOUTH|SOUTH|EAST|EAST|EAST|EAST|EAST|EAST|NORTH|NORTH|NORTH|NORTH|NORTH|NORTH|WEST|WEST|WEST|WEST|SOUTH|SOUTH"));
            }

        }

        [TestMethod]
        public void TestMethod6()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                Codingame.Hard.Bender.Solution.Main(_td.testdata6.ToArray());

                var result = Regex.Replace(sw.ToString(), @"\r\n", "|");
                Assert.IsTrue(result.Contains("SOUTH|SOUTH|SOUTH|SOUTH|EAST|EAST|EAST|EAST|EAST|EAST"));
            }

        }
        [TestMethod]
        public void TestMethod7()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                Codingame.Hard.Bender.Solution.Main(_td.testdata7.ToArray());

                var result = Regex.Replace(sw.ToString(), @"\r\n", "|");
                Assert.IsTrue(result.Contains("SOUTH|SOUTH|SOUTH|SOUTH|WEST|WEST|WEST|WEST|WEST|WEST|WEST|NORTH|NORTH|NORTH|NORTH|NORTH|NORTH|NORTH|EAST|EAST|EAST|EAST|EAST|EAST|EAST|SOUTH|SOUTH"));
            }

        }
        [TestMethod]
        public void TestMethod8()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                Codingame.Hard.Bender.Solution.Main(_td.testdata8.ToArray());

                var result = Regex.Replace(sw.ToString(), @"\r\n", "|");
                Assert.IsTrue(result.Contains("SOUTH|SOUTH|SOUTH|EAST|EAST|EAST|EAST|EAST|EAST|EAST|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH"));
            }

        }
        [TestMethod]
        public void TestMethod9()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                Codingame.Hard.Bender.Solution.Main(_td.testdata9.ToArray());

                var result = Regex.Replace(sw.ToString(), @"\r\n", "|");
                Assert.IsTrue(result.Contains("SOUTH|SOUTH|SOUTH|SOUTH|EAST|EAST|EAST|EAST|NORTH|NORTH|WEST|WEST|WEST|WEST|SOUTH|SOUTH|SOUTH|SOUTH|EAST|EAST|EAST|EAST|EAST"));
            }

        }
        [TestMethod]
        public void TestMethod10()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                Codingame.Hard.Bender.Solution.Main(_td.testdata10.ToArray());

                var result = Regex.Replace(sw.ToString(), @"\r\n", "|");
                Assert.IsTrue(result.Contains("SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|WEST|WEST|NORTH|NORTH|NORTH|NORTH|NORTH|NORTH|NORTH|NORTH|NORTH|NORTH|NORTH|NORTH|EAST|EAST|EAST|EAST|EAST|EAST|EAST|EAST|EAST|EAST|EAST|EAST|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|WEST|WEST|WEST|WEST|WEST|WEST|SOUTH|SOUTH|SOUTH|EAST|EAST|EAST"));
            }

        }
        [TestMethod]
        public void TestMethod11()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                Codingame.Hard.Bender.Solution.Main(_td.testdata11.ToArray());

                var result = Regex.Replace(sw.ToString(), @"\r\n", "|");
                Assert.IsTrue(result.Contains("LOOP"));
            }

        }
        [TestMethod]
        public void TestMethod12()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                Codingame.Hard.Bender.Solution.Main(_td.testdata12.ToArray());

                var result = Regex.Replace(sw.ToString(), @"\r\n", "|");
                Assert.IsTrue(result.Contains("SOUTH|SOUTH|SOUTH|SOUTH|EAST|EAST|EAST|EAST|NORTH|NORTH|NORTH|NORTH|WEST|WEST|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|EAST|EAST|EAST|NORTH|WEST|" +
                "WEST|WEST|WEST|WEST|SOUTH|SOUTH|EAST|EAST|EAST|EAST|NORTH|NORTH|NORTH|NORTH|NORTH|NORTH|NORTH|NORTH|NORTH|WEST|WEST|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|" +
                "SOUTH|SOUTH|EAST|EAST|EAST|NORTH|WEST|WEST|WEST|WEST|WEST|SOUTH|SOUTH|EAST|EAST|EAST|EAST|NORTH|NORTH|NORTH|NORTH|NORTH|NORTH|NORTH|NORTH|NORTH|NORTH|NORTH|NORTH|NORTH|NORTH|WEST|WEST|" +
                "SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|EAST|EAST|EAST|SOUTH|SOUTH|SOUTH|WEST|WEST|WEST|WEST|WEST|SOUTH|SOUTH|EAST|EAST|" +
                "EAST|EAST|NORTH|NORTH|NORTH|NORTH|WEST|WEST|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|SOUTH|EAST|EAST|EAST|EAST"));
            }

        }
    }

    public class TestData
    {
        public List<string> testdata1;
        public List<string> testdata2;
        public List<string> testdata3;
        public List<string> testdata4;
        public List<string> testdata5;
        public List<string> testdata6;
        public List<string> testdata7;
        public List<string> testdata8;
        public List<string> testdata9;
        public List<string> testdata10;
        public List<string> testdata11;
        public List<string> testdata12;






        public TestData()
        {
            testdata1 = new List<string>();
            testdata2 = new List<string>();
            testdata3 = new List<string>();
            testdata4 = new List<string>();
            testdata5 = new List<string>();
            testdata6 = new List<string>();
            testdata7 = new List<string>();
            testdata8 = new List<string>();
            testdata9 = new List<string>();
            testdata10 = new List<string>();
            testdata11 = new List<string>();
            testdata12 = new List<string>();

            // expected: s s e e 5x5

            testdata1.Add("5 5");
            testdata1.Add("#####");
            testdata1.Add("#@  #");
            testdata1.Add("#   #");
            testdata1.Add("#  $#");
            testdata1.Add("#####");

            // expected: s e e e s e s s s 8x8
            testdata2.Add("8 8");
            testdata2.Add("########");
            testdata2.Add("# @    #");
            testdata2.Add("#     X#");
            testdata2.Add("# XXX  #");
            testdata2.Add("#   XX #");
            testdata2.Add("#   XX #");
            testdata2.Add("#     $#");
            testdata2.Add("########");

            // expected: s s e e e n n n n n 8x8
            testdata3.Add("8 8");
            testdata3.Add("########");
            testdata3.Add("#     $#");
            testdata3.Add("#      #");
            testdata3.Add("#      #");
            testdata3.Add("#  @   #");
            testdata3.Add("#      #");
            testdata3.Add("#      #");
            testdata3.Add("########");

            // expected: e e e e s s s s 8x8
            testdata4.Add("8 8");
            testdata4.Add("########");
            testdata4.Add("#      #");
            testdata4.Add("# @    #");
            testdata4.Add("# XX   #");
            testdata4.Add("#  XX  #");
            testdata4.Add("#   XX #");
            testdata4.Add("#     $#");
            testdata4.Add("########");

            // expected: s s e e e e e e n n n n n n w w w w s s 10x10
            testdata5.Add("10 10");
            testdata5.Add("##########");
            testdata5.Add("#        #");
            testdata5.Add("#  S   W #");
            testdata5.Add("#        #");
            testdata5.Add("#  $     #");
            testdata5.Add("#        #");
            testdata5.Add("#@       #");
            testdata5.Add("#        #");
            testdata5.Add("#E     N #");
            testdata5.Add("##########");

            // expected: s s s s e e e e e e 10x10
            testdata6.Add("10 10");
            testdata6.Add("##########");
            testdata6.Add("# @      #");
            testdata6.Add("# B      #");
            testdata6.Add("#XXX     #");
            testdata6.Add("# B      #");
            testdata6.Add("#    BXX$#");
            testdata6.Add("#XXXXXXXX#");
            testdata6.Add("#        #");
            testdata6.Add("#        #");
            testdata6.Add("##########");

            // expected: 
            testdata7.Add("10 10");
            testdata7.Add("##########");
            testdata7.Add("#    I   #");
            testdata7.Add("#        #");
            testdata7.Add("#       $#");
            testdata7.Add("#       @#");
            testdata7.Add("#        #");
            testdata7.Add("#       I#");
            testdata7.Add("#        #");
            testdata7.Add("#        #");
            testdata7.Add("##########");

            // expected: s s s s e e e e e e e s s s s s s s
            testdata8.Add("10 10");
            testdata8.Add("##########");
            testdata8.Add("#    T   #");
            testdata8.Add("#        #");
            testdata8.Add("#        #");
            testdata8.Add("#        #");
            testdata8.Add("#@       #");
            testdata8.Add("#        #");
            testdata8.Add("#        #");
            testdata8.Add("#    T  $#");
            testdata8.Add("##########");

            // expected: s s s s s s s e e e e e
            testdata9.Add("10 10");
            testdata9.Add("##########");
            testdata9.Add("#        #");
            testdata9.Add("#  @     #");
            testdata9.Add("#  B     #");
            testdata9.Add("#  S   W #");
            testdata9.Add("# XXX    #");
            testdata9.Add("#  B   N #");
            testdata9.Add("# XXXXXXX#");
            testdata9.Add("#       $#");
            testdata9.Add("##########");

            // expected: 15 x 15
            testdata10.Add("15 15");
            testdata10.Add("###############");
            testdata10.Add("#      IXXXXX #");
            testdata10.Add("#  @          #");
            testdata10.Add("#             #");
            testdata10.Add("#             #");
            testdata10.Add("#  I          #");
            testdata10.Add("#  B          #");
            testdata10.Add("#  B   S     W#");
            testdata10.Add("#  B   T      #");
            testdata10.Add("#             #");
            testdata10.Add("#         T   #");
            testdata10.Add("#         B   #");
            testdata10.Add("#            $#");
            testdata10.Add("#        XXXX #");
            testdata10.Add("###############");


            // expected: 
            testdata11.Add("15 15");
            testdata11.Add("###############");
            testdata11.Add("#      IXXXXX #");
            testdata11.Add("#  @          #");
            testdata11.Add("#E S          #");
            testdata11.Add("#             #");
            testdata11.Add("#  I          #");
            testdata11.Add("#  B          #");
            testdata11.Add("#  B   S     W#");
            testdata11.Add("#  B   T      #");
            testdata11.Add("#             #");
            testdata11.Add("#         T   #");
            testdata11.Add("#         B   #");
            testdata11.Add("#N          W$#");
            testdata11.Add("#        XXXX #");
            testdata11.Add("###############");

            // expected: 
            testdata12.Add("15 30");
            testdata12.Add("###############");
            testdata12.Add("#  #@#I  T$#  #");
            testdata12.Add("#  #    IB #  #");
            testdata12.Add("#  #     W #  #");
            testdata12.Add("#  #      ##  #");
            testdata12.Add("#  #B XBN# #  #");
            testdata12.Add("#  ##      #  #");
            testdata12.Add("#  #       #  #");
            testdata12.Add("#  #     W #  #");
            testdata12.Add("#  #      ##  #");
            testdata12.Add("#  #B XBN# #  #");
            testdata12.Add("#  ##      #  #");
            testdata12.Add("#  #       #  #");
            testdata12.Add("#  #     W #  #");
            testdata12.Add("#  #      ##  #");
            testdata12.Add("#  #B XBN# #  #");
            testdata12.Add("#  ##      #  #");
            testdata12.Add("#  #       #  #");
            testdata12.Add("#  #       #  #");
            testdata12.Add("#  #      ##  #");
            testdata12.Add("#  #  XBIT #  #");
            testdata12.Add("#  #########  #");
            testdata12.Add("#             #");
            testdata12.Add("# ##### ##### #");
            testdata12.Add("# #     #     #");
            testdata12.Add("# #     #  ## #");
            testdata12.Add("# #     #   # #");
            testdata12.Add("# ##### ##### #");
            testdata12.Add("#             #");
            testdata12.Add("###############");


        }
    }
}
