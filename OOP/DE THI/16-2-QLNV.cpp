
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;

class Nguoi{
	public:
	string hoten;
	int tuoi;
	string getTen()
	{
		return this->hoten;
	}
	int getTuoi()
	{
		return this->tuoi;
	}
	void setTen(string hoten)
	{
		this->hoten=hoten;
	}
	void setTuoi(int tuoi)
	{
		this->tuoi=tuoi;
	}
		
};  
class qlnv:public Nguoi{
	public:
		int snct;
		float luong;
		int getSnct(){
			return snct;
		}
		float getLuong()
		{
			return luong;
		}
		friend istream&operator>>(istream&Cin, qlnv&tk)
		{
		   cout<<"Nhap hoten:";Cin>>tk.hoten;
		   cout<<"Nhap tuoi:";Cin>>tk.tuoi;
		   cout<<"nhap so nam cong tac :";Cin>>tk.snct;
	       cout<<"nhap luong :";Cin>>tk.luong;
	       return Cin;
		}
		friend ostream&operator<<(ostream&Cout, const qlnv&tk)
		{
			Cout<<tk.hoten<<" "<<tk.tuoi<<" "<<tk.snct<<" "<<tk.luong<<endl;
			return Cout;
		}
};
class App{
	int n;
	qlnv *ds;
	public:
		friend istream&operator>>(istream&input,App&app)
		{
			cout<<"Nhap so nhan vien:";input>>app.n;
			app.ds=new qlnv[app.n];
			for(int i=0;i<app.n;i++)
			{
				cout<<"Nhap nhan vien thu:"<<i+1<<endl;
				input>>app.ds[i];
			}
			return input;
		}
		friend ostream&operator<<(ostream&output,const App&app)
		{
			for(int i=0;i<app.n;i++){
		         output<<app.ds[i];
	             }   
	            return output;
		}
		
		int tinhluongTB()
		{
			float luongtong=0;
			for(int i=0;i<n;i++)
			{
				luongtong+=ds[i].getLuong();
			}
			return luongtong/n;
		}
		void timkiem()
		{
			int max=ds[0].getSnct();
			for(int i=1;i<n;i++)
			{
				if(ds[i].getSnct()>max)
				{
					max=ds[i].getSnct();
				}
			}
			cout<<"Nhan vien co so nam cong tac nhieu nhat la:"<<endl;
			for(int i=0;i<n;i++){
			if(ds[i].getSnct()==max)
			{
			cout<<ds[i].getTen();	
			}
		}
	}
};

int main() {
App a;
cin>>a;cout<<a;
cout<<"luong binh quan la:"<<a.tinhluongTB()<<endl;
a.timkiem();
}
