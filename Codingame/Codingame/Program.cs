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
            
            Codingame.Hard.SuperComputer.Solution.Main(td.testdata8.ToArray());

            //TestData td = new TestData(); 
            //Codingame.Medium.Winamax.Solution.Main(td[2].ToArray());
            //var result = Regex.Replace(sw.ToString(), @"\r\n", "|");
            //for(int i = 0 ; i < 12 ; i ++)
            //{
            //    Codingame.Hard.Bender.Solution.Main(td[i].ToArray());
            //}
            
            //Codingame.Medium.SolutionM3.Main(args);
           // Codingame.Hard.TheParanoidAndroidOSF.Main(args);
            


            
            
        }
    }


// testing example: http://www.softwareandi.com/2012/02/how-to-write-automated-testdata8-for.html 


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
            testdata8 = new List<string>();
            testdata9 = new List<string>();
            testdata10 = new List<string>();
            
            // testdata8.Add("");
            //test1    
           
            

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




            // super computer
            testdata8.Add("4");
            testdata8.Add("2 5");
            testdata8.Add("9 7");
            testdata8.Add("15 6");
            testdata8.Add("9 3");


            // super computer   
            testdata9.Add("5");
            testdata9.Add("3 5");
            testdata9.Add("9 2");
            testdata9.Add("24 5");
            testdata9.Add("16 9");
            testdata9.Add("11 6");

            //  super computer         
            testdata10.Add("279");
            testdata10.Add("166687 63");
            testdata10.Add("592098 29");
            testdata10.Add("612426 36");
            testdata10.Add("550447 736");
            testdata10.Add("491602 170");
            testdata10.Add("917961 832");
            testdata10.Add("14211 467");
            testdata10.Add("945403 233");
            testdata10.Add("667148 658");
            testdata10.Add("487690 389");
            testdata10.Add("435219 968");
            testdata10.Add("268108 137");
            testdata10.Add("881708 889");
            testdata10.Add("592160 525");
            testdata10.Add("525623 452");
            testdata10.Add("883900 218");
            testdata10.Add("462827 195");
            testdata10.Add("991446 226");
            testdata10.Add("593676 138");
            testdata10.Add("494961 82");
            testdata10.Add("203001 369");
            testdata10.Add("238365 896");
            testdata10.Add("802843 26");
            testdata10.Add("792393 814");
            testdata10.Add("995470 489");
            testdata10.Add("873606 662");
            testdata10.Add("41738 306");
            testdata10.Add("27926 580");
            testdata10.Add("303616 218");
            testdata10.Add("479043 139");
            testdata10.Add("842821 28");
            testdata10.Add("650207 45");
            testdata10.Add("522990 674");
            testdata10.Add("853077 927");
            testdata10.Add("13280 786");
            testdata10.Add("502119 528");
            testdata10.Add("600930 52");
            testdata10.Add("11108 680");
            testdata10.Add("752109 731");
            testdata10.Add("439742 121");
            testdata10.Add("929020 91");
            testdata10.Add("366285 979");
            testdata10.Add("890015 550");
            testdata10.Add("107664 612");
            testdata10.Add("722845 590");
            testdata10.Add("802361 625");
            testdata10.Add("864212 552");
            testdata10.Add("398264 572");
            testdata10.Add("783486 392");
            testdata10.Add("635907 260");
            testdata10.Add("128466 187");
            testdata10.Add("257901 482");
            testdata10.Add("50952 280");
            testdata10.Add("679534 763");
            testdata10.Add("911249 553");
            testdata10.Add("471808 540");
            testdata10.Add("475629 821");
            testdata10.Add("511069 459");
            testdata10.Add("68688 529");
            testdata10.Add("569610 576");
            testdata10.Add("935535 342");
            testdata10.Add("40486 109");
            testdata10.Add("21137 472");
            testdata10.Add("964957 66");
            testdata10.Add("220355 146");
            testdata10.Add("532832 65");
            testdata10.Add("145625 649");
            testdata10.Add("699796 154");
            testdata10.Add("820441 550");
            testdata10.Add("669629 81");
            testdata10.Add("40889 388");
            testdata10.Add("339806 99");
            testdata10.Add("757942 673");
            testdata10.Add("38868 730");
            testdata10.Add("363210 329");
            testdata10.Add("34622 529");
            testdata10.Add("431607 41");
            testdata10.Add("461653 786");
            testdata10.Add("422222 282");
            testdata10.Add("771813 198");
            testdata10.Add("145019 544");
            testdata10.Add("564608 405");
            testdata10.Add("530651 888");
            testdata10.Add("381759 772");
            testdata10.Add("82134 206");
            testdata10.Add("583325 39");
            testdata10.Add("836331 161");
            testdata10.Add("873061 934");
            testdata10.Add("940828 490");
            testdata10.Add("15935 885");
            testdata10.Add("287283 747");
            testdata10.Add("135145 706");
            testdata10.Add("216847 816");
            testdata10.Add("349847 699");
            testdata10.Add("20433 34");
            testdata10.Add("812266 458");
            testdata10.Add("309713 383");
            testdata10.Add("179114 520");
            testdata10.Add("8487 988");
            testdata10.Add("71605 767");
            testdata10.Add("887187 495");
            testdata10.Add("819623 203");
            testdata10.Add("955716 749");
            testdata10.Add("274063 8");
            testdata10.Add("613801 793");
            testdata10.Add("630066 259");
            testdata10.Add("9815 923");
            testdata10.Add("992001 449");
            testdata10.Add("199706 16");
            testdata10.Add("245874 895");
            testdata10.Add("168763 225");
            testdata10.Add("826411 593");
            testdata10.Add("313519 850");
            testdata10.Add("202778 900");
            testdata10.Add("112691 239");
            testdata10.Add("846799 771");
            testdata10.Add("630496 879");
            testdata10.Add("474711 382");
            testdata10.Add("64118 688");
            testdata10.Add("360893 807");
            testdata10.Add("550051 921");
            testdata10.Add("277589 176");
            testdata10.Add("147172 654");
            testdata10.Add("305609 335");
            testdata10.Add("175791 315");
            testdata10.Add("701050 608");
            testdata10.Add("409905 692");
            testdata10.Add("344216 710");
            testdata10.Add("688598 392");
            testdata10.Add("946758 598");
            testdata10.Add("213456 943");
            testdata10.Add("294032 616");
            testdata10.Add("406688 394");
            testdata10.Add("807870 241");
            testdata10.Add("719668 571");
            testdata10.Add("67204 169");
            testdata10.Add("468135 950");
            testdata10.Add("602089 647");
            testdata10.Add("108314 188");
            testdata10.Add("634010 448");
            testdata10.Add("821936 663");
            testdata10.Add("215351 721");
            testdata10.Add("514408 238");
            testdata10.Add("721746 719");
            testdata10.Add("732238 431");
            testdata10.Add("852317 996");
            testdata10.Add("623087 208");
            testdata10.Add("596492 549");
            testdata10.Add("596570 66");
            testdata10.Add("495250 492");
            testdata10.Add("521924 280");
            testdata10.Add("805920 889");
            testdata10.Add("158008 161");
            testdata10.Add("515330 710");
            testdata10.Add("975959 42");
            testdata10.Add("217116 785");
            testdata10.Add("349019 343");
            testdata10.Add("303469 352");
            testdata10.Add("940909 875");
            testdata10.Add("402230 374");
            testdata10.Add("757331 479");
            testdata10.Add("134101 71");
            testdata10.Add("58149 438");
            testdata10.Add("983443 319");
            testdata10.Add("366814 858");
            testdata10.Add("401776 525");
            testdata10.Add("27183 822");
            testdata10.Add("29466 891");
            testdata10.Add("225224 216");
            testdata10.Add("106581 990");
            testdata10.Add("670094 101");
            testdata10.Add("29944 496");
            testdata10.Add("656406 750");
            testdata10.Add("521938 533");
            testdata10.Add("557050 409");
            testdata10.Add("526496 571");
            testdata10.Add("794418 622");
            testdata10.Add("476455 798");
            testdata10.Add("226993 27");
            testdata10.Add("21715 399");
            testdata10.Add("485915 517");
            testdata10.Add("384425 433");
            testdata10.Add("540263 108");
            testdata10.Add("840346 429");
            testdata10.Add("271779 480");
            testdata10.Add("47438 199");
            testdata10.Add("795824 11");
            testdata10.Add("262289 624");
            testdata10.Add("415594 427");
            testdata10.Add("455883 362");
            testdata10.Add("23062 294");
            testdata10.Add("206716 799");
            testdata10.Add("201257 752");
            testdata10.Add("582493 794");
            testdata10.Add("600925 777");
            testdata10.Add("463598 493");
            testdata10.Add("26008 841");
            testdata10.Add("898186 44");
            testdata10.Add("125067 315");
            testdata10.Add("764330 733");
            testdata10.Add("742283 812");
            testdata10.Add("692446 822");
            testdata10.Add("773569 998");
            testdata10.Add("942162 470");
            testdata10.Add("740704 894");
            testdata10.Add("323089 855");
            testdata10.Add("322410 71");
            testdata10.Add("550080 969");
            testdata10.Add("181340 594");
            testdata10.Add("747785 178");
            testdata10.Add("197116 681");
            testdata10.Add("851433 199");
            testdata10.Add("951966 382");
            testdata10.Add("548169 751");
            testdata10.Add("519996 758");
            testdata10.Add("116614 554");
            testdata10.Add("149978 92");
            testdata10.Add("161023 158");
            testdata10.Add("281437 240");
            testdata10.Add("499872 664");
            testdata10.Add("103508 931");
            testdata10.Add("966687 708");
            testdata10.Add("526133 301");
            testdata10.Add("831577 681");
            testdata10.Add("124704 66");
            testdata10.Add("801000 8");
            testdata10.Add("116163 674");
            testdata10.Add("735432 245");
            testdata10.Add("911719 878");
            testdata10.Add("986990 50");
            testdata10.Add("786369 664");
            testdata10.Add("388514 253");
            testdata10.Add("968069 464");
            testdata10.Add("515725 167");
            testdata10.Add("781089 566");
            testdata10.Add("532684 464");
            testdata10.Add("977352 218");
            testdata10.Add("521962 562");
            testdata10.Add("732640 147");
            testdata10.Add("615576 49");
            testdata10.Add("513945 992");
            testdata10.Add("668613 322");
            testdata10.Add("605608 620");
            testdata10.Add("105565 7");
            testdata10.Add("27469 410");
            testdata10.Add("729913 764");
            testdata10.Add("861692 693");
            testdata10.Add("397618 271");
            testdata10.Add("957735 638");
            testdata10.Add("578084 46");
            testdata10.Add("12026 524");
            testdata10.Add("368079 913");
            testdata10.Add("239828 385");
            testdata10.Add("414960 686");
            testdata10.Add("670182 350");
            testdata10.Add("341834 66");
            testdata10.Add("53099 879");
            testdata10.Add("593489 945");
            testdata10.Add("792883 160");
            testdata10.Add("408270 752");
            testdata10.Add("888131 684");
            testdata10.Add("772654 400");
            testdata10.Add("760694 557");
            testdata10.Add("401645 239");
            testdata10.Add("47806 495");
            testdata10.Add("698747 363");
            testdata10.Add("969926 57");
            testdata10.Add("998051 70");
            testdata10.Add("162283 625");
            testdata10.Add("63638 977");
            testdata10.Add("988992 979");
            testdata10.Add("346127 401");
            testdata10.Add("390115 472");
            testdata10.Add("690597 580");
            testdata10.Add("1024 899");
            testdata10.Add("405089 729");
            testdata10.Add("514282 638");
            testdata10.Add("783181 583");
          
        }
    }

}
