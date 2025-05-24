/*
Xây dựng lớp phân số:
Thuộc tính: x(tử số), y(mẫu số)
Phương thức:Hàm tạo không tham số, hàm tạo có tham so, hàm rút gọn phân số, 
hàm toán tử in một phân số, hàm cộng hai phân số; 
ham ban nhan 2 phan so
Viết hàm main() nhập vào hai phân số p1,p2 bằng cách sử dụng hàm tạo rồi in ra p1,p2 và tổng, tich của 2 phân số đó
*/
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;
class Phanso{
	int tu,mau;
	public:
		Phanso(){
			tu=0;mau=1;
		}
		Phanso(const int& ts, const int& ms)
		{
			tu=ts;
			mau=ms;
		}
	
		void nhap()
		{
			cout<<"Nhap lan luot tu va mau cua phan so: ";
			cin>> tu >>mau;
		}
		void xuat()
		{
			cout<<tu<<"/"<<mau<<endl;
		}
		void cong(Phanso p1)
		{
			tu=tu*p1.mau + mau*p1.tu;
			mau= mau*p1.mau;
		}
		Phanso rutgon();
		friend ostream&operator<<(ostream&,const Phanso&);
		friend istream&operator>>(istream&,Phanso&);
		public: int getTuso(){
			return tu;
		}
		public: int getMauso(){
			return mau;
		}
		Phanso cong(const Phanso&);
		friend Phanso nhan(const Phanso&,Phanso&);
};
      
int main() {
Phanso p1,p2,p3;
p1.nhap();
p2.nhap();
cout<<"Tong 2 phan so = ";
p3=p1; 
p3.cong(p2);
p3.xuat();
}
