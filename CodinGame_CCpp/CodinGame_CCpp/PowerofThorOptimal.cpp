#include <iostream>
#include <string>
#include <map>
using namespace std;
int main(){
std::map<string,int>compasDirect;
compasDirect["N"]=-1;
compasDirect["S"]=1;
compasDirect["W"]=-1;
compasDirect["E"]=1;
compasDirect[""]=0;
int x2;
int y2;
int x1;
int y1;	
cin >> x2 >> y2 >> x1 >> y1; cin.ignore();
while(1){
int remainingTurns;
cin >> remainingTurns; cin.ignore();
string a,b;
int d=y1-y2;
a=(d==0)?(""):((d>0)?("N"):("S"));
d=x1-x2;
b=(d==0)?(""):((d>0)?("W"):("E"));
x1+=compasDirect[b];
y1+=compasDirect[a];
cout << a << b << endl;}}

