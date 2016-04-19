using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingame.Medium.MarsLanderLvl2
{

    // based on Fabrizio Cucci solution found on Github
    class Solution
    {
        private const int EPSILON = 5;
        private const int MAX_VERTICAL_SPEED = 40;
        private const int MAX_HORIZONTAL_SPEED = 20;

        private const double GRAVITY = 3.711;
        private const int SECURITY_DISTANCE_FROM_FLAT_GROUND = 50;


        public static void Main(string[] args)
        {
            string[] inputs;
            int surfaceN = int.Parse(Console.ReadLine()); // the number of points used to draw the surface of Mars.
            int[] landingZone = new int[3];
            int speedOut = 0;
            int rotOut = 0;
            int[,] landys = new int[surfaceN,2];
            int lz = 0;
            
            for (int i = 0; i < surfaceN; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                int landX = int.Parse(inputs[0]); // X coordinate of a surface point. (0 to 6999)
                int landY = int.Parse(inputs[1]); // Y coordinate of a surface point. By linking all the points together in a sequential fashion, you form the surface of Mars.
                Console.Error.WriteLine("landx: "+landX);
                Console.Error.WriteLine("landy: "+landY);
                landys[i,1] = landY;
                landys[i,0] = landX;
                if(i > 0)
                {
                    if (landys[i, 1] == landys[i - 1, 1])
                    {
                        landingZone[0] = landys[i - 1, 0];
                        landingZone[1] = landys[i, 0];
                        landingZone[2] = landys[i, 1];
                    }
                }
            }
            lz = landingZone[0] + ((landingZone[1] - landingZone[0])/2);
            // game loop
            while (true)
            {
                inputs = Console.ReadLine().Split(' ');
                int X = int.Parse(inputs[0]);
                int Y = int.Parse(inputs[1]);
                int hSpeed = int.Parse(inputs[2]); // the horizontal speed (in m/s), can be negative.
                int vSpeed = int.Parse(inputs[3]); // the vertical speed (in m/s), can be negative.
                int fuel = int.Parse(inputs[4]); // the quantity of remaining fuel in liters.
                int rotate = int.Parse(inputs[5]); // the rotation angle in degrees (-90 to 90).
                int power = int.Parse(inputs[6]); // the thrust power (0 to 4).

                

                // Write an action using Console.WriteLine()
                Console.Error.WriteLine("rot: " + rotate);
                Console.Error.WriteLine("x: " + lz);
                Console.Error.WriteLine("x2: " + landingZone[1] + " " + landingZone[0]);
                Console.Error.WriteLine("X: " + X);
                Console.Error.WriteLine("Y: " + Y);
                Console.Error.WriteLine("y: " + landingZone[2]);


                if (isMarsLanderFlyingOverFlatGround(X, landingZone[0], landingZone[1])) 
                {

                    if (isMarsLanderAboutToLand(Y, landingZone[2])) 
                    {
         		        rotOut= 0;
         		        speedOut= 3;
         	        } else if (areMarsLanderSpeedLimitsSatisfied(hSpeed, vSpeed)) {
         		        rotOut= 0;
         		        speedOut= 2;
         	        } else {
         		        rotOut= calculateRotationToSlowDownMarsLander(hSpeed, vSpeed);
         		        speedOut= 4;
         	        }
         
                 } else {

                     if (isMarsLanderFlyingInTheWrongDirection(X, hSpeed, landingZone[0], landingZone[1]) || isMarsLanderFlyingTooFastTowardsFlatGround(hSpeed))
                     {
         		        rotOut= calculateRotationToSlowDownMarsLander(hSpeed, vSpeed);
         		        speedOut= 4;
         	        } else if (isMarsLanderFlyingTooSlowTowardsFlatGround(hSpeed)) {
                        rotOut = calculateRotationToSpeedUpMarsLanderTowardsFlatGround(X, landingZone[0], landingZone[1]);
         		        speedOut= 4;
         	        } else {
         		        rotOut= 0;
         		        speedOut= calculateThrustPowerToFlyTowardsFlatGround(vSpeed);
         	        }
         	
                 }
                Console.WriteLine(rotOut + " " + speedOut); // rotate power. rotate is the desired rotation angle. power is the desired thrust power.
            }
        }

        private static bool isMarsLanderFlyingOverFlatGround(int marsLanderX, int flatGroundLeftX, int flatGroundRightX) 
        {
	        return marsLanderX >= flatGroundLeftX && marsLanderX <= flatGroundRightX;
        }

        private static bool isMarsLanderAboutToLand(int marsLanderY, int flatGroundY) 
        {
	        return marsLanderY < flatGroundY + SECURITY_DISTANCE_FROM_FLAT_GROUND;
        }

        private static bool areMarsLanderSpeedLimitsSatisfied(int marsLanderHorizontalSpeed, int marsLanderVerticalSpeed) 
        {
	        return Math.Abs(marsLanderHorizontalSpeed) <= (MAX_HORIZONTAL_SPEED - EPSILON) && Math.Abs(marsLanderVerticalSpeed) <= (MAX_VERTICAL_SPEED - EPSILON);
        }

        private static int calculateRotationToSlowDownMarsLander(int horizontalSpeed, int verticalSpeed) 
        {
	        double speed = Math.Sqrt(Math.Pow(horizontalSpeed, 2) + Math.Pow(verticalSpeed, 2));
	        double rotationAsRadians = Math.Asin((double) horizontalSpeed / speed);
	        return (int)RadianToDegree(rotationAsRadians);
        }

        private static bool isMarsLanderFlyingInTheWrongDirection(int marsLanderX, int marsLanderHorizontalSpeed, int flatGroundLeftX, int flatGroundRightX) 
        {
	
	        if (marsLanderX < flatGroundLeftX && marsLanderHorizontalSpeed < 0) 
            {
		        return true;
	        }
	
	        if (marsLanderX > flatGroundRightX && marsLanderHorizontalSpeed > 0) 
            {
		        return true;
	        }
	
	        return false;
        }

        private static bool isMarsLanderFlyingTooFastTowardsFlatGround(int marsLanderHorizontalSpeed) 
        {
	        return Math.Abs(marsLanderHorizontalSpeed) > (MAX_HORIZONTAL_SPEED * 4);
        }

        private static bool isMarsLanderFlyingTooSlowTowardsFlatGround(int marsLanderHorizontalSpeed) 
        {
	        return Math.Abs(marsLanderHorizontalSpeed) < (MAX_HORIZONTAL_SPEED * 2);
        }

        private static int calculateRotationToSpeedUpMarsLanderTowardsFlatGround(int marsLanderX, int flatGroundLeftX, int flatGroundRightX) 
        {
	
	        if (marsLanderX < flatGroundLeftX) {
		        return - (int)RadianToDegree(Math.Acos(GRAVITY / 4.0)); 
	        }
	
	        if (marsLanderX > flatGroundRightX) {
                return +(int)RadianToDegree(Math.Acos(GRAVITY / 4.0)); 
	        }
	
	        return 0;
        }

        private static int calculateThrustPowerToFlyTowardsFlatGround(int marsLanderVerticalSpeed) 
        {
	        return (marsLanderVerticalSpeed >= 0) ? 3 : 4;
        }

        private static double RadianToDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }
    }

    
}