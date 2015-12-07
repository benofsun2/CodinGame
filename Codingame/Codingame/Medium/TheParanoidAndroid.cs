using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingame.Medium
{
    class TheParanoidAndroid
    {
        private static void OutputErrorVars(string[] vars)
        {
            Console.Error.WriteLine("************************************************");
            for(int i = 0 ; i < vars.Length ; i++ )
            {
                Console.Error.WriteLine("var[" + i + "]: " + vars[i]);
            }
            Console.Error.WriteLine("************************************************");

        }

        private static Dictionary<int, int> elevators;

        static void Main(string[] args)
        {
            string[] inputs;
            inputs = Console.ReadLine().Split(' ');
            int nbFloors = int.Parse(inputs[0]); // number of floors
            int width = int.Parse(inputs[1]); // width of the area
            int nbRounds = int.Parse(inputs[2]); // maximum number of rounds
            int exitFloor = int.Parse(inputs[3]); // floor on which the exit is found
            int exitPos = int.Parse(inputs[4]); // position of the exit on its floor
            int nbTotalClones = int.Parse(inputs[5]); // number of generated clones
            int nbAdditionalElevators = int.Parse(inputs[6]); // ignore (always zero)
            int nbElevators = int.Parse(inputs[7]); // number of elevators

            //OutputErrorVars(inputs);
            elevators = new Dictionary<int,int>();
            for (int i = 0; i < nbElevators; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                int elevatorFloor = int.Parse(inputs[0]); // floor on which this elevator is found
                int elevatorPos = int.Parse(inputs[1]); // position of the elevator on its floor
                elevators.Add(elevatorFloor, elevatorPos);
            }

            // game loop
            while (true)
            {
                inputs = Console.ReadLine().Split(' ');
                int cloneFloor = int.Parse(inputs[0]); // floor of the leading clone
                int clonePos = int.Parse(inputs[1]); // position of the leading clone on its floor
                string direction = inputs[2]; // direction of the leading clone: LEFT or RIGHT

                BlockCloneGoingWrongWay(clonePos, (IsCloneOnRightFloor(cloneFloor , exitFloor))?exitPos:GetThisFloorsElevatorPos(cloneFloor), direction);
            }
        }

        private static int GetThisFloorsElevatorPos(int floor)
        {
            if(elevators.Keys.Contains(floor))
            {
                return elevators[floor];
            }
            else
            {
                return -1;
            }
        }




        private static bool IsCloneOnRightFloor(int exitFloor, int cloneFloor)
        {
            return exitFloor == cloneFloor;
        }


        private static bool IsCloneGoingRightWay(int c, int p, string w)
        {
            if(w.ToLower() == "right")
            {
                return (p >= c);
            }
            else
            {
                return (c >= p);
            }
        }

        private static void BlockCloneGoingWrongWay(int c, int p, string w)
        {
            if (w.ToLower() != "none" || p == -1)
            {
                if (!IsCloneGoingRightWay(c, p, w))
                {
                    Console.WriteLine("BLOCK");
                }
                else
                {
                    Console.WriteLine("WAIT");
                }
            }
            else
            {
                Console.WriteLine("WAIT");
            }
        }
    }
}
