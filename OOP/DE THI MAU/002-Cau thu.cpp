
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;
class Nguoi{
	int ma; 
	string ten;
	int tuoi;
	public:
		int getMa(){
			return ma;
		}
		string getTen(){
			return ten;
		}
		int getTuoi(){
			return tuoi;
		}
		void setTen(string ten){
			this->ten=ten;
		}
		void nhap(){
			cout<<"Ma nhan vien:";cin>>ma;
			cout<<"\nHo ten:";cin>>ten;
			cout<<"\nTuoi:";cin>>tuoi;
		}
		void xuat(){
			cout<<ma<<" "<<ten<<" "<<tuoi<<endl;
		}
};
class CT:public Nguoi{
	int sbt;
	int sptd;
	public:
		CT(){
		}
		CT(int sbt, int sptd)
		{
			sbt=sbt;
			sptd=sptd;
		}
		int getSBT(){ return sbt;
		}
		int getSPTD(){
			return sptd;
		}
		void tinhtien()
		{
			float tienthuong;
			if(3<=sbt<5 || sptd>=500){ tienthuong=5000;
			}
			if(sbt>=5){tienthuong=7000;
			}
		}
		void nhap()
		{
			Nguoi::nhap();
			cout<<"\nNhap so ban thang:";cin>>sbt;
			cout<<"\nNhap so phut thi dau:";cin>>sptd;
			
		}
		void xuat()
		{
			Nguoi::xuat();
			cout<<sbt<<" "<<sptd<<endl;
		}
		
}; 
class Ungdung{
	int n;
	CT *ct;
	public:
		friend istream&operator >>(istream&input, Ungdung&ud)
		{
			cout<<"Nhap vao so cau thu:";cin>>ud.n;
			ud.ct=new CT[ud.n];
			for(int i=0;i<ud.n;i++)
			{
				cout<<"Nhap vao cau thu thu:"<<i+1<<endl;
				ud.ct[i].nhap();
			}
			return input;
		}
		friend ostream&operator<<(ostream&output,const Ungdung&ud)
		{
			for(int i=0;i<ud.n;i++)
			{
			ud.ct[i];
			}
			return output;
		}
		void timkiem()
		{
			int min=ct[0].getTuoi();
			for(int i=1;i<n;i++)
			{
				if(ct[i].getTuoi()<min)
				{
					min=ct[i].getTuoi();
				}
			}
			cout<<"Cau thu tre tuoi nhat la:"<<endl;
		for(int i=0;i<n;i++){
				if(ct[i].getTuoi()==min){
					cout<<ct[i];
				}
			}
		}
};   
int main(){
Ungdung a;
cin>>a;cout<<a;
a.timkiem();

}
