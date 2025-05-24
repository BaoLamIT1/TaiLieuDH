//ham co doi mac dinh:  la ham co doi cho truoc va doi nay phai la doi cuoi cung trong cac doi
#include<stdio.h>
#include<math.h>
#include<stdlib.h>
#include<conio.h>
#include<string.h>
#include<iostream>
#include<bits/stdc++.h>
    using namespace std;
    float SHCN(const float d=10, const float r=8){
      	return d*r;
	  }
int main() {
       cout << SHCN(100,80) <<endl;
       cout <<SHCN(1000)<<endl;

}
/*
class hcn{
	private:
		int d,r;
	public:
		void nhap(){
			cin >> d;
			cin >> r;
		}
		void display(){
			cout<<"Area: "<< d*r<<endl;
		}
};
      
int main() {
       hcn s;
       s.nhap();
       s.display();
       return 0;

}
*/

