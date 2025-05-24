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
	int a,b;
	public:
		Phanso(){
			a=0;b=1;
		}
		Phanso(const int& ts, const int& ms)
		{
			a=ts;
			b=ms;
		}
		int ucln(int a, int b);
	    void rutgon();
		friend ostream&operator<<(ostream&,const Phanso&);
		Phanso operator+(Phanso x);
		Phanso operator*(Phanso x);
		
};
int Phanso::ucln( int a ,int b){
	int trunggian;
	while (a%b!=0)
	{
		trunggian=a%b;
		a=b;
		b=trunggian;
	}
	return b;
}
void Phanso::rutgon()
{
	a=a/ucln(a,b);
	b=b/ucln(a,b);
}
Phanso Phanso::operator+(Phanso x){
	Phanso c;
	c.a=a*x.b+x.a*b;
	c.b=b*x.b;
	return c;	
}
Phanso Phanso::operator*(Phanso x)
{
	Phanso c;
	c.a=a*x.a;
	c.b=b*x.b;
	return c;
} 

ostream & operator<<(ostream& Cout,const Phanso& x){
	Cout<<x.a<<"/"<<x.b;
	return Cout;
}
int main() {
Phanso p1(1,3),p2(2,5);
cout<<"Tong 2 phan so la: "<<p1+p2<<endl;
cout<<"Tich 2 phan so la: "<<p1*p2;
}
