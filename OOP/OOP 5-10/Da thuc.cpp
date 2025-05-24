/* Xây dựng lớp DaThuc
- Thuộc tính: int bac , float *hs(he so)
Phg thức: Hàm tạo ko tham số , hàm tạo có tham số , nhập đa thức, hàm toán tử in đa thức tính,
hàm bạn tính giá trị của đa thức tại X0, hàm toán tử cộng 2 Dathuc,
*/
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;   
	  class Dathuc{
	  	private:
	  	int bac;
	  	float *hs;
	public:
		Dathuc(){
		}
	Dathuc(int bac, float *hs){
		this->bac=bac;
	    this->hs=hs;
	}
	~Dathuc(){
		bac=0;
		delete hs;
	}
	friend istream &operator>>(istream&, Dathuc&);
	friend ostream &operator<<(ostream&, const Dathuc&);
	friend float gt(const Dathuc& Dt, const int&x);
    Dathuc operator +(Dathuc&);
};
istream &operator>>(istream&Cin, Dathuc&Dt){
	cout<<"\nNhap vao bac cua da thuc: "; Cin>>Dt.bac;
	Dt.hs= new float[Dt.bac+1];
	cout<<"\nNhap vao he so cua da thuc: ";
	for(int i=0;i<=Dt.bac;i++)
	{
		cout<<"a["<<i<<"]= "; Cin>>Dt.hs[i];
	}
	return Cin;
}
ostream &operator<<(ostream&Cout, const Dathuc&Dt)
{
	for(int i =0;i<=Dt.bac;i++)
	cout<<Dt.hs[i];
	return Cout;
}
float gt(const Dathuc& Dt, const int &x){
	float sum=0;
	for(int i=Dt.bac;i>=0;i--)
	{
		sum += Dt.hs[i] * pow(x,i);
	}
	return sum;
}
Dathuc operator+(const Dathuc&Dt, const Dathuc&Dt2)
{
	Dathuc c;
	int M= max(Dt.bac,Dt2.bac);
	int m=min(Dt.bac,Dt2.bac);
	c.bac=M;
	c.hs
}
int main() {
 

}
