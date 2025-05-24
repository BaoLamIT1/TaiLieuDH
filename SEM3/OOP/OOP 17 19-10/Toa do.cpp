
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;
class A{
//int x,y;
int *x, y;
public: 
//A(){x=y=0;}	
   A(int m=0,int n=0){
   	
//	x=m;y=n;
    x=new int;   
	*x=m;y=n;
}
A(const A&ob){     // hàm tạo sao chép
	x=new int;
	*x=*(ob.x); y=ob.y;
}
void xuat(){
			cout<<*x<<" "<<y<<" "<<endl;
		}
};
class B:public A{
	//int mau;
	int *z;
	public:
		B(int x=0,int y=0, int mau=1):A(x,y){
			z=new int;
			*(this->z)=mau;
		}
		B(const B&ob):A((A)ob){     // hàm tạo sao chép
	z=new int;
	*z=*(ob.z); 
}
     void xuat(){
			A::xuat(); cout<<" "<<*z<<endl;
		}
};      
int main() {
B A(4,3,2);
B B(A); //B B=A ; gọi đến hàm tạo sao chép
//goi den toán tử gán
A.xuat();
B.xuat();

}
