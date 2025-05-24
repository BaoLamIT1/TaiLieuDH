
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;
class Nhanvien1{
	public:
	int ma;
	string hoten;
	float hesoluong;
	int getMa(){
		return this->ma;
	}
	string getHoten()
	{
		return this->hoten;
	}
	float getHSL(){
		return this->hesoluong;
	}
	
};
class Nhanvien2:public Nhanvien1{
	public:
		string phong;
		string getPhong(){
			return phong;
		}
		friend istream&operator>>(istream&Cin,Nhanvien2&nv)
		{
			cout<<"NHap ma nhan vien:";Cin>>nv.ma;
			cout<<"\nNhap hoten:";Cin>>nv.hoten;
			cout<<"\nNhap he so luong:";Cin>>nv.hesoluong;
			cout<<"\nNhap phong ban (A1,A2,A3):";Cin>>nv.phong;
			return Cin;
		}
		friend ostream&operator<<(ostream&Cout,Nhanvien2&nv)
		{
			Cout<<nv.ma<<" "<<nv.hoten<<" "<<nv.hesoluong<<" "<<nv.phong<<endl;
			return Cout;
		}
		
}; 

class App{
	public:
		int n;
		Nhanvien2 *ds;
		friend istream&operator>>(istream&Cin, App&app)
		{
			cout<<"Nhap vao so nhan vien";Cin>>app.n;
			app.ds=new Nhanvien2[app.n];
			for(int i=0;i<app.n;i++)
			{
				cout<<"Nhap vao nhan vien thu "<<i+1<<endl;
				Cin>>app.ds[i];
			}
			return Cin;
		}
	    friend ostream&operator<<(ostream&Cout,App&app)
	    {
	       for(int i=0;i<app.n;i++)
	       Cout<<app.ds[i];
	       return Cout;
		}
		void sapxepHSL()
		{
			for(int i=0;i<n-1;i++)
			{
				for(int j=i+1;j<n;j++)
				{
					if(ds[i].getHSL()<ds[j].getHSL())
					{
						swap(ds[i],ds[j]);
					}
				}
			}
			cout<<"\nDanh sach nhan vien theo thu tu giam dan cua HSL: "<<endl;
			for(int i=0;i<n;i++)
			{
				cout<<ds[i];
			}
		}
		void thongke(){
			int sum1=0, sum2=0,sum3=0;
			for(int i=0;i<n;i++)
			{
				if(ds[i].getPhong()=="A1") 
				{
					sum1++;
				}
				if(ds[i].getPhong()=="A2") 
				{
					sum2++;
				}
				if(ds[i].getPhong()=="A3") 
				{
					sum3++;
				}
			}
			cout<<"\nSo nv phong A1:"<<sum1;
			cout<<"\nSo nv phong A2:"<<sum2;
			cout<<"\nSo nv phong A3:"<<sum3;
		}
};    
int main() {
App a;
cin>>a;cout<<a;
a.sapxepHSL();
a.thongke();
}
