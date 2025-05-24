
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;
class thisinh{
	public:
		int n;
		long sbd;
		string hoten;
		int toan; int ly; int hoa;
	void nhap(){
	cout<<"Nhap vao so luong thi sinh: "; cin>>n;
	for( int i=0;i<n;i++){
	cout<<"Nhap sbd sinh vien: "; cin>> sbd;
	cout<<"Nhap ho ten: "; cin>> hoten; 
	cout<<"Nhap diem toan: "; cin>> toan;
	cout<<"Nhap diem ly: "; cin>> ly;
	cout<<"Nhap diem hoa: "; cin>> hoa;
	cout<<"Tong diem 3 mon la: "<< toan+ly+hoa<<endl;
	float tbc=(toan+ly+hoa)/3.0;
	cout<<"Diem trung binh 3 mon la:"<<tbc<<endl;
}
}

};
  
int main() {
thisinh ts;
ts.nhap();
ts.xuat();

}
