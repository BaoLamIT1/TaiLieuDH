
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;

class ToaDo{
	float x,y;
	public:
		void nhap()
		{
			cout<<"Nhap x: "; cin>>x;
			cout<<"Nhap y: "; cin>>y;
		}
		void xuat()
		{
			cout<<"("<<x<<","<<y<<")";
		}
		float kc()                 // float operator!(){
		{
			return sqrt(x*x+y*y); 
		}
		float kc(ToaDo B)           //float operator+(ToaDo B){
		{
			return sqrt(pow(x-B.x,2)+pow(y-B.y,2));
		}
};
int main() {
ToaDo A,B;
A.nhap();A.xuat();
B.nhap();B.xuat();
cout<<"\nOA"<<A.kc()<<"OB="<<B.kc()<<"AB="<<A.kc(B);
//cout<<"\nOA"<<!A<<"OB="<<!B<<"AB="<<A.kc(B);

}
