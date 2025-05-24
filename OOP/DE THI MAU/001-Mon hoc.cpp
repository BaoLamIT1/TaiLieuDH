
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;
class Subject{
	int ma;
	string tenmon;
	int tinchi;
	int n;
	public:
		int getMa(){return ma;
		}
		string getTenmon(){return tenmon;
		}
		int GetTC(){return tinchi;
		}
		void setMa(int ma){this->ma=ma;
		}
		void setTC(int tinchi){this->tinchi=tinchi;
		}
		void setTenmon(string tenmon){this->tenmon=tenmon;
		}
		void nhap(){
			cout<<"Nhap vao so mon hoc:"; cin>>n;
			for(int i=0;i<=n;i++){
			cout<<"\nNhap ma mon hoc:";cin>>ma;
			cout<<"\nNhap ten mon hoc:";cin>>tenmon;
			cout<<"\nNhap so tin chi:";cin>>tinchi;
		}
		}
		void xuat()
		{
			cout<<ma<<" "<<tenmon<<" "<<tinchi<<endl;
		}
		
};
class DKHP: public Subject{
	int msv;
	string tensv;
	public:
	DKHP(){
	}	
	DKHP(int msv, string tensv){
		msv=msv;
		tensv=tensv;
	}
	string getTensv(){
		return tensv;
	}
	int getMsv(){return msv;
	}
	void nhap(){
		Subject::nhap();
		cout<<"\nNhap ma sinh vien:";cin>>msv;
		cout<<"\nNhap ten sinh vien:";getline(cin,tensv);
	}
	void xuat()
	{
		Subject::xuat();
		cout<<msv<<" "<<tensv<<endl;
	}
}; 
class Ungdung{
	int n;
	DKHP *ds;
	public:
		friend istream&operator>>(istream&input,Ungdung&ud)
		{
			cout<<"Nhap vao so sinh vien:";input>>ud.n;
			ud.ds=new DKHP[ud.n];
			for(int i=0;i<ud.n;i++)
			{ 
			cout<<"Nhap vao sinh vien thu"<<i+1<<endl;
			ud.ds[i].nhap();			
			}
			return input;
		}
		
}; 
int main() {
Ungdung a;
cin>>a;

}
