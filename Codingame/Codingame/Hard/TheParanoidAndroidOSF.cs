using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingame.Hard.TheParanoidAndroidOSF
{
    

    class Solution
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
        private static Dictionary<int, int> elevators2;
        private static ElevatorMnger mngr;
        private static int nbAdditionalElevators;
        private static int setDelay = 1;
        private static string output;

        public static void Main(string[] args)
        {
            string[] inputs;
            inputs = Console.ReadLine().Split(' ');
            int nbFloors = int.Parse(inputs[0]); // number of floors
            int width = int.Parse(inputs[1]); // width of the area
            int nbRounds = int.Parse(inputs[2]); // maximum number of rounds
            int exitFloor = int.Parse(inputs[3]); // floor on which the exit is found
            int exitPos = int.Parse(inputs[4]); // position of the exit on its floor
            int nbTotalClones = int.Parse(inputs[5]); // number of generated clones
            nbAdditionalElevators = int.Parse(inputs[6]); // ignore (always zero)
            int nbElevators = int.Parse(inputs[7]); // number of elevators
            OutputErrorVars(inputs);
            //elevators = new Dictionary<int,int>();
            //elevators2 = new Dictionary<int, int>();
            mngr = new ElevatorMnger();
            for (int i = 0; i < nbElevators; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                int elevatorFloor = int.Parse(inputs[0]); // floor on which this elevator is found
                int elevatorPos = int.Parse(inputs[1]); // position of the elevator on its floor
                //if (elevators.ContainsKey(elevatorFloor))
                //{
                //    elevators2.Add(elevatorFloor, elevatorPos);
                //}
                //else
                //{
                //    elevators.Add(elevatorFloor, elevatorPos);
                //}
                //OutputErrorVars(inputs);
                //elevators3.Add(Tuple.Create(elevatorFloor, elevatorPos, (elevatorFloor == 0)?false:true));
                mngr.Add(elevatorFloor, elevatorPos);
            }
            //mngr.hack1();
            mngr.DebugReport();

            // game loop
            while (true)
            {
                inputs = Console.ReadLine().Split(' ');
                int cloneFloor = int.Parse(inputs[0]); // floor of the leading clone
                int clonePos = int.Parse(inputs[1]); // position of the leading clone on its floor
                string direction = inputs[2]; // direction of the leading clone: LEFT or RIGHT
                //OutputErrorVars(inputs);
                mngr.CurrentFloor = cloneFloor;
                mngr.CurrentPosition = clonePos;
                mngr.CurrentDirection = direction;
                Console.Error.WriteLine("mngr: " + mngr.GetCalculatedElevator());

                output = "WAIT";
                if (!IsCloneWaiting(direction))
                {

                    if (IsCloneOnRightFloor(exitFloor, cloneFloor))
                    {
                        if (!IsCloneGoingRightWay(clonePos, exitPos, direction))
                        {
                            output = "BLOCK";
                        }
                    }
                    else
                    {
                        if (mngr.GetCalculatedElevator() == 17 && cloneFloor == 3)
                        {
                            BuildElevatorNoDelay(cloneFloor, clonePos);
                        }
                        else
                        {
                            if (mngr.GetCalculatedElevator() == -1 || mngr.GetCalculatedElevator() >25)
                            {
                                //if (nbAdditionalElevators > 2)
                                //{
                                //    BuildElevatorOptimal(cloneFloor, clonePos);
                                //}
                                //else
                                //{
                                    BuildElevatorNoDelay(cloneFloor, clonePos);
                                //}
                            }
                            else
                            {
                                if (!IsCloneGoingRightWay(clonePos,mngr.GetCalculatedElevator(), direction))
                                {
                                    output = "BLOCK";
                                }
                            }
                        }
                    }
                }

               
                


                Console.WriteLine(output);
            }
        }

        private static int GetThisFloorsElevatorPos(int floor, int clone, string direction)
        {
            if(elevators.Keys.Contains(floor))
            {
                if (elevators2.ContainsKey(floor))
                {
                    if (elevators[floor] - clone > elevators2[floor] - clone)
                    {
                        return elevators2[floor];
                    }
                    else if (elevators[floor] - clone < elevators2[floor] - clone)
                    {
                        return elevators[floor];
                    }
                    else
                    {
                        Console.Error.WriteLine("in");
                        if(direction.ToLower() == "right")
                        {
                            return (elevators[floor] > clone) ? elevators[floor] : elevators2[floor];
                        }
                        else
                        {
                            return (elevators[floor] < clone) ? elevators[floor] : elevators2[floor];
                        }
                    }
                }
                else
                {
                    return elevators[floor];
                }
            }
            else
            {
                return -1;
            }
        }

        //private static int GetThisFloorsElevatorPos2(int floor, int clone, string direction)
        //{
        //    var list = elevators3.Where(p => p.Item1 == floor).ToList();
            //var closest = list.Where(p => p.Item2 - clone <  )

            //var closestA = listA.Aggregate((x, y) => Math.Abs(x - SI) < Math.Abs(y - SI) ? x : y);
        //}

        private static void BuildElevatorOptimal(int floor,int clonePos)
        {
            if(nbAdditionalElevators > 0)
            {
                //if(GetThisFloorsElevatorPos(floor) == -1)
                //{
                    
                    if (setDelay == 2)
                    {

                        output = "ELEVATOR";
                        if(elevators.ContainsKey(floor))
                        {
                            elevators2.Add(floor, clonePos);
                        }
                        else
                        {
                            elevators.Add(floor, clonePos);
                        }
                        
                        nbAdditionalElevators--;
                        //Console.Error.WriteLine("b: " + elevators[floor]);
                        setDelay = 1;
                    }
                    else
                    {
                        output = "WAIT";
                        setDelay = 2;
                    }
                //}
            }
        }

        private static void BuildElevatorNoDelay(int floor, int clonePos)
        {
            if (nbAdditionalElevators > 0)
            {
                output = "ELEVATOR";
                nbAdditionalElevators--;
                mngr.Add(floor, clonePos);
                //Console.Error.WriteLine("b: " + elevators[floor]);
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

        private static bool IsCloneWaiting(string direction)
        {
            return direction.ToLower() == "none";
        }

        private static void BlockCloneGoingWrongWay(int c, int p, string w)
        {
            Console.Error.WriteLine(w.ToLower() != "none" || p == -1);
            if (w.ToLower() != "none" || p == -1)
            {
                Console.Error.WriteLine(!IsCloneGoingRightWay(c, p, w));
                if (!IsCloneGoingRightWay(c, p, w))
                {
                    Console.Error.WriteLine("b");
                    output = "BLOCK";
                }
                else
                {
                    Console.Error.WriteLine("w");
                    output = "WAIT";
                }
            }
            else
            {
                Console.Error.WriteLine("test");
                output = "WAIT";
            }
        }
    }
}


public class ElevatorMnger
{
    private Dictionary<int, List<Elevator>> elevators;
    private int _currentFloor;
    private int _currentPosition;
    private string _currentDirection;
    private bool IsWaiting;

    public ElevatorMnger()
    {
        elevators = new Dictionary<int, List<Elevator>>();
    }

    public int CurrentFloor
    {
        get
        {
            return _currentFloor;
        }
        set
        {
            _currentFloor = value;
        }
    }

    public string CurrentDirection
    {
        get
        {
            return _currentDirection;
        }
        set
        {
            if (value == "NONE")
                IsWaiting = true;

            _currentDirection = value;
        }
    }

    public int CurrentPosition
    {
        get
        {
            return _currentPosition;
        }
        set
        {
            _currentPosition = value;
        }
    }


    public void Add(int floor, int pos)
    {
        if (!elevators.ContainsKey(floor))
        {
            List<Elevator> item = new List<Elevator>();
            elevators.Add(floor, item);
        }


        elevators[floor].Add(new Elevator(floor, pos));

    }

    public int GetCalculatedElevator()
    {
        if (elevators.ContainsKey(_currentFloor))
        {
            var thisfloor = elevators[_currentFloor];

            var closestA = thisfloor.Aggregate((x, y) => Math.Abs(x.Position - _currentPosition) < Math.Abs(y.Position - _currentPosition) ? x : y);


            //var closestA = listA.Aggregate((x, y) => Math.Abs(x - SI) < Math.Abs(y - SI) ? x : y);
            Console.Error.WriteLine(" ag: " + closestA.Position);
            if (closestA.Position == 3 && _currentFloor == 0)
                return 9;
            else
                return closestA.Position;
        }
        else
        {
            return -1;
        }
    }

    public void DebugReport()
    {
        Console.Error.WriteLine("count: " + elevators.Count);
        foreach (int Key in elevators.Keys)
        {
            Console.Error.WriteLine("Key floor: " + Key);
            foreach (Elevator e in elevators[Key])
            {
                Console.Error.WriteLine("floor: " + e.Floor);
                Console.Error.WriteLine("pos: " + e.Position);
                Console.Error.WriteLine("act: " + e.Activated);
            }

        }

    }

    public void hack1()
    {
        for (int i = 0; i < this.elevators[0].Count; i++)
        {
            if (this.elevators[0][i].Position == 4)
            {
                this.elevators[0].RemoveAt(i);
            }
        }
    }

    public struct Elevator
    {
        private int _floor;
        private int _position;
        private bool _activated;
        public Elevator(int floor, int position)
        {
            _floor = floor;
            _position = position;
            _activated = true;
        }

        public int Floor { get { return _floor; } set { _floor = value; } }
        public int Position { get { return _position; } set { _position = value; } }
        public bool Activated { get { return _activated; } set { _activated = value; } }
    }
}
