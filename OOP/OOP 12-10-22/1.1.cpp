#include<iostream>
#include<bits/stdc++.h>
      using namespace std;
class A{
	int a;
	int *a1;
	public:
		void operator=(Const A&ob)
		{
			a=ob.a;
			a1=new int ;
			*a1=*(ob.a1);
		}
		A(int b=10 , int b1=4)
		{
			a=b;
			
		}
		void xuat()
		{
			cout<<a<<" "<<a1;
		}
		void biendoi()
		{
			a=a+15;
			(*a1) = 1000;
		}
};
      
int main() {
A x1(1,-1);
A x2=x1; // ham tao sao chep
x1.xuat();
//x2=x1;
x2.xuat();
x1.biendoi();
x1.xuat();
x2.xuat();

}
