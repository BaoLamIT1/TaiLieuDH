
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;

      class Myclass{
      	public:
      		static int x;
	  };
	  int Myclass ::x=10;
int main() {
Myclass m1;
Myclass m2;
m1.x=20;m2.x=30;
cout<<m1.x<<""<<m2.x;
return 0;
}
/*// ==> Luon lay ket qua sau ??
Bien static la bien ma duoc dung cho tat ca doi tuong;
*/
