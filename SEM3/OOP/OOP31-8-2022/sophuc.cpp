/*Hàm toán tử : ý nghĩa: Triển khai dc các phép toán đối với các kiểu dữ liệu do người dùng tự định nghĩa */
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;
class sophuc{
	public:
		double a,b;
		void nhap(){
			cout<<"Nhap he so a: ";cin >>a;
			cout<<"Nhap he so b: ";cin >>b;
		}
		void display(){
			cout<<a<<"+"<<b<<"i"<<endl;
		}	
};
sophuc cong(const sophuc sp1 ,const sophuc sp2){
	sophuc sp3;
	sp3.a=sp1.a+sp2.a;
	sp3.b=sp1.b+sp2.b;
	return sp3;
}
sophuc hieu(const sophuc sp1 ,const sophuc sp2){
	sophuc sp3;
	sp3.a=sp1.a-sp2.a;
	sp3.b=sp1.b-sp2.b;
	return sp3;
}
sophuc tich(const sophuc sp1 ,const sophuc sp2){
	sophuc sp3;
	sp3.a=sp1.a*sp2.a;
	sp3.b=sp1.b*sp2.b;
	return sp3;
}
sophuc thuong(const sophuc sp1 ,const sophuc sp2){
	sophuc sp3;
	sp3.a=sp1.a/sp2.a;
	sp3.b=sp1.b/sp2.b;
	return sp3;
}
int main() {
   sophuc sp1,sp2,sp3;
   sp1.nhap();
   sp2.nhap();
   sp1.display();
   sp2.display();
   sp3=cong(sp1,sp2);  cout<<"Tong 2 sp la: "<<sp3.a <<"+"<<sp3.b<<"i"<<endl;
   sp3=hieu(sp1,sp2);  cout<<"Hieu 2 sp la: "<<sp3.a <<"+"<<sp3.b<<"i"<<endl;
   sp3=tich(sp1,sp2);  cout<<"Tich 2 sp la: "<< sp3.a <<"+"<<sp3.b<<"i"<<endl;
   sp3=thuong(sp1,sp2);cout<<"Thuong 2 sp la: "<<sp3.a <<"+"<<sp3.b<<"i"<<endl;
   
}


/* BTVN:
Định nghĩa cấu trúc đa thức,vector 
Xây dựng các phép toán cộng 2 vt, nhân vô hướng 2vt, nhân vt vs 1 số nguyên( mặc định số ng là 2), hàm nhập xuất 1 vt.
Ứng dụng để nhập vào 3 vt u,v,s,số nguyên k. Tính( k.u +2.v)* s.
*/