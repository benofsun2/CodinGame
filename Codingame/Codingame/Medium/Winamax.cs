using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Codingame.Medium.Winamax
{

    class Solution
    {

        public static void Main(string[] args)
        {
            int winner;
            int count;
            //bool gameover;
            bool isPAT;
            //gameover = false;
            winner = 0;
            count = 0;
            isPAT = false;
            Dictionary<int, char> weight = new Dictionary<int, char>();
            weight.Add(2, '2');
            weight.Add(3, '3');
            weight.Add(4, '4');
            weight.Add(5, '5');
            weight.Add(6, '6');
            weight.Add(7, '7');
            weight.Add(8, '8');
            weight.Add(9, '9');
            weight.Add(10, '1');
            weight.Add(11, 'J');
            weight.Add(12, 'Q');
            weight.Add(13, 'K');
            weight.Add(14, 'A');
            Player ply1 = new Player(1);
            Player ply2 = new Player(2);

            //var sr = new StringReader(args[0]);
            //Console.SetIn(sr);
            int n = int.Parse(Console.ReadLine()); // the number of cards for player 1
            Console.Error.WriteLine(n);
            for (int i = 0; i < n; i++)
            {
                //sr = new StringReader(args[i + 1]);
                //Console.SetIn(sr);
                string cardp1 = Console.ReadLine(); // the n cards of player 1
                ply1.Push(cardp1);
                Console.Error.WriteLine(cardp1);
            }
            //sr = new StringReader(args[27]);
            //Console.SetIn(sr);
            int m = int.Parse(Console.ReadLine()); // the number of cards for player 2
            Console.Error.WriteLine(m);
            for (int i = 0; i < m; i++)
            {
                //sr = new StringReader(args[i + 28]);
                //Console.SetIn(sr);
                string cardp2 = Console.ReadLine(); // the m cards of player 2
                ply2.Push(cardp2);
                Console.Error.WriteLine(cardp2);
            }

            bool war = false;
            while (ply1.CardCount != 0 && ply2.CardCount != 0)
            {
                string p1 = "";
                string p2 = "";
                
                p1 = (war) ? ply1.PlayCardWar() : ply1.PlayCardBattle();
                
                p2 = (war) ? ply2.PlayCardWar() : ply2.PlayCardBattle();

                Console.Error.WriteLine(p1);
                Console.Error.WriteLine(p2);
                

                //if (p1 != "" && p2 != "")
                //{
                    var w1 = weight.FirstOrDefault(x => x.Value == p1[0]).Key;
                    var w2 = weight.FirstOrDefault(x => x.Value == p2[0]).Key;
                    Console.Error.WriteLine(w1);
                    Console.Error.WriteLine(w2);
                    if (w1 > w2)
                    {
                        if (war)
                            //count++;
                        ply1.WinHand(ply2.LooseHand());
                        war = false;
                    }
                    else if (w1 < w2)
                    {
                        if (war)
                            //count++;
                        ply2.WinHand(ply1.LooseHand());
                        war = false;
                    }
                    else
                    {
                        war = true;
                        //count++;
                    }

                    count++;
                //}
                //else
                //{
                //    Console.Error.WriteLine(ply1.CardCount);
                //    Console.Error.WriteLine(ply2.CardCount);
                //    isPAT = war;
                //    break;
                //}
            }

            isPAT = war;
            if(ply1.CardCount > ply2.CardCount)
            {
                winner = 1;
            }
            else
            {
                winner = 2;
            }
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            if (isPAT)
            {
                Console.WriteLine("PAT");
            }
            else
            {
                Console.WriteLine(winner + " " + count);
            }

        }


    }

    class Player
    {
        private Stack<string> deck;
        private Queue<string> hand;
        private int playernumber;

        public Player(int number)
        {
            playernumber = number;
            deck = new Stack<string>();
            hand = new Queue<string>();
        }

        public int CardCount
        {
            get
            {
                return deck.Count;
            }
        }

        public void Push(string card)
        {
            deck.Push(card);
        }

        public string PlayCardBattle()
        {
            string ret = "";
            if (deck.Count > 0)
            {
                ret = deck.Pop();
                hand.Enqueue(ret);
            }
            return ret;
        }

        public string PlayCardWar()
        {
            string ret = "";
            if (deck.Count > 0)
            {
                ret = deck.Pop();
                hand.Enqueue(ret);
                ret = "";
            }
            if (deck.Count > 0)
            {
                ret = deck.Pop();
                hand.Enqueue(ret);
                ret = "";
            }
            if (deck.Count > 0)
            {
                ret = deck.Pop();
                hand.Enqueue(ret);
                ret = "";
            }
            if (deck.Count > 0)
            {
                ret = deck.Pop();
                hand.Enqueue(ret);
            }
            return ret;
        }

        public Queue<string> LooseHand()
        {
            Queue<string> ret = new Queue<string>(hand);
            hand.Clear();
            return ret;

        }

        public void WinHand(Queue<string> winings)
        {
            var arr1 = deck.ToArray();
            Array.Reverse(arr1); 
            var arr2 = hand.ToArray();
            var arr3 = winings.ToArray();

            Array.Reverse(arr2);
            Array.Reverse(arr3);
            hand.Clear();
            deck.Clear();
            if (playernumber == 1)
            {
                for (int i = 0; i < arr3.Length; i++)
                {
                    deck.Push(arr3[i]);
                }

                for (int i = 0; i < arr2.Length; i++)
                {
                    deck.Push(arr2[i]);
                }
            }
            else
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    deck.Push(arr2[i]);
                }

                for (int i = 0; i < arr3.Length; i++)
                {
                    deck.Push(arr3[i]);
                }
            }


            for (int i = 0; i < arr1.Length; i++)
            {
                deck.Push(arr1[i]);
            }
        }
    }
}