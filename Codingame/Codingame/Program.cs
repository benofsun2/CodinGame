using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingame
{
    public class Program
    {
        public static void Main(string[] args)
        {

            TestData td = new TestData();
            Codingame.Medium.Winamax.Solution.Main(td[2].ToArray());
            //var result = Regex.Replace(sw.ToString(), @"\r\n", "|");
            //for(int i = 0 ; i < 12 ; i ++)
            //{
            //    Codingame.Hard.BenderSolution.Main(td[i].ToArray());
            //}
            
            //Codingame.Medium.SolutionM3.Main(args);
           // Codingame.Hard.TheParanoidAndroidOSF.Main(args);
            


            
            
        }
    }


// testing example: http://www.softwareandi.com/2012/02/how-to-write-automated-tests-for.html 


    public class TestData
    {
        public List<string> testdata1;
        public List<string> testdata2;
        public List<string> testdata3;
        public List<string> testdata4;
        public List<string> testdata5;
        public List<string> testdata6;
        public List<string> testdata7;
        

        private List<List<string>> testdatas;


        public List<string> this[int index]
        {
            get { return testdatas[index]; }
        }



        public TestData()
        {
            testdata1 = new List<string>();
            testdata2 = new List<string>();
            testdata3 = new List<string>();
            testdata4 = new List<string>();
            testdata5 = new List<string>();
            testdata6 = new List<string>();
            testdata7 = new List<string>();
            

            testdatas = new List<List<string>>();

            // expected:
            //3
            //AD
            //KC
            //QC
            //3
            //KH
            //QS
            //JC
            testdata1.Add("3");
            testdata1.Add("AD");
            testdata1.Add("KC");
            testdata1.Add("QC");
            testdata1.Add("3");
            testdata1.Add("KH");
            testdata1.Add("QS");
            testdata1.Add("JC");
            testdatas.Add(testdata1);
            // expected: 

            testdata2.Add("25 33");
            testdata2.Add("49");
            testdata2.Add("2 29");
            testdata2.Add("UR");
            testdatas.Add(testdata2);
            // expected:

            testdata3.Add("26");
            testdata3.Add("6H");
            testdata3.Add("7H");
            testdata3.Add("6C");
            testdata3.Add("QS");
            testdata3.Add("7S");
            testdata3.Add("8D");
            testdata3.Add("6D");
            testdata3.Add("5S");
            testdata3.Add("6S");
            testdata3.Add("QH");
            testdata3.Add("4D");
            testdata3.Add("3S");
            testdata3.Add("7C");
            testdata3.Add("3C");
            testdata3.Add("4S");
            testdata3.Add("5H");
            testdata3.Add("QD");
            testdata3.Add("5C");
            testdata3.Add("3H");
            testdata3.Add("3D");
            testdata3.Add("8C");
            testdata3.Add("4H");
            testdata3.Add("4C");
            testdata3.Add("QC");
            testdata3.Add("5D");
            testdata3.Add("7D");
            testdata3.Add("26");
            testdata3.Add("JH");
            testdata3.Add("AH");
            testdata3.Add("KD");
            testdata3.Add("AD");
            testdata3.Add("9C");
            testdata3.Add("2D");
            testdata3.Add("2H");
            testdata3.Add("JC");
            testdata3.Add("10C");
            testdata3.Add("KC");
            testdata3.Add("10D");
            testdata3.Add("JS");
            testdata3.Add("JD");
            testdata3.Add("9D");
            testdata3.Add("9S");
            testdata3.Add("KS");
            testdata3.Add("AS");
            testdata3.Add("KH");
            testdata3.Add("10S");
            testdata3.Add("8S");
            testdata3.Add("2S");
            testdata3.Add("10H");
            testdata3.Add("8H");
            testdata3.Add("AC");
            testdata3.Add("2C");
            testdata3.Add("9H");
            testdata3.Add("7D");
           
           
            testdatas.Add(testdata3);
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
            testdatas.Add(testdata4);
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
            testdatas.Add(testdata5);
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
            testdatas.Add(testdata6);
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
            testdatas.Add(testdata7);
          
        }
    }

}
