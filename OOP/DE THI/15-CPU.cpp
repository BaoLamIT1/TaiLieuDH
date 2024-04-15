
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;

class  MatHang{
	public:
	int ma;
	string ten, nsx;
	int solg;
	float gia;
	int getMa()
	{
		return this->ma;
	}
	string getTen()
	{
		return this->ten;
	}
	string getNsx()
	{
		return this->nsx;
	}
	int getSlg()
	{
		return this->solg;
	}
	float getGia()
	{
		return this->gia;
	}
	void setMa(int ma)
	{
		this->ma=ma;
	}
	void setNsx(string nsx)
	{
		this->nsx=nsx;
	}
};
class Maytinh:public MatHang{
	public:
		string cpu, hdh;
		int tronglg;
		string getCpu()
			{
				return cpu;
			}
		string getHdh(){
				return hdh;
			}
		int getTronglg()
			{
				return tronglg;
			}
friend istream&operator>>(istream&Cin,Maytinh&mt)
	{
		cout<<"\nNhap ma hang:";Cin>>mt.ma;
		cout<<"\nNhap ten hang:";Cin>>mt.ten;
		cout<<"\nNhap nsx:";Cin>>mt.nsx;
		cout<<"\nNhap solg:";Cin>>mt.solg;
		cout<<"\nNhap don gia:";Cin>>mt.gia;
		cout<<"\nNhap cpu:";Cin>>mt.cpu;
		cout<<"\nNhap hdh:";Cin>>mt.hdh;
		cout<<"\nNhap tronglg:";Cin>>mt.tronglg;
		return Cin;
	}
friend ostream&operator<<(ostream&Cout,const Maytinh&mt)
	{
		Cout<<mt.ma<<" "<<mt.ten<<" "<<mt.nsx<<" "<< mt.solg<<" "<<mt.gia<<" "<<mt.cpu<<" "<< mt.hdh<<" "<< mt.tronglg<<endl;
		return Cout;
	}
			
};  
class App{
	int n;
	MatHang *ds;
	public:
	      friend istream&operator>>(istream&input, App&app)
	{
		cout<<"Nhap vao so may tinh:";input>>app.n;
		app.ds=new MatHang[app.n];
		for(int i=0;i<app.n;i++)
		{
			cout<<"Nhap vao may thu "<<i+1<<endl;
			app.ds[i];
		}
		return input;
	}
	      friend ostream&operator<<(ostream&output,const App&app)
	{
		for(int i=0;i<app.n;i++){
		app.ds[i];
	             }   
	            return output;
	}
	
	void timmay(){
			string mayCanTim;
			fflush(stdin);
			cout<<"nhap ten may can tim :";getline(cin,mayCanTim);
			bool tk=false;
			for(int i=0;i<n;i++){
				if(ds[i].getTen()==mayCanTim){
					ds[i];
					tk=true;
				}
			}
			
			if(tk==false){
				cout<<"khong co may can tim!"<<endl;	
			}
		}
		
		
	void timkiem()
		{
			int max=ds[0].getGia();
			for(int i=1;i<n;i++)
			{
				if(ds[i].getGia()>max)
				{
					max=ds[i].getGia();
				}
			}
			cout<<"May co don gia max la:"<<endl;
			for(int i=0;i<n;i++){
			if(ds[i].getGia()==max)
			{
			ds[i];	
			}
		}
	}

};   
int main() {
App a;
cin>>a ; cout<<a;
a.timmay();
a.timkiem();

}
