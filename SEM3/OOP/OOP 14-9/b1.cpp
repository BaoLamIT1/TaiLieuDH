
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;
class A{
	private:
		int a1;
	protected:
		int a2;
	public:
		int a3;
	void f()
	{
		A obj;
		cout<<obj.a1<<endl;
		cout<<obj.a2<<endl;
		cout<<obj.a3<<endl;
	}
	friend int main();
};
 class B
int main() {
      A obj;
      cout<<obj.a1<<endl; // ko truy xuat dc 
      cout<<obj.a2<<endl; // ko truy xuat dc 
      cout<<obj.a3<<endl;

}
