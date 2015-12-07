#include <iostream>
#include <string>
#include <vector>
#include <algorithm>
#include <map>

using namespace std;

string GetSetX(int x1, int x2);
string GetSetY(int y1, int y2);


/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/
int main2()
{	
	std::map<string, int> compasDirect;
	compasDirect["N"] = -1;
	compasDirect["S"] = 1;
	compasDirect["W"] = -1;
	compasDirect["E"] = 1;
	compasDirect[""] = 0;

    int lightX; // the X position of the light of power
    int lightY; // the Y position of the light of power
    int initialTX; // Thor's starting X position
    int initialTY; // Thor's starting Y position
	int nextTX; // Thor's next x position
	int nextTY;  // Thor's next y position
    cin >> lightX >> lightY >> initialTX >> initialTY; cin.ignore();

    // game loop
    while (1) {
        int remainingTurns; // The remaining amount of turns Thor can move. Do not remove this line.
        cin >> remainingTurns; cin.ignore();

        // Write an action using cout. DON'T FORGET THE "<< endl"
        // To debug: cerr << "Debug messages..." << endl;
		nextTX = initialTX + compasDirect[GetSetX(initialTX, lightX)];
		nextTY = initialTY + compasDirect[GetSetY(initialTY, lightY)];

		cerr << nextTY << " " << nextTX << endl;

		cerr << GetSetY(initialTY, lightY) << GetSetX(initialTX, lightX) << endl;
		cout << GetSetY(initialTY, lightY) << GetSetX(initialTX, lightX) << endl; // A single line providing the move to be made: N NE E SE S SW W or NW

		initialTX = nextTX;
		initialTY = nextTY;
    }
}


string GetSetY(int y1, int y2)
{
	int d1 = y1 - y2;
	cerr << d1 << endl;
	return((d1 == 0) ? ("") : ((d1 > 0) ? ("N") : ("S")));
}


string GetSetX(int x1, int x2)
{
	int d2 = x1 - x2;
	cerr << d2 << endl;
	return((d2 == 0) ? ("") : ((d2 > 0) ? ("W") : ("E")));
}



	